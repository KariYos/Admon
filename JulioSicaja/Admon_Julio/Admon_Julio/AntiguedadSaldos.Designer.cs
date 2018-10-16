namespace Admon_Julio
{
    partial class AntiguedadSaldos
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
            this.Lbl_FechaReporte = new System.Windows.Forms.Label();
            this.Lbl_CodCliente = new System.Windows.Forms.Label();
            this.Pnl_Contenedor = new System.Windows.Forms.Panel();
            this.Txt_CodCliente = new System.Windows.Forms.TextBox();
            this.Dtp_FechaReporte = new System.Windows.Forms.DateTimePicker();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Pnl_Contenedor.SuspendLayout();
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
            this.diseño1.Titulo = "410_Balance de Antiguedad de Saldos";
            // 
            // Lbl_FechaReporte
            // 
            this.Lbl_FechaReporte.AutoSize = true;
            this.Lbl_FechaReporte.Location = new System.Drawing.Point(56, 81);
            this.Lbl_FechaReporte.Name = "Lbl_FechaReporte";
            this.Lbl_FechaReporte.Size = new System.Drawing.Size(179, 23);
            this.Lbl_FechaReporte.TabIndex = 1;
            this.Lbl_FechaReporte.Text = "Fecha del Reporte";
            // 
            // Lbl_CodCliente
            // 
            this.Lbl_CodCliente.AutoSize = true;
            this.Lbl_CodCliente.Location = new System.Drawing.Point(49, 128);
            this.Lbl_CodCliente.Name = "Lbl_CodCliente";
            this.Lbl_CodCliente.Size = new System.Drawing.Size(186, 23);
            this.Lbl_CodCliente.TabIndex = 2;
            this.Lbl_CodCliente.Text = "Código del Cliente";
            // 
            // Pnl_Contenedor
            // 
            this.Pnl_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Pnl_Contenedor.Controls.Add(this.Btn_Report);
            this.Pnl_Contenedor.Controls.Add(this.Dtp_FechaReporte);
            this.Pnl_Contenedor.Controls.Add(this.Txt_CodCliente);
            this.Pnl_Contenedor.Controls.Add(this.Lbl_CodCliente);
            this.Pnl_Contenedor.Controls.Add(this.Lbl_FechaReporte);
            this.Pnl_Contenedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Contenedor.Location = new System.Drawing.Point(165, 196);
            this.Pnl_Contenedor.Name = "Pnl_Contenedor";
            this.Pnl_Contenedor.Size = new System.Drawing.Size(519, 248);
            this.Pnl_Contenedor.TabIndex = 3;
            // 
            // Txt_CodCliente
            // 
            this.Txt_CodCliente.Location = new System.Drawing.Point(299, 120);
            this.Txt_CodCliente.Name = "Txt_CodCliente";
            this.Txt_CodCliente.Size = new System.Drawing.Size(148, 31);
            this.Txt_CodCliente.TabIndex = 2;
            // 
            // Dtp_FechaReporte
            // 
            this.Dtp_FechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaReporte.Location = new System.Drawing.Point(299, 75);
            this.Dtp_FechaReporte.Name = "Dtp_FechaReporte";
            this.Dtp_FechaReporte.Size = new System.Drawing.Size(148, 31);
            this.Dtp_FechaReporte.TabIndex = 1;
            // 
            // Btn_Report
            // 
            this.Btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Report.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Report.Location = new System.Drawing.Point(376, 173);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(71, 60);
            this.Btn_Report.TabIndex = 3;
            this.Btn_Report.Text = "Generar";
            this.Btn_Report.UseVisualStyleBackColor = false;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // AntiguedadSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Pnl_Contenedor);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AntiguedadSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntiguedadSaldos";
            this.Pnl_Contenedor.ResumeLayout(false);
            this.Pnl_Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.Panel Pnl_Contenedor;
        private System.Windows.Forms.DateTimePicker Dtp_FechaReporte;
        private System.Windows.Forms.TextBox Txt_CodCliente;
        private System.Windows.Forms.Label Lbl_CodCliente;
        private System.Windows.Forms.Label Lbl_FechaReporte;
        private System.Windows.Forms.Button Btn_Report;
    }
}