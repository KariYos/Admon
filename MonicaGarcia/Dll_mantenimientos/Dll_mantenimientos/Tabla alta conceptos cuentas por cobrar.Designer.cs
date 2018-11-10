namespace Dll_mantenimientos
{
    partial class Tabla_alta_conceptos_cuentas_por_cobrar
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
            this.diseñoTablaAltas = new DiseñoVentana.Diseño();
            this.dgvTablaAltas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAltas)).BeginInit();
            this.SuspendLayout();
            // 
            // diseñoTablaAltas
            // 
            this.diseñoTablaAltas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseñoTablaAltas.Forma = this;
            this.diseñoTablaAltas.Location = new System.Drawing.Point(0, 0);
            this.diseñoTablaAltas.Name = "diseñoTablaAltas";
            this.diseñoTablaAltas.Size = new System.Drawing.Size(933, 700);
            this.diseñoTablaAltas.TabIndex = 0;
            this.diseñoTablaAltas.Titulo = "Tabla alta conceptos cuentas por cobrar";
            this.diseñoTablaAltas.Load += new System.EventHandler(this.diseñoTablaAltas_Load);
            // 
            // dgvTablaAltas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaAltas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaAltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaAltas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaAltas.Location = new System.Drawing.Point(92, 123);
            this.dgvTablaAltas.Name = "dgvTablaAltas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaAltas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaAltas.Size = new System.Drawing.Size(764, 514);
            this.dgvTablaAltas.TabIndex = 5;
            this.dgvTablaAltas.DoubleClick += new System.EventHandler(this.dgvTablaCobrador_DoubleClick);
            // 
            // Tabla_alta_conceptos_cuentas_por_cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.dgvTablaAltas);
            this.Controls.Add(this.diseñoTablaAltas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabla_alta_conceptos_cuentas_por_cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla_alta_conceptos_cuentas_por_cobrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAltas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseñoTablaAltas;
        private System.Windows.Forms.DataGridView dgvTablaAltas;
    }
}