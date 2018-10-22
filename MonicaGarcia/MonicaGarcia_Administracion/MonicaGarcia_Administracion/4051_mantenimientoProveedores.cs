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
    public partial class _4051_mantenimientoProveedores : Form
    {
        Navegador nav = new Navegador();
        validacion val = new validacion();
        public _4051_mantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gpb_contacto_Enter(object sender, EventArgs e)
        {

        }

        private void diseño1_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_codigoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumeros(e);
        }

        private void Txt_nombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarLetras(e);
        }

        private void Txt_nitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNit(e);
        }

        private void Txt_direccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumerosyLetras(e);
        }

        private void Txt_telefono2Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumeros(e);
        }

        private void Txt_telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarNumeros(e);
        }

        private void Txt_correoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.proValidarCorreo(e);
        }
    }
}
