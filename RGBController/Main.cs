﻿using System;
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
    public partial class Main : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            if (!Arduino.Conect(S.Default.DefaultPort))
            {
                Settings settings_form = new Settings();
                settings_form.ShowDialog();
            }
            
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.ShowDialog();
        }

        private void MinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MoveBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MoveBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MoveBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
