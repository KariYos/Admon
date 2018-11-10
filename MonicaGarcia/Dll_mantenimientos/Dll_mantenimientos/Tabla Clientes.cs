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
    public partial class Tabla_Clientes : Form
    {
        Navegador nv = new Navegador();
        public Tabla_Clientes()
        {
            InitializeComponent();
        }

        private void dgvTablaClientes_DoubleClick(object sender, EventArgs e)
        {
            //Envio a la forma la tabla de Clientes
            new _4053_Mantenimiento_Clientes(dgvTablaClientes).Show();
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            //Se cargan los datos del cliente
            DataTable table = nv.cargarDatos("TBL_Cliente");
            dgvTablaClientes.DataSource = table;
        }
    }
}
