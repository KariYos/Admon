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
    public partial class _4612_Mantenimiento_Cobradores : Form
    {
        Navegador nvco = new Navegador();
        public _4612_Mantenimiento_Cobradores(DataGridView dgvTabla)
        {
            InitializeComponent();
            //Ingreso de la forma
            nvco.nombreForm(this);
            nvco.dgv_datos(dgvTabla);
        }

        private void Txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_codEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdb_nodisponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_disponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Estado_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Comision_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void diseño2_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_apellidoCobrador_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Cobrador_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_codCobrador_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Empleado_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Comision_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void diseñoCobradores_Load(object sender, EventArgs e)
        {
            //Cargo dentro del combobox la lista de los nombres de los empleados que se encuentran guardadas dentro de la base de datos.
            //Y guardo el Id en un textbox para almacenarlo en la base de datos.
            DataSet dt = nvco.cargarCombobox("tbl_empleados", "ID_Empleado", "Nombre");
            cmb_Empleado.ValueMember = "ID_Empleado";
            cmb_Empleado.DisplayMember = "Nombre";
            cmb_Empleado.DataSource = dt.Tables[0].DefaultView;
            nvco.ingresarTabla("TBL_Cobrador");
        }

        private void diseñoCobradores_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //Se ingresa el link de la ayuda para que aparezca al presionar f1
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "cobradores.html");
        }

        private void rdb_disponible_CheckedChanged_1(object sender, EventArgs e)
        {
            //Al seleccionar que la persona  esta dispoible, guardo en el textbox el estado 0 de disponibilidad.
            Txt_Estado.Text = "0";
        }

        private void rdb_nodisponible_CheckedChanged_1(object sender, EventArgs e)
        {
            //Al seleccionar que la persona no esta dispoible, guardo en el textbox el estado 1 de disponibilidad.
            Txt_Estado.Text = "1";
        }

        private void cmb_Empleado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //con forme se escoge una opción del combobox se guarda en el textbox de codEmpleado su id
            //y en el textbox nombre el nombre del empleado.
            if (cmb_Empleado.SelectedValue.ToString() != null)
            {
                string scodEmpleado = cmb_Empleado.SelectedValue.ToString();
                Txt_codEmpleado.Text = scodEmpleado;
                Txt_nombre.Text = cmb_Empleado.Text;
            }
        }
    }
}
