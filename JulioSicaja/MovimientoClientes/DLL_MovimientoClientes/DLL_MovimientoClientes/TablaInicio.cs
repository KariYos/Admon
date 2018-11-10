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

namespace DLL_MovimientoClientes
{
    public partial class TablaInicio : Form
    {
        static int num;
        Navegador nv = new Navegador();
        public TablaInicio(int aux)
        {
            InitializeComponent();
            num = aux;
        }

        private void TablaInicio_Load(object sender, EventArgs e)
        {
            DataTable table;
            switch (num)
            {   //Cargar los datos de Altas cuentas por cobrar
                case 1:
                    table = nv.cargarDatos("TBL_CxC");
                    Dgv_tabla.DataSource = table;
                    break;

                case 2:
                    break;

            }
        }

        private void Dgv_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (num)
            {
                case 1:
                    new _4064_Altas_de_Cuentas_por_Cobrar(Dgv_tabla).Show();
                    break;

                case 2:
                    new _4402_Balance_de_Antiguedad_Saldos_Clientes().Show();
                    break;
            }
        }
    }
}
