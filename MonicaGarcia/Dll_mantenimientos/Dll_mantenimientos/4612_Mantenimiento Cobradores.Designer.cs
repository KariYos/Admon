﻿namespace Dll_mantenimientos
{
    partial class _4612_Mantenimiento_Cobradores
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
            this.diseñoCobradores = new DiseñoVentana.Diseño();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_codEmpleado = new System.Windows.Forms.TextBox();
            this.rdb_nodisponible = new System.Windows.Forms.RadioButton();
            this.rdb_disponible = new System.Windows.Forms.RadioButton();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.Txt_Comision = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Lbl_apellidoCobrador = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_Cobrador = new System.Windows.Forms.Label();
            this.Lbl_codCobrador = new System.Windows.Forms.Label();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Lbl_Comision = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.SuspendLayout();
            // 
            // diseñoCobradores
            // 
            this.diseñoCobradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseñoCobradores.Forma = this;
            this.diseñoCobradores.Location = new System.Drawing.Point(0, 0);
            this.diseñoCobradores.Name = "diseñoCobradores";
            this.diseñoCobradores.Size = new System.Drawing.Size(933, 700);
            this.diseñoCobradores.TabIndex = 0;
            this.diseñoCobradores.Titulo = "4612_Mantenimiento Cobradores";
            this.diseñoCobradores.Load += new System.EventHandler(this.diseñoCobradores_Load);
            this.diseñoCobradores.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.diseñoCobradores_HelpRequested);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.Location = new System.Drawing.Point(524, 542);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.Size = new System.Drawing.Size(73, 27);
            this.Txt_Estado.TabIndex = 72;
            this.Txt_Estado.Tag = "4";
            this.Txt_Estado.Text = "0";
            this.Txt_Estado.Visible = false;
            // 
            // Txt_codEmpleado
            // 
            this.Txt_codEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codEmpleado.Location = new System.Drawing.Point(346, 419);
            this.Txt_codEmpleado.Name = "Txt_codEmpleado";
            this.Txt_codEmpleado.Size = new System.Drawing.Size(68, 27);
            this.Txt_codEmpleado.TabIndex = 71;
            this.Txt_codEmpleado.Tag = "2";
            // 
            // rdb_nodisponible
            // 
            this.rdb_nodisponible.AutoSize = true;
            this.rdb_nodisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.rdb_nodisponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nodisponible.Location = new System.Drawing.Point(658, 543);
            this.rdb_nodisponible.Name = "rdb_nodisponible";
            this.rdb_nodisponible.Size = new System.Drawing.Size(134, 23);
            this.rdb_nodisponible.TabIndex = 70;
            this.rdb_nodisponible.TabStop = true;
            this.rdb_nodisponible.Text = "No disponible";
            this.rdb_nodisponible.UseVisualStyleBackColor = false;
            this.rdb_nodisponible.CheckedChanged += new System.EventHandler(this.rdb_nodisponible_CheckedChanged_1);
            // 
            // rdb_disponible
            // 
            this.rdb_disponible.AutoSize = true;
            this.rdb_disponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.rdb_disponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_disponible.Location = new System.Drawing.Point(346, 543);
            this.rdb_disponible.Name = "rdb_disponible";
            this.rdb_disponible.Size = new System.Drawing.Size(108, 23);
            this.rdb_disponible.TabIndex = 69;
            this.rdb_disponible.TabStop = true;
            this.rdb_disponible.Text = "Disponible";
            this.rdb_disponible.UseVisualStyleBackColor = false;
            this.rdb_disponible.CheckedChanged += new System.EventHandler(this.rdb_disponible_CheckedChanged_1);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(137, 542);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Estado.TabIndex = 68;
            this.Lbl_Estado.Text = "Estado";
            // 
            // cmb_Empleado
            // 
            this.cmb_Empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleado.FormattingEnabled = true;
            this.cmb_Empleado.Location = new System.Drawing.Point(420, 419);
            this.cmb_Empleado.Name = "cmb_Empleado";
            this.cmb_Empleado.Size = new System.Drawing.Size(366, 27);
            this.cmb_Empleado.TabIndex = 67;
            this.cmb_Empleado.SelectedIndexChanged += new System.EventHandler(this.cmb_Empleado_SelectedIndexChanged_1);
            // 
            // Txt_Comision
            // 
            this.Txt_Comision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Comision.Location = new System.Drawing.Point(346, 479);
            this.Txt_Comision.Name = "Txt_Comision";
            this.Txt_Comision.Size = new System.Drawing.Size(440, 27);
            this.Txt_Comision.TabIndex = 63;
            this.Txt_Comision.Tag = "3";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(346, 299);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.ReadOnly = true;
            this.Txt_nombre.Size = new System.Drawing.Size(440, 27);
            this.Txt_nombre.TabIndex = 64;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(346, 359);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.ReadOnly = true;
            this.Txt_Apellido.Size = new System.Drawing.Size(440, 27);
            this.Txt_Apellido.TabIndex = 66;
            // 
            // Lbl_apellidoCobrador
            // 
            this.Lbl_apellidoCobrador.AutoSize = true;
            this.Lbl_apellidoCobrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_apellidoCobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellidoCobrador.Location = new System.Drawing.Point(137, 362);
            this.Lbl_apellidoCobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_apellidoCobrador.Name = "Lbl_apellidoCobrador";
            this.Lbl_apellidoCobrador.Size = new System.Drawing.Size(177, 19);
            this.Lbl_apellidoCobrador.TabIndex = 60;
            this.Lbl_apellidoCobrador.Text = "Apellido de cobrador";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(346, 239);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(163, 27);
            this.Txt_codigo.TabIndex = 65;
            this.Txt_codigo.Tag = "1";
            // 
            // Lbl_Cobrador
            // 
            this.Lbl_Cobrador.AutoSize = true;
            this.Lbl_Cobrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_Cobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cobrador.Location = new System.Drawing.Point(137, 302);
            this.Lbl_Cobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cobrador.Name = "Lbl_Cobrador";
            this.Lbl_Cobrador.Size = new System.Drawing.Size(175, 19);
            this.Lbl_Cobrador.TabIndex = 59;
            this.Lbl_Cobrador.Text = "Nombre de cobrador";
            // 
            // Lbl_codCobrador
            // 
            this.Lbl_codCobrador.AutoSize = true;
            this.Lbl_codCobrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_codCobrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codCobrador.Location = new System.Drawing.Point(137, 242);
            this.Lbl_codCobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codCobrador.Name = "Lbl_codCobrador";
            this.Lbl_codCobrador.Size = new System.Drawing.Size(146, 19);
            this.Lbl_codCobrador.TabIndex = 58;
            this.Lbl_codCobrador.Text = "Codigo Cobrador";
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_Empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.Location = new System.Drawing.Point(137, 422);
            this.Lbl_Empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Empleado.TabIndex = 62;
            this.Lbl_Empleado.Text = "Empleado";
            // 
            // Lbl_Comision
            // 
            this.Lbl_Comision.AutoSize = true;
            this.Lbl_Comision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.Lbl_Comision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Comision.Location = new System.Drawing.Point(137, 482);
            this.Lbl_Comision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Comision.Name = "Lbl_Comision";
            this.Lbl_Comision.Size = new System.Drawing.Size(81, 19);
            this.Lbl_Comision.TabIndex = 61;
            this.Lbl_Comision.Text = "Comision";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(39, 105);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = "ModuloAdmon.chm";
            this.navegador1.pubNombreHtml = "cobradores.html";
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 73;
            // 
            // _4612_Mantenimiento_Cobradores
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
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.cmb_Empleado);
            this.Controls.Add(this.Txt_Comision);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Lbl_apellidoCobrador);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.Lbl_Cobrador);
            this.Controls.Add(this.Lbl_codCobrador);
            this.Controls.Add(this.Lbl_Empleado);
            this.Controls.Add(this.Lbl_Comision);
            this.Controls.Add(this.diseñoCobradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_4612_Mantenimiento_Cobradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4612_Mantenimiento_Cobradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiseñoVentana.Diseño diseñoCobradores;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_codEmpleado;
        private System.Windows.Forms.RadioButton rdb_nodisponible;
        private System.Windows.Forms.RadioButton rdb_disponible;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.ComboBox cmb_Empleado;
        private System.Windows.Forms.TextBox Txt_Comision;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label Lbl_apellidoCobrador;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_Cobrador;
        private System.Windows.Forms.Label Lbl_codCobrador;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Label Lbl_Comision;
        private CapaDiseno.Navegador navegador1;
    }
}