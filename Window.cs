using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ledControl
{
    public partial class Window : Form
    {
        SerialPort port;

        public Window()
        {
            InitializeComponent();
            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.Open();
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }


        private void Rgb0_Click(object sender, EventArgs e)
        {
            if (takeColor.ShowDialog() == DialogResult.OK)
            {
                rgb0.BackColor = takeColor.Color;
                port.Write("0" + HexConverter(takeColor.Color));
            }
        }

        private void Rgb1_Click(object sender, EventArgs e)
        {
            if (takeColor.ShowDialog() == DialogResult.OK)
            {
                rgb1.BackColor = takeColor.Color;
                port.Write("1" + HexConverter(takeColor.Color));
            }
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}
