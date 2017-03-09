using EQRSWin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQRSWin.DataAccess
{
    public class SettingDao
    {

        public void SaveSetting(Setting newSetting)
        {
            using (var ctx = new EQRSContext())
            {
                var setting = ctx.Settings.FirstOrDefault();
                if (setting == null)
                {
                    setting = new Entities.Setting();
                    ctx.Settings.Add(setting);
                }

                setting.PortName = newSetting.PortName;
                setting.BaudRate = newSetting.BaudRate;

                ctx.SaveChanges();
            }
        }

        public Setting GetSetting()
        {
            using (var ctx = new EQRSContext())
            {
                return ctx.Settings.FirstOrDefault();
            }
        }
    }
}
