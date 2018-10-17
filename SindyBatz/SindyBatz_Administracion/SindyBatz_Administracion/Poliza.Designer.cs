namespace SindyBatz_Administracion
{
    partial class Poliza
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_poliza = new DiseñoVentana.Diseño();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Lbl_perid = new System.Windows.Forms.Label();
            this.Gpb_periodo = new System.Windows.Forms.GroupBox();
            this.Lbl_FechaFinal = new System.Windows.Forms.Label();
            this.Lbl_FechaInicial = new System.Windows.Forms.Label();
            this.Dtp_DateFinal = new System.Windows.Forms.DateTimePicker();
            this.v = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.Dgv_poliza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pic_navegador = new System.Windows.Forms.PictureBox();
            this.Gpb_periodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_navegador)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_poliza
            // 
            this.Pnl_poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_poliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_poliza.Forma = this;
            this.Pnl_poliza.Location = new System.Drawing.Point(0, 0);
            this.Pnl_poliza.Name = "Pnl_poliza";
            this.Pnl_poliza.Size = new System.Drawing.Size(933, 700);
            this.Pnl_poliza.TabIndex = 0;
            this.Pnl_poliza.Titulo = "4011_Polizas";
            this.Pnl_poliza.Load += new System.EventHandler(this.diseño1_Load);
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.Location = new System.Drawing.Point(313, 78);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(36, 16);
            this.Lbl_año.TabIndex = 12;
            this.Lbl_año.Text = "2018";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "/";
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.Location = new System.Drawing.Point(290, 78);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(15, 16);
            this.Lbl_mes.TabIndex = 11;
            this.Lbl_mes.Text = "2";
            // 
            // Lbl_perid
            // 
            this.Lbl_perid.AutoSize = true;
            this.Lbl_perid.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_perid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_perid.Location = new System.Drawing.Point(236, 78);
            this.Lbl_perid.Name = "Lbl_perid";
            this.Lbl_perid.Size = new System.Drawing.Size(60, 16);
            this.Lbl_perid.TabIndex = 9;
            this.Lbl_perid.Text = "Período ";
            // 
            // Gpb_periodo
            // 
            this.Gpb_periodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Gpb_periodo.Controls.Add(this.Lbl_año);
            this.Gpb_periodo.Controls.Add(this.Lbl_FechaFinal);
            this.Gpb_periodo.Controls.Add(this.label6);
            this.Gpb_periodo.Controls.Add(this.Lbl_FechaInicial);
            this.Gpb_periodo.Controls.Add(this.Lbl_mes);
            this.Gpb_periodo.Controls.Add(this.Dtp_DateFinal);
            this.Gpb_periodo.Controls.Add(this.Lbl_perid);
            this.Gpb_periodo.Controls.Add(this.v);
            this.Gpb_periodo.Controls.Add(this.Lbl_Periodo);
            this.Gpb_periodo.Location = new System.Drawing.Point(181, 134);
            this.Gpb_periodo.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_periodo.Name = "Gpb_periodo";
            this.Gpb_periodo.Size = new System.Drawing.Size(592, 108);
            this.Gpb_periodo.TabIndex = 8;
            this.Gpb_periodo.TabStop = false;
            this.Gpb_periodo.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Lbl_FechaFinal
            // 
            this.Lbl_FechaFinal.AutoSize = true;
            this.Lbl_FechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaFinal.Location = new System.Drawing.Point(363, 15);
            this.Lbl_FechaFinal.Name = "Lbl_FechaFinal";
            this.Lbl_FechaFinal.Size = new System.Drawing.Size(99, 19);
            this.Lbl_FechaFinal.TabIndex = 7;
            this.Lbl_FechaFinal.Text = "Fecha Final";
            // 
            // Lbl_FechaInicial
            // 
            this.Lbl_FechaInicial.AutoSize = true;
            this.Lbl_FechaInicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaInicial.Location = new System.Drawing.Point(139, 15);
            this.Lbl_FechaInicial.Name = "Lbl_FechaInicial";
            this.Lbl_FechaInicial.Size = new System.Drawing.Size(109, 19);
            this.Lbl_FechaInicial.TabIndex = 6;
            this.Lbl_FechaInicial.Text = "Fecha Inicial";
            // 
            // Dtp_DateFinal
            // 
            this.Dtp_DateFinal.Location = new System.Drawing.Point(329, 42);
            this.Dtp_DateFinal.Name = "Dtp_DateFinal";
            this.Dtp_DateFinal.Size = new System.Drawing.Size(200, 20);
            this.Dtp_DateFinal.TabIndex = 5;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(99, 42);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(200, 20);
            this.v.TabIndex = 4;
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Periodo.Location = new System.Drawing.Point(6, 42);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Periodo.TabIndex = 3;
            this.Lbl_Periodo.Text = "Período";
            // 
            // Dgv_poliza
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_poliza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_poliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_poliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Cuenta,
            this.Debe,
            this.Column3,
            this.Column4});
            this.Dgv_poliza.Location = new System.Drawing.Point(78, 262);
            this.Dgv_poliza.Name = "Dgv_poliza";
            this.Dgv_poliza.Size = new System.Drawing.Size(770, 370);
            this.Dgv_poliza.TabIndex = 9;
            this.Dgv_poliza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nomenclatura";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 15;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 220;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Haber";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Pic_navegador
            // 
            this.Pic_navegador.Image = global::SindyBatz_Administracion.Properties.Resources.navv;
            this.Pic_navegador.Location = new System.Drawing.Point(45, 46);
            this.Pic_navegador.Name = "Pic_navegador";
            this.Pic_navegador.Size = new System.Drawing.Size(858, 61);
            this.Pic_navegador.TabIndex = 1;
            this.Pic_navegador.TabStop = false;
            this.Pic_navegador.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Poliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Dgv_poliza);
            this.Controls.Add(this.Gpb_periodo);
            this.Controls.Add(this.Pic_navegador);
            this.Controls.Add(this.Pnl_poliza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Poliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliza";
            this.Gpb_periodo.ResumeLayout(false);
            this.Gpb_periodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_navegador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño Pnl_poliza;
        private System.Windows.Forms.PictureBox Pic_navegador;
        private System.Windows.Forms.Label Lbl_año;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.Label Lbl_perid;
        private System.Windows.Forms.GroupBox Gpb_periodo;
        private System.Windows.Forms.Label Lbl_FechaFinal;
        private System.Windows.Forms.Label Lbl_FechaInicial;
        private System.Windows.Forms.DateTimePicker Dtp_DateFinal;
        private System.Windows.Forms.DateTimePicker v;
        private System.Windows.Forms.Label Lbl_Periodo;
        private System.Windows.Forms.DataGridView Dgv_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}