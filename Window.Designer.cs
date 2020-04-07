namespace ledControl
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
            this.takeColor = new System.Windows.Forms.ColorDialog();
            this.rgb0 = new System.Windows.Forms.Button();
            this.rgb1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // takeColor
            // 
            this.takeColor.AnyColor = true;
            this.takeColor.FullOpen = true;
            this.takeColor.SolidColorOnly = true;
            // 
            // rgb0
            // 
            this.rgb0.Location = new System.Drawing.Point(12, 12);
            this.rgb0.Name = "rgb0";
            this.rgb0.Size = new System.Drawing.Size(100, 100);
            this.rgb0.TabIndex = 0;
            this.rgb0.Text = "Left led";
            this.rgb0.UseVisualStyleBackColor = true;
            this.rgb0.Click += new System.EventHandler(this.Rgb0_Click);
            // 
            // rgb1
            // 
            this.rgb1.Location = new System.Drawing.Point(118, 12);
            this.rgb1.Name = "rgb1";
            this.rgb1.Size = new System.Drawing.Size(100, 100);
            this.rgb1.TabIndex = 1;
            this.rgb1.Text = "Right led";
            this.rgb1.UseVisualStyleBackColor = true;
            this.rgb1.Click += new System.EventHandler(this.Rgb1_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 124);
            this.Controls.Add(this.rgb1);
            this.Controls.Add(this.rgb0);
            this.Name = "Window";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog takeColor;
        private System.Windows.Forms.Button rgb0;
        private System.Windows.Forms.Button rgb1;
    }
}

