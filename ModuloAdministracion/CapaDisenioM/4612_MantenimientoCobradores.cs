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
    public partial class _4612_MantenimientoCobradores : Form
    {
        public _4612_MantenimientoCobradores()
        {
            InitializeComponent();
        }

        private void navegador2_Load(object sender, EventArgs e)
        {

        }

        private void navegador2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "cobradores.html");
        }
    }
}
