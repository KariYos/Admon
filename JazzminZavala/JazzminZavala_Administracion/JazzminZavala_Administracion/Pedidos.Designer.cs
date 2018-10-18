namespace JazzminZavala_Administracion
{
    partial class Pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.diseño1 = new DiseñoVentana.Diseño();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_aFactura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gpb_datosp = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_numPedido = new System.Windows.Forms.Label();
            this.Dtp_fechap = new System.Windows.Forms.DateTimePicker();
            this.Lbl_pedido = new System.Windows.Forms.Label();
            this.Txt_direccionp = new System.Windows.Forms.TextBox();
            this.Lbl_fechap = new System.Windows.Forms.Label();
            this.Txt_nitp = new System.Windows.Forms.TextBox();
            this.Lbl_direccionp = new System.Windows.Forms.Label();
            this.Txt_nombrep = new System.Windows.Forms.TextBox();
            this.Lbl_nitp = new System.Windows.Forms.Label();
            this.Lbl_nombrep = new System.Windows.Forms.Label();
            this.Cbo_formaenvio = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lbl_formaenvio = new System.Windows.Forms.Label();
            this.Gpb_empresa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_detallePedido = new System.Windows.Forms.GroupBox();
            this.Dgb_detallePedido = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_porcentaje = new System.Windows.Forms.Label();
            this.Lbl_codigop = new System.Windows.Forms.Label();
            this.Txt_codigop = new System.Windows.Forms.TextBox();
            this.Lbl_descuentoP = new System.Windows.Forms.Label();
            this.Lbl_descripcionDp = new System.Windows.Forms.Label();
            this.Lbl_nombredp = new System.Windows.Forms.Label();
            this.Txt_descuentop = new System.Windows.Forms.TextBox();
            this.Txt_descripcionp = new System.Windows.Forms.TextBox();
            this.Txt_cantidadp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gpb_datosp.SuspendLayout();
            this.Gpb_empresa.SuspendLayout();
            this.Gpb_detallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_detallePedido)).BeginInit();
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
            this.diseño1.Titulo = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(148)))), ((int)(((byte)(72)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pedido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_aFactura);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Gpb_datosp);
            this.panel1.Controls.Add(this.Gpb_empresa);
            this.panel1.Controls.Add(this.Gpb_detallePedido);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 660);
            this.panel1.TabIndex = 25;
            // 
            // Btn_aFactura
            // 
            this.Btn_aFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aFactura.Location = new System.Drawing.Point(775, 606);
            this.Btn_aFactura.Name = "Btn_aFactura";
            this.Btn_aFactura.Size = new System.Drawing.Size(132, 42);
            this.Btn_aFactura.TabIndex = 54;
            this.Btn_aFactura.Text = "Convertir en Factura";
            this.Btn_aFactura.UseVisualStyleBackColor = true;
            this.Btn_aFactura.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JazzminZavala_Administracion.Properties.Resources.WhatsApp_Image_2018_10_15_at_8_14_11_PM;
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(873, 72);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Gpb_datosp
            // 
            this.Gpb_datosp.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datosp.Controls.Add(this.button2);
            this.Gpb_datosp.Controls.Add(this.Lbl_numPedido);
            this.Gpb_datosp.Controls.Add(this.Dtp_fechap);
            this.Gpb_datosp.Controls.Add(this.Lbl_pedido);
            this.Gpb_datosp.Controls.Add(this.Txt_direccionp);
            this.Gpb_datosp.Controls.Add(this.Lbl_fechap);
            this.Gpb_datosp.Controls.Add(this.Txt_nitp);
            this.Gpb_datosp.Controls.Add(this.Lbl_direccionp);
            this.Gpb_datosp.Controls.Add(this.Txt_nombrep);
            this.Gpb_datosp.Controls.Add(this.Lbl_nitp);
            this.Gpb_datosp.Controls.Add(this.Lbl_nombrep);
            this.Gpb_datosp.Controls.Add(this.Cbo_formaenvio);
            this.Gpb_datosp.Controls.Add(this.textBox2);
            this.Gpb_datosp.Controls.Add(this.Lbl_formaenvio);
            this.Gpb_datosp.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gpb_datosp.Location = new System.Drawing.Point(26, 158);
            this.Gpb_datosp.Name = "Gpb_datosp";
            this.Gpb_datosp.Size = new System.Drawing.Size(881, 134);
            this.Gpb_datosp.TabIndex = 46;
            this.Gpb_datosp.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(244, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 38);
            this.button2.TabIndex = 51;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Lbl_numPedido
            // 
            this.Lbl_numPedido.AutoSize = true;
            this.Lbl_numPedido.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_numPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numPedido.ForeColor = System.Drawing.Color.Red;
            this.Lbl_numPedido.Location = new System.Drawing.Point(852, 22);
            this.Lbl_numPedido.Name = "Lbl_numPedido";
            this.Lbl_numPedido.Size = new System.Drawing.Size(19, 19);
            this.Lbl_numPedido.TabIndex = 11;
            this.Lbl_numPedido.Text = "#";
            // 
            // Dtp_fechap
            // 
            this.Dtp_fechap.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dtp_fechap.CustomFormat = "dd-MM-yy";
            this.Dtp_fechap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechap.Location = new System.Drawing.Point(570, 28);
            this.Dtp_fechap.Name = "Dtp_fechap";
            this.Dtp_fechap.Size = new System.Drawing.Size(104, 26);
            this.Dtp_fechap.TabIndex = 22;
            // 
            // Lbl_pedido
            // 
            this.Lbl_pedido.AutoSize = true;
            this.Lbl_pedido.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_pedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pedido.ForeColor = System.Drawing.Color.Red;
            this.Lbl_pedido.Location = new System.Drawing.Point(756, 22);
            this.Lbl_pedido.Name = "Lbl_pedido";
            this.Lbl_pedido.Size = new System.Drawing.Size(94, 19);
            this.Lbl_pedido.TabIndex = 10;
            this.Lbl_pedido.Text = "Pedido No.";
            // 
            // Txt_direccionp
            // 
            this.Txt_direccionp.BackColor = System.Drawing.Color.White;
            this.Txt_direccionp.Enabled = false;
            this.Txt_direccionp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccionp.Location = new System.Drawing.Point(376, 63);
            this.Txt_direccionp.Multiline = true;
            this.Txt_direccionp.Name = "Txt_direccionp";
            this.Txt_direccionp.Size = new System.Drawing.Size(298, 20);
            this.Txt_direccionp.TabIndex = 11;
            // 
            // Lbl_fechap
            // 
            this.Lbl_fechap.AutoSize = true;
            this.Lbl_fechap.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fechap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_fechap.Location = new System.Drawing.Point(514, 32);
            this.Lbl_fechap.Name = "Lbl_fechap";
            this.Lbl_fechap.Size = new System.Drawing.Size(54, 18);
            this.Lbl_fechap.TabIndex = 10;
            this.Lbl_fechap.Text = "Fecha";
            // 
            // Txt_nitp
            // 
            this.Txt_nitp.BackColor = System.Drawing.Color.White;
            this.Txt_nitp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nitp.Location = new System.Drawing.Point(107, 63);
            this.Txt_nitp.Multiline = true;
            this.Txt_nitp.Name = "Txt_nitp";
            this.Txt_nitp.Size = new System.Drawing.Size(135, 20);
            this.Txt_nitp.TabIndex = 9;
            this.Txt_nitp.Text = "C/F";
            // 
            // Lbl_direccionp
            // 
            this.Lbl_direccionp.AutoSize = true;
            this.Lbl_direccionp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_direccionp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccionp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_direccionp.Location = new System.Drawing.Point(292, 64);
            this.Lbl_direccionp.Name = "Lbl_direccionp";
            this.Lbl_direccionp.Size = new System.Drawing.Size(81, 18);
            this.Lbl_direccionp.TabIndex = 7;
            this.Lbl_direccionp.Text = "Dirección";
            // 
            // Txt_nombrep
            // 
            this.Txt_nombrep.BackColor = System.Drawing.Color.White;
            this.Txt_nombrep.Enabled = false;
            this.Txt_nombrep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombrep.Location = new System.Drawing.Point(107, 29);
            this.Txt_nombrep.Multiline = true;
            this.Txt_nombrep.Name = "Txt_nombrep";
            this.Txt_nombrep.Size = new System.Drawing.Size(379, 20);
            this.Txt_nombrep.TabIndex = 4;
            // 
            // Lbl_nitp
            // 
            this.Lbl_nitp.AutoSize = true;
            this.Lbl_nitp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nitp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_nitp.Location = new System.Drawing.Point(69, 64);
            this.Lbl_nitp.Name = "Lbl_nitp";
            this.Lbl_nitp.Size = new System.Drawing.Size(27, 18);
            this.Lbl_nitp.TabIndex = 6;
            this.Lbl_nitp.Text = "Nit";
            // 
            // Lbl_nombrep
            // 
            this.Lbl_nombrep.AutoSize = true;
            this.Lbl_nombrep.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombrep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombrep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_nombrep.Location = new System.Drawing.Point(33, 30);
            this.Lbl_nombrep.Name = "Lbl_nombrep";
            this.Lbl_nombrep.Size = new System.Drawing.Size(68, 18);
            this.Lbl_nombrep.TabIndex = 5;
            this.Lbl_nombrep.Text = "Nombre";
            // 
            // Cbo_formaenvio
            // 
            this.Cbo_formaenvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_formaenvio.FormattingEnabled = true;
            this.Cbo_formaenvio.Location = new System.Drawing.Point(421, 94);
            this.Cbo_formaenvio.Name = "Cbo_formaenvio";
            this.Cbo_formaenvio.Size = new System.Drawing.Size(253, 26);
            this.Cbo_formaenvio.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 0;
            // 
            // Lbl_formaenvio
            // 
            this.Lbl_formaenvio.AutoSize = true;
            this.Lbl_formaenvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_formaenvio.Location = new System.Drawing.Point(292, 99);
            this.Lbl_formaenvio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_formaenvio.Name = "Lbl_formaenvio";
            this.Lbl_formaenvio.Size = new System.Drawing.Size(121, 18);
            this.Lbl_formaenvio.TabIndex = 5;
            this.Lbl_formaenvio.Text = "Forma de Envio";
            // 
            // Gpb_empresa
            // 
            this.Gpb_empresa.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_empresa.Controls.Add(this.label1);
            this.Gpb_empresa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_empresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gpb_empresa.Location = new System.Drawing.Point(26, 124);
            this.Gpb_empresa.Name = "Gpb_empresa";
            this.Gpb_empresa.Size = new System.Drawing.Size(881, 26);
            this.Gpb_empresa.TabIndex = 45;
            this.Gpb_empresa.TabStop = false;
            this.Gpb_empresa.Text = "COLCHONERIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 0;
            // 
            // Gpb_detallePedido
            // 
            this.Gpb_detallePedido.Controls.Add(this.Dgb_detallePedido);
            this.Gpb_detallePedido.Controls.Add(this.Lbl_porcentaje);
            this.Gpb_detallePedido.Controls.Add(this.Lbl_codigop);
            this.Gpb_detallePedido.Controls.Add(this.Txt_codigop);
            this.Gpb_detallePedido.Controls.Add(this.Lbl_descuentoP);
            this.Gpb_detallePedido.Controls.Add(this.Lbl_descripcionDp);
            this.Gpb_detallePedido.Controls.Add(this.Lbl_nombredp);
            this.Gpb_detallePedido.Controls.Add(this.Txt_descuentop);
            this.Gpb_detallePedido.Controls.Add(this.Txt_descripcionp);
            this.Gpb_detallePedido.Controls.Add(this.Txt_cantidadp);
            this.Gpb_detallePedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detallePedido.Location = new System.Drawing.Point(26, 298);
            this.Gpb_detallePedido.Name = "Gpb_detallePedido";
            this.Gpb_detallePedido.Size = new System.Drawing.Size(881, 296);
            this.Gpb_detallePedido.TabIndex = 44;
            this.Gpb_detallePedido.TabStop = false;
            this.Gpb_detallePedido.Text = "Detalle Pedido";
            // 
            // Dgb_detallePedido
            // 
            this.Dgb_detallePedido.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgb_detallePedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgb_detallePedido.BackgroundColor = System.Drawing.Color.White;
            this.Dgb_detallePedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgb_detallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgb_detallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_detallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgb_detallePedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgb_detallePedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Dgb_detallePedido.Location = new System.Drawing.Point(107, 86);
            this.Dgb_detallePedido.Name = "Dgb_detallePedido";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            this.Dgb_detallePedido.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgb_detallePedido.Size = new System.Drawing.Size(682, 130);
            this.Dgb_detallePedido.TabIndex = 65;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.Width = 190;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sub-Total";
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descuento";
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Lbl_porcentaje
            // 
            this.Lbl_porcentaje.AutoSize = true;
            this.Lbl_porcentaje.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_porcentaje.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_porcentaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_porcentaje.Location = new System.Drawing.Point(711, 45);
            this.Lbl_porcentaje.Name = "Lbl_porcentaje";
            this.Lbl_porcentaje.Size = new System.Drawing.Size(25, 22);
            this.Lbl_porcentaje.TabIndex = 64;
            this.Lbl_porcentaje.Text = "%";
            // 
            // Lbl_codigop
            // 
            this.Lbl_codigop.AutoSize = true;
            this.Lbl_codigop.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_codigop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_codigop.Location = new System.Drawing.Point(176, 28);
            this.Lbl_codigop.Name = "Lbl_codigop";
            this.Lbl_codigop.Size = new System.Drawing.Size(64, 18);
            this.Lbl_codigop.TabIndex = 62;
            this.Lbl_codigop.Text = "Codigo";
            // 
            // Txt_codigop
            // 
            this.Txt_codigop.BackColor = System.Drawing.Color.White;
            this.Txt_codigop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigop.Location = new System.Drawing.Point(174, 46);
            this.Txt_codigop.Multiline = true;
            this.Txt_codigop.Name = "Txt_codigop";
            this.Txt_codigop.Size = new System.Drawing.Size(100, 20);
            this.Txt_codigop.TabIndex = 63;
            // 
            // Lbl_descuentoP
            // 
            this.Lbl_descuentoP.AutoSize = true;
            this.Lbl_descuentoP.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_descuentoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descuentoP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_descuentoP.Location = new System.Drawing.Point(568, 28);
            this.Lbl_descuentoP.Name = "Lbl_descuentoP";
            this.Lbl_descuentoP.Size = new System.Drawing.Size(87, 18);
            this.Lbl_descuentoP.TabIndex = 61;
            this.Lbl_descuentoP.Text = "Descuento";
            // 
            // Lbl_descripcionDp
            // 
            this.Lbl_descripcionDp.AutoSize = true;
            this.Lbl_descripcionDp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_descripcionDp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcionDp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_descripcionDp.Location = new System.Drawing.Point(367, 28);
            this.Lbl_descripcionDp.Name = "Lbl_descripcionDp";
            this.Lbl_descripcionDp.Size = new System.Drawing.Size(97, 18);
            this.Lbl_descripcionDp.TabIndex = 59;
            this.Lbl_descripcionDp.Text = "Descripción";
            // 
            // Lbl_nombredp
            // 
            this.Lbl_nombredp.AutoSize = true;
            this.Lbl_nombredp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombredp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombredp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_nombredp.Location = new System.Drawing.Point(285, 28);
            this.Lbl_nombredp.Name = "Lbl_nombredp";
            this.Lbl_nombredp.Size = new System.Drawing.Size(77, 18);
            this.Lbl_nombredp.TabIndex = 54;
            this.Lbl_nombredp.Text = "Cantidad";
            // 
            // Txt_descuentop
            // 
            this.Txt_descuentop.BackColor = System.Drawing.Color.White;
            this.Txt_descuentop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descuentop.Location = new System.Drawing.Point(564, 46);
            this.Txt_descuentop.Multiline = true;
            this.Txt_descuentop.Name = "Txt_descuentop";
            this.Txt_descuentop.Size = new System.Drawing.Size(141, 20);
            this.Txt_descuentop.TabIndex = 58;
            // 
            // Txt_descripcionp
            // 
            this.Txt_descripcionp.BackColor = System.Drawing.Color.White;
            this.Txt_descripcionp.Enabled = false;
            this.Txt_descripcionp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcionp.Location = new System.Drawing.Point(364, 46);
            this.Txt_descripcionp.Multiline = true;
            this.Txt_descripcionp.Name = "Txt_descripcionp";
            this.Txt_descripcionp.Size = new System.Drawing.Size(194, 20);
            this.Txt_descripcionp.TabIndex = 56;
            // 
            // Txt_cantidadp
            // 
            this.Txt_cantidadp.BackColor = System.Drawing.Color.White;
            this.Txt_cantidadp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cantidadp.Location = new System.Drawing.Point(283, 46);
            this.Txt_cantidadp.Multiline = true;
            this.Txt_cantidadp.Name = "Txt_cantidadp";
            this.Txt_cantidadp.Size = new System.Drawing.Size(76, 20);
            this.Txt_cantidadp.TabIndex = 55;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gpb_datosp.ResumeLayout(false);
            this.Gpb_datosp.PerformLayout();
            this.Gpb_empresa.ResumeLayout(false);
            this.Gpb_empresa.PerformLayout();
            this.Gpb_detallePedido.ResumeLayout(false);
            this.Gpb_detallePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_detallePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Gpb_detallePedido;
        private System.Windows.Forms.ComboBox Cbo_formaenvio;
        private System.Windows.Forms.Label Lbl_formaenvio;
        private System.Windows.Forms.GroupBox Gpb_datosp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_numPedido;
        private System.Windows.Forms.DateTimePicker Dtp_fechap;
        private System.Windows.Forms.Label Lbl_pedido;
        private System.Windows.Forms.TextBox Txt_direccionp;
        private System.Windows.Forms.Label Lbl_fechap;
        private System.Windows.Forms.TextBox Txt_nitp;
        private System.Windows.Forms.Label Lbl_direccionp;
        private System.Windows.Forms.TextBox Txt_nombrep;
        private System.Windows.Forms.Label Lbl_nitp;
        private System.Windows.Forms.Label Lbl_nombrep;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox Gpb_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_porcentaje;
        private System.Windows.Forms.Label Lbl_codigop;
        private System.Windows.Forms.TextBox Txt_codigop;
        private System.Windows.Forms.Label Lbl_descuentoP;
        private System.Windows.Forms.Label Lbl_descripcionDp;
        private System.Windows.Forms.Label Lbl_nombredp;
        private System.Windows.Forms.TextBox Txt_descuentop;
        private System.Windows.Forms.TextBox Txt_descripcionp;
        private System.Windows.Forms.TextBox Txt_cantidadp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Dgb_detallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Btn_aFactura;
    }
}