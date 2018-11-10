using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiseñoVentana;
using CapaDiseno;
using CapaDatos;

namespace DLL_MovimientoClientes
{
    public partial class _4064_Altas_de_Cuentas_por_Cobrar : Form, IForm
    {
        Diseño di = new Diseño();
        Navegador nv = new Navegador();
        Commandos com = new Commandos();
        public _4064_Altas_de_Cuentas_por_Cobrar(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);            //mandar el form
            nv.dgv_datos(dgv);              //para usar las flechas

        }
        /*public void ChangeTextBoxText(string text)
        {
            box_example.Text = text;
        }*/

        public void fila(params string[] fila)
        {
            Txt_CodigoBClien.Text = fila[0]; //codigo cliente
            Txt_NombreCliente.Text = fila[1]; //Nombre cliente

            DataTable tabla = com.pubSeleccionarData("Select em.Nombre, ve.PK_CodVendedor from tbl_empleados em, TBL_Vendedor ve, TBL_Cliente cl where cl.PK_codCliente ='"+Convert.ToInt32(Txt_CodigoBClien.Text)+"' AND cl.FK_codVendedor = ve.PK_CodVendedor AND ve.FK_CodEmpleado = em.ID_Empleado");
          //  MessageBox.Show("Nombre Vendedor: " + tabla.Rows[0][0].ToString()+" " + tabla.Rows[0][1].ToString());
            Txt_Vendedor.Text = tabla.Rows[0][1].ToString();
            Txt_VendedorB.Text= tabla.Rows[0][0].ToString();

        }
        public void fila3(params string[] fila3)
        {
            Txt_NumFactura.Text = fila3[0];
            Txt_NumDoc.Text = fila3[1];

        }

        public void fila2(params string[] fila2)
        {
            Txt_ConceptoBClie.Text = fila2[0];
            Txt_ConceptoClien.Text = fila2[1];
            Txt_TipoConceptoClien.Text = fila2[2];
        }
        public void fila4(params string[] fila4)
        {
            Txt_MonedaBuscar.Text = fila4[0];
            Txt_TipoMoneda.Text = fila4[1];

        }
        private void _4064_Altas_de_Cuentas_por_Cobrar_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaBuscar form2 = new TablaBuscar("TBL_Cliente",1);
            form2.Show(this);
            

        }

        private void diseño1_Load(object sender, EventArgs e)
        {
           /* DataSet dt = nv.cargarCombobox("tbl_usuario", "PK_Usu_Codigo", "usu_nickname");
            Cmb_prueba.ValueMember = "PK_Usu_Codigo";
            Cmb_prueba.DisplayMember = "usu_nickname";
            Cmb_prueba.DataSource = dt.Tables[0].DefaultView;*/

            nv.ingresarTabla("TBL_CxC");
            
        }

        private void Cmb_prueba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TablaBuscar form2 = new TablaBuscar("TBL_ConceptoCliente",2);
            form2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaBuscar form2 = new TablaBuscar("TBL_Factura", 3);
            form2.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TablaBuscar form2 = new TablaBuscar("tbl_moneda", 4);
            form2.Show(this);
        }
    }
}
