using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace DLL_Ventas
{
    public partial class Tabla : Form
    {
        Navegador nv = new Navegador();
        public Tabla(int i)
        {
            InitializeComponent();
            iForma = i;
        }

        static int iForma = 0;
        private void diseño1_Load(object sender, EventArgs e)
        {
            DataTable table;
            switch (iForma)
            {
                case 1:
                    table = nv.cargarDatos("TBL_Cotizacion");
                    Dgv_datos.DataSource = table;
                    break;

                case 2:
                    table = nv.cargarDatos("TBL_Pedido");
                    Dgv_datos.DataSource = table;
                    break;

                case 3:
                    table = nv.cargarDatos("TBL_Factura");
                    Dgv_datos.DataSource = table;
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Dgv_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (iForma)
            {
                case 1:
                    new _4203_Cotización(Dgv_datos).Show();
                    break;

                case 2:
                    new _4204_Pedido(Dgv_datos).Show();
                    break;

                case 3:
                    new _4205_Factura(Dgv_datos).Show();
                    break;
            }
        }
    }
}
