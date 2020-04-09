namespace RGBController
{
    partial class Main
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
            this.MinimalizeButton = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.MoveBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimalizeButton
            // 
            this.MinimalizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimalizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimalizeButton.Image = global::RGBController.Properties.Resources.sharp_close_black_48dp;
            this.MinimalizeButton.Location = new System.Drawing.Point(717, -1);
            this.MinimalizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimalizeButton.Name = "MinimalizeButton";
            this.MinimalizeButton.Size = new System.Drawing.Size(62, 62);
            this.MinimalizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimalizeButton.TabIndex = 2;
            this.MinimalizeButton.TabStop = false;
            this.MinimalizeButton.Click += new System.EventHandler(this.MinimalizeButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.Image = global::RGBController.Properties.Resources.sharp_settings_black_48dp;
            this.SettingsButton.Location = new System.Drawing.Point(667, 5);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(50, 50);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MoveBar
            // 
            this.MoveBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MoveBar.Location = new System.Drawing.Point(0, -1);
            this.MoveBar.Name = "MoveBar";
            this.MoveBar.Size = new System.Drawing.Size(779, 62);
            this.MoveBar.TabIndex = 3;
            this.MoveBar.TabStop = false;
            this.MoveBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseDown);
            this.MoveBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseMove);
            this.MoveBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.MinimalizeButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MoveBar);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBController";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimalizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.PictureBox MinimalizeButton;
        private System.Windows.Forms.PictureBox MoveBar;
    }
}

