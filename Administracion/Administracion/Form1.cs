using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString();
            label1.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();


        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _303_Proveedor abrir = new _303_Proveedor();
            abrir.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes abrir = new Clientes();
            abrir.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentasPorPagar abrir = new CuentasPorPagar();
            abrir.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devoluciones abrir = new Devoluciones();
            abrir.Show();
        }
    }
}
