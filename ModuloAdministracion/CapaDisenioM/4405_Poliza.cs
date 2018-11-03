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
    public partial class _4405_Poliza : Form
    {
        public _4405_Poliza()
        {
            InitializeComponent();
        }

        private void _4405_Poliza_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "poliza.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "poliza.html");
        }
    }
}
