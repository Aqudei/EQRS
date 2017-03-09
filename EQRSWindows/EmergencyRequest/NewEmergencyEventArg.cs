using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQRSWin
{
    public class NewEmergencyEventArg
    {
        public long NewEmergencyEventArgId { get; set; }
        public NewEmergencyEventArg()
        { }

        public NewEmergencyEventArg(DateTime time, EmergencyRequest request)
        {
            Time = time;
            Request = request;
        }

        public EmergencyRequest Request { get;  set; }
        public DateTime Time { get; set; }
    }
}
