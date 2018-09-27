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
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Tmr_tiempo = new System.Windows.Forms.Timer(this.components);
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
            this.clienteToolStripMenuItem,
            this.cuentasPorPagarToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cuentasPorPagarToolStripMenuItem
            // 
            this.cuentasPorPagarToolStripMenuItem.Name = "cuentasPorPagarToolStripMenuItem";
            this.cuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cuentasPorPagarToolStripMenuItem.Text = "Cuentas por Pagar";
            this.cuentasPorPagarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorPagarToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorCobrarToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pedidoToolStripMenuItem.Text = "Pedidos";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContraseñaToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.Location = new System.Drawing.Point(32, 583);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(54, 18);
            this.Lbl_Hora.TabIndex = 3;
            this.Lbl_Hora.Text = "label1";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(32, 612);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "label2";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(826, 612);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(83, 18);
            this.Lbl_Usuario.TabIndex = 5;
            this.Lbl_Usuario.Text = "\"USUARIO\"";
            // 
            // Tmr_tiempo
            // 
            this.Tmr_tiempo.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
    }
}

