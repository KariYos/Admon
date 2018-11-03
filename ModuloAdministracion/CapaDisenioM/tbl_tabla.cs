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
namespace CapaDisenioM
{
    public partial class tbl_tabla : Form
    {
        Navegador nv = new Navegador();
        //Su funcion es para dar valor e ir al datagrid
        static int inValor;
        public tbl_tabla(int valor)
        {
            InitializeComponent();
            inValor = valor;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*switch(inValor)
            {
                case 1:
                    new _4014_Alta_de_Cuentas_por_Pagar(dgr).Show();
                    break;

                case 2:
                    new _4015_Alta_de_Conceptos_de_Cuentas_por_Pagar(dgr).Show();
                    break;
         
            
            }*/

            
        }

        private void tbl_tabla_Load(object sender, EventArgs e)
        {
           /* DataTable tbl_t;
            switch (inValor)
            {
                case 1:
                    tbl_t = nv.cargarDatos("TBL_CxP");
                    dgr.DataSource = tbl_t;
                    break;
                case 2:
                    tbl_t = nv.cargarDatos("TBL_ConceptosCxP");
                    dgr.DataSource = tbl_t;
                    break;
            }*/
            
        }
    }
}
