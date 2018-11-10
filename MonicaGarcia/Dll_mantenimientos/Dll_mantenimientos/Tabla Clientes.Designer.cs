namespace Dll_mantenimientos
{
    partial class Tabla_Clientes
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
            this.diseño1 = new DiseñoVentana.Diseño();
            this.dgvTablaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaClientes)).BeginInit();
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
            this.diseño1.Tag = "Tabla Clientes";
            this.diseño1.Titulo = null;
            this.diseño1.Load += new System.EventHandler(this.diseño1_Load);
            // 
            // dgvTablaClientes
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTablaClientes.Location = new System.Drawing.Point(86, 135);
            this.dgvTablaClientes.Name = "dgvTablaClientes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTablaClientes.Size = new System.Drawing.Size(764, 514);
            this.dgvTablaClientes.TabIndex = 2;
            this.dgvTablaClientes.DoubleClick += new System.EventHandler(this.dgvTablaClientes_DoubleClick);
            // 
            // Tabla_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.dgvTablaClientes);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabla_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.DataGridView dgvTablaClientes;
    }
}