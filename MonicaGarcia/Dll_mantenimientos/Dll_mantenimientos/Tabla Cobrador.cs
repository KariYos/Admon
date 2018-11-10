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
    public partial class Tabla_Cobrador : Form
    {
        Navegador navct = new Navegador();
        public Tabla_Cobrador()
        {
            InitializeComponent();
        }

        private void dgvTablaProveedor_DoubleClick(object sender, EventArgs e)
        {
            //Envio a la forma la tabla de Cobradores
            new _4612_Mantenimiento_Cobradores(dgvTablaCobrador).Show();
        }

        private void diseñoCobrador_Load(object sender, EventArgs e)
        {
            //Se cargan los datos del cobrador
            DataTable table = navct.cargarDatos("TBL_Cobrador");
            dgvTablaCobrador.DataSource = table;
        }
    }
}
