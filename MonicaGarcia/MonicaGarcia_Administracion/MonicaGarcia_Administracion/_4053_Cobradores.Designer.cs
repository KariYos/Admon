namespace MonicaGarcia_Administracion
{
    partial class _4053_Cobradores
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
            this.Gpb_DatosCobrador = new System.Windows.Forms.GroupBox();
            this.rdb_nodisponible = new System.Windows.Forms.RadioButton();
            this.rdb_disponible = new System.Windows.Forms.RadioButton();
            this.Lbl_estatus = new System.Windows.Forms.Label();
            this.cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.Txt_ComisionCobrador = new System.Windows.Forms.TextBox();
            this.Txt_nombreCobrador = new System.Windows.Forms.TextBox();
            this.Txt_apellidoCobrador = new System.Windows.Forms.TextBox();
            this.Lbl_ApellidoC = new System.Windows.Forms.Label();
            this.Txt_codigoCobrador = new System.Windows.Forms.TextBox();
            this.Lbl_nombreC = new System.Windows.Forms.Label();
            this.Lbl_codigoC = new System.Windows.Forms.Label();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Lbl_Comision = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Gpb_DatosCobrador.SuspendLayout();
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
            this.diseño1.Titulo = "4053_Cobradores";
            this.diseño1.Load += new System.EventHandler(this.diseño1_Load);
            // 
            // Gpb_DatosCobrador
            // 
            this.Gpb_DatosCobrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Gpb_DatosCobrador.Controls.Add(this.rdb_nodisponible);
            this.Gpb_DatosCobrador.Controls.Add(this.rdb_disponible);
            this.Gpb_DatosCobrador.Controls.Add(this.Lbl_estatus);
            this.Gpb_DatosCobrador.Controls.Add(this.cmb_Empleado);
            this.Gpb_DatosCobrador.Controls.Add(this.Txt_ComisionCobrador);
            this.Gpb_DatosCobrador.Controls.Add(this.Txt_nombreCobrador);
            this.Gpb_DatosCobrador.Controls.Add(this.Txt_apellidoCobrador);
            this.Gpb_DatosCobrador.Controls.Add(this.Lbl_ApellidoC);
            this.Gpb_DatosCobrador.Controls.Add(this.Txt_codigoCobrador);
            this.Gpb_DatosCobrador.Controls.Add(this.Lbl_nombreC);
            this.Gpb_DatosCobrador.Controls.Add(this.Lbl_codigoC);
            this.Gpb_DatosCobrador.Controls.Add(this.Lbl_empleado);
            this.Gpb_DatosCobrador.Controls.Add(this.Lbl_Comision);
            this.Gpb_DatosCobrador.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_DatosCobrador.Location = new System.Drawing.Point(86, 197);
            this.Gpb_DatosCobrador.Name = "Gpb_DatosCobrador";
            this.Gpb_DatosCobrador.Size = new System.Drawing.Size(730, 411);
            this.Gpb_DatosCobrador.TabIndex = 18;
            this.Gpb_DatosCobrador.TabStop = false;
            this.Gpb_DatosCobrador.Text = "Datos ";
            this.Gpb_DatosCobrador.Enter += new System.EventHandler(this.Gpb_DatosCobrador_Enter);
            // 
            // rdb_nodisponible
            // 
            this.rdb_nodisponible.AutoSize = true;
            this.rdb_nodisponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nodisponible.Location = new System.Drawing.Point(560, 357);
            this.rdb_nodisponible.Name = "rdb_nodisponible";
            this.rdb_nodisponible.Size = new System.Drawing.Size(134, 23);
            this.rdb_nodisponible.TabIndex = 13;
            this.rdb_nodisponible.TabStop = true;
            this.rdb_nodisponible.Text = "No disponible";
            this.rdb_nodisponible.UseVisualStyleBackColor = true;
            // 
            // rdb_disponible
            // 
            this.rdb_disponible.AutoSize = true;
            this.rdb_disponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_disponible.Location = new System.Drawing.Point(248, 357);
            this.rdb_disponible.Name = "rdb_disponible";
            this.rdb_disponible.Size = new System.Drawing.Size(108, 23);
            this.rdb_disponible.TabIndex = 12;
            this.rdb_disponible.TabStop = true;
            this.rdb_disponible.Text = "Disponible";
            this.rdb_disponible.UseVisualStyleBackColor = true;
            // 
            // Lbl_estatus
            // 
            this.Lbl_estatus.AutoSize = true;
            this.Lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estatus.Location = new System.Drawing.Point(39, 361);
            this.Lbl_estatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estatus.Name = "Lbl_estatus";
            this.Lbl_estatus.Size = new System.Drawing.Size(58, 19);
            this.Lbl_estatus.TabIndex = 11;
            this.Lbl_estatus.Text = "Estatus";
            // 
            // cmb_Empleado
            // 
            this.cmb_Empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleado.FormattingEnabled = true;
            this.cmb_Empleado.Location = new System.Drawing.Point(248, 293);
            this.cmb_Empleado.Name = "cmb_Empleado";
            this.cmb_Empleado.Size = new System.Drawing.Size(440, 27);
            this.cmb_Empleado.TabIndex = 10;
            // 
            // Txt_ComisionCobrador
            // 
            this.Txt_ComisionCobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ComisionCobrador.Location = new System.Drawing.Point(248, 233);
            this.Txt_ComisionCobrador.Name = "Txt_ComisionCobrador";
            this.Txt_ComisionCobrador.Size = new System.Drawing.Size(440, 27);
            this.Txt_ComisionCobrador.TabIndex = 6;
            // 
            // Txt_nombreCobrador
            // 
            this.Txt_nombreCobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreCobrador.Location = new System.Drawing.Point(248, 113);
            this.Txt_nombreCobrador.Name = "Txt_nombreCobrador";
            this.Txt_nombreCobrador.ReadOnly = true;
            this.Txt_nombreCobrador.Size = new System.Drawing.Size(440, 27);
            this.Txt_nombreCobrador.TabIndex = 7;
            // 
            // Txt_apellidoCobrador
            // 
            this.Txt_apellidoCobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidoCobrador.Location = new System.Drawing.Point(248, 173);
            this.Txt_apellidoCobrador.Name = "Txt_apellidoCobrador";
            this.Txt_apellidoCobrador.ReadOnly = true;
            this.Txt_apellidoCobrador.Size = new System.Drawing.Size(440, 27);
            this.Txt_apellidoCobrador.TabIndex = 9;
            // 
            // Lbl_ApellidoC
            // 
            this.Lbl_ApellidoC.AutoSize = true;
            this.Lbl_ApellidoC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApellidoC.Location = new System.Drawing.Point(39, 180);
            this.Lbl_ApellidoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApellidoC.Name = "Lbl_ApellidoC";
            this.Lbl_ApellidoC.Size = new System.Drawing.Size(177, 19);
            this.Lbl_ApellidoC.TabIndex = 2;
            this.Lbl_ApellidoC.Text = "Apellido de cobrador";
            // 
            // Txt_codigoCobrador
            // 
            this.Txt_codigoCobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoCobrador.Location = new System.Drawing.Point(248, 53);
            this.Txt_codigoCobrador.Name = "Txt_codigoCobrador";
            this.Txt_codigoCobrador.ReadOnly = true;
            this.Txt_codigoCobrador.Size = new System.Drawing.Size(163, 27);
            this.Txt_codigoCobrador.TabIndex = 8;
            // 
            // Lbl_nombreC
            // 
            this.Lbl_nombreC.AutoSize = true;
            this.Lbl_nombreC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreC.Location = new System.Drawing.Point(39, 121);
            this.Lbl_nombreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreC.Name = "Lbl_nombreC";
            this.Lbl_nombreC.Size = new System.Drawing.Size(175, 19);
            this.Lbl_nombreC.TabIndex = 1;
            this.Lbl_nombreC.Text = "Nombre de cobrador";
            // 
            // Lbl_codigoC
            // 
            this.Lbl_codigoC.AutoSize = true;
            this.Lbl_codigoC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoC.Location = new System.Drawing.Point(39, 62);
            this.Lbl_codigoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoC.Name = "Lbl_codigoC";
            this.Lbl_codigoC.Size = new System.Drawing.Size(146, 19);
            this.Lbl_codigoC.TabIndex = 0;
            this.Lbl_codigoC.Text = "Codigo Cobrador";
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_empleado.Location = new System.Drawing.Point(39, 298);
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
            this.Lbl_Comision.Location = new System.Drawing.Point(39, 239);
            this.Lbl_Comision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Comision.Name = "Lbl_Comision";
            this.Lbl_Comision.Size = new System.Drawing.Size(81, 19);
            this.Lbl_Comision.TabIndex = 4;
            this.Lbl_Comision.Text = "Comision";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(39, 78);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 19;
            // 
            // _4053_Cobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Gpb_DatosCobrador);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_4053_Cobradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4053_Cobradores";
            this.Gpb_DatosCobrador.ResumeLayout(false);
            this.Gpb_DatosCobrador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.GroupBox Gpb_DatosCobrador;
        private System.Windows.Forms.ComboBox cmb_Empleado;
        private System.Windows.Forms.TextBox Txt_ComisionCobrador;
        private System.Windows.Forms.TextBox Txt_nombreCobrador;
        private System.Windows.Forms.TextBox Txt_apellidoCobrador;
        private System.Windows.Forms.Label Lbl_ApellidoC;
        private System.Windows.Forms.TextBox Txt_codigoCobrador;
        private System.Windows.Forms.Label Lbl_nombreC;
        private System.Windows.Forms.Label Lbl_codigoC;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.Label Lbl_Comision;
        private System.Windows.Forms.RadioButton rdb_nodisponible;
        private System.Windows.Forms.RadioButton rdb_disponible;
        private System.Windows.Forms.Label Lbl_estatus;
        private CapaDiseno.Navegador navegador1;
    }
}