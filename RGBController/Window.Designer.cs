namespace RGBController
{
    partial class Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Settings = new System.Windows.Forms.PictureBox();
            this.SingleFade = new System.Windows.Forms.Button();
            this.DoubleFade = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Brightness = new System.Windows.Forms.TrackBar();
            this.Speed = new System.Windows.Forms.TrackBar();
            this.SpeedGroup = new System.Windows.Forms.GroupBox();
            this.BrightnessGroup = new System.Windows.Forms.GroupBox();
            this.SpeedMin = new System.Windows.Forms.Label();
            this.SpeedMax = new System.Windows.Forms.Label();
            this.BrightnessMin = new System.Windows.Forms.Label();
            this.BrightnessMax = new System.Windows.Forms.Label();
            this.SpeedMidle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.SpeedGroup.SuspendLayout();
            this.BrightnessGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings.Image = global::RGBController.Properties.Resources.settings;
            this.Settings.Location = new System.Drawing.Point(11, 162);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(50, 50);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings.TabIndex = 1;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SingleFade
            // 
            this.SingleFade.Location = new System.Drawing.Point(11, 12);
            this.SingleFade.Name = "SingleFade";
            this.SingleFade.Size = new System.Drawing.Size(171, 45);
            this.SingleFade.TabIndex = 5;
            this.SingleFade.Text = "Single fade";
            this.SingleFade.UseVisualStyleBackColor = true;
            this.SingleFade.Click += new System.EventHandler(this.SingleFade_Click);
            // 
            // DoubleFade
            // 
            this.DoubleFade.Location = new System.Drawing.Point(11, 63);
            this.DoubleFade.Name = "DoubleFade";
            this.DoubleFade.Size = new System.Drawing.Size(171, 45);
            this.DoubleFade.TabIndex = 6;
            this.DoubleFade.Text = "Double fade";
            this.DoubleFade.UseVisualStyleBackColor = true;
            this.DoubleFade.Click += new System.EventHandler(this.DoubleFade_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "RGBController";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(11, 114);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(86, 45);
            this.Left.TabIndex = 7;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(103, 114);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(79, 45);
            this.Right.TabIndex = 8;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Brightness
            // 
            this.Brightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.Brightness.LargeChange = 50;
            this.Brightness.Location = new System.Drawing.Point(2, 13);
            this.Brightness.Maximum = 255;
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(192, 45);
            this.Brightness.SmallChange = 10;
            this.Brightness.TabIndex = 9;
            this.Brightness.TickFrequency = 5;
            this.Brightness.Value = 255;
            this.Brightness.Scroll += new System.EventHandler(this.Brightness_Scroll);
            // 
            // Speed
            // 
            this.Speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.Speed.Location = new System.Drawing.Point(6, 13);
            this.Speed.Maximum = 200;
            this.Speed.Minimum = 1;
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(188, 45);
            this.Speed.TabIndex = 10;
            this.Speed.TickFrequency = 20;
            this.Speed.Value = 100;
            this.Speed.Scroll += new System.EventHandler(this.Speed_Scroll);
            // 
            // SpeedGroup
            // 
            this.SpeedGroup.Controls.Add(this.SpeedMidle);
            this.SpeedGroup.Controls.Add(this.SpeedMax);
            this.SpeedGroup.Controls.Add(this.SpeedMin);
            this.SpeedGroup.Controls.Add(this.Speed);
            this.SpeedGroup.Location = new System.Drawing.Point(188, 12);
            this.SpeedGroup.Name = "SpeedGroup";
            this.SpeedGroup.Size = new System.Drawing.Size(200, 64);
            this.SpeedGroup.TabIndex = 11;
            this.SpeedGroup.TabStop = false;
            this.SpeedGroup.Text = "Speed";
            // 
            // BrightnessGroup
            // 
            this.BrightnessGroup.Controls.Add(this.BrightnessMax);
            this.BrightnessGroup.Controls.Add(this.BrightnessMin);
            this.BrightnessGroup.Controls.Add(this.Brightness);
            this.BrightnessGroup.Location = new System.Drawing.Point(188, 82);
            this.BrightnessGroup.Name = "BrightnessGroup";
            this.BrightnessGroup.Size = new System.Drawing.Size(200, 64);
            this.BrightnessGroup.TabIndex = 12;
            this.BrightnessGroup.TabStop = false;
            this.BrightnessGroup.Text = "Brightness";
            // 
            // SpeedMin
            // 
            this.SpeedMin.AutoSize = true;
            this.SpeedMin.Location = new System.Drawing.Point(9, 45);
            this.SpeedMin.Name = "SpeedMin";
            this.SpeedMin.Size = new System.Drawing.Size(22, 13);
            this.SpeedMin.TabIndex = 13;
            this.SpeedMin.Text = "0.1";
            // 
            // SpeedMax
            // 
            this.SpeedMax.AutoSize = true;
            this.SpeedMax.Location = new System.Drawing.Point(171, 45);
            this.SpeedMax.Name = "SpeedMax";
            this.SpeedMax.Size = new System.Drawing.Size(19, 13);
            this.SpeedMax.TabIndex = 14;
            this.SpeedMax.Text = "10";
            // 
            // BrightnessMin
            // 
            this.BrightnessMin.AutoSize = true;
            this.BrightnessMin.Location = new System.Drawing.Point(9, 45);
            this.BrightnessMin.Name = "BrightnessMin";
            this.BrightnessMin.Size = new System.Drawing.Size(13, 13);
            this.BrightnessMin.TabIndex = 15;
            this.BrightnessMin.Text = "0";
            // 
            // BrightnessMax
            // 
            this.BrightnessMax.AutoSize = true;
            this.BrightnessMax.Location = new System.Drawing.Point(169, 45);
            this.BrightnessMax.Name = "BrightnessMax";
            this.BrightnessMax.Size = new System.Drawing.Size(25, 13);
            this.BrightnessMax.TabIndex = 14;
            this.BrightnessMax.Text = "255";
            // 
            // SpeedMidle
            // 
            this.SpeedMidle.AutoSize = true;
            this.SpeedMidle.Location = new System.Drawing.Point(94, 45);
            this.SpeedMidle.Name = "SpeedMidle";
            this.SpeedMidle.Size = new System.Drawing.Size(13, 13);
            this.SpeedMidle.TabIndex = 16;
            this.SpeedMidle.Text = "1";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 221);
            this.Controls.Add(this.BrightnessGroup);
            this.Controls.Add(this.SpeedGroup);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.DoubleFade);
            this.Controls.Add(this.SingleFade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBController";
            this.Shown += new System.EventHandler(this.Window_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.SpeedGroup.ResumeLayout(false);
            this.SpeedGroup.PerformLayout();
            this.BrightnessGroup.ResumeLayout(false);
            this.BrightnessGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.Button SingleFade;
        private System.Windows.Forms.Button DoubleFade;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.TrackBar Brightness;
        private System.Windows.Forms.TrackBar Speed;
        private System.Windows.Forms.GroupBox SpeedGroup;
        private System.Windows.Forms.GroupBox BrightnessGroup;
        private System.Windows.Forms.Label SpeedMidle;
        private System.Windows.Forms.Label SpeedMax;
        private System.Windows.Forms.Label SpeedMin;
        private System.Windows.Forms.Label BrightnessMax;
        private System.Windows.Forms.Label BrightnessMin;
    }
}

