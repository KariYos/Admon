namespace Dll_mantenimientos
{
    partial class _4603_Mantenimiento_Vendedores
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
            this.diseñoVendedor = new DiseñoVentana.Diseño();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_codEmpleado = new System.Windows.Forms.TextBox();
            this.rdb_nodisponible = new System.Windows.Forms.RadioButton();
            this.rdb_disponible = new System.Windows.Forms.RadioButton();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.cmb_nombreEmpleado = new System.Windows.Forms.ComboBox();
            this.Txt_ComisionVendedor = new System.Windows.Forms.TextBox();
            this.Txt_nombreVendedor = new System.Windows.Forms.TextBox();
            this.Txt_apellidoVendedor = new System.Windows.Forms.TextBox();
            this.Lbl_ApellidoV = new System.Windows.Forms.Label();
            this.Txt_cdigoVemdedor = new System.Windows.Forms.TextBox();
            this.Lbl_nombreV = new System.Windows.Forms.Label();
            this.Lbl_codigoV = new System.Windows.Forms.Label();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Lbl_Comision = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.SuspendLayout();
            // 
            // diseñoVendedor
            // 
            this.diseñoVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseñoVendedor.Forma = this;
            this.diseñoVendedor.Location = new System.Drawing.Point(0, 0);
            this.diseñoVendedor.Name = "diseñoVendedor";
            this.diseñoVendedor.Size = new System.Drawing.Size(933, 700);
            this.diseñoVendedor.TabIndex = 0;
            this.diseñoVendedor.Titulo = "4603_Mantenimiento Vendedores";
            this.diseñoVendedor.Load += new System.EventHandler(this.diseñoVendedor_Load);
            this.diseñoVendedor.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.diseñoVendedor_HelpRequested);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.Location = new System.Drawing.Point(518, 526);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.Size = new System.Drawing.Size(73, 27);
            this.Txt_Estado.TabIndex = 69;
            this.Txt_Estado.Tag = "4";
            this.Txt_Estado.Text = "0";
            this.Txt_Estado.Visible = false;
            // 
            // Txt_codEmpleado
            // 
            this.Txt_codEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codEmpleado.Location = new System.Drawing.Point(353, 407);
            this.Txt_codEmpleado.Name = "Txt_codEmpleado";
            this.Txt_codEmpleado.Size = new System.Drawing.Size(68, 27);
            this.Txt_codEmpleado.TabIndex = 68;
            this.Txt_codEmpleado.Tag = "2";
            // 
            // rdb_nodisponible
            // 
            this.rdb_nodisponible.AutoSize = true;
            this.rdb_nodisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.rdb_nodisponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nodisponible.Location = new System.Drawing.Point(665, 527);
            this.rdb_nodisponible.Name = "rdb_nodisponible";
            this.rdb_nodisponible.Size = new System.Drawing.Size(134, 23);
            this.rdb_nodisponible.TabIndex = 67;
            this.rdb_nodisponible.TabStop = true;
            this.rdb_nodisponible.Text = "No disponible";
            this.rdb_nodisponible.UseVisualStyleBackColor = false;
            this.rdb_nodisponible.CheckedChanged += new System.EventHandler(this.rdb_nodisponible_CheckedChanged);
            // 
            // rdb_disponible
            // 
            this.rdb_disponible.AutoSize = true;
            this.rdb_disponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.rdb_disponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_disponible.Location = new System.Drawing.Point(353, 527);
            this.rdb_disponible.Name = "rdb_disponible";
            this.rdb_disponible.Size = new System.Drawing.Size(108, 23);
            this.rdb_disponible.TabIndex = 66;
            this.rdb_disponible.TabStop = true;
            this.rdb_disponible.Text = "Disponible";
            this.rdb_disponible.UseVisualStyleBackColor = false;
            this.rdb_disponible.CheckedChanged += new System.EventHandler(this.rdb_disponible_CheckedChanged);
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(143, 529);
            this.Lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(59, 19);
            this.Lbl_estado.TabIndex = 65;
            this.Lbl_estado.Text = "Estado";
            // 
            // cmb_nombreEmpleado
            // 
            this.cmb_nombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nombreEmpleado.FormattingEnabled = true;
            this.cmb_nombreEmpleado.Location = new System.Drawing.Point(436, 407);
            this.cmb_nombreEmpleado.Name = "cmb_nombreEmpleado";
            this.cmb_nombreEmpleado.Size = new System.Drawing.Size(357, 27);
            this.cmb_nombreEmpleado.TabIndex = 64;
            this.cmb_nombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmb_Empleado_SelectedIndexChanged);
            // 
            // Txt_ComisionVendedor
            // 
            this.Txt_ComisionVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ComisionVendedor.Location = new System.Drawing.Point(353, 463);
            this.Txt_ComisionVendedor.Name = "Txt_ComisionVendedor";
            this.Txt_ComisionVendedor.Size = new System.Drawing.Size(440, 27);
            this.Txt_ComisionVendedor.TabIndex = 60;
            this.Txt_ComisionVendedor.Tag = "3";
            // 
            // Txt_nombreVendedor
            // 
            this.Txt_nombreVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreVendedor.Location = new System.Drawing.Point(353, 294);
            this.Txt_nombreVendedor.Name = "Txt_nombreVendedor";
            this.Txt_nombreVendedor.ReadOnly = true;
            this.Txt_nombreVendedor.Size = new System.Drawing.Size(440, 27);
            this.Txt_nombreVendedor.TabIndex = 61;
            // 
            // Txt_apellidoVendedor
            // 
            this.Txt_apellidoVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidoVendedor.Location = new System.Drawing.Point(353, 350);
            this.Txt_apellidoVendedor.Name = "Txt_apellidoVendedor";
            this.Txt_apellidoVendedor.ReadOnly = true;
            this.Txt_apellidoVendedor.Size = new System.Drawing.Size(440, 27);
            this.Txt_apellidoVendedor.TabIndex = 63;
            // 
            // Lbl_ApellidoV
            // 
            this.Lbl_ApellidoV.AutoSize = true;
            this.Lbl_ApellidoV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_ApellidoV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApellidoV.Location = new System.Drawing.Point(143, 354);
            this.Lbl_ApellidoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApellidoV.Name = "Lbl_ApellidoV";
            this.Lbl_ApellidoV.Size = new System.Drawing.Size(184, 19);
            this.Lbl_ApellidoV.TabIndex = 57;
            this.Lbl_ApellidoV.Text = "Apellido del vendedor";
            // 
            // Txt_cdigoVemdedor
            // 
            this.Txt_cdigoVemdedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cdigoVemdedor.Location = new System.Drawing.Point(353, 238);
            this.Txt_cdigoVemdedor.Name = "Txt_cdigoVemdedor";
            this.Txt_cdigoVemdedor.Size = new System.Drawing.Size(163, 27);
            this.Txt_cdigoVemdedor.TabIndex = 62;
            this.Txt_cdigoVemdedor.Tag = "1";
            // 
            // Lbl_nombreV
            // 
            this.Lbl_nombreV.AutoSize = true;
            this.Lbl_nombreV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_nombreV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreV.Location = new System.Drawing.Point(143, 298);
            this.Lbl_nombreV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreV.Name = "Lbl_nombreV";
            this.Lbl_nombreV.Size = new System.Drawing.Size(182, 19);
            this.Lbl_nombreV.TabIndex = 56;
            this.Lbl_nombreV.Text = "Nombre del vendedor";
            // 
            // Lbl_codigoV
            // 
            this.Lbl_codigoV.AutoSize = true;
            this.Lbl_codigoV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_codigoV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoV.Location = new System.Drawing.Point(143, 242);
            this.Lbl_codigoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoV.Name = "Lbl_codigoV";
            this.Lbl_codigoV.Size = new System.Drawing.Size(176, 19);
            this.Lbl_codigoV.TabIndex = 55;
            this.Lbl_codigoV.Text = "Codigo del vendedor";
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_empleado.Location = new System.Drawing.Point(143, 410);
            this.Lbl_empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_empleado.Name = "Lbl_empleado";
            this.Lbl_empleado.Size = new System.Drawing.Size(90, 19);
            this.Lbl_empleado.TabIndex = 59;
            this.Lbl_empleado.Text = "Empleado";
            // 
            // Lbl_Comision
            // 
            this.Lbl_Comision.AutoSize = true;
            this.Lbl_Comision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_Comision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Comision.Location = new System.Drawing.Point(143, 466);
            this.Lbl_Comision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Comision.Name = "Lbl_Comision";
            this.Lbl_Comision.Size = new System.Drawing.Size(85, 19);
            this.Lbl_Comision.TabIndex = 58;
            this.Lbl_Comision.Text = "Comision ";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(36, 100);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = "ModuloAdmon.chm";
            this.navegador1.pubNombreHtml = "vendedores.html";
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 70;
            // 
            // _4603_Mantenimiento_Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Txt_codEmpleado);
            this.Controls.Add(this.rdb_nodisponible);
            this.Controls.Add(this.rdb_disponible);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.cmb_nombreEmpleado);
            this.Controls.Add(this.Txt_ComisionVendedor);
            this.Controls.Add(this.Txt_nombreVendedor);
            this.Controls.Add(this.Txt_apellidoVendedor);
            this.Controls.Add(this.Lbl_ApellidoV);
            this.Controls.Add(this.Txt_cdigoVemdedor);
            this.Controls.Add(this.Lbl_nombreV);
            this.Controls.Add(this.Lbl_codigoV);
            this.Controls.Add(this.Lbl_empleado);
            this.Controls.Add(this.Lbl_Comision);
            this.Controls.Add(this.diseñoVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_4603_Mantenimiento_Vendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4603_Mantenimiento_Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiseñoVentana.Diseño diseñoVendedor;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_codEmpleado;
        private System.Windows.Forms.RadioButton rdb_nodisponible;
        private System.Windows.Forms.RadioButton rdb_disponible;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.ComboBox cmb_nombreEmpleado;
        private System.Windows.Forms.TextBox Txt_ComisionVendedor;
        private System.Windows.Forms.TextBox Txt_nombreVendedor;
        private System.Windows.Forms.TextBox Txt_apellidoVendedor;
        private System.Windows.Forms.Label Lbl_ApellidoV;
        private System.Windows.Forms.TextBox Txt_cdigoVemdedor;
        private System.Windows.Forms.Label Lbl_nombreV;
        private System.Windows.Forms.Label Lbl_codigoV;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.Label Lbl_Comision;
        private CapaDiseno.Navegador navegador1;
    }
}