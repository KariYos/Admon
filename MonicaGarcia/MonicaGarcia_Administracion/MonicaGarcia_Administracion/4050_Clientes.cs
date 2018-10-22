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
    public partial class _4050_Clientes : Form
    {
        Navegador nav = new Navegador();
        validacion val = new validacion();
        public _4050_Clientes()
        {
            InitializeComponent();
        }

        private void diseño1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumeros(e);
        }

        private void Txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarCorreo(e);
        }

        private void Txt_telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumeros(e);
        }

        private void Txt_telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumeros(e);
        }

        private void Txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumerosyLetras(e);
        }

        private void Txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNit(e);
        }

        private void Txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarLetras(e);
           
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarLetras(e);
            
        }
    }
}
