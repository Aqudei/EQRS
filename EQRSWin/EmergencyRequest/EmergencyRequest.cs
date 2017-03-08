using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQRSWin
{
    [ComplexType]
    public class EmergencyRequest
    {
        public string EmergencyDetail { get; internal set; }
        public double Latitude { get; internal set; }
        public double Longitude { get; internal set; }
        public string ResponderCode { get; internal set; }
    }
}
