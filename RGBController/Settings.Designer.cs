namespace RGBController
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ConnectGroup = new System.Windows.Forms.GroupBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.Ports = new System.Windows.Forms.ComboBox();
            this.Accept = new System.Windows.Forms.Button();
            this.AutorunCheckBox = new System.Windows.Forms.CheckBox();
            this.ConnectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectGroup
            // 
            this.ConnectGroup.Controls.Add(this.ConnectionButton);
            this.ConnectGroup.Controls.Add(this.Ports);
            this.ConnectGroup.Location = new System.Drawing.Point(12, 12);
            this.ConnectGroup.Name = "ConnectGroup";
            this.ConnectGroup.Size = new System.Drawing.Size(200, 87);
            this.ConnectGroup.TabIndex = 6;
            this.ConnectGroup.TabStop = false;
            this.ConnectGroup.Text = "Connect to Arduino";
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(6, 50);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(188, 28);
            this.ConnectionButton.TabIndex = 2;
            this.ConnectionButton.Text = "Connect";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // Ports
            // 
            this.Ports.FormattingEnabled = true;
            this.Ports.Location = new System.Drawing.Point(6, 23);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(188, 21);
            this.Ports.TabIndex = 0;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(137, 144);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 7;
            this.Accept.Text = "OK";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Acceept_Click);
            // 
            // AutorunCheckBox
            // 
            this.AutorunCheckBox.AutoSize = true;
            this.AutorunCheckBox.Location = new System.Drawing.Point(12, 105);
            this.AutorunCheckBox.Name = "AutorunCheckBox";
            this.AutorunCheckBox.Size = new System.Drawing.Size(63, 17);
            this.AutorunCheckBox.TabIndex = 8;
            this.AutorunCheckBox.Text = "Autorun";
            this.AutorunCheckBox.UseVisualStyleBackColor = true;
            this.AutorunCheckBox.CheckedChanged += new System.EventHandler(this.IsAutorun_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 179);
            this.Controls.Add(this.AutorunCheckBox);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ConnectGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.ConnectGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox ConnectGroup;
        public System.Windows.Forms.Button ConnectionButton;
        public System.Windows.Forms.ComboBox Ports;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.CheckBox AutorunCheckBox;
    }
}