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
    public partial class _4053_Mantenimiento_Clientes : Form
    {
        Navegador nvc = new Navegador();
        public _4053_Mantenimiento_Clientes(DataGridView dgvTabla)
        {
            InitializeComponent();
            //Ingreso nombre de la forma
            nvc.nombreForm(this);
            nvc.dgv_datos(dgvTabla);
        }

        private void diseñoClientes_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //Se ingresa el link de la ayuda para cuando el usuario presione F1
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "clientes.html");

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

        private void diseñoClientes_Load(object sender, EventArgs e)
        {
            //Método para seleccionar la tabla a utilizar en esta forma

            nvc.ingresarTabla("TBL_Cliente");
            /*DataSet dt = nvc.cargarCombobox("TBL_vendedor", "PK_codVendedor", "Nombre");
            cmb_vendedor.ValueMember= "PK_codVendedor";
            cmb_vendedor.DisplayMember = "Nombre";
            cmb_vendedor.DataSource = dt.Tables[0].DefaultView;*/
        }
    }
}
