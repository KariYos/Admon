using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebavalidarcorreo
{
    public partial class Form1 : Form
    {
        validar val = new validar();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val.proComprobarFormatoEmail(textBox1.Text);
        }
    }
}
