using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenioM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = panel2.Width;
            Pic_cerrar.Location = new Point(x - 35, 6);
            Pic_minimizar.Location = new Point(x - 75, 6);


            timer1.Start();
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();

            Logo ventana = new Logo();
            ventana.MdiParent = this;
            ventana.Show();

            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    // Poner color al MDI
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    //Ignorar todo lo demas
                }
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new tbl_tabla().Show();
        }

        private void movimientosDeCuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void altaDeCuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new tbl_tabla(1).Show();
        }

        private void conceptosDeCuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new tbl_tabla(2).Show();
        }

        private void mantenimientoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4003_MantenimientoProveedores forma = new _4003_MantenimientoProveedores();
            forma.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4053_MantenimientoClientes forma = new _4053_MantenimientoClientes();
            forma.Show();
        }

        private void altasDeCuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4064_Altas_de_Cuentas_por_Cobrar forma = new _4064_Altas_de_Cuentas_por_Cobrar();
            forma.Show();
        }

        private void conceptosDeCuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4065_Alta_de_Conceptos_de_Cuentas_por_Cobrar forma = new _4065_Alta_de_Conceptos_de_Cuentas_por_Cobrar();
            forma.Show();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4203_Cotización forma = new _4203_Cotización();
            forma.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4204_Pedido forma = new _4204_Pedido();
            forma.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4205_Factura forma = new _4205_Factura();
            forma.Show();
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4405_Poliza forma = new _4405_Poliza();
            forma.Show();
        }

        private void antiguedadDeSaldosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4402_Balance_de_Antiguedad_Saldos_Clientes forma = new _4402_Balance_de_Antiguedad_Saldos_Clientes();
            forma.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4603_MantenimientoVendedores forma = new _4603_MantenimientoVendedores();
            forma.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4612_MantenimientoCobradores forma = new _4612_MantenimientoCobradores();
            forma.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "ayudaGeneral.html");
        }

        private void Pic_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pic_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
