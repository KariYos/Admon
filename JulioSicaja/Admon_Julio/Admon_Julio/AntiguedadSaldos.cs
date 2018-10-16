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
    public partial class AntiguedadSaldos : Form
    {
        public AntiguedadSaldos()
        {
            InitializeComponent();
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            new TablaAntiguedadSaldos().Show();
        }
    }
}
