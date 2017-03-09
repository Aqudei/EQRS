using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace EQRSWin
{
    public class SMSRouter
    {
        public event EventHandler<NewEmergencyEventArg> NewEmergencyEvent;

        private Regex rgx;
        private GsmCommMain _mainComm;

        public SMSRouter()
        {
            // ResponderCode::EmergencyDetails::Latitude::Longitude::PhoneNumber
            rgx = new Regex(@"([A-Za-z]+)::([A-Za-z\s]+)::([0-9]+\.?[0-9]+)::([0-9]+\.?[0-9]+)");
        }

        public SMSRouter(GsmComm.GsmCommunication.GsmCommMain mainComm) : this()
        {
            _mainComm = mainComm;
        }

        /// <summary>
        /// Parse received sms into format understandable by this system
        /// </summary>
        /// <param name="input">The input sms in the for of ResponderCode::EmergencyDetails::Latitude::Longitude::PhoneNumber</param>
        /// <returns></returns>
        public EmergencyRequest Parse(string input)
        {
            var rslt = rgx.Match(input);
            if (rslt.Success)
            {
                var er = new EmergencyRequest();
                er.ResponderCode = rslt.Groups[1].Value.ToUpper();
                er.EmergencyDetail = rslt.Groups[2].Value.ToUpper();
                er.Latitude = double.Parse(rslt.Groups[3].Value);
                er.Longitude = double.Parse(rslt.Groups[4].Value);
                return er;
            }
            else
            {
                return null;
            }
        }

        public void HandleReceived(string originatingAddress, DateTime sCTimestamp, string userDataText)
        {
            var er = Parse(userDataText);
            if (er != null)
            {

                using (var ctx = new EQRSContext())
                {
                    var responders = ctx.Responders.Where(r => r.ResponderCode == er.ResponderCode).ToList();
                    if (responders != null && responders.Any())
                    {
                        if (_mainComm != null && _mainComm.IsConnected())
                        {
                            foreach (var r in responders)
                            {

                                Debug.WriteLine("Sending message to responder " + r.ToString());
                                var msg = string.Format("Emergency:{0}\nWhere: lat {1} long {2}", er.EmergencyDetail, er.Latitude, er.Longitude);
                                SmsSubmitPdu pdu = new SmsSubmitPdu(msg, r.MobileNumber);
                                _mainComm.SendMessage(pdu);
                                er.MobileNumber = originatingAddress;
                                NewEmergencyEvent?.Invoke(this, new NewEmergencyEventArg
                                {
                                    Request = er,
                                    Time = sCTimestamp
                                });

                            }
                        }
                    }
                }
            }
        }
    }
}
