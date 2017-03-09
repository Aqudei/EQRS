using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EQRSWin.Entities
{
    /// <summary>
    /// Holds the  setting for the GSM modem.
    /// </summary>
    public class Setting
    {
        public int SettingId { get; set; }
        public string PortName { get; set; }
        public int BaudRate { get; set; }

    }
}
