namespace Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ms_MDI = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeCuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDeCuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionDeCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            this.mantenimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionDeCargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoAnticipoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_MDI.SuspendLayout();
            this.SuspendLayout();
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
            this.Ms_MDI.Location = new System.Drawing.Point(0, 0);
            this.Ms_MDI.Name = "Ms_MDI";
            this.Ms_MDI.Size = new System.Drawing.Size(917, 26);
            this.Ms_MDI.TabIndex = 1;
            this.Ms_MDI.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
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
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosDeCuentasPorCobrarToolStripMenuItem,
            this.altaDeCuentasPorPagarToolStripMenuItem,
            this.conceptosDeCuentasPorPagarToolStripMenuItem,
            this.divisionDeCargosToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.movimientosToolStripMenuItem.Text = "Movimiento de proveedores";
            // 
            // movimientosDeCuentasPorCobrarToolStripMenuItem
            // 
            this.movimientosDeCuentasPorCobrarToolStripMenuItem.Name = "movimientosDeCuentasPorCobrarToolStripMenuItem";
            this.movimientosDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.movimientosDeCuentasPorCobrarToolStripMenuItem.Text = "Movimientos de cuentas por pagar";
            // 
            // altaDeCuentasPorPagarToolStripMenuItem
            // 
            this.altaDeCuentasPorPagarToolStripMenuItem.Name = "altaDeCuentasPorPagarToolStripMenuItem";
            this.altaDeCuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.altaDeCuentasPorPagarToolStripMenuItem.Text = "Alta de cuentas por pagar";
            // 
            // conceptosDeCuentasPorPagarToolStripMenuItem
            // 
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Name = "conceptosDeCuentasPorPagarToolStripMenuItem";
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.conceptosDeCuentasPorPagarToolStripMenuItem.Text = "Conceptos de cuentas por pagar";
            // 
            // divisionDeCargosToolStripMenuItem
            // 
            this.divisionDeCargosToolStripMenuItem.Name = "divisionDeCargosToolStripMenuItem";
            this.divisionDeCargosToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.divisionDeCargosToolStripMenuItem.Text = "Division de Cargos";
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
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaClientesToolStripMenuItem,
            this.pagoAnticipoClientesToolStripMenuItem,
            this.cajaProveedoresToolStripMenuItem});
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.devolucionesToolStripMenuItem.Text = "Caja";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
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
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.Location = new System.Drawing.Point(21, 589);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(43, 18);
            this.Lbl_Hora.TabIndex = 3;
            this.Lbl_Hora.Text = "Hora";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(21, 623);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(806, 623);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(83, 18);
            this.Lbl_Usuario.TabIndex = 5;
            this.Lbl_Usuario.Text = "\"USUARIO\"";
            // 
            // Tmr_tiempo
            // 
            this.Tmr_tiempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            this.mantenimientoClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientoProveedoresToolStripMenuItem,
            this.altasDeCuentasPorCobrarToolStripMenuItem,
            this.conceptosDeCuentasPorCobrarToolStripMenuItem,
            this.divisionDeCargosToolStripMenuItem1});
            this.mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            this.mantenimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.mantenimientoClientesToolStripMenuItem.Text = "Movimiento clientes";
            this.mantenimientoClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClientesToolStripMenuItem_Click);
            // 
            // movimientoProveedoresToolStripMenuItem
            // 
            this.movimientoProveedoresToolStripMenuItem.Name = "movimientoProveedoresToolStripMenuItem";
            this.movimientoProveedoresToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.movimientoProveedoresToolStripMenuItem.Text = "Movimiento de cuentas por cobrar";
            // 
            // altasDeCuentasPorCobrarToolStripMenuItem
            // 
            this.altasDeCuentasPorCobrarToolStripMenuItem.Name = "altasDeCuentasPorCobrarToolStripMenuItem";
            this.altasDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.altasDeCuentasPorCobrarToolStripMenuItem.Text = "Altas de cuentas por cobrar";
            // 
            // conceptosDeCuentasPorCobrarToolStripMenuItem
            // 
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Name = "conceptosDeCuentasPorCobrarToolStripMenuItem";
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Text = "Conceptos de cuentas por cobrar";
            // 
            // divisionDeCargosToolStripMenuItem1
            // 
            this.divisionDeCargosToolStripMenuItem1.Name = "divisionDeCargosToolStripMenuItem1";
            this.divisionDeCargosToolStripMenuItem1.Size = new System.Drawing.Size(332, 22);
            this.divisionDeCargosToolStripMenuItem1.Text = "Division de cargos";
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            this.cotizacionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cotizacionToolStripMenuItem.Text = "Cotizacion";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
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
            // antiguedadDeSaldosClientesToolStripMenuItem
            // 
            this.antiguedadDeSaldosClientesToolStripMenuItem.Name = "antiguedadDeSaldosClientesToolStripMenuItem";
            this.antiguedadDeSaldosClientesToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.antiguedadDeSaldosClientesToolStripMenuItem.Text = "Antiguedad de saldos clientes";
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
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
            this.seguridadToolStripMenuItem1.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // mantenimientoProveedorToolStripMenuItem
            // 
            this.mantenimientoProveedorToolStripMenuItem.Name = "mantenimientoProveedorToolStripMenuItem";
            this.mantenimientoProveedorToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.mantenimientoProveedorToolStripMenuItem.Text = "Mantenimiento proveedor";
            // 
            // mantenimientoDeClientesToolStripMenuItem
            // 
            this.mantenimientoDeClientesToolStripMenuItem.Name = "mantenimientoDeClientesToolStripMenuItem";
            this.mantenimientoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.mantenimientoDeClientesToolStripMenuItem.Text = "Mantenimiento de clientes";
            // 
            // calendarioToolStripMenuItem1
            // 
            this.calendarioToolStripMenuItem1.Name = "calendarioToolStripMenuItem1";
            this.calendarioToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
            this.calendarioToolStripMenuItem1.Text = "Calendario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Hora);
            this.Controls.Add(this.Ms_MDI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "301_MenuAdministración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Ms_MDI.ResumeLayout(false);
            this.Ms_MDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Ms_MDI;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Timer Tmr_tiempo;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeCuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeCuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDeCuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionDeCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeCuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDeCuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionDeCargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoAnticipoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem1;
    }
}

