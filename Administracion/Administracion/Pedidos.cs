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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Tmr_tiempo_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Tmr_tiempo.Start();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            Tmr_tiempo.Start();
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
