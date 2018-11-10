namespace Dll_mantenimientos
{
    partial class _4065_Alta_conceptos_cuentas_por_cobrar
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
            this.diseñoAltas = new DiseñoVentana.Diseño();
            this.Txt_tipoS = new System.Windows.Forms.TextBox();
            this.rgb_abono = new System.Windows.Forms.RadioButton();
            this.rdb_cargo = new System.Windows.Forms.RadioButton();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_cuentaContable = new System.Windows.Forms.TextBox();
            this.cmb_cuentaContable = new System.Windows.Forms.ComboBox();
            this.Txt_codigoConcepto = new System.Windows.Forms.TextBox();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Lbl_tipoSaldo = new System.Windows.Forms.Label();
            this.Lbl_desc = new System.Windows.Forms.Label();
            this.Lbl_codigoConcepto = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.SuspendLayout();
            // 
            // diseñoAltas
            // 
            this.diseñoAltas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseñoAltas.Forma = this;
            this.diseñoAltas.Location = new System.Drawing.Point(0, 0);
            this.diseñoAltas.Name = "diseñoAltas";
            this.diseñoAltas.Size = new System.Drawing.Size(933, 700);
            this.diseñoAltas.TabIndex = 0;
            this.diseñoAltas.Tag = "";
            this.diseñoAltas.Titulo = "4065 Altas Conceptos Cuetas por Cobrar";
            this.diseñoAltas.Load += new System.EventHandler(this.diseñoAltas_Load);
            // 
            // Txt_tipoS
            // 
            this.Txt_tipoS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tipoS.Location = new System.Drawing.Point(584, 273);
            this.Txt_tipoS.Name = "Txt_tipoS";
            this.Txt_tipoS.Size = new System.Drawing.Size(68, 27);
            this.Txt_tipoS.TabIndex = 70;
            this.Txt_tipoS.Tag = "3";
            this.Txt_tipoS.Visible = false;
            this.Txt_tipoS.TextChanged += new System.EventHandler(this.Txt_cuenta_TextChanged);
            // 
            // rgb_abono
            // 
            this.rgb_abono.AutoSize = true;
            this.rgb_abono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.rgb_abono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_abono.Location = new System.Drawing.Point(470, 274);
            this.rgb_abono.Name = "rgb_abono";
            this.rgb_abono.Size = new System.Drawing.Size(80, 23);
            this.rgb_abono.TabIndex = 69;
            this.rgb_abono.TabStop = true;
            this.rgb_abono.Text = "Abono";
            this.rgb_abono.UseVisualStyleBackColor = false;
            this.rgb_abono.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_cargo
            // 
            this.rdb_cargo.AutoSize = true;
            this.rdb_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.rdb_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_cargo.Location = new System.Drawing.Point(340, 274);
            this.rdb_cargo.Name = "rdb_cargo";
            this.rdb_cargo.Size = new System.Drawing.Size(76, 23);
            this.rdb_cargo.TabIndex = 68;
            this.rdb_cargo.TabStop = true;
            this.rdb_cargo.Text = "Cargo";
            this.rdb_cargo.UseVisualStyleBackColor = false;
            this.rdb_cargo.CheckedChanged += new System.EventHandler(this.rdb_disponible_CheckedChanged);
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(340, 387);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(442, 166);
            this.Txt_descripcion.TabIndex = 67;
            this.Txt_descripcion.Tag = "2";
            // 
            // Txt_cuentaContable
            // 
            this.Txt_cuentaContable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cuentaContable.Location = new System.Drawing.Point(338, 328);
            this.Txt_cuentaContable.Name = "Txt_cuentaContable";
            this.Txt_cuentaContable.Size = new System.Drawing.Size(68, 27);
            this.Txt_cuentaContable.TabIndex = 66;
            this.Txt_cuentaContable.Tag = "4";
            // 
            // cmb_cuentaContable
            // 
            this.cmb_cuentaContable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cuentaContable.FormattingEnabled = true;
            this.cmb_cuentaContable.Location = new System.Drawing.Point(425, 328);
            this.cmb_cuentaContable.Name = "cmb_cuentaContable";
            this.cmb_cuentaContable.Size = new System.Drawing.Size(357, 27);
            this.cmb_cuentaContable.TabIndex = 65;
            this.cmb_cuentaContable.SelectedIndexChanged += new System.EventHandler(this.cmb_cuentaContable_SelectedIndexChanged_1);
            // 
            // Txt_codigoConcepto
            // 
            this.Txt_codigoConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoConcepto.Location = new System.Drawing.Point(340, 213);
            this.Txt_codigoConcepto.Name = "Txt_codigoConcepto";
            this.Txt_codigoConcepto.Size = new System.Drawing.Size(442, 27);
            this.Txt_codigoConcepto.TabIndex = 64;
            this.Txt_codigoConcepto.Tag = "1";
            this.Txt_codigoConcepto.TextChanged += new System.EventHandler(this.Txt_codigoConcepto_TextChanged_1);
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_cuenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.Location = new System.Drawing.Point(122, 328);
            this.Lbl_cuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(170, 23);
            this.Lbl_cuenta.TabIndex = 63;
            this.Lbl_cuenta.Text = "Cuenta Contable";
            // 
            // Lbl_tipoSaldo
            // 
            this.Lbl_tipoSaldo.AutoSize = true;
            this.Lbl_tipoSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_tipoSaldo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoSaldo.Location = new System.Drawing.Point(122, 273);
            this.Lbl_tipoSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tipoSaldo.Name = "Lbl_tipoSaldo";
            this.Lbl_tipoSaldo.Size = new System.Drawing.Size(136, 23);
            this.Lbl_tipoSaldo.TabIndex = 62;
            this.Lbl_tipoSaldo.Text = "Tipo de Saldo";
            // 
            // Lbl_desc
            // 
            this.Lbl_desc.AutoSize = true;
            this.Lbl_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_desc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_desc.Location = new System.Drawing.Point(122, 387);
            this.Lbl_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_desc.Name = "Lbl_desc";
            this.Lbl_desc.Size = new System.Drawing.Size(119, 23);
            this.Lbl_desc.TabIndex = 61;
            this.Lbl_desc.Text = "Descripción";
            // 
            // Lbl_codigoConcepto
            // 
            this.Lbl_codigoConcepto.AutoSize = true;
            this.Lbl_codigoConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_codigoConcepto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoConcepto.Location = new System.Drawing.Point(122, 213);
            this.Lbl_codigoConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoConcepto.Name = "Lbl_codigoConcepto";
            this.Lbl_codigoConcepto.Size = new System.Drawing.Size(211, 23);
            this.Lbl_codigoConcepto.TabIndex = 60;
            this.Lbl_codigoConcepto.Text = "Número de Concepto";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(51, 97);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = "ModuloAdmon.chm";
            this.navegador1.pubNombreHtml = "AltasConceptosClientes.html";
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 71;
            // 
            // _4065_Alta_conceptos_cuentas_por_cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_tipoS);
            this.Controls.Add(this.rgb_abono);
            this.Controls.Add(this.rdb_cargo);
            this.Controls.Add(this.Txt_descripcion);
            this.Controls.Add(this.Txt_cuentaContable);
            this.Controls.Add(this.cmb_cuentaContable);
            this.Controls.Add(this.Txt_codigoConcepto);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.Lbl_tipoSaldo);
            this.Controls.Add(this.Lbl_desc);
            this.Controls.Add(this.Lbl_codigoConcepto);
            this.Controls.Add(this.diseñoAltas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_4065_Alta_conceptos_cuentas_por_cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4065_Alta_conceptos_cuentas_por_cobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiseñoVentana.Diseño diseñoAltas;
        private System.Windows.Forms.TextBox Txt_tipoS;
        private System.Windows.Forms.RadioButton rgb_abono;
        private System.Windows.Forms.RadioButton rdb_cargo;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.TextBox Txt_cuentaContable;
        private System.Windows.Forms.ComboBox cmb_cuentaContable;
        private System.Windows.Forms.TextBox Txt_codigoConcepto;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Label Lbl_tipoSaldo;
        private System.Windows.Forms.Label Lbl_desc;
        private System.Windows.Forms.Label Lbl_codigoConcepto;
        private CapaDiseno.Navegador navegador1;
    }
}