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
    
    public partial class Pruebass : Form
    {
        Navegador nv = new Navegador();
        public Pruebass(DataGridView dgr)
        {
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void Pruebass_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("prueba2");
        }
    }
}
