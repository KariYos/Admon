namespace MonicaGarcia_Administracion
{
    partial class _4052_Vendedor
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
            this.Gpb_DatosVendedor = new System.Windows.Forms.GroupBox();
            this.rdb_nodisponible = new System.Windows.Forms.RadioButton();
            this.rdb_disponible = new System.Windows.Forms.RadioButton();
            this.Lbl_estatus = new System.Windows.Forms.Label();
            this.cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.Txt_ComisionVendedor = new System.Windows.Forms.TextBox();
            this.Txt_nombreVededor = new System.Windows.Forms.TextBox();
            this.Txt_apellidoVendedor = new System.Windows.Forms.TextBox();
            this.Lbl_ApellidoV = new System.Windows.Forms.Label();
            this.Txt_cdigoVemdedor = new System.Windows.Forms.TextBox();
            this.Lbl_nombreV = new System.Windows.Forms.Label();
            this.Lbl_codigoV = new System.Windows.Forms.Label();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Lbl_Comision = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Gpb_DatosVendedor.SuspendLayout();
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
            this.diseño1.Titulo = "4052_Vendedor";
            this.diseño1.Load += new System.EventHandler(this.diseño1_Load);
            // 
            // Gpb_DatosVendedor
            // 
            this.Gpb_DatosVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Gpb_DatosVendedor.Controls.Add(this.rdb_nodisponible);
            this.Gpb_DatosVendedor.Controls.Add(this.rdb_disponible);
            this.Gpb_DatosVendedor.Controls.Add(this.Lbl_estatus);
            this.Gpb_DatosVendedor.Controls.Add(this.cmb_Empleado);
            this.Gpb_DatosVendedor.Controls.Add(this.Txt_ComisionVendedor);
            this.Gpb_DatosVendedor.Controls.Add(this.Txt_nombreVededor);
            this.Gpb_DatosVendedor.Controls.Add(this.Txt_apellidoVendedor);
            this.Gpb_DatosVendedor.Controls.Add(this.Lbl_ApellidoV);
            this.Gpb_DatosVendedor.Controls.Add(this.Txt_cdigoVemdedor);
            this.Gpb_DatosVendedor.Controls.Add(this.Lbl_nombreV);
            this.Gpb_DatosVendedor.Controls.Add(this.Lbl_codigoV);
            this.Gpb_DatosVendedor.Controls.Add(this.Lbl_empleado);
            this.Gpb_DatosVendedor.Controls.Add(this.Lbl_Comision);
            this.Gpb_DatosVendedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_DatosVendedor.Location = new System.Drawing.Point(73, 215);
            this.Gpb_DatosVendedor.Name = "Gpb_DatosVendedor";
            this.Gpb_DatosVendedor.Size = new System.Drawing.Size(777, 438);
            this.Gpb_DatosVendedor.TabIndex = 16;
            this.Gpb_DatosVendedor.TabStop = false;
            this.Gpb_DatosVendedor.Text = "Datos ";
            this.Gpb_DatosVendedor.Enter += new System.EventHandler(this.Gpb_DatosVendedor_Enter);
            // 
            // rdb_nodisponible
            // 
            this.rdb_nodisponible.AutoSize = true;
            this.rdb_nodisponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nodisponible.Location = new System.Drawing.Point(588, 365);
            this.rdb_nodisponible.Name = "rdb_nodisponible";
            this.rdb_nodisponible.Size = new System.Drawing.Size(134, 23);
            this.rdb_nodisponible.TabIndex = 16;
            this.rdb_nodisponible.TabStop = true;
            this.rdb_nodisponible.Text = "No disponible";
            this.rdb_nodisponible.UseVisualStyleBackColor = true;
            // 
            // rdb_disponible
            // 
            this.rdb_disponible.AutoSize = true;
            this.rdb_disponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_disponible.Location = new System.Drawing.Point(276, 365);
            this.rdb_disponible.Name = "rdb_disponible";
            this.rdb_disponible.Size = new System.Drawing.Size(108, 23);
            this.rdb_disponible.TabIndex = 15;
            this.rdb_disponible.TabStop = true;
            this.rdb_disponible.Text = "Disponible";
            this.rdb_disponible.UseVisualStyleBackColor = true;
            // 
            // Lbl_estatus
            // 
            this.Lbl_estatus.AutoSize = true;
            this.Lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estatus.Location = new System.Drawing.Point(66, 360);
            this.Lbl_estatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estatus.Name = "Lbl_estatus";
            this.Lbl_estatus.Size = new System.Drawing.Size(58, 19);
            this.Lbl_estatus.TabIndex = 14;
            this.Lbl_estatus.Text = "Estatus";
            // 
            // cmb_Empleado
            // 
            this.cmb_Empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleado.FormattingEnabled = true;
            this.cmb_Empleado.Location = new System.Drawing.Point(276, 300);
            this.cmb_Empleado.Name = "cmb_Empleado";
            this.cmb_Empleado.Size = new System.Drawing.Size(440, 27);
            this.cmb_Empleado.TabIndex = 10;
            // 
            // Txt_ComisionVendedor
            // 
            this.Txt_ComisionVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ComisionVendedor.Location = new System.Drawing.Point(276, 244);
            this.Txt_ComisionVendedor.Name = "Txt_ComisionVendedor";
            this.Txt_ComisionVendedor.Size = new System.Drawing.Size(440, 27);
            this.Txt_ComisionVendedor.TabIndex = 6;
            this.Txt_ComisionVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ComisionVendedor_KeyPress);
            // 
            // Txt_nombreVededor
            // 
            this.Txt_nombreVededor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreVededor.Location = new System.Drawing.Point(276, 132);
            this.Txt_nombreVededor.Name = "Txt_nombreVededor";
            this.Txt_nombreVededor.ReadOnly = true;
            this.Txt_nombreVededor.Size = new System.Drawing.Size(440, 27);
            this.Txt_nombreVededor.TabIndex = 7;
            // 
            // Txt_apellidoVendedor
            // 
            this.Txt_apellidoVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidoVendedor.Location = new System.Drawing.Point(276, 188);
            this.Txt_apellidoVendedor.Name = "Txt_apellidoVendedor";
            this.Txt_apellidoVendedor.ReadOnly = true;
            this.Txt_apellidoVendedor.Size = new System.Drawing.Size(440, 27);
            this.Txt_apellidoVendedor.TabIndex = 9;
            // 
            // Lbl_ApellidoV
            // 
            this.Lbl_ApellidoV.AutoSize = true;
            this.Lbl_ApellidoV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApellidoV.Location = new System.Drawing.Point(66, 192);
            this.Lbl_ApellidoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApellidoV.Name = "Lbl_ApellidoV";
            this.Lbl_ApellidoV.Size = new System.Drawing.Size(184, 19);
            this.Lbl_ApellidoV.TabIndex = 2;
            this.Lbl_ApellidoV.Text = "Apellido del vendedor";
            // 
            // Txt_cdigoVemdedor
            // 
            this.Txt_cdigoVemdedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cdigoVemdedor.Location = new System.Drawing.Point(276, 76);
            this.Txt_cdigoVemdedor.Name = "Txt_cdigoVemdedor";
            this.Txt_cdigoVemdedor.ReadOnly = true;
            this.Txt_cdigoVemdedor.Size = new System.Drawing.Size(163, 27);
            this.Txt_cdigoVemdedor.TabIndex = 8;
            // 
            // Lbl_nombreV
            // 
            this.Lbl_nombreV.AutoSize = true;
            this.Lbl_nombreV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreV.Location = new System.Drawing.Point(66, 136);
            this.Lbl_nombreV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreV.Name = "Lbl_nombreV";
            this.Lbl_nombreV.Size = new System.Drawing.Size(182, 19);
            this.Lbl_nombreV.TabIndex = 1;
            this.Lbl_nombreV.Text = "Nombre del vendedor";
            // 
            // Lbl_codigoV
            // 
            this.Lbl_codigoV.AutoSize = true;
            this.Lbl_codigoV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoV.Location = new System.Drawing.Point(66, 80);
            this.Lbl_codigoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoV.Name = "Lbl_codigoV";
            this.Lbl_codigoV.Size = new System.Drawing.Size(176, 19);
            this.Lbl_codigoV.TabIndex = 0;
            this.Lbl_codigoV.Text = "Codigo del vendedor";
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_empleado.Location = new System.Drawing.Point(66, 304);
            this.Lbl_empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_empleado.Name = "Lbl_empleado";
            this.Lbl_empleado.Size = new System.Drawing.Size(90, 19);
            this.Lbl_empleado.TabIndex = 5;
            this.Lbl_empleado.Text = "Empleado";
            // 
            // Lbl_Comision
            // 
            this.Lbl_Comision.AutoSize = true;
            this.Lbl_Comision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Comision.Location = new System.Drawing.Point(66, 248);
            this.Lbl_Comision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Comision.Name = "Lbl_Comision";
            this.Lbl_Comision.Size = new System.Drawing.Size(85, 19);
            this.Lbl_Comision.TabIndex = 4;
            this.Lbl_Comision.Text = "Comision ";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(38, 90);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 17;
            // 
            // _4052_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Gpb_DatosVendedor);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_4052_Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4052_Vendedor";
            this.Gpb_DatosVendedor.ResumeLayout(false);
            this.Gpb_DatosVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.GroupBox Gpb_DatosVendedor;
        private System.Windows.Forms.ComboBox cmb_Empleado;
        private System.Windows.Forms.TextBox Txt_ComisionVendedor;
        private System.Windows.Forms.TextBox Txt_nombreVededor;
        private System.Windows.Forms.TextBox Txt_apellidoVendedor;
        private System.Windows.Forms.Label Lbl_ApellidoV;
        private System.Windows.Forms.TextBox Txt_cdigoVemdedor;
        private System.Windows.Forms.Label Lbl_nombreV;
        private System.Windows.Forms.Label Lbl_codigoV;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.Label Lbl_Comision;
        private System.Windows.Forms.RadioButton rdb_nodisponible;
        private System.Windows.Forms.RadioButton rdb_disponible;
        private System.Windows.Forms.Label Lbl_estatus;
        private CapaDiseno.Navegador navegador1;
    }
}