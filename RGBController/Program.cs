using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S = RGBController.Properties.Settings;

namespace RGBController
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            if (!Arduino.Conect(S.Default.DefaultPort))
            {
                Settings settings_form = new Settings();
                settings_form.ShowDialog();
            }
            Application.Run(new Window());
            


            RGBController.Properties.Settings.Default.Save();
            Arduino.Disconnect();
        }


    }
}
