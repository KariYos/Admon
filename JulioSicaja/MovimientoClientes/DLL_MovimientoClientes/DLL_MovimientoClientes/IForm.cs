using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_MovimientoClientes
{
    public interface IForm
    {
       // void ChangeTextBoxText(string text);
        void fila(params string[] fila);
        void fila2(params string[] fila2);
        void fila3(params string[] fila3);

        void fila4(params string[] fila4);
    }
}
