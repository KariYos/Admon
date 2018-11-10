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
namespace Dll_mantenimientos
{
    public partial class Tabla_Vendedores : Form
    {
        Navegador navv = new Navegador();
        public Tabla_Vendedores()
        {
            InitializeComponent();

        }

        private void dgvTablaVendedor_DoubleClick(object sender, EventArgs e)
        {
            //Envio a la forma la tabla de Vendedores
            new _4603_Mantenimiento_Vendedores(dgvTablaVendedor).Show();
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            //Se cargan los datos del vendedor
            DataTable table = navv.cargarDatos("TBL_Vendedor");
            dgvTablaVendedor.DataSource = table;
        }
    }
}
