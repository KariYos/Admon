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
    public partial class _4015_Alta_de_Conceptos_de_Cuentas_por_Pagar : Form
    {
        Navegador nv = new Navegador();
        public _4015_Alta_de_Conceptos_de_Cuentas_por_Pagar(DataGridView dgr)
        {
            InitializeComponent();
           // nv.ingresarTabla("TBL_ConceptosCxP");
        }

        private void _4015_Alta_de_Conceptos_de_Cuentas_por_Pagar_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void DisenoConceptosCxP_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "altaConceptosCxP.html");
        }
    }
}
