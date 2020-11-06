using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S = RGBController.Properties.Settings;

namespace RGBController
{
    public static class Connection
    {
        public static void RGBSetColor(Color color)
        {
            Arduino.Send(5, new byte[] { color.R, color.G, color.B });
        }

        public static void RGBSetBright(byte bright)
        {
            Arduino.Send(6, new byte[] { bright });
        }

        public static void LampSetBright(byte bright)
        {
            Arduino.Send(2, new byte[] { bright });
        }

        public static void YellowSetBright(byte bright)
        {
            Arduino.Send(4, new byte[] { bright });
        }

        public static void BlueSetBright(byte bright)
        {
            Arduino.Send(3, new byte[] { bright });
        }

        ///////////////////////////////////////////////////////////////////////

        public static byte[] GetData()
        {
            Arduino.Send(255, new byte[] { });
            byte[] data = Arduino.Read(7);
            return data;
        }

        public static void Connect()
        {
            RGBSetColor(S.Default.rgbColor);
            RGBSetBright(S.Default.rgbBright);
            LampSetBright(S.Default.lampBright);
            YellowSetBright(S.Default.yellowBright);
            BlueSetBright(S.Default.blueBright);
        }

        public static void Disconnect()
        {
            RGBSetColor(Color.Black);
            RGBSetBright(0);
            LampSetBright(0);
            YellowSetBright(0);
            BlueSetBright(0);
        }

    }
}
