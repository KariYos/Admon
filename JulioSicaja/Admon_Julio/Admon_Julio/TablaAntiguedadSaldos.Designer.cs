namespace Admon_Julio
{
    partial class TablaAntiguedadSaldos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasMas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.diseño1.Titulo = "411_Reporte Antiguedad Saldos de Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoFactura,
            this.nFactura,
            this.fecha,
            this.vence,
            this.atraso,
            this.saldo,
            this.pago,
            this.tSaldo,
            this.dia30,
            this.dias60,
            this.dias90,
            this.diasMas});
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(909, 488);
            this.dataGridView1.TabIndex = 1;
            // 
            // tipoFactura
            // 
            this.tipoFactura.HeaderText = "Tipo";
            this.tipoFactura.Name = "tipoFactura";
            // 
            // nFactura
            // 
            this.nFactura.HeaderText = "Factura";
            this.nFactura.Name = "nFactura";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // vence
            // 
            this.vence.HeaderText = "Vence";
            this.vence.Name = "vence";
            // 
            // atraso
            // 
            this.atraso.HeaderText = "Atraso";
            this.atraso.Name = "atraso";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo Factura";
            this.saldo.Name = "saldo";
            // 
            // pago
            // 
            this.pago.HeaderText = "Pago Factura";
            this.pago.Name = "pago";
            // 
            // tSaldo
            // 
            this.tSaldo.HeaderText = "Saldo";
            this.tSaldo.Name = "tSaldo";
            // 
            // dia30
            // 
            this.dia30.HeaderText = "1-30 dias";
            this.dia30.Name = "dia30";
            // 
            // dias60
            // 
            this.dias60.HeaderText = "31-60 Dias";
            this.dias60.Name = "dias60";
            // 
            // dias90
            // 
            this.dias90.HeaderText = "61-90 Dias";
            this.dias90.Name = "dias90";
            // 
            // diasMas
            // 
            this.diasMas.HeaderText = "91+ Dias";
            this.diasMas.Name = "diasMas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Reporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // TablaAntiguedadSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablaAntiguedadSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaAntiguedadSaldos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn atraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias90;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasMas;
    }
}