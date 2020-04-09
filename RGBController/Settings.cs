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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            StatusChange();

            
        }

        private void StatusChange()
        {
            if(Arduino.IsConnected())
            {
                ConnectGroup.Text = "Connected";
                ConnectionButton.Text = "Disconnect";
                
                Ports.Items.Clear();
                Ports.Items.Add(Arduino.PortName());
                Ports.SelectedItem = Arduino.PortName();
                Ports.Enabled = false;
            }
            else
            {
                ConnectGroup.Text = "Connect to Arduino";
                ConnectionButton.Text = "Connect";

                String[] ports;
                ports = SerialPort.GetPortNames();

                Ports.Items.Clear();
                foreach (string port in ports)
                {
                    Ports.Items.Add(port);
                    if (ports[0] != null)
                    {
                        Ports.SelectedItem = ports[0];
                    }
                }
                Ports.Enabled = true;
            }
        }




        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (Arduino.IsConnected())
            {
                ConnectGroup.Text = "Disconnectiong...";
                Arduino.Disconnect();
            }
            else
            {
                ConnectGroup.Text = "Connecting...";
                string selectedPort = Ports.GetItemText(Ports.SelectedItem);
                if(Arduino.Conect(selectedPort))
                {
                    S.Default.DefaultPort = selectedPort;
                    S.Default.Save();
                }
            }
            StatusChange();
        }

        private void Acceept_Click(object sender, EventArgs e)
        {
            if (Arduino.IsConnected()) this.Close();
            else MessageBox.Show("Please connect Arduino");
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Arduino.IsConnected()) Application.Exit();
        }
    }
}