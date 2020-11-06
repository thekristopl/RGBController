using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using S = RGBController.Properties.Settings;
using System.Security.Cryptography;

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
            port.ReadTimeout = 5000;

            try
            {
                port.Open();
                Send(1, null);

                byte[] read = { 0 };
                port.Read(read, 0, 1);
                if (read[0] != 1) return false;
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
            //MessageBox1.Show("Connected succesfully in port " + _port);
            isConnected = true;
            return true;
        }

        public static void Send(byte header, byte[] options)
        {
            int len;
            if (options == null) len = 0;
            else len = (byte)options.Length;

            byte[] toSend = new byte[2 + len];

            toSend[0] = header;
            toSend[1] = (byte)len;

            for(int i = 0; i < len; i++)
            {
                toSend[i + 2] = options[i];
            }

            string a = "";
            foreach (byte b in toSend) a += b.ToString() + " ";
            //MessageBox.Show(a);


            port.Write(toSend, 0, len + 2);
        }

        public static byte[] Read(int bytesToRead)
        {
            if(!isConnected) return null;

            byte[] buffer = new byte[bytesToRead];
            port.Read(buffer, 0, bytesToRead);
            return buffer;
        }


        public static bool Disconnect()
        {
            if (!isConnected) return false;
            
            Send(0, null);
            try
            {
                byte[] read = { 0 };
                port.Read(read, 0, 1);
                if (read[0] != 0) return false;
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
