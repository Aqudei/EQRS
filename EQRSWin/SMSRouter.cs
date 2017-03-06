using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EQRSWin
{
    public class SMSRouter
    {
        public class EmergencyRequest
        {
            public string EmergencyDetail { get; internal set; }
            public double Latitude { get; internal set; }
            public double Longitude { get; internal set; }
            public string PhoneNumber { get; internal set; }
            public string ResponderCode { get; internal set; }
        }

        private Regex rgx;

        public SMSRouter()
        {
            // ResponderCode::EmergencyDetails::Latitude::Longitude::PhoneNumber
            rgx = new Regex(@"([A-Za-z]+)::([A-Za-z\s]+)::([0-9]+\.?[0-9]+)::([0-9]+\.?[0-9]+)::([0-9]+)");
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
                er.PhoneNumber = rslt.Groups[5].Value.ToUpper();
                return er;
            }
            else
            {
                return null;
            }
        }
    }
}
