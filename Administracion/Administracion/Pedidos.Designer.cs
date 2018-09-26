namespace Administracion
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Gpb_datosdepedido = new System.Windows.Forms.GroupBox();
            this.Dtp_fechaemision = new System.Windows.Forms.DateTimePicker();
            this.Cbo_formaenvio = new System.Windows.Forms.ComboBox();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.Txt_codproducto = new System.Windows.Forms.TextBox();
            this.Lbl_codproducto = new System.Windows.Forms.Label();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.Lbl_fechadeemision = new System.Windows.Forms.Label();
            this.Lbl_formaenvio = new System.Windows.Forms.Label();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Cbo_almacen = new System.Windows.Forms.ComboBox();
            this.Txt_codvendedor = new System.Windows.Forms.TextBox();
            this.Txt_codalmacen = new System.Windows.Forms.TextBox();
            this.Lbl_codalmacen = new System.Windows.Forms.Label();
            this.Lbl_almacen = new System.Windows.Forms.Label();
            this.Lbl_codvendedor = new System.Windows.Forms.Label();
            this.Lbl_vendedor = new System.Windows.Forms.Label();
            this.Gpb_datosCliente = new System.Windows.Forms.GroupBox();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Telefono = new System.Windows.Forms.Label();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Txt_codcliente = new System.Windows.Forms.TextBox();
            this.Lbl_codigocliente = new System.Windows.Forms.Label();
            this.Tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            this.Gpb_datosdepedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gpb_datosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(794, 632);
            this.Lbl_Usuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(62, 18);
            this.Lbl_Usuario.TabIndex = 38;
            this.Lbl_Usuario.Text = "Usuario";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(29, 632);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_fecha.TabIndex = 37;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(29, 611);
            this.Lbl_hora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(43, 18);
            this.Lbl_hora.TabIndex = 36;
            this.Lbl_hora.Text = "Hora";
            // 
            // Gpb_datosdepedido
            // 
            this.Gpb_datosdepedido.Controls.Add(this.Dtp_fechaemision);
            this.Gpb_datosdepedido.Controls.Add(this.Cbo_formaenvio);
            this.Gpb_datosdepedido.Controls.Add(this.Txt_cantidad);
            this.Gpb_datosdepedido.Controls.Add(this.Cbo_producto);
            this.Gpb_datosdepedido.Controls.Add(this.Txt_codproducto);
            this.Gpb_datosdepedido.Controls.Add(this.Lbl_codproducto);
            this.Gpb_datosdepedido.Controls.Add(this.Lbl_producto);
            this.Gpb_datosdepedido.Controls.Add(this.Lbl_fechadeemision);
            this.Gpb_datosdepedido.Controls.Add(this.Lbl_formaenvio);
            this.Gpb_datosdepedido.Controls.Add(this.Lbl_cantidad);
            this.Gpb_datosdepedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosdepedido.Location = new System.Drawing.Point(455, 110);
            this.Gpb_datosdepedido.Name = "Gpb_datosdepedido";
            this.Gpb_datosdepedido.Size = new System.Drawing.Size(433, 238);
            this.Gpb_datosdepedido.TabIndex = 35;
            this.Gpb_datosdepedido.TabStop = false;
            this.Gpb_datosdepedido.Text = "Datos de Pedido";
            // 
            // Dtp_fechaemision
            // 
            this.Dtp_fechaemision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaemision.Location = new System.Drawing.Point(189, 185);
            this.Dtp_fechaemision.Name = "Dtp_fechaemision";
            this.Dtp_fechaemision.Size = new System.Drawing.Size(226, 27);
            this.Dtp_fechaemision.TabIndex = 19;
            // 
            // Cbo_formaenvio
            // 
            this.Cbo_formaenvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_formaenvio.FormattingEnabled = true;
            this.Cbo_formaenvio.Location = new System.Drawing.Point(179, 147);
            this.Cbo_formaenvio.Name = "Cbo_formaenvio";
            this.Cbo_formaenvio.Size = new System.Drawing.Size(236, 29);
            this.Cbo_formaenvio.TabIndex = 18;
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cantidad.Location = new System.Drawing.Point(258, 111);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(157, 27);
            this.Txt_cantidad.TabIndex = 17;
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Location = new System.Drawing.Point(179, 73);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(236, 29);
            this.Cbo_producto.TabIndex = 16;
            // 
            // Txt_codproducto
            // 
            this.Txt_codproducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codproducto.Location = new System.Drawing.Point(258, 37);
            this.Txt_codproducto.Name = "Txt_codproducto";
            this.Txt_codproducto.Size = new System.Drawing.Size(157, 27);
            this.Txt_codproducto.TabIndex = 13;
            // 
            // Lbl_codproducto
            // 
            this.Lbl_codproducto.AutoSize = true;
            this.Lbl_codproducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codproducto.Location = new System.Drawing.Point(28, 43);
            this.Lbl_codproducto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_codproducto.Name = "Lbl_codproducto";
            this.Lbl_codproducto.Size = new System.Drawing.Size(124, 21);
            this.Lbl_codproducto.TabIndex = 11;
            this.Lbl_codproducto.Text = "Cod. Producto";
            // 
            // Lbl_producto
            // 
            this.Lbl_producto.AutoSize = true;
            this.Lbl_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_producto.Location = new System.Drawing.Point(28, 79);
            this.Lbl_producto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_producto.Name = "Lbl_producto";
            this.Lbl_producto.Size = new System.Drawing.Size(82, 21);
            this.Lbl_producto.TabIndex = 9;
            this.Lbl_producto.Text = "Producto";
            // 
            // Lbl_fechadeemision
            // 
            this.Lbl_fechadeemision.AutoSize = true;
            this.Lbl_fechadeemision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechadeemision.Location = new System.Drawing.Point(28, 187);
            this.Lbl_fechadeemision.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_fechadeemision.Name = "Lbl_fechadeemision";
            this.Lbl_fechadeemision.Size = new System.Drawing.Size(144, 21);
            this.Lbl_fechadeemision.TabIndex = 4;
            this.Lbl_fechadeemision.Text = "Fecha de Emisión";
            // 
            // Lbl_formaenvio
            // 
            this.Lbl_formaenvio.AutoSize = true;
            this.Lbl_formaenvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_formaenvio.Location = new System.Drawing.Point(28, 151);
            this.Lbl_formaenvio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_formaenvio.Name = "Lbl_formaenvio";
            this.Lbl_formaenvio.Size = new System.Drawing.Size(130, 21);
            this.Lbl_formaenvio.TabIndex = 5;
            this.Lbl_formaenvio.Text = "Forma de Envio";
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad.Location = new System.Drawing.Point(28, 115);
            this.Lbl_cantidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(87, 21);
            this.Lbl_cantidad.TabIndex = 10;
            this.Lbl_cantidad.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_vendedor);
            this.groupBox1.Controls.Add(this.Cbo_almacen);
            this.groupBox1.Controls.Add(this.Txt_codvendedor);
            this.groupBox1.Controls.Add(this.Txt_codalmacen);
            this.groupBox1.Controls.Add(this.Lbl_codalmacen);
            this.groupBox1.Controls.Add(this.Lbl_almacen);
            this.groupBox1.Controls.Add(this.Lbl_codvendedor);
            this.groupBox1.Controls.Add(this.Lbl_vendedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 231);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Almacén";
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(121, 177);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(236, 29);
            this.Cbo_vendedor.TabIndex = 20;
            // 
            // Cbo_almacen
            // 
            this.Cbo_almacen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_almacen.FormattingEnabled = true;
            this.Cbo_almacen.Location = new System.Drawing.Point(121, 93);
            this.Cbo_almacen.Name = "Cbo_almacen";
            this.Cbo_almacen.Size = new System.Drawing.Size(236, 29);
            this.Cbo_almacen.TabIndex = 19;
            // 
            // Txt_codvendedor
            // 
            this.Txt_codvendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codvendedor.Location = new System.Drawing.Point(200, 136);
            this.Txt_codvendedor.Name = "Txt_codvendedor";
            this.Txt_codvendedor.Size = new System.Drawing.Size(157, 27);
            this.Txt_codvendedor.TabIndex = 18;
            // 
            // Txt_codalmacen
            // 
            this.Txt_codalmacen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codalmacen.Location = new System.Drawing.Point(200, 52);
            this.Txt_codalmacen.Name = "Txt_codalmacen";
            this.Txt_codalmacen.Size = new System.Drawing.Size(157, 27);
            this.Txt_codalmacen.TabIndex = 16;
            // 
            // Lbl_codalmacen
            // 
            this.Lbl_codalmacen.AutoSize = true;
            this.Lbl_codalmacen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codalmacen.Location = new System.Drawing.Point(25, 55);
            this.Lbl_codalmacen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_codalmacen.Name = "Lbl_codalmacen";
            this.Lbl_codalmacen.Size = new System.Drawing.Size(124, 21);
            this.Lbl_codalmacen.TabIndex = 17;
            this.Lbl_codalmacen.Text = "Cod. Almacén";
            // 
            // Lbl_almacen
            // 
            this.Lbl_almacen.AutoSize = true;
            this.Lbl_almacen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_almacen.Location = new System.Drawing.Point(25, 96);
            this.Lbl_almacen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_almacen.Name = "Lbl_almacen";
            this.Lbl_almacen.Size = new System.Drawing.Size(82, 21);
            this.Lbl_almacen.TabIndex = 6;
            this.Lbl_almacen.Text = "Almacén";
            // 
            // Lbl_codvendedor
            // 
            this.Lbl_codvendedor.AutoSize = true;
            this.Lbl_codvendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codvendedor.Location = new System.Drawing.Point(25, 137);
            this.Lbl_codvendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_codvendedor.Name = "Lbl_codvendedor";
            this.Lbl_codvendedor.Size = new System.Drawing.Size(130, 21);
            this.Lbl_codvendedor.TabIndex = 8;
            this.Lbl_codvendedor.Text = "Cod. Vendedor";
            // 
            // Lbl_vendedor
            // 
            this.Lbl_vendedor.AutoSize = true;
            this.Lbl_vendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vendedor.Location = new System.Drawing.Point(25, 178);
            this.Lbl_vendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_vendedor.Name = "Lbl_vendedor";
            this.Lbl_vendedor.Size = new System.Drawing.Size(88, 21);
            this.Lbl_vendedor.TabIndex = 7;
            this.Lbl_vendedor.Text = "Vendedor";
            // 
            // Gpb_datosCliente
            // 
            this.Gpb_datosCliente.Controls.Add(this.Cbo_cliente);
            this.Gpb_datosCliente.Controls.Add(this.Lbl_Telefono);
            this.Gpb_datosCliente.Controls.Add(this.Txt_telefono);
            this.Gpb_datosCliente.Controls.Add(this.Lbl_direccion);
            this.Gpb_datosCliente.Controls.Add(this.Txt_direccion);
            this.Gpb_datosCliente.Controls.Add(this.Lbl_cliente);
            this.Gpb_datosCliente.Controls.Add(this.Txt_codcliente);
            this.Gpb_datosCliente.Controls.Add(this.Lbl_codigocliente);
            this.Gpb_datosCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosCliente.Location = new System.Drawing.Point(32, 110);
            this.Gpb_datosCliente.Name = "Gpb_datosCliente";
            this.Gpb_datosCliente.Size = new System.Drawing.Size(393, 238);
            this.Gpb_datosCliente.TabIndex = 33;
            this.Gpb_datosCliente.TabStop = false;
            this.Gpb_datosCliente.Text = "Datos Cliente";
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(121, 89);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(236, 29);
            this.Cbo_cliente.TabIndex = 15;
            // 
            // Lbl_Telefono
            // 
            this.Lbl_Telefono.AutoSize = true;
            this.Lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefono.Location = new System.Drawing.Point(25, 185);
            this.Lbl_Telefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Telefono.Name = "Lbl_Telefono";
            this.Lbl_Telefono.Size = new System.Drawing.Size(76, 21);
            this.Lbl_Telefono.TabIndex = 3;
            this.Lbl_Telefono.Text = "Teléfono";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(121, 178);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(236, 27);
            this.Txt_telefono.TabIndex = 14;
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccion.Location = new System.Drawing.Point(25, 141);
            this.Lbl_direccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(83, 21);
            this.Lbl_direccion.TabIndex = 2;
            this.Lbl_direccion.Text = "Dirección";
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(121, 136);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(236, 27);
            this.Txt_direccion.TabIndex = 13;
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cliente.Location = new System.Drawing.Point(25, 97);
            this.Lbl_cliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(66, 21);
            this.Lbl_cliente.TabIndex = 0;
            this.Lbl_cliente.Text = "Cliente";
            // 
            // Txt_codcliente
            // 
            this.Txt_codcliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codcliente.Location = new System.Drawing.Point(200, 50);
            this.Txt_codcliente.Name = "Txt_codcliente";
            this.Txt_codcliente.Size = new System.Drawing.Size(157, 27);
            this.Txt_codcliente.TabIndex = 12;
            // 
            // Lbl_codigocliente
            // 
            this.Lbl_codigocliente.AutoSize = true;
            this.Lbl_codigocliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigocliente.Location = new System.Drawing.Point(25, 53);
            this.Lbl_codigocliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_codigocliente.Name = "Lbl_codigocliente";
            this.Lbl_codigocliente.Size = new System.Drawing.Size(108, 21);
            this.Lbl_codigocliente.TabIndex = 1;
            this.Lbl_codigocliente.Text = "Cod. Cliente";
            // 
            // Tmr_tiempo
            // 
            this.Tmr_tiempo.Enabled = true;
            this.Tmr_tiempo.Tick += new System.EventHandler(this.Tmr_tiempo_Tick);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_hora);
            this.Controls.Add(this.Gpb_datosdepedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gpb_datosCliente);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.Gpb_datosdepedido.ResumeLayout(false);
            this.Gpb_datosdepedido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gpb_datosCliente.ResumeLayout(false);
            this.Gpb_datosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.GroupBox Gpb_datosdepedido;
        private System.Windows.Forms.DateTimePicker Dtp_fechaemision;
        private System.Windows.Forms.ComboBox Cbo_formaenvio;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.TextBox Txt_codproducto;
        private System.Windows.Forms.Label Lbl_codproducto;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.Label Lbl_fechadeemision;
        private System.Windows.Forms.Label Lbl_formaenvio;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.ComboBox Cbo_almacen;
        private System.Windows.Forms.TextBox Txt_codvendedor;
        private System.Windows.Forms.TextBox Txt_codalmacen;
        private System.Windows.Forms.Label Lbl_codalmacen;
        private System.Windows.Forms.Label Lbl_almacen;
        private System.Windows.Forms.Label Lbl_codvendedor;
        private System.Windows.Forms.Label Lbl_vendedor;
        private System.Windows.Forms.GroupBox Gpb_datosCliente;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.Label Lbl_Telefono;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.TextBox Txt_codcliente;
        private System.Windows.Forms.Label Lbl_codigocliente;
        private System.Windows.Forms.Timer Tmr_tiempo;
    }
}