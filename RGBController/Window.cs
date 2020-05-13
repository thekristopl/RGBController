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
using S = RGBController.Properties.Settings;

namespace RGBController
{
    public partial class Window : Form
    {
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();

            this.WindowState = FormWindowState.Normal;
            Brightness.Value = S.Default.Brightness;
            Speed.Value = S.Default.Speed;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if(e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = true;
                e.Cancel = true;
            }

        }

        private void Window_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public Window()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.ShowDialog();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            CollorPicker Picker = new CollorPicker();

            if (Picker.ShowDialog() == DialogResult.OK)
            {
                Color color = Picker.Choice;
               
                Arduino.Send("MODE", new List<byte> {0, color.R, color.G, color.B });
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            CollorPicker Picker = new CollorPicker();

            if (Picker.ShowDialog() == DialogResult.OK)
            {
                Color color = Picker.Choice;
              
                Arduino.Send("MODE", new List<byte> {1, color.R, color.G, color.B });
            }
        }


        private void SingleFade_Click(object sender, EventArgs e)
        {
            Arduino.Send("MODE", new List<byte>{2});
        }

        private void DoubleFade_Click(object sender, EventArgs e)
        {
            byte[] options = { 3 };
            Arduino.Send("MODE", new List<byte> {3});
        }


        private void Speed_Scroll(object sender, EventArgs e)
        {
            S.Default.Speed = Speed.Value;
            Arduino.Send("SPEE", new List<byte> { (byte)Speed.Value });
        }

        private void Brightness_Scroll(object sender, EventArgs e)
        {
            S.Default.Brightness = Brightness.Value;
            Arduino.Send("BRIG", new List<byte> { (byte)Brightness.Value });
        }
    }
}
