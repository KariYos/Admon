using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonicaGarcia_Administracion
{
    public partial class menumantenimientos : Form
    {
        public menumantenimientos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new _4050_Clientes().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new _4051_mantenimientoProveedores().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new _4052_Vendedor().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new _4053_Cobradores().Show();
        }
    }
}
