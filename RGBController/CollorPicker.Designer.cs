namespace RGBController
{
    partial class CollorPicker
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
            this.Wheel = new System.Windows.Forms.PictureBox();
            this.Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel)).BeginInit();
            this.SuspendLayout();
            // 
            // Wheel
            // 
            this.Wheel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wheel.Image = global::RGBController.Properties.Resources.color_wheel;
            this.Wheel.Location = new System.Drawing.Point(12, 12);
            this.Wheel.Name = "Wheel";
            this.Wheel.Size = new System.Drawing.Size(256, 256);
            this.Wheel.TabIndex = 0;
            this.Wheel.TabStop = false;
            this.Wheel.Click += new System.EventHandler(this.Wheel_Click);
            this.Wheel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wheel_MouseDown);
            this.Wheel.MouseEnter += new System.EventHandler(this.wheel_MouseEnter);
            this.Wheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 274);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(256, 43);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // CollorPicker
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 330);
            this.ControlBox = false;
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Wheel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CollorPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick color";
            ((System.ComponentModel.ISupportInitialize)(this.Wheel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Wheel;
        private System.Windows.Forms.Button Ok;
    }
}