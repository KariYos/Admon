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
    public partial class Cotización : Form
    {
        public Cotización()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Pedidos().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Factura().Show();
        }
    }
}
