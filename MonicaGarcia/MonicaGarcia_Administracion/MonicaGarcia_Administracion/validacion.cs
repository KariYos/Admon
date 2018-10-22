using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MonicaGarcia_Administracion
{
    class validacion
    {
        int icontador = 0;
        public void provalidartamañocodigopersona(string sTamaño)
        {

            if (sTamaño.Length < 13)
            {
                MessageBox.Show("El tamaño correcto es de 13 caracteres, y usted ha ingresado uno menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void proValidarLetras(KeyPressEventArgs tecla)
        {
            if (Char.IsLetter(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsControl(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsSeparator(tecla.KeyChar)) { tecla.Handled = false; }
            else
            {
                tecla.Handled = true;
                MessageBox.Show("Solamente se pueden ingresar letras", "Error de carácter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void proValidarNumeros(KeyPressEventArgs tecla)
        {
            if (Char.IsDigit(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsControl(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsSeparator(tecla.KeyChar)) { tecla.Handled = false; }
            else
            {
                tecla.Handled = true;
                MessageBox.Show("Solamente se pueden ingresar numeros", "Error de carácter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void proValidarNumerosyLetras(KeyPressEventArgs tecla)
        {
            if (Char.IsLetterOrDigit(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsControl(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsSeparator(tecla.KeyChar)) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals(".")) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals(",")) { tecla.Handled = false; }
            else
            {
                tecla.Handled = true;
                MessageBox.Show("Solamente se pueden ingresar letras y números", "Error de caracteres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void proValidarCorreo(KeyPressEventArgs tecla)
        {
            if (Char.IsLetterOrDigit(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsControl(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsSeparator(tecla.KeyChar)) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals("@")) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals(".")) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals("_")) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals("-")) { tecla.Handled = false; }
            else
            {
                tecla.Handled = true;
                MessageBox.Show("El caracter que intenta ingresar no está permitido", "Error de caracteres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void proValidarNit(KeyPressEventArgs tecla)
        {


            if (Char.IsDigit(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsLetter(tecla.KeyChar) && icontador < 1) { tecla.Handled = false; icontador++; }
            else if (Char.IsControl(tecla.KeyChar)) { tecla.Handled = false; }
            else if (Char.IsSeparator(tecla.KeyChar)) { tecla.Handled = false; }
            else if (tecla.KeyChar.ToString().Equals("-")) { tecla.Handled = false; }
            else
            {
                tecla.Handled = true;
                MessageBox.Show("El numero de nit es inválido.", "Error de caracteres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void proComprobarFormatoEmail(string sCorreo)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sCorreo, sFormato))
            {
                MessageBox.Show("Correo Correcto");
            }
            else { MessageBox.Show("Dirección de correo electrónica incorrecto"); }
        }
    }
    }

