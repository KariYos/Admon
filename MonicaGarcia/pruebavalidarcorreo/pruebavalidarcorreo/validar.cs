using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pruebavalidarcorreo
{
    class validar
    {
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
