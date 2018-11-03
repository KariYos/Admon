namespace CapaDisenioM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Pic_minimizar = new System.Windows.Forms.PictureBox();
            this.Pic_cerrar = new System.Windows.Forms.PictureBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Ms_MDI = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeCuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDeCuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoAnticipoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cerrar)).BeginInit();
            this.Ms_MDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.Pic_minimizar);
            this.panel2.Controls.Add(this.Pic_cerrar);
            this.panel2.Controls.Add(this.Lbl_Titulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 42);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaDisenioM.Properties.Resources.calendario;
            this.pictureBox3.Location = new System.Drawing.Point(5, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Pic_minimizar
            // 
            this.Pic_minimizar.Image = global::CapaDisenioM.Properties.Resources.minimize;
            this.Pic_minimizar.Location = new System.Drawing.Point(860, 6);
            this.Pic_minimizar.Name = "Pic_minimizar";
            this.Pic_minimizar.Size = new System.Drawing.Size(32, 33);
            this.Pic_minimizar.TabIndex = 1;
            this.Pic_minimizar.TabStop = false;
            this.Pic_minimizar.Click += new System.EventHandler(this.Pic_minimizar_Click);
            // 
            // Pic_cerrar
            // 
            this.Pic_cerrar.Image = global::CapaDisenioM.Properties.Resources.Cancelar;
            this.Pic_cerrar.Location = new System.Drawing.Point(898, 6);
            this.Pic_cerrar.Name = "Pic_cerrar";
            this.Pic_cerrar.Size = new System.Drawing.Size(32, 33);
            this.Pic_cerrar.TabIndex = 0;
            this.Pic_cerrar.TabStop = false;
            this.Pic_cerrar.Click += new System.EventHandler(this.Pic_cerrar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(68, 6);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(283, 32);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "4000_Administración";
            // 
            // Ms_MDI
            // 
            this.Ms_MDI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ms_MDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Ms_MDI.Location = new System.Drawing.Point(0, 42);
            this.Ms_MDI.Name = "Ms_MDI";
            this.Ms_MDI.Size = new System.Drawing.Size(1028, 26);
            this.Ms_MDI.TabIndex = 4;
            this.Ms_MDI.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoProveedorToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // mantenimientoProveedorToolStripMenuItem
            // 
            this.mantenimientoProveedorToolStripMenuItem.Name = "mantenimientoProveedorToolStripMenuItem";
            this.mantenimientoProveedorToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.mantenimientoProveedorToolStripMenuItem.Text = "Mantenimiento proveedor";
            this.mantenimientoProveedorToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProveedorToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeCuentasPorPagarToolStripMenuItem,
            this.conceptosDeCuentasPorPagarToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.movimientosToolStripMenuItem.Text = "Movimiento de proveedores";
            // 
            // altaDeCuentasPorPagarToolStripMenuItem
            // 
            this.altaDeCuentasPorPagarToolStripMenuItem.Name = "altaDeCuentasPorPagarToolStripMenuItem";
            this.altaDeCuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.altaDeCuentasPorPagarToolStripMenuItem.Text = "Alta de cuentas por pagar";
            this.altaDeCuentasPorPagarToolStripMenuItem.Click += new System.EventHandler(this.altaDeCuentasPorPagarToolStripMenuItem_Click);
            // 
            // conceptosDeCuentasPorPagarToolStripMenuItem
            // 
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Name = "conceptosDeCuentasPorPagarToolStripMenuItem";
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Text = "Alta de Conceptos de cuentas por pagar";
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Click += new System.EventHandler(this.conceptosDeCuentasPorPagarToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeClientesToolStripMenuItem,
            this.mantenimientoClientesToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // mantenimientoDeClientesToolStripMenuItem
            // 
            this.mantenimientoDeClientesToolStripMenuItem.Name = "mantenimientoDeClientesToolStripMenuItem";
            this.mantenimientoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.mantenimientoDeClientesToolStripMenuItem.Text = "Mantenimiento de clientes";
            this.mantenimientoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeClientesToolStripMenuItem_Click);
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            this.mantenimientoClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasDeCuentasPorCobrarToolStripMenuItem,
            this.conceptosDeCuentasPorCobrarToolStripMenuItem});
            this.mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            this.mantenimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.mantenimientoClientesToolStripMenuItem.Text = "Movimiento clientes";
            // 
            // altasDeCuentasPorCobrarToolStripMenuItem
            // 
            this.altasDeCuentasPorCobrarToolStripMenuItem.Name = "altasDeCuentasPorCobrarToolStripMenuItem";
            this.altasDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(389, 22);
            this.altasDeCuentasPorCobrarToolStripMenuItem.Text = "Altas de cuentas por cobrar";
            this.altasDeCuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.altasDeCuentasPorCobrarToolStripMenuItem_Click);
            // 
            // conceptosDeCuentasPorCobrarToolStripMenuItem
            // 
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Name = "conceptosDeCuentasPorCobrarToolStripMenuItem";
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(389, 22);
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Text = "Altas de Conceptos de cuentas por cobrar";
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.conceptosDeCuentasPorCobrarToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.facturaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            this.cotizacionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cotizacionToolStripMenuItem.Text = "Cotizacion";
            this.cotizacionToolStripMenuItem.Click += new System.EventHandler(this.cotizacionToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaClientesToolStripMenuItem,
            this.pagoAnticipoClientesToolStripMenuItem,
            this.cajaProveedoresToolStripMenuItem});
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.devolucionesToolStripMenuItem.Text = "Caja";
            // 
            // cajaClientesToolStripMenuItem
            // 
            this.cajaClientesToolStripMenuItem.Name = "cajaClientesToolStripMenuItem";
            this.cajaClientesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cajaClientesToolStripMenuItem.Text = "Caja clientes";
            // 
            // pagoAnticipoClientesToolStripMenuItem
            // 
            this.pagoAnticipoClientesToolStripMenuItem.Name = "pagoAnticipoClientesToolStripMenuItem";
            this.pagoAnticipoClientesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.pagoAnticipoClientesToolStripMenuItem.Text = "Pago anticipo clientes";
            // 
            // cajaProveedoresToolStripMenuItem
            // 
            this.cajaProveedoresToolStripMenuItem.Name = "cajaProveedoresToolStripMenuItem";
            this.cajaProveedoresToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cajaProveedoresToolStripMenuItem.Text = "Caja proveedores";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiguedadDeSaldosClientesToolStripMenuItem,
            this.listaDePreciosToolStripMenuItem,
            this.comisionesToolStripMenuItem,
            this.polizaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // antiguedadDeSaldosClientesToolStripMenuItem
            // 
            this.antiguedadDeSaldosClientesToolStripMenuItem.Name = "antiguedadDeSaldosClientesToolStripMenuItem";
            this.antiguedadDeSaldosClientesToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.antiguedadDeSaldosClientesToolStripMenuItem.Text = "Antiguedad de saldos clientes";
            this.antiguedadDeSaldosClientesToolStripMenuItem.Click += new System.EventHandler(this.antiguedadDeSaldosClientesToolStripMenuItem_Click);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de precios";
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.polizaToolStripMenuItem.Text = "Poliza";
            this.polizaToolStripMenuItem.Click += new System.EventHandler(this.polizaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.seguridadToolStripMenuItem1,
            this.calendarioToolStripMenuItem1});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.calendarioToolStripMenuItem.Text = "Mantenimiento vendedores";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.seguridadToolStripMenuItem.Text = "Mantenimiento cobradores";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
            this.seguridadToolStripMenuItem1.Text = "Seguridad";
            // 
            // calendarioToolStripMenuItem1
            // 
            this.calendarioToolStripMenuItem1.Name = "calendarioToolStripMenuItem1";
            this.calendarioToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
            this.calendarioToolStripMenuItem1.Text = "Calendario";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Moneda.AutoSize = true;
            this.Lbl_Moneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.Lbl_Moneda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Moneda.Location = new System.Drawing.Point(72, 603);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(71, 18);
            this.Lbl_Moneda.TabIndex = 16;
            this.Lbl_Moneda.Text = "Moneda";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(857, 603);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(83, 18);
            this.Lbl_Usuario.TabIndex = 15;
            this.Lbl_Usuario.Text = "\"USUARIO\"";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(72, 577);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_Fecha.TabIndex = 14;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.Lbl_Hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.Location = new System.Drawing.Point(72, 549);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(43, 18);
            this.Lbl_Hora.TabIndex = 13;
            this.Lbl_Hora.Text = "Hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1028, 664);
            this.Controls.Add(this.Lbl_Moneda);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Hora);
            this.Controls.Add(this.Ms_MDI);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_cerrar)).EndInit();
            this.Ms_MDI.ResumeLayout(false);
            this.Ms_MDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Pic_minimizar;
        private System.Windows.Forms.PictureBox Pic_cerrar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.MenuStrip Ms_MDI;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeCuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDeCuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeCuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDeCuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoAnticipoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Timer timer1;
    }
}

