namespace Administracion
{
    partial class Devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Gpb_cantidades = new System.Windows.Forms.GroupBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Lbl_unidades = new System.Windows.Forms.Label();
            this.lLbl_total = new System.Windows.Forms.Label();
            this.Txt_unidades = new System.Windows.Forms.TextBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Gpb_datosCliente = new System.Windows.Forms.GroupBox();
            this.Btn_datosCliente = new System.Windows.Forms.Button();
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.Cbo_tipoDevolucion = new System.Windows.Forms.ComboBox();
            this.Lbl_tipoDev = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Gpb_cantidades.SuspendLayout();
            this.Gpb_datosCliente.SuspendLayout();
            this.Gpb_encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(841, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "fecha";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Gpb_cantidades
            // 
            this.Gpb_cantidades.Controls.Add(this.Txt_total);
            this.Gpb_cantidades.Controls.Add(this.Lbl_descripcion);
            this.Gpb_cantidades.Controls.Add(this.Lbl_unidades);
            this.Gpb_cantidades.Controls.Add(this.lLbl_total);
            this.Gpb_cantidades.Controls.Add(this.Txt_unidades);
            this.Gpb_cantidades.Controls.Add(this.Txt_descripcion);
            this.Gpb_cantidades.Location = new System.Drawing.Point(56, 455);
            this.Gpb_cantidades.Name = "Gpb_cantidades";
            this.Gpb_cantidades.Size = new System.Drawing.Size(790, 121);
            this.Gpb_cantidades.TabIndex = 39;
            this.Gpb_cantidades.TabStop = false;
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(587, 64);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(119, 23);
            this.Txt_total.TabIndex = 29;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(45, 36);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(97, 18);
            this.Lbl_descripcion.TabIndex = 24;
            this.Lbl_descripcion.Text = "Descripción";
            // 
            // Lbl_unidades
            // 
            this.Lbl_unidades.AutoSize = true;
            this.Lbl_unidades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_unidades.Location = new System.Drawing.Point(454, 36);
            this.Lbl_unidades.Name = "Lbl_unidades";
            this.Lbl_unidades.Size = new System.Drawing.Size(127, 18);
            this.Lbl_unidades.TabIndex = 25;
            this.Lbl_unidades.Text = "Fact. / Unidades";
            // 
            // lLbl_total
            // 
            this.lLbl_total.AutoSize = true;
            this.lLbl_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLbl_total.Location = new System.Drawing.Point(455, 69);
            this.lLbl_total.Name = "lLbl_total";
            this.lLbl_total.Size = new System.Drawing.Size(126, 18);
            this.lLbl_total.TabIndex = 26;
            this.lLbl_total.Text = "Total por Partida";
            // 
            // Txt_unidades
            // 
            this.Txt_unidades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_unidades.Location = new System.Drawing.Point(587, 31);
            this.Txt_unidades.Name = "Txt_unidades";
            this.Txt_unidades.Size = new System.Drawing.Size(119, 23);
            this.Txt_unidades.TabIndex = 28;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(148, 31);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(288, 23);
            this.Txt_descripcion.TabIndex = 27;
            // 
            // Gpb_datosCliente
            // 
            this.Gpb_datosCliente.Controls.Add(this.Btn_datosCliente);
            this.Gpb_datosCliente.Location = new System.Drawing.Point(56, 190);
            this.Gpb_datosCliente.Name = "Gpb_datosCliente";
            this.Gpb_datosCliente.Size = new System.Drawing.Size(790, 240);
            this.Gpb_datosCliente.TabIndex = 38;
            this.Gpb_datosCliente.TabStop = false;
            // 
            // Btn_datosCliente
            // 
            this.Btn_datosCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_datosCliente.Location = new System.Drawing.Point(21, 19);
            this.Btn_datosCliente.Name = "Btn_datosCliente";
            this.Btn_datosCliente.Size = new System.Drawing.Size(122, 33);
            this.Btn_datosCliente.TabIndex = 23;
            this.Btn_datosCliente.Text = "Datos Cliente";
            this.Btn_datosCliente.UseVisualStyleBackColor = true;
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.Cbo_tipoDevolucion);
            this.Gpb_encabezado.Controls.Add(this.Lbl_tipoDev);
            this.Gpb_encabezado.Controls.Add(this.Lbl_fecha);
            this.Gpb_encabezado.Controls.Add(this.Dtp_fecha);
            this.Gpb_encabezado.Location = new System.Drawing.Point(56, 90);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(790, 81);
            this.Gpb_encabezado.TabIndex = 37;
            this.Gpb_encabezado.TabStop = false;
            // 
            // Cbo_tipoDevolucion
            // 
            this.Cbo_tipoDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipoDevolucion.FormattingEnabled = true;
            this.Cbo_tipoDevolucion.Location = new System.Drawing.Point(172, 35);
            this.Cbo_tipoDevolucion.Name = "Cbo_tipoDevolucion";
            this.Cbo_tipoDevolucion.Size = new System.Drawing.Size(121, 25);
            this.Cbo_tipoDevolucion.TabIndex = 20;
            // 
            // Lbl_tipoDev
            // 
            this.Lbl_tipoDev.AutoSize = true;
            this.Lbl_tipoDev.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoDev.Location = new System.Drawing.Point(39, 35);
            this.Lbl_tipoDev.Name = "Lbl_tipoDev";
            this.Lbl_tipoDev.Size = new System.Drawing.Size(127, 18);
            this.Lbl_tipoDev.TabIndex = 19;
            this.Lbl_tipoDev.Text = "Tipo Devolución";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(490, 35);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_fecha.TabIndex = 21;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Location = new System.Drawing.Point(550, 30);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 23);
            this.Dtp_fecha.TabIndex = 22;
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Gpb_cantidades);
            this.Controls.Add(this.Gpb_datosCliente);
            this.Controls.Add(this.Gpb_encabezado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devoluciones";
            this.Text = "309_Devoluciones";
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            this.Gpb_cantidades.ResumeLayout(false);
            this.Gpb_cantidades.PerformLayout();
            this.Gpb_datosCliente.ResumeLayout(false);
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox Gpb_cantidades;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label Lbl_unidades;
        private System.Windows.Forms.Label lLbl_total;
        private System.Windows.Forms.TextBox Txt_unidades;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.GroupBox Gpb_datosCliente;
        private System.Windows.Forms.Button Btn_datosCliente;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.ComboBox Cbo_tipoDevolucion;
        private System.Windows.Forms.Label Lbl_tipoDev;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
    }
}