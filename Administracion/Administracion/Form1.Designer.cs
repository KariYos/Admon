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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pedidoToolStripMenuItem.Text = "Pedidos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
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
            // Lbl_hora
            // 
            this.Lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(40, 422);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(54, 18);
            this.Lbl_hora.TabIndex = 2;
            this.Lbl_hora.Text = "label1";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(40, 449);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_fecha.TabIndex = 3;
            this.Lbl_fecha.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(805, 449);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(83, 18);
            this.Lbl_Usuario.TabIndex = 4;
            this.Lbl_Usuario.Text = "\"USUARIO\"";
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.Image")));
            this.Pic_Logo.Location = new System.Drawing.Point(497, 165);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(275, 275);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Logo.TabIndex = 1;
            this.Pic_Logo.TabStop = false;
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(909, 487);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_hora);
            this.Controls.Add(this.Pic_Logo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "301_MenuAdministración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
    }
}

