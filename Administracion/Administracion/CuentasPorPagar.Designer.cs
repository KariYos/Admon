namespace Administracion
{
    partial class CuentasPorPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentasPorPagar));
            this.navegador1 = new CapaDiseno.Navegador();
            this.Pnl_Enca = new System.Windows.Forms.Panel();
            this.Label_Enca = new System.Windows.Forms.Label();
            this.Gbp_grupo = new System.Windows.Forms.GroupBox();
            this.Dtp_Final = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.Txt_Abonado = new System.Windows.Forms.TextBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Cbo_Proveedores = new System.Windows.Forms.ComboBox();
            this.Label_Final = new System.Windows.Forms.Label();
            this.Label_Inicio = new System.Windows.Forms.Label();
            this.Label_Saldo = new System.Windows.Forms.Label();
            this.Label_Abonado = new System.Windows.Forms.Label();
            this.Label_Total = new System.Windows.Forms.Label();
            this.Label_Proveedor = new System.Windows.Forms.Label();
            this.Pnl_Enca.SuspendLayout();
            this.Gbp_grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(26, 38);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 0;
            // 
            // Pnl_Enca
            // 
            this.Pnl_Enca.BackColor = System.Drawing.Color.Gray;
            this.Pnl_Enca.Controls.Add(this.Label_Enca);
            this.Pnl_Enca.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Enca.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Enca.Name = "Pnl_Enca";
            this.Pnl_Enca.Size = new System.Drawing.Size(917, 32);
            this.Pnl_Enca.TabIndex = 4;
            // 
            // Label_Enca
            // 
            this.Label_Enca.AutoSize = true;
            this.Label_Enca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Enca.Location = new System.Drawing.Point(3, 0);
            this.Label_Enca.Name = "Label_Enca";
            this.Label_Enca.Size = new System.Drawing.Size(232, 29);
            this.Label_Enca.TabIndex = 0;
            this.Label_Enca.Text = "Cuentas Por Pagar";
            // 
            // Gbp_grupo
            // 
            this.Gbp_grupo.BackColor = System.Drawing.Color.Transparent;
            this.Gbp_grupo.Controls.Add(this.Dtp_Final);
            this.Gbp_grupo.Controls.Add(this.Dtp_Inicio);
            this.Gbp_grupo.Controls.Add(this.Txt_Saldo);
            this.Gbp_grupo.Controls.Add(this.Txt_Abonado);
            this.Gbp_grupo.Controls.Add(this.Txt_Total);
            this.Gbp_grupo.Controls.Add(this.Cbo_Proveedores);
            this.Gbp_grupo.Controls.Add(this.Label_Final);
            this.Gbp_grupo.Controls.Add(this.Label_Inicio);
            this.Gbp_grupo.Controls.Add(this.Label_Saldo);
            this.Gbp_grupo.Controls.Add(this.Label_Abonado);
            this.Gbp_grupo.Controls.Add(this.Label_Total);
            this.Gbp_grupo.Controls.Add(this.Label_Proveedor);
            this.Gbp_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gbp_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_grupo.Location = new System.Drawing.Point(29, 104);
            this.Gbp_grupo.Name = "Gbp_grupo";
            this.Gbp_grupo.Size = new System.Drawing.Size(854, 545);
            this.Gbp_grupo.TabIndex = 5;
            this.Gbp_grupo.TabStop = false;
            // 
            // Dtp_Final
            // 
            this.Dtp_Final.CustomFormat = "";
            this.Dtp_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Final.Location = new System.Drawing.Point(298, 343);
            this.Dtp_Final.Name = "Dtp_Final";
            this.Dtp_Final.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Final.TabIndex = 11;
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.CustomFormat = "";
            this.Dtp_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Inicio.Location = new System.Drawing.Point(298, 297);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Inicio.TabIndex = 10;
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Saldo.Location = new System.Drawing.Point(298, 242);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(100, 26);
            this.Txt_Saldo.TabIndex = 9;
            // 
            // Txt_Abonado
            // 
            this.Txt_Abonado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Abonado.Location = new System.Drawing.Point(298, 192);
            this.Txt_Abonado.Name = "Txt_Abonado";
            this.Txt_Abonado.Size = new System.Drawing.Size(100, 26);
            this.Txt_Abonado.TabIndex = 8;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(298, 142);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(100, 26);
            this.Txt_Total.TabIndex = 7;
            // 
            // Cbo_Proveedores
            // 
            this.Cbo_Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Proveedores.FormattingEnabled = true;
            this.Cbo_Proveedores.Location = new System.Drawing.Point(298, 92);
            this.Cbo_Proveedores.Name = "Cbo_Proveedores";
            this.Cbo_Proveedores.Size = new System.Drawing.Size(200, 28);
            this.Cbo_Proveedores.TabIndex = 6;
            // 
            // Label_Final
            // 
            this.Label_Final.AutoSize = true;
            this.Label_Final.Location = new System.Drawing.Point(80, 343);
            this.Label_Final.Name = "Label_Final";
            this.Label_Final.Size = new System.Drawing.Size(125, 25);
            this.Label_Final.TabIndex = 5;
            this.Label_Final.Text = "Fecha Final";
            // 
            // Label_Inicio
            // 
            this.Label_Inicio.AutoSize = true;
            this.Label_Inicio.Location = new System.Drawing.Point(80, 297);
            this.Label_Inicio.Name = "Label_Inicio";
            this.Label_Inicio.Size = new System.Drawing.Size(128, 25);
            this.Label_Inicio.TabIndex = 4;
            this.Label_Inicio.Text = "Fecha Inicio";
            // 
            // Label_Saldo
            // 
            this.Label_Saldo.AutoSize = true;
            this.Label_Saldo.Location = new System.Drawing.Point(80, 242);
            this.Label_Saldo.Name = "Label_Saldo";
            this.Label_Saldo.Size = new System.Drawing.Size(151, 25);
            this.Label_Saldo.TabIndex = 3;
            this.Label_Saldo.Text = "Saldo Faltante";
            // 
            // Label_Abonado
            // 
            this.Label_Abonado.AutoSize = true;
            this.Label_Abonado.Location = new System.Drawing.Point(80, 198);
            this.Label_Abonado.Name = "Label_Abonado";
            this.Label_Abonado.Size = new System.Drawing.Size(98, 25);
            this.Label_Abonado.TabIndex = 2;
            this.Label_Abonado.Text = "Abonado";
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.Location = new System.Drawing.Point(80, 142);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(139, 25);
            this.Label_Total.TabIndex = 1;
            this.Label_Total.Text = "Total a pagar";
            // 
            // Label_Proveedor
            // 
            this.Label_Proveedor.AutoSize = true;
            this.Label_Proveedor.Location = new System.Drawing.Point(80, 92);
            this.Label_Proveedor.Name = "Label_Proveedor";
            this.Label_Proveedor.Size = new System.Drawing.Size(111, 25);
            this.Label_Proveedor.TabIndex = 0;
            this.Label_Proveedor.Text = "Proveedor";
            // 
            // CuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Gbp_grupo);
            this.Controls.Add(this.Pnl_Enca);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CuentasPorPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "304-Cuentas Por Pagar";
            this.Pnl_Enca.ResumeLayout(false);
            this.Pnl_Enca.PerformLayout();
            this.Gbp_grupo.ResumeLayout(false);
            this.Gbp_grupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Panel Pnl_Enca;
        private System.Windows.Forms.Label Label_Enca;
        private System.Windows.Forms.GroupBox Gbp_grupo;
        private System.Windows.Forms.DateTimePicker Dtp_Final;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.TextBox Txt_Saldo;
        private System.Windows.Forms.TextBox Txt_Abonado;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.ComboBox Cbo_Proveedores;
        private System.Windows.Forms.Label Label_Final;
        private System.Windows.Forms.Label Label_Inicio;
        private System.Windows.Forms.Label Label_Saldo;
        private System.Windows.Forms.Label Label_Abonado;
        private System.Windows.Forms.Label Label_Total;
        private System.Windows.Forms.Label Label_Proveedor;
    }
}