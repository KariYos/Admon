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

namespace prueba11
{
    public partial class Form1 : Form
    {
        Navegador nv = new Navegador();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla_Campos("refresh", "id", "nombre", "status");
            
        }
    }
}
