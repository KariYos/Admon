namespace DLL_MovimientoClientes
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
            this.diseño2 = new DiseñoVentana.Diseño();
            this.SuspendLayout();
            // 
            // diseño1
            // 
            this.diseño1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseño1.Forma = null;
            this.diseño1.Location = new System.Drawing.Point(0, 0);
            this.diseño1.Name = "diseño1";
            this.diseño1.Size = new System.Drawing.Size(933, 700);
            this.diseño1.TabIndex = 0;
            this.diseño1.Titulo = null;
            // 
            // Btn_Report
            // 
            this.Btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Report.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_Report.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Report.Location = new System.Drawing.Point(513, 376);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(71, 60);
            this.Btn_Report.TabIndex = 14;
            this.Btn_Report.Text = "Generar";
            this.Btn_Report.UseVisualStyleBackColor = false;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // Dtp_FechaReporte
            // 
            this.Dtp_FechaReporte.CustomFormat = "YYYY-MM-DD";
            this.Dtp_FechaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaReporte.Location = new System.Drawing.Point(436, 269);
            this.Dtp_FechaReporte.Name = "Dtp_FechaReporte";
            this.Dtp_FechaReporte.Size = new System.Drawing.Size(148, 31);
            this.Dtp_FechaReporte.TabIndex = 10;
            this.Dtp_FechaReporte.ValueChanged += new System.EventHandler(this.Dtp_FechaReporte_ValueChanged);
            // 
            // Txt_CodCliente
            // 
            this.Txt_CodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodCliente.Location = new System.Drawing.Point(436, 314);
            this.Txt_CodCliente.Name = "Txt_CodCliente";
            this.Txt_CodCliente.Size = new System.Drawing.Size(148, 31);
            this.Txt_CodCliente.TabIndex = 12;
            this.Txt_CodCliente.TextChanged += new System.EventHandler(this.Txt_CodCliente_TextChanged);
            // 
            // Lbl_CodCliente
            // 
            this.Lbl_CodCliente.AutoSize = true;
            this.Lbl_CodCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Lbl_CodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_CodCliente.Location = new System.Drawing.Point(244, 316);
            this.Lbl_CodCliente.Name = "Lbl_CodCliente";
            this.Lbl_CodCliente.Size = new System.Drawing.Size(188, 25);
            this.Lbl_CodCliente.TabIndex = 13;
            this.Lbl_CodCliente.Text = "Código del Cliente";
            this.Lbl_CodCliente.Click += new System.EventHandler(this.Lbl_CodCliente_Click);
            // 
            // Lbl_FechaReporte
            // 
            this.Lbl_FechaReporte.AutoSize = true;
            this.Lbl_FechaReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Lbl_FechaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaReporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_FechaReporte.Location = new System.Drawing.Point(241, 275);
            this.Lbl_FechaReporte.Name = "Lbl_FechaReporte";
            this.Lbl_FechaReporte.Size = new System.Drawing.Size(160, 25);
            this.Lbl_FechaReporte.TabIndex = 11;
            this.Lbl_FechaReporte.Text = "Fecha de Corte";
            this.Lbl_FechaReporte.Click += new System.EventHandler(this.Lbl_FechaReporte_Click);
            // 
            // diseño2
            // 
            this.diseño2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseño2.Forma = this;
            this.diseño2.Location = new System.Drawing.Point(0, 0);
            this.diseño2.Name = "diseño2";
            this.diseño2.Size = new System.Drawing.Size(933, 700);
            this.diseño2.TabIndex = 9;
            this.diseño2.Titulo = "4402_Balance de Antiguedad de Saldos";
            this.diseño2.Load += new System.EventHandler(this.diseño2_Load);
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
            this.Controls.Add(this.diseño2);
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
        private DiseñoVentana.Diseño diseño2;
    }
}