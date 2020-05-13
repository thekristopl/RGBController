using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
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
            port.ReadTimeout = 10000;

            try
            {
                port.Open();
                Send("STAR", null);

                string read = port.ReadLine();
                //MessageBox.Show(read);
                if (!read.Contains("STA_")) return false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Connection timeout in port " + _port);
                port.Close();
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied in port " + _port);
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("Port " + _port + " does not exist.");
                return false;
            }
            //MessageBox.Show("Connected succesfully in port " + _port);
            isConnected = true;
            return true;
        }

        public static void Send(string header, List<byte> options)
        {
            if (header == null) return;

            if (options == null)
            {
                byte[] head = Encoding.ASCII.GetBytes(header + (char)0);
                port.Write(head, 0, head.Length);

                string m = "";
                foreach (byte h in head) m += h.ToString() + " ";
                //MessageBox.Show(m);
            }
            else
            {
                byte[] head = Encoding.ASCII.GetBytes(header + (char)options.Count);
                port.Write(head, 0, head.Length);
                port.Write(options.ToArray(), 0, options.Count);

                string m = "";
                foreach (byte h in head) m += h.ToString() + " ";
                foreach (byte o in options.ToArray()) m += o.ToString() + " ";
                //MessageBox.Show(m);
            }

        }

        public static bool Disconnect()
        {
            if (!isConnected) return false;
            
            Send("STOP", null);
            try
            {
                string read = port.ReadLine();
                //MessageBox.Show(read);
                if (!read.Contains("STO_")) return false;
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
