namespace DLL_Ventas
{
    partial class Tabla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.diseño1 = new DiseñoVentana.Diseño();
            this.Dgv_datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).BeginInit();
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
            this.diseño1.Titulo = "Tabla";
            this.diseño1.Load += new System.EventHandler(this.diseño1_Load);
            // 
            // Dgv_datos
            // 
            this.Dgv_datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Dgv_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_datos.Location = new System.Drawing.Point(0, 44);
            this.Dgv_datos.Name = "Dgv_datos";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_datos.Size = new System.Drawing.Size(933, 656);
            this.Dgv_datos.TabIndex = 203;
            this.Dgv_datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_datos_CellDoubleClick);
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Dgv_datos);
            this.Controls.Add(this.diseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiseñoVentana.Diseño diseño1;
        private System.Windows.Forms.DataGridView Dgv_datos;
    }
}