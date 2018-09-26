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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Pic_calendario = new System.Windows.Forms.PictureBox();
            this.Tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_calendario)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(809, 616);
            this.Lbl_Usuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(62, 18);
            this.Lbl_Usuario.TabIndex = 34;
            this.Lbl_Usuario.Text = "Usuario";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(44, 616);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_fecha.TabIndex = 33;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(44, 595);
            this.Lbl_hora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(43, 18);
            this.Lbl_hora.TabIndex = 32;
            this.Lbl_hora.Text = "Hora";
            // 
            // Pic_calendario
            // 
            this.Pic_calendario.Image = global::Administracion.Properties.Resources.caalendario;
            this.Pic_calendario.Location = new System.Drawing.Point(47, 26);
            this.Pic_calendario.Name = "Pic_calendario";
            this.Pic_calendario.Size = new System.Drawing.Size(825, 548);
            this.Pic_calendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_calendario.TabIndex = 31;
            this.Pic_calendario.TabStop = false;
            // 
            // Tmr_tiempo
            // 
            this.Tmr_tiempo.Enabled = true;
            this.Tmr_tiempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_hora);
            this.Controls.Add(this.Pic_calendario);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_calendario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.PictureBox Pic_calendario;
        private System.Windows.Forms.Timer Tmr_tiempo;
    }
}