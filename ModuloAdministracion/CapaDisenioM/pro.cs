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
    public partial class pro : Form
    {
        Navegador nv = new Navegador();
        public pro(DataGridView dgr)
        {
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void pro_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("prueba7");
        }
    }
}
