namespace Dll_mantenimientos
{
    partial class Tabla_Cobrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.diseñoCobrador = new DiseñoVentana.Diseño();
            this.dgvTablaCobrador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCobrador)).BeginInit();
            this.SuspendLayout();
            // 
            // diseñoCobrador
            // 
            this.diseñoCobrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseñoCobrador.Forma = this;
            this.diseñoCobrador.Location = new System.Drawing.Point(0, 0);
            this.diseñoCobrador.Name = "diseñoCobrador";
            this.diseñoCobrador.Size = new System.Drawing.Size(933, 700);
            this.diseñoCobrador.TabIndex = 0;
            this.diseñoCobrador.Titulo = "Tabla Cobrador";
            this.diseñoCobrador.Load += new System.EventHandler(this.diseñoCobrador_Load);
            // 
            // dgvTablaCobrador
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaCobrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaCobrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaCobrador.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTablaCobrador.Location = new System.Drawing.Point(84, 113);
            this.dgvTablaCobrador.Name = "dgvTablaCobrador";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaCobrador.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTablaCobrador.Size = new System.Drawing.Size(764, 514);
            this.dgvTablaCobrador.TabIndex = 4;
            this.dgvTablaCobrador.DoubleClick += new System.EventHandler(this.dgvTablaProveedor_DoubleClick);
            // 
            // Tabla_Cobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.dgvTablaCobrador);
            this.Controls.Add(this.diseñoCobrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabla_Cobrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla_Cobrador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCobrador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseñoCobrador;
        private System.Windows.Forms.DataGridView dgvTablaCobrador;
    }
}