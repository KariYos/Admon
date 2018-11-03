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
    public partial class _4003_MantenimientoProveedores : Form
    {
        public _4003_MantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void diseño1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "proveedores.html");
        }
    }
}
