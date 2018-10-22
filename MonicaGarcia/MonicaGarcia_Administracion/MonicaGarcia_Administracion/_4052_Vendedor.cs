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

namespace MonicaGarcia_Administracion
{
    public partial class _4052_Vendedor : Form
    {
        Navegador nav = new Navegador();
        validacion val = new validacion();
        public _4052_Vendedor()
        {
            InitializeComponent();
        }

        private void Gpb_DatosVendedor_Enter(object sender, EventArgs e)
        {

        }

        private void diseño1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_ComisionVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarPrecios(e);
        }
    }
}
