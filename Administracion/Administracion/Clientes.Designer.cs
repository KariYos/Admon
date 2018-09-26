namespace Administracion
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Dgv_contacto = new System.Windows.Forms.GroupBox();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Lbl_tel = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Txt_tel = new System.Windows.Forms.TextBox();
            this.Dgv_info = new System.Windows.Forms.GroupBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.Txt_dire = new System.Windows.Forms.TextBox();
            this.Lbl_dire = new System.Windows.Forms.Label();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.Txt_dpi = new System.Windows.Forms.TextBox();
            this.Dgv_basico = new System.Windows.Forms.GroupBox();
            this.Cbo_tipoCliente = new System.Windows.Forms.ComboBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_tipoCliente = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Dgv_contacto.SuspendLayout();
            this.Dgv_info.SuspendLayout();
            this.Dgv_basico.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "hora";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "fecha";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(841, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dgv_contacto
            // 
            this.Dgv_contacto.Controls.Add(this.Txt_correo);
            this.Dgv_contacto.Controls.Add(this.Lbl_tel);
            this.Dgv_contacto.Controls.Add(this.Lbl_correo);
            this.Dgv_contacto.Controls.Add(this.Txt_tel);
            this.Dgv_contacto.Location = new System.Drawing.Point(60, 478);
            this.Dgv_contacto.Name = "Dgv_contacto";
            this.Dgv_contacto.Size = new System.Drawing.Size(790, 116);
            this.Dgv_contacto.TabIndex = 28;
            this.Dgv_contacto.TabStop = false;
            // 
            // Txt_correo
            // 
            this.Txt_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo.Location = new System.Drawing.Point(220, 71);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(322, 23);
            this.Txt_correo.TabIndex = 17;
            // 
            // Lbl_tel
            // 
            this.Lbl_tel.AutoSize = true;
            this.Lbl_tel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel.Location = new System.Drawing.Point(119, 35);
            this.Lbl_tel.Name = "Lbl_tel";
            this.Lbl_tel.Size = new System.Drawing.Size(71, 18);
            this.Lbl_tel.TabIndex = 10;
            this.Lbl_tel.Text = "Teléfono";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(119, 76);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(60, 18);
            this.Lbl_correo.TabIndex = 11;
            this.Lbl_correo.Text = "Correo";
            // 
            // Txt_tel
            // 
            this.Txt_tel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tel.Location = new System.Drawing.Point(221, 30);
            this.Txt_tel.Name = "Txt_tel";
            this.Txt_tel.Size = new System.Drawing.Size(122, 23);
            this.Txt_tel.TabIndex = 16;
            // 
            // Dgv_info
            // 
            this.Dgv_info.Controls.Add(this.Txt_nombre);
            this.Dgv_info.Controls.Add(this.Lbl_dpi);
            this.Dgv_info.Controls.Add(this.Lbl_nombre);
            this.Dgv_info.Controls.Add(this.Lbl_apellido);
            this.Dgv_info.Controls.Add(this.Txt_dire);
            this.Dgv_info.Controls.Add(this.Lbl_dire);
            this.Dgv_info.Controls.Add(this.Txt_apellido);
            this.Dgv_info.Controls.Add(this.Txt_dpi);
            this.Dgv_info.Location = new System.Drawing.Point(60, 239);
            this.Dgv_info.Name = "Dgv_info";
            this.Dgv_info.Size = new System.Drawing.Size(790, 219);
            this.Dgv_info.TabIndex = 27;
            this.Dgv_info.TabStop = false;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(220, 72);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(394, 23);
            this.Txt_nombre.TabIndex = 13;
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpi.Location = new System.Drawing.Point(119, 36);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(31, 18);
            this.Lbl_dpi.TabIndex = 6;
            this.Lbl_dpi.Text = "DPI";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(119, 77);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(68, 18);
            this.Lbl_nombre.TabIndex = 7;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.Location = new System.Drawing.Point(119, 118);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(71, 18);
            this.Lbl_apellido.TabIndex = 8;
            this.Lbl_apellido.Text = "Apellido";
            // 
            // Txt_dire
            // 
            this.Txt_dire.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dire.Location = new System.Drawing.Point(220, 154);
            this.Txt_dire.Name = "Txt_dire";
            this.Txt_dire.Size = new System.Drawing.Size(394, 23);
            this.Txt_dire.TabIndex = 15;
            // 
            // Lbl_dire
            // 
            this.Lbl_dire.AutoSize = true;
            this.Lbl_dire.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dire.Location = new System.Drawing.Point(119, 159);
            this.Lbl_dire.Name = "Lbl_dire";
            this.Lbl_dire.Size = new System.Drawing.Size(81, 18);
            this.Lbl_dire.TabIndex = 9;
            this.Lbl_dire.Text = "Dirección";
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.Location = new System.Drawing.Point(220, 113);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(394, 23);
            this.Txt_apellido.TabIndex = 14;
            // 
            // Txt_dpi
            // 
            this.Txt_dpi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dpi.Location = new System.Drawing.Point(220, 31);
            this.Txt_dpi.Name = "Txt_dpi";
            this.Txt_dpi.Size = new System.Drawing.Size(169, 23);
            this.Txt_dpi.TabIndex = 12;
            // 
            // Dgv_basico
            // 
            this.Dgv_basico.Controls.Add(this.Cbo_tipoCliente);
            this.Dgv_basico.Controls.Add(this.Lbl_codigo);
            this.Dgv_basico.Controls.Add(this.Txt_codigo);
            this.Dgv_basico.Controls.Add(this.Lbl_tipoCliente);
            this.Dgv_basico.Location = new System.Drawing.Point(60, 109);
            this.Dgv_basico.Name = "Dgv_basico";
            this.Dgv_basico.Size = new System.Drawing.Size(790, 118);
            this.Dgv_basico.TabIndex = 26;
            this.Dgv_basico.TabStop = false;
            // 
            // Cbo_tipoCliente
            // 
            this.Cbo_tipoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipoCliente.FormattingEnabled = true;
            this.Cbo_tipoCliente.Location = new System.Drawing.Point(137, 69);
            this.Cbo_tipoCliente.Name = "Cbo_tipoCliente";
            this.Cbo_tipoCliente.Size = new System.Drawing.Size(121, 25);
            this.Cbo_tipoCliente.TabIndex = 18;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(32, 33);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(64, 18);
            this.Lbl_codigo.TabIndex = 3;
            this.Lbl_codigo.Text = "Código";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(137, 28);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(122, 23);
            this.Txt_codigo.TabIndex = 4;
            // 
            // Lbl_tipoCliente
            // 
            this.Lbl_tipoCliente.AutoSize = true;
            this.Lbl_tipoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoCliente.Location = new System.Drawing.Point(32, 76);
            this.Lbl_tipoCliente.Name = "Lbl_tipoCliente";
            this.Lbl_tipoCliente.Size = new System.Drawing.Size(95, 18);
            this.Lbl_tipoCliente.TabIndex = 5;
            this.Lbl_tipoCliente.Text = "Tipo Cliente";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(33, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 18;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Dgv_contacto);
            this.Controls.Add(this.Dgv_info);
            this.Controls.Add(this.Dgv_basico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Dgv_contacto.ResumeLayout(false);
            this.Dgv_contacto.PerformLayout();
            this.Dgv_info.ResumeLayout(false);
            this.Dgv_info.PerformLayout();
            this.Dgv_basico.ResumeLayout(false);
            this.Dgv_basico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox Dgv_contacto;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label Lbl_tel;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.TextBox Txt_tel;
        private System.Windows.Forms.GroupBox Dgv_info;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_dpi;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.TextBox Txt_dire;
        private System.Windows.Forms.Label Lbl_dire;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox Txt_dpi;
        private System.Windows.Forms.GroupBox Dgv_basico;
        private System.Windows.Forms.ComboBox Cbo_tipoCliente;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_tipoCliente;
        private CapaDiseno.Navegador navegador1;
    }
}