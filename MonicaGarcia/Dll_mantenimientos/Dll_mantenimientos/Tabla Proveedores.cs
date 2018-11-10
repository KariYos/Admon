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

    public partial class Tabla_Proveedores : Form
    {
        Navegador nav = new Navegador();
        public Tabla_Proveedores()
        {
            InitializeComponent();
        }

        private void diseño1_DoubleClick(object sender, EventArgs e)
        {
            //Envio a la forma la tabla de Proveedores
            new _4003_Mantenimiento_Proveedor(dgvTablaProveedor).Show();
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            //Se cargan los datos del proveedor
            DataTable table = nav.cargarDatos("TBL_Provedor");
            dgvTablaProveedor.DataSource = table;
        }
    }
}
