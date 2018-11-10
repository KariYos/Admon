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
using CapaDatos;

namespace DLL_Ventas
{
    public partial class _4203_Cotización : Form
    {
        Navegador nv = new Navegador();
        Commandos cmd = new Commandos();
        public _4203_Cotización(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);            
            nv.dgv_datos(dgv);
        }

        //--------------------------------------------------------------------------------------------------------
        //FUNCIONES PARA CALCULAR LOS TOTALES DEL DATAGRID
        private double priSumarColumnasDGV(int iCol, DataGridView Dgv)
        {
            double doSuma = 0;
            foreach (DataGridViewRow data in Dgv.Rows)
            {
                doSuma += Convert.ToDouble(data.Cells[iCol].Value);
            }
            return doSuma;
        }

        private void priCalcularTotales(int iCol1, int iCol2, int iCol3, int iCol4, DataGridView Dgv)
        {
            Txt_resSubtotal.Text = priSumarColumnasDGV(5, Dgv).ToString();
            Txt_resIva.Text = priSumarColumnasDGV(4, Dgv).ToString();
            Txt_resDescuentos.Text = priSumarColumnasDGV(7, Dgv).ToString();
            Txt_resTotal.Text = priSumarColumnasDGV(8, Dgv).ToString();
        }
        //-----------------------------------------------------------------------------------------------------

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            double doCant = 0, doPrecio = 0, doIva=0, doPorcDesc = 0, doDesc = 0, doSub = 0, doAuxSub = 0, doTotal = 0;  //Para el DataGrid
            try
            {
                //Realizar cálculos para ingresar los registros en el datagrid
                doCant = Convert.ToDouble(Txt_cantidad.Text);
                doPrecio = Convert.ToDouble(Txt_precioU.Text);
                doPorcDesc = Convert.ToDouble(Txt_descuento.Text);

                doAuxSub = (doCant * doPrecio);
                doIva = doAuxSub * 0.12;
                doSub = (doAuxSub + doIva);                                     //Resultado para columna "Sub-Total"
                doDesc = (doSub * doPorcDesc) / 100;                            //Resultado para columna "Descuento"
                doTotal = doSub - doDesc;                                       //Resultado para columna "Total"

                //Mover datos de los textos para llenar el detalle de cotización.
                Dgb_cotización.Rows.Add(Txt_codigo.Text, Cbo_descripcion.Text, Txt_cantidad.Text, Txt_precioU.Text, doIva, doSub, Txt_descuento.Text, doDesc, doTotal);

                //Limpiar Campos
                Txt_codigo.Text = "";
                Cbo_descripcion.Text = "";
                Txt_cantidad.Text = "";
                //Txt_precioU.Text = "";
                Txt_descuento.Text = "";

                //--------------------------------------------------------------------------------------------------------------------------------
                //Incrementar los Totales con cada registro que se va añadiendo al DataGrid
                priCalcularTotales(5, 4, 7, 8, Dgb_cotización);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1: " + ex);
            }
        }

        int iFila; //Guardar fila seleccionada del DataGrid para poder eliminar registro.
        private void Dgb_cotización_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iFila = 0;
                iFila = Convert.ToInt32(Dgb_cotización.CurrentCell.RowIndex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error2: " + ex);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Dgb_cotización.Rows.RemoveAt(iFila);                //Eliminar la fila seleccionada.

                //Volver a sumar las columnas, porque se eliminaron registros del DataGrid.
                priCalcularTotales(5, 4, 7, 8, Dgb_cotización);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona una fila para poder eliminarla", "Fila no seleccionada");
            }
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("TBL_Cotizacion");                 //Mandar la tabla en donde se guardarán los datos.

            //Llenar Combobox con datos de la Tabla Cliente
            DataSet dt;
            dt = nv.cargarCombobox("TBL_Cliente", "PK_codCliente", "Nombre");
            Cbo_nombre.ValueMember = "PK_codCliente";
            Cbo_nombre.DisplayMember = "Nombre";
            Cbo_nombre.DataSource = dt.Tables[0].DefaultView;

            //Llenar Combobox con datos de la Tabla Producto
            dt = nv.cargarCombobox("TBL_Producto", "PK_Codigo_Producto", "Descripcion_Producto");
            Cbo_descripcion.ValueMember = "PK_Codigo_Producto";
            Cbo_descripcion.DisplayMember = "Descripcion_Producto";
            Cbo_descripcion.DataSource = dt.Tables[0].DefaultView;

        }

        private void diseño1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "cotizacion.html");     //Ayuda al presionar f1
        }

        private void Cbo_nombre_SelectedIndexChanged(object sender, EventArgs e)  //Llenar Datos del Cliente en base al que se seleccione en el Combobox "Nombre"
        {
            int iGetCodigo = Convert.ToInt32(Cbo_nombre.SelectedValue.ToString());
            MessageBox.Show("cod cliente:" + iGetCodigo);
            DataTable dt = cmd.pubSeleccionarData("Select cl.PK_codCliente, cl.Direccion, em.Nombre from tbl_empleados em, TBL_Vendedor ve, TBL_Cliente cl  where cl.PK_codCliente = '"+ iGetCodigo + "' AND cl.FK_codVendedor = ve.PK_CodVendedor AND ve.FK_CodEmpleado = em.ID_Empleado;");

            Txt_nit.Text = dt.Rows[0][0].ToString();
            Txt_direccion.Text = dt.Rows[0][1].ToString();
            Txt_vendedor.Text = dt.Rows[0][2].ToString();
        }
    }
}
