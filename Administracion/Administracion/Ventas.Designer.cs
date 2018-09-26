namespace Administracion
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.Gbp_grupo = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Pnl_Enca = new System.Windows.Forms.Panel();
            this.Label_Enca = new System.Windows.Forms.Label();
            this.Gbp_grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Pnl_Enca.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbp_grupo
            // 
            this.Gbp_grupo.BackColor = System.Drawing.Color.Transparent;
            this.Gbp_grupo.Controls.Add(this.dataGridView1);
            this.Gbp_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gbp_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_grupo.Location = new System.Drawing.Point(26, 104);
            this.Gbp_grupo.Name = "Gbp_grupo";
            this.Gbp_grupo.Size = new System.Drawing.Size(854, 545);
            this.Gbp_grupo.TabIndex = 1;
            this.Gbp_grupo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(26, 38);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 2;
            // 
            // Pnl_Enca
            // 
            this.Pnl_Enca.BackColor = System.Drawing.Color.Gray;
            this.Pnl_Enca.Controls.Add(this.Label_Enca);
            this.Pnl_Enca.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Enca.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Enca.Name = "Pnl_Enca";
            this.Pnl_Enca.Size = new System.Drawing.Size(917, 32);
            this.Pnl_Enca.TabIndex = 3;
            // 
            // Label_Enca
            // 
            this.Label_Enca.AutoSize = true;
            this.Label_Enca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Enca.Location = new System.Drawing.Point(3, 0);
            this.Label_Enca.Name = "Label_Enca";
            this.Label_Enca.Size = new System.Drawing.Size(92, 29);
            this.Label_Enca.TabIndex = 0;
            this.Label_Enca.Text = "Ventas";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Pnl_Enca);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Gbp_grupo);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CuentasPorPagar_Load);
            this.Gbp_grupo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Pnl_Enca.ResumeLayout(false);
            this.Pnl_Enca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbp_grupo;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Panel Pnl_Enca;
        private System.Windows.Forms.Label Label_Enca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}