using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzminZavala_Administracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Pedidos().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Tabla().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Factura().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Cotización().Show();
        }
    }
}
