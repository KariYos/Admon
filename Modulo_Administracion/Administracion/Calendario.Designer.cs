namespace Administracion
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.Pic_calendario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_calendario)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_calendario
            // 
            this.Pic_calendario.Image = global::Administracion.Properties.Resources.caalendario;
            this.Pic_calendario.Location = new System.Drawing.Point(46, 56);
            this.Pic_calendario.Name = "Pic_calendario";
            this.Pic_calendario.Size = new System.Drawing.Size(825, 548);
            this.Pic_calendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_calendario.TabIndex = 32;
            this.Pic_calendario.TabStop = false;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Pic_calendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "310_Calendario";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_calendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_calendario;
    }
}