namespace Listado_de_precios
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.LISTADO = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_por_Mayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayoreo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayoreo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LISTADO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LISTADO
            // 
            this.LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LISTADO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Precio_venta,
            this.Precio_por_Mayor,
            this.mayoreo2,
            this.mayoreo3});
            this.LISTADO.Location = new System.Drawing.Point(12, 347);
            this.LISTADO.Name = "LISTADO";
            this.LISTADO.Size = new System.Drawing.Size(745, 159);
            this.LISTADO.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CodigoProducto";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio de Compra";
            this.Precio.Name = "Precio";
            // 
            // Precio_venta
            // 
            this.Precio_venta.HeaderText = "Precio Venta";
            this.Precio_venta.Name = "Precio_venta";
            // 
            // Precio_por_Mayor
            // 
            this.Precio_por_Mayor.HeaderText = "Precio por docena";
            this.Precio_por_Mayor.Name = "Precio_por_Mayor";
            // 
            // mayoreo2
            // 
            this.mayoreo2.HeaderText = "Precio por medio ciento";
            this.mayoreo2.Name = "mayoreo2";
            // 
            // mayoreo3
            // 
            this.mayoreo3.HeaderText = "Precio por Ciento";
            this.mayoreo3.Name = "mayoreo3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 518);
            this.Controls.Add(this.LISTADO);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Lstado de precio por marca";
            ((System.ComponentModel.ISupportInitialize)(this.LISTADO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LISTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_por_Mayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayoreo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayoreo3;
    }
}