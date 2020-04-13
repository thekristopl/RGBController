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
            this.PC = new System.Windows.Forms.PictureBox();
            this.MinimalizeButton = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // PC
            // 
            this.PC.BackColor = System.Drawing.Color.Transparent;
            this.PC.Image = global::RGBController.Properties.Resources.pc;
            this.PC.Location = new System.Drawing.Point(65, 50);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(340, 330);
            this.PC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PC.TabIndex = 4;
            this.PC.TabStop = false;
            // 
            // MinimalizeButton
            // 
            this.MinimalizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimalizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimalizeButton.Image = global::RGBController.Properties.Resources.x;
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
            this.SettingsButton.Image = global::RGBController.Properties.Resources.settings;
            this.SettingsButton.Location = new System.Drawing.Point(667, 5);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(50, 50);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Margin = new System.Windows.Forms.Padding(0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(779, 454);
            this.Background.TabIndex = 3;
            this.Background.TabStop = false;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseMove);
            this.Background.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 95);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.MinimalizeButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.Background);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBController";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.PictureBox MinimalizeButton;
        private System.Windows.Forms.PictureBox PC;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button button1;
    }
}

