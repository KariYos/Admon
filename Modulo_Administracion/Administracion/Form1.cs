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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            Tmr_tiempo.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tmr_tiempo.Start();
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor abrir = new Proveedor();
            abrir.ShowDialog();
            this.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendario abrir = new Calendario();
            abrir.ShowDialog();
            this.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido abrir = new Pedido();
            abrir.ShowDialog();
            this.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devoluciones abrir = new Devoluciones();
            abrir.ShowDialog();
            this.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente abrir = new Cliente();
            abrir.ShowDialog();
            this.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentasPorPagar abrir = new CuentasPorPagar();
            abrir.ShowDialog();
            this.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentasPorCobrar abrir = new CuentasPorCobrar();
            abrir.ShowDialog();
            this.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas abrir = new Ventas();
            abrir.ShowDialog();
            this.Show();
        }
    }
}
