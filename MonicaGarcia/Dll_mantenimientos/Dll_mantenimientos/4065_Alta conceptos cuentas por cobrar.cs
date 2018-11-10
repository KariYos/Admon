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
    public partial class _4065_Alta_conceptos_cuentas_por_cobrar : Form
    {
        Navegador nva = new Navegador();
        public _4065_Alta_conceptos_cuentas_por_cobrar(DataGridView dgvTabla)
        {
           
            InitializeComponent();
            //Ingreso nombre de la forma
            nva.nombreForm(this);
            nva.dgv_datos(dgvTabla);
        }

        private void diseñoConceptosAltasPorCobrar_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_codigoConcepto_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_tipoSaldo_Click(object sender, EventArgs e)
        {

        }

        private void Txt_tipoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_codigoConcepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_cuenta_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cuentaContable_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cuentaContable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_desc_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cdigoVemdedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_codigoConcepto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rdb_disponible_CheckedChanged(object sender, EventArgs e)
        {
            //Si la persona selecciona cargo se coloca en el textbox para guardarlo en la base de datos.
            Txt_tipoS.Text = "Cargo";
        }

        private void Txt_cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Si la persona selecciona abono se coloca en el textbox para guardarlo en la base de datos.
            Txt_tipoS.Text = "Abono";
        }

        private void diseñoAltas_Load(object sender, EventArgs e)
        {
            //Cargo dentro del combobox las cuentas contables que se encuentran guardadas dentro de la base de datos.
            //Y guardo el Id en un textbox para almacenarlo en la base de datos.
            DataSet dt = nva.cargarCombobox("tbl_catalogo_cuentas_contables", "id_cuenta", "Nombre_cuenta");
            cmb_cuentaContable.ValueMember = "id_cuenta";
            cmb_cuentaContable.DisplayMember = "Nombre_cuenta";
            cmb_cuentaContable.DataSource = dt.Tables[0].DefaultView;

            //Llama al método en el que se le indica la tabla.
            nva.ingresarTabla("TBL_ConceptoCliente");
        }

        private void cmb_cuentaContable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Dependiendo de lo el usuario seleccione, se copia inmediatamente dentro del id del textbox.
            if (cmb_cuentaContable.SelectedValue.ToString() != null)
            {
                string scodEmpleado = cmb_cuentaContable.SelectedValue.ToString();
                Txt_cuentaContable.Text = scodEmpleado;
               
            }
        }
    }
}
