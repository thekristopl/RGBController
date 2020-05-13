using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBController
{
    public partial class CollorPicker : Form
    {
        public CollorPicker()
        {
            InitializeComponent();
        }

        private Bitmap W = new Bitmap(RGBController.Properties.Resources.color_wheel);
        public Color Choice = Color.White;
        private bool Change = true;


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Change)
            {
                if (e.X >= 0 && e.Y >= 0 && e.Y < RGBController.Properties.Resources.color_wheel.Height && e.Y < RGBController.Properties.Resources.color_wheel.Width)
                {
                    Ok.BackColor = W.GetPixel(e.X, e.Y);
                    Wheel.Cursor = Cursors.Cross;
                }
                else Wheel.Cursor = Cursors.Default;
            }
        }

        private void wheel_MouseDown(object sender, MouseEventArgs e)
        {
            Choice = W.GetPixel(e.X, e.Y);
            Ok.BackColor = W.GetPixel(e.X, e.Y);
            Change = false;
        }

        private void wheel_MouseEnter(object sender, EventArgs e)
        {
            Change = true;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Wheel_Click(object sender, EventArgs e)
        {

        }
    }
}
