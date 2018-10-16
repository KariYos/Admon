namespace Admon_Julio
{
    partial class ClienteConsultar
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
            this.diseño1 = new DiseñoVentana.Diseño();
            this.Gpx_Contenedor = new System.Windows.Forms.GroupBox();
            this.Lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.Gpx_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // diseño1
            // 
            this.diseño1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseño1.Forma = this;
            this.diseño1.Location = new System.Drawing.Point(0, 0);
            this.diseño1.Name = "diseño1";
            this.diseño1.Size = new System.Drawing.Size(933, 700);
            this.diseño1.TabIndex = 0;
            this.diseño1.Titulo = "413_Movimiento de Cuentas por Cobrar";
            // 
            // Gpx_Contenedor
            // 
            this.Gpx_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Gpx_Contenedor.Controls.Add(this.Btn_Cliente);
            this.Gpx_Contenedor.Controls.Add(this.textBox1);
            this.Gpx_Contenedor.Controls.Add(this.Lbl_CodigoCliente);
            this.Gpx_Contenedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpx_Contenedor.Location = new System.Drawing.Point(260, 211);
            this.Gpx_Contenedor.Name = "Gpx_Contenedor";
            this.Gpx_Contenedor.Size = new System.Drawing.Size(337, 183);
            this.Gpx_Contenedor.TabIndex = 1;
            this.Gpx_Contenedor.TabStop = false;
            this.Gpx_Contenedor.Text = "Cliente a consultar";
            // 
            // Lbl_CodigoCliente
            // 
            this.Lbl_CodigoCliente.AutoSize = true;
            this.Lbl_CodigoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoCliente.Location = new System.Drawing.Point(48, 80);
            this.Lbl_CodigoCliente.Name = "Lbl_CodigoCliente";
            this.Lbl_CodigoCliente.Size = new System.Drawing.Size(71, 19);
            this.Lbl_CodigoCliente.TabIndex = 0;
            this.Lbl_CodigoCliente.Text = "Codigo:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cliente.Location = new System.Drawing.Point(205, 117);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(71, 60);
            this.Btn_Cliente.TabIndex = 4;
            this.Btn_Cliente.Text = "Consultar";
            this.Btn_Cliente.UseVisualStyleBackColor = false;
            // 
            // ClienteConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Gpx_Contenedor);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteConsultar";
            this.Gpx_Contenedor.ResumeLayout(false);
            this.Gpx_Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.GroupBox Gpx_Contenedor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_CodigoCliente;
        private System.Windows.Forms.Button Btn_Cliente;
    }
}