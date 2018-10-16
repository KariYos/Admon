namespace KarinaYos_Administracion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiseñoMovProv = new DiseñoVentana.Diseño();
            this.Dgb_MovProv = new System.Windows.Forms.DataGridView();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_MovProv)).BeginInit();
            this.SuspendLayout();
            // 
            // DiseñoMovProv
            // 
            this.DiseñoMovProv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiseñoMovProv.Forma = this;
            this.DiseñoMovProv.Location = new System.Drawing.Point(0, 0);
            this.DiseñoMovProv.Name = "DiseñoMovProv";
            this.DiseñoMovProv.Size = new System.Drawing.Size(933, 700);
            this.DiseñoMovProv.TabIndex = 0;
            this.DiseñoMovProv.Titulo = "MovimientosCxP";
            // 
            // Dgb_MovProv
            // 
            this.Dgb_MovProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_MovProv.Location = new System.Drawing.Point(43, 69);
            this.Dgb_MovProv.Name = "Dgb_MovProv";
            this.Dgb_MovProv.Size = new System.Drawing.Size(833, 496);
            this.Dgb_MovProv.TabIndex = 1;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_Agregar.Location = new System.Drawing.Point(428, 594);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(61, 60);
            this.Btn_Agregar.TabIndex = 29;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Dgb_MovProv);
            this.Controls.Add(this.DiseñoMovProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_MovProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño DiseñoMovProv;
        private System.Windows.Forms.DataGridView Dgb_MovProv;
        private System.Windows.Forms.Button Btn_Agregar;
    }
}

