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

        public Window()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            Connection.Connect();




        }

        private void Window_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
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
            else Connection.Disconnect();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.ShowDialog();
        }

        private void CloseUsingNotify(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ShowUsingNotify(object sender, MouseEventArgs e)
        {
            this.Show();

            this.WindowState = FormWindowState.Normal;
        }

        /////////////////////////////////////////////////////////////////////////

        private void RGBSetColor(object sender, EventArgs e)
        {
            CollorPicker Picker = new CollorPicker();

            if (Picker.ShowDialog() == DialogResult.OK)
            {
                Connection.RGBSetColor(Picker.Choice);
                RGBCollor.BackColor = Picker.Choice;
            }
        }

        private void RGBSetBright(object sender, EventArgs e)
        {
            Connection.RGBSetBright((byte)RGBBrightness.Value);
        }

        private void LampSetBright(object sender, EventArgs e)
        {
            Connection.LampSetBright((byte)lampBar.Value);
        }

        private void YellowSetBright(object sender, EventArgs e)
        {
            Connection.YellowSetBright((byte)yellowBar.Value);
        }

        private void BlueSetBright(object sender, EventArgs e)
        {
            Connection.BlueSetBright((byte)blueBar.Value);
        }
    }
}
