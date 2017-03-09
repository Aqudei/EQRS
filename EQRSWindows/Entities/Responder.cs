using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EQRSWin
{
    public class Responder
    {
        public long ResponderId { get; set; }
        public string ResponderName { get; set; }
        public string ResponderCode { get; set; }
        public string MobileNumber { get; set; }

        public override string ToString()
        {
            return ResponderName + " : " + MobileNumber;
        }
    }
}
