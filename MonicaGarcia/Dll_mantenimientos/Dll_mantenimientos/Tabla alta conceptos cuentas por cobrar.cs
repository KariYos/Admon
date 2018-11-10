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
    public partial class Tabla_alta_conceptos_cuentas_por_cobrar : Form
    {
        Navegador nava = new Navegador();
        public Tabla_alta_conceptos_cuentas_por_cobrar()
        {
            InitializeComponent();
        }

        private void diseñoTablaAltas_Load(object sender, EventArgs e)
        {
            //Se cargan los datos de las altas de conceptos de las cuentas por cobrar.
            DataTable table = nava.cargarDatos("TBL_ConceptoCliente");
            dgvTablaAltas.DataSource = table;
        }

        private void dgvTablaCobrador_DoubleClick(object sender, EventArgs e)
        {
            //Envio a la forma la tabla de las altas de conceptos de cuentas por cobrar.
            new _4065_Alta_conceptos_cuentas_por_cobrar(dgvTablaAltas).Show();
        }
    }
}
