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

namespace Dll_mantenimientos
{
    public partial class _4003_Mantenimiento_Proveedor : Form
    {
       Navegador navp = new Navegador();
        public _4003_Mantenimiento_Proveedor(DataGridView dgvTablaProveedor)
        {
            InitializeComponent();
            //Asignar nombre a la forma
            navp.nombreForm(this);
            //Cargar la tabla de los proveedores
            navp.dgv_datos( dgvTablaProveedor);
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            //Método del navegador para mandar la tabla a utilizar
            navp.ingresarTabla("TBL_Provedor");
        }

        private void rdb_disponible_CheckedChanged(object sender, EventArgs e)
        {
            //Al seleccionar que la persona esta dispoible, guardo en el textbox el estado 0 de disponibilidad.
            Txt_Estado.Text = "0";
        }

        private void rdb_nodisponible_CheckedChanged(object sender, EventArgs e)
        {
            //Al seleccionar que la persona no esta dispoible, guardo en el textbox el estado 1 de disponibilidad.
            Txt_Estado.Text = "1";
        }

        private void diseño1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //Llamada de ayuda al presionar F1
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "proveedores.html");
        }
    }
}
