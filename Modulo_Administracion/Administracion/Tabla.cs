using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion
{
    public partial class Tabla : Form
    {
        private int form;
        public Tabla(string nombre, int n)
        {
            InitializeComponent();
            Lbl_Titulo.Text = nombre;
            form = n;
        }

        private void Tabla_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (form)
            {
                case 1:
                    new CuentasPorCobrar().Show();
                    break;
                case 2:
                    new CuentasPorPagar().Show();
                    break;
            }
            
        }
    }
}
