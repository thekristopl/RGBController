using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using S = RGBController.Properties.Settings;

namespace RGBController
{
    static class Arduino
    {
        static SerialPort port;
        static bool isConnected = false;

        public static bool IsConnected()
        {
            return isConnected;
        }

        public static string PortName()
        {
            return port.PortName;
        }

        public static bool Conect(string _port)
        { 
            port = new SerialPort(_port, 9600, Parity.None, 8, StopBits.One);
            port.ReadTimeout = 3000;

            try
            {
                port.Open();
                port.Write("START");
                if (!port.ReadLine().Contains("START_")) return false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Connection timeout in port " + _port);
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied in port " + _port);
                return false;
            }
            //MessageBox.Show("Connected succesfully in port " + _port);
            isConnected = true;
            return true;
        }

        public static void Send(string line)
        {
            if (isConnected) port.Write(line);
        }

        public static bool Disconnect()
        {
            port.Write("STOP");
            try
            {
                if (!port.ReadLine().Contains("STOP_")) return false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Port does not respond");
            }

            //MessageBox.Show("Disconnected succesfully");
            port.Close();
            isConnected = false;
            return true;
        }

    }
}
