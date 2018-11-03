using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenioM
{
    public partial class _4402_Balance_de_Antiguedad_Saldos_Clientes : Form
    {
        public _4402_Balance_de_Antiguedad_Saldos_Clientes()
        {
            InitializeComponent();
        }

        private void diseño1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "Saldos.html");
        }
    }
}
