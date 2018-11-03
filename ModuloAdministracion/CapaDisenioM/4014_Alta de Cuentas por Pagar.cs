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
    public partial class _4014_Alta_de_Cuentas_por_Pagar : Form
    {
        Navegador nv = new Navegador();
        public _4014_Alta_de_Cuentas_por_Pagar(DataGridView dgr)
        {
            InitializeComponent();
            // nv.ingresarTabla("TBL_CxP");
            //nv.dgv_datos(dgr);
        }


        private void _4014_Alta_de_Cuentas_por_Pagar_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void DisenoCxP_Load(object sender, EventArgs e)
        {
            //nv.ingresarTabla("TBL_CxP");
        }

        private void Lbl_CodigoProv_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_ConceptoProv_Click(object sender, EventArgs e)
        {

        }

        private void Txt_ConceptoBProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_TipoConceptoProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_ConceptoProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_CodigoProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_TipoConcepto_Click(object sender, EventArgs e)
        {

        }

        private void Txt_CodigoBProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "altaMovCxP.html");
        }
    }
}
