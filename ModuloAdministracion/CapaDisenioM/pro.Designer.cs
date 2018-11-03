namespace CapaDisenioM
{
    partial class pro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.navegador2 = new CapaDiseno.Navegador();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "3";
            // 
            // navegador2
            // 
            this.navegador2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador2.DataGr = null;
            this.navegador2.Forma = this;
            this.navegador2.Location = new System.Drawing.Point(72, 12);
            this.navegador2.Name = "navegador2";
            this.navegador2.Procedimiento = null;
            this.navegador2.pubNombrechm = null;
            this.navegador2.pubNombreHtml = null;
            this.navegador2.Size = new System.Drawing.Size(857, 60);
            this.navegador2.TabIndex = 4;
            // 
            // pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 499);
            this.Controls.Add(this.navegador2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "pro";
            this.Text = "pro";
            this.Load += new System.EventHandler(this.pro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private CapaDiseno.Navegador navegador2;
    }
}