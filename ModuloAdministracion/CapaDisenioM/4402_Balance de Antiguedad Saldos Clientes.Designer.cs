namespace CapaDisenioM
{
    partial class _4402_Balance_de_Antiguedad_Saldos_Clientes
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
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Dtp_FechaReporte = new System.Windows.Forms.DateTimePicker();
            this.Txt_CodCliente = new System.Windows.Forms.TextBox();
            this.Lbl_CodCliente = new System.Windows.Forms.Label();
            this.Lbl_FechaReporte = new System.Windows.Forms.Label();
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
            this.diseño1.Titulo = "4402_Balance de Antiguedad de Saldos";
            this.diseño1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.diseño1_HelpRequested);
            // 
            // Btn_Report
            // 
            this.Btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Report.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_Report.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Report.Location = new System.Drawing.Point(562, 370);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(71, 60);
            this.Btn_Report.TabIndex = 8;
            this.Btn_Report.Text = "Generar";
            this.Btn_Report.UseVisualStyleBackColor = false;
            // 
            // Dtp_FechaReporte
            // 
            this.Dtp_FechaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaReporte.Location = new System.Drawing.Point(485, 263);
            this.Dtp_FechaReporte.Name = "Dtp_FechaReporte";
            this.Dtp_FechaReporte.Size = new System.Drawing.Size(148, 31);
            this.Dtp_FechaReporte.TabIndex = 4;
            // 
            // Txt_CodCliente
            // 
            this.Txt_CodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodCliente.Location = new System.Drawing.Point(485, 308);
            this.Txt_CodCliente.Name = "Txt_CodCliente";
            this.Txt_CodCliente.Size = new System.Drawing.Size(148, 31);
            this.Txt_CodCliente.TabIndex = 6;
            // 
            // Lbl_CodCliente
            // 
            this.Lbl_CodCliente.AutoSize = true;
            this.Lbl_CodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_CodCliente.Location = new System.Drawing.Point(293, 310);
            this.Lbl_CodCliente.Name = "Lbl_CodCliente";
            this.Lbl_CodCliente.Size = new System.Drawing.Size(188, 25);
            this.Lbl_CodCliente.TabIndex = 7;
            this.Lbl_CodCliente.Text = "Código del Cliente";
            // 
            // Lbl_FechaReporte
            // 
            this.Lbl_FechaReporte.AutoSize = true;
            this.Lbl_FechaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaReporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_FechaReporte.Location = new System.Drawing.Point(290, 269);
            this.Lbl_FechaReporte.Name = "Lbl_FechaReporte";
            this.Lbl_FechaReporte.Size = new System.Drawing.Size(189, 25);
            this.Lbl_FechaReporte.TabIndex = 5;
            this.Lbl_FechaReporte.Text = "Fecha del Reporte";
            // 
            // _4402_Balance_de_Antiguedad_Saldos_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.Dtp_FechaReporte);
            this.Controls.Add(this.Txt_CodCliente);
            this.Controls.Add(this.Lbl_CodCliente);
            this.Controls.Add(this.Lbl_FechaReporte);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_4402_Balance_de_Antiguedad_Saldos_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4402_Balance_de_Antiguedad_Saldos_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.DateTimePicker Dtp_FechaReporte;
        private System.Windows.Forms.TextBox Txt_CodCliente;
        private System.Windows.Forms.Label Lbl_CodCliente;
        private System.Windows.Forms.Label Lbl_FechaReporte;
    }
}