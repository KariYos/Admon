namespace Admon_Julio
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
            this.diseño1 = new DiseñoVentana.Diseño();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.balanceDeAntiguedadDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.altasDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDeCuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.diseño1.Titulo = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceDeAntiguedadDeSaldosToolStripMenuItem,
            this.movimientosClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 74);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // balanceDeAntiguedadDeSaldosToolStripMenuItem
            // 
            this.balanceDeAntiguedadDeSaldosToolStripMenuItem.Name = "balanceDeAntiguedadDeSaldosToolStripMenuItem";
            this.balanceDeAntiguedadDeSaldosToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.balanceDeAntiguedadDeSaldosToolStripMenuItem.Text = "Balance de antiguedad de saldos";
            this.balanceDeAntiguedadDeSaldosToolStripMenuItem.Click += new System.EventHandler(this.balanceDeAntiguedadDeSaldosToolStripMenuItem_Click);
            // 
            // movimientosClientesToolStripMenuItem
            // 
            this.movimientosClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasPorCobrarToolStripMenuItem,
            this.altasDeCuentasPorCobrarToolStripMenuItem,
            this.conceptosDeCuentasPorCobrarToolStripMenuItem});
            this.movimientosClientesToolStripMenuItem.Name = "movimientosClientesToolStripMenuItem";
            this.movimientosClientesToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.movimientosClientesToolStripMenuItem.Text = "Movimientos Clientes";
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorCobrarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(285, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 74);
            this.panel1.TabIndex = 2;
            // 
            // altasDeCuentasPorCobrarToolStripMenuItem
            // 
            this.altasDeCuentasPorCobrarToolStripMenuItem.Name = "altasDeCuentasPorCobrarToolStripMenuItem";
            this.altasDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.altasDeCuentasPorCobrarToolStripMenuItem.Text = "Altas de Cuentas por Cobrar";
            // 
            // conceptosDeCuentasPorCobrarToolStripMenuItem
            // 
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Name = "conceptosDeCuentasPorCobrarToolStripMenuItem";
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.conceptosDeCuentasPorCobrarToolStripMenuItem.Text = "Conceptos de cuentas por cobrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem balanceDeAntiguedadDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeCuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDeCuentasPorCobrarToolStripMenuItem;
    }
}

