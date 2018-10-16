using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admon_Julio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void balanceDeAntiguedadDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AntiguedadSaldos().Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClienteConsultar().Show();
        }
    }
}
