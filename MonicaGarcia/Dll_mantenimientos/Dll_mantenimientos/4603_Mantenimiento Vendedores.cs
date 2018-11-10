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
    public partial class _4603_Mantenimiento_Vendedores : Form
    {
        Navegador nvv = new Navegador();
        public _4603_Mantenimiento_Vendedores(DataGridView dgvTabla)
        {
            //Ingreso del nombre de la forma
            InitializeComponent();
            nvv.nombreForm(this);
            nvv.dgv_datos(dgvTabla);
        }

        private void Lbl_codigoV_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cdigoVemdedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_nombreV_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nombreVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_ApellidoV_Click(object sender, EventArgs e)
        {

        }

        private void Txt_apellidoVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdb_disponible_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Estado.Text = "0";
        }

        private void rdb_nodisponible_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Estado.Text = "1";
        }

        private void diseñoVendedor_Load(object sender, EventArgs e)
        {
            //Cargo dentro del combobox los nombres de los empleados que se encuentran guardadas dentro de la base de datos.
            //Y guardo el Id en un textbox para almacenarlo en la base de datos.
            DataSet dt = nvv.cargarCombobox("tbl_empleados", "ID_Empleado", "Nombre");
            cmb_nombreEmpleado.ValueMember= "ID_Empleado";
            cmb_nombreEmpleado.DisplayMember = "Nombre";
            cmb_nombreEmpleado.DataSource = dt.Tables[0].DefaultView;

            nvv.ingresarTabla("TBL_Vendedor");
          


        }

        private void diseñoVendedor_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //Se ingresa el link de la ayuda para que aparezca al presionar f1
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "vendedores.html");
        }

        private void cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con forme se escoge una opción del combobox se guarda en el textbox de codEmpleado su id
            //y en el textbox nombreVendedor el nombre del empleado.
            if (cmb_nombreEmpleado.SelectedValue.ToString() != null)
            {
                string scodEmpleado = cmb_nombreEmpleado.SelectedValue.ToString();
                Txt_codEmpleado.Text = scodEmpleado;
                Txt_nombreVendedor.Text = cmb_nombreEmpleado.Text;
            }
        }
    }
}
