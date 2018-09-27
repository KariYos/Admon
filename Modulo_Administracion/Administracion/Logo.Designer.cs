namespace Administracion
{
    partial class Logo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo));
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.Image")));
            this.Pic_Logo.Location = new System.Drawing.Point(-2, -1);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(338, 338);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_Logo.TabIndex = 3;
            this.Pic_Logo.TabStop = false;
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(338, 338);
            this.Controls.Add(this.Pic_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Logo;
    }
}