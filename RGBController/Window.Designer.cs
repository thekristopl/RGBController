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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.RGBCollor = new System.Windows.Forms.Button();
            this.lampBar = new System.Windows.Forms.TrackBar();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.yellowBar = new System.Windows.Forms.TrackBar();
            this.RGBBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RGBBrightness = new System.Windows.Forms.TrackBar();
            this.Lights = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBar)).BeginInit();
            this.RGBBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBrightness)).BeginInit();
            this.Lights.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings.Image = global::RGBController.Properties.Resources.settings;
            this.Settings.Location = new System.Drawing.Point(285, 12);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(50, 50);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings.TabIndex = 1;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.OpenSettings);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "RGBController";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.CloseUsingNotify);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowUsingNotify);
            // 
            // RGBCollor
            // 
            this.RGBCollor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RGBCollor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGBCollor.Location = new System.Drawing.Point(56, 37);
            this.RGBCollor.Name = "RGBCollor";
            this.RGBCollor.Size = new System.Drawing.Size(45, 115);
            this.RGBCollor.TabIndex = 2;
            this.RGBCollor.UseVisualStyleBackColor = true;
            this.RGBCollor.Click += new System.EventHandler(this.RGBSetColor);
            // 
            // lampBar
            // 
            this.lampBar.BackColor = System.Drawing.SystemColors.Control;
            this.lampBar.CausesValidation = false;
            this.lampBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lampBar.LargeChange = 20;
            this.lampBar.Location = new System.Drawing.Point(6, 35);
            this.lampBar.Maximum = 255;
            this.lampBar.Name = "lampBar";
            this.lampBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lampBar.Size = new System.Drawing.Size(45, 120);
            this.lampBar.SmallChange = 3;
            this.lampBar.TabIndex = 3;
            this.lampBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.lampBar.ValueChanged += new System.EventHandler(this.LampSetBright);
            // 
            // blueBar
            // 
            this.blueBar.BackColor = System.Drawing.SystemColors.Control;
            this.blueBar.CausesValidation = false;
            this.blueBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.blueBar.LargeChange = 20;
            this.blueBar.Location = new System.Drawing.Point(106, 35);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueBar.Size = new System.Drawing.Size(45, 120);
            this.blueBar.SmallChange = 3;
            this.blueBar.TabIndex = 3;
            this.blueBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.blueBar.ValueChanged += new System.EventHandler(this.BlueSetBright);
            // 
            // yellowBar
            // 
            this.yellowBar.BackColor = System.Drawing.SystemColors.Control;
            this.yellowBar.CausesValidation = false;
            this.yellowBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.yellowBar.LargeChange = 20;
            this.yellowBar.Location = new System.Drawing.Point(57, 35);
            this.yellowBar.Maximum = 255;
            this.yellowBar.Name = "yellowBar";
            this.yellowBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.yellowBar.Size = new System.Drawing.Size(45, 120);
            this.yellowBar.SmallChange = 3;
            this.yellowBar.TabIndex = 3;
            this.yellowBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.yellowBar.ValueChanged += new System.EventHandler(this.YellowSetBright);
            // 
            // RGBBox
            // 
            this.RGBBox.Controls.Add(this.label5);
            this.RGBBox.Controls.Add(this.label4);
            this.RGBBox.Controls.Add(this.RGBBrightness);
            this.RGBBox.Controls.Add(this.RGBCollor);
            this.RGBBox.Location = new System.Drawing.Point(175, 12);
            this.RGBBox.Name = "RGBBox";
            this.RGBBox.Size = new System.Drawing.Size(107, 158);
            this.RGBBox.TabIndex = 6;
            this.RGBBox.TabStop = false;
            this.RGBBox.Text = "RGB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bright";
            // 
            // RGBBrightness
            // 
            this.RGBBrightness.BackColor = System.Drawing.SystemColors.Control;
            this.RGBBrightness.CausesValidation = false;
            this.RGBBrightness.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.RGBBrightness.LargeChange = 20;
            this.RGBBrightness.Location = new System.Drawing.Point(6, 35);
            this.RGBBrightness.Maximum = 255;
            this.RGBBrightness.Name = "RGBBrightness";
            this.RGBBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RGBBrightness.Size = new System.Drawing.Size(45, 120);
            this.RGBBrightness.SmallChange = 3;
            this.RGBBrightness.TabIndex = 3;
            this.RGBBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RGBBrightness.ValueChanged += new System.EventHandler(this.RGBSetBright);
            // 
            // Lights
            // 
            this.Lights.Controls.Add(this.label3);
            this.Lights.Controls.Add(this.label2);
            this.Lights.Controls.Add(this.blueBar);
            this.Lights.Controls.Add(this.label1);
            this.Lights.Controls.Add(this.yellowBar);
            this.Lights.Controls.Add(this.lampBar);
            this.Lights.Location = new System.Drawing.Point(12, 12);
            this.Lights.Name = "Lights";
            this.Lights.Size = new System.Drawing.Size(157, 158);
            this.Lights.TabIndex = 7;
            this.Lights.TabStop = false;
            this.Lights.Text = "Lights";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yellow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lamp";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 180);
            this.Controls.Add(this.Lights);
            this.Controls.Add(this.RGBBox);
            this.Controls.Add(this.Settings);
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
            ((System.ComponentModel.ISupportInitialize)(this.lampBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBar)).EndInit();
            this.RGBBox.ResumeLayout(false);
            this.RGBBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBrightness)).EndInit();
            this.Lights.ResumeLayout(false);
            this.Lights.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button RGBCollor;
        private System.Windows.Forms.TrackBar lampBar;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.TrackBar yellowBar;
        private System.Windows.Forms.GroupBox RGBBox;
        private System.Windows.Forms.TrackBar RGBBrightness;
        private System.Windows.Forms.GroupBox Lights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

