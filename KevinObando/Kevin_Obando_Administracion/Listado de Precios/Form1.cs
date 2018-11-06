using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado_de_Precios
{
    public partial class Form1 : Form
    {
        Int32 idUsuario;
        public Form1(Int32? id_Usuario)
        {
            InitializeComponent();
            idUsuario = (Int32)id_Usuario;
        }
        // metodos globales para etiquetas del formulario 

        AccionesEnControles ac = new AccionesEnControles();

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Columns.Add("ColumnId", "Id");
            dgvProductos.Columns.Add("ColumnNumero", "#");
            dgvProductos.Columns.Add("ColumnCodigo", "Codigo");
            dgvProductos.Columns.Add("ColumnNombre", "Nombre");
            dgvProductos.Columns.Add("ColumnMarca", "Marca");
            dgvProductos.Columns.Add("ColumnCategoria", "Categoria");
            dgvProductos.Columns.Add("ColumnUnidMed", "Unid. Med");
            dgvProductos.Columns.Add("ColumnProveedor", "Proveedor");

            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Width = 30;
            dgvProductos.Columns[1].Width = 60;

            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

        }
        private void CrearGridCategoria()
        {
            dgvCategoria.Columns.Add("ColumnId", "id");
            dgvCategoria.Columns.Add("ColumnNumero", "#");
            dgvCategoria.Columns.Add("ColumnCodigo", "Codigo");
            dgvCategoria.Columns.Add("ColumnNombre", "Nombre");
            dgvCategoria.Columns.Add("ColumnDescripcion", "Descripción");

            //  dgvCategoria.Columns[0].Visible = false;
            dgvCategoria.Columns[1].Width = 30;
            dgvCategoria.Columns[2].Width = 150;
            dgvCategoria.Columns[3].Width = 300;

            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategoria.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.MultiSelect = false;

        }
        private void CrearGridUniMed()
        {
            dgvUnidadMedida.Columns.Add("ColumnId", "id");
            dgvUnidadMedida.Columns.Add("ColumnNumero", "#");
            dgvUnidadMedida.Columns.Add("ColumnCodigo", "Codigo");
            dgvUnidadMedida.Columns.Add("ColumnDescripcion", "Descripción");
            dgvUnidadMedida.Columns.Add("ColumnAbrev", "Abreviatura");

            dgvUnidadMedida.Columns[0].Visible = false;
            dgvUnidadMedida.Columns[1].Width = 30;
            dgvUnidadMedida.Columns[3].Width = 300;
            dgvUnidadMedida.Columns[4].Width = 150;


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUnidadMedida.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvUnidadMedida.AllowUserToAddRows = false;
            dgvUnidadMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void CrearGridProveedor()
        {
            dgvProveedor.Columns.Add("ColumnId", "id");
            dgvProveedor.Columns.Add("ColumnNumero", "#");
            dgvProveedor.Columns.Add("ColumnCodigo", "Codigo");
            dgvProveedor.Columns.Add("ColumnRazSocial", "Raz. Social");
            dgvProveedor.Columns.Add("ColumnRuc", "Ruc");

            dgvProveedor.Columns[0].Visible = false;
            dgvProveedor.Columns[1].Width = 30;
            dgvProveedor.Columns[3].Width = 300;
            dgvProveedor.Columns[4].Width = 150;


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedor.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void CrearGridMaterial()
        {
            dgvMaterial.Columns.Add("ColumnId", "id");
            dgvMaterial.Columns.Add("ColumnNumero", "#");
            dgvMaterial.Columns.Add("ColumnCodigo", "Codigo");
            dgvMaterial.Columns.Add("ColumnNombre", "Nombre");

            dgvMaterial.Columns[0].Visible = false;
            dgvMaterial.Columns[1].Width = 30;
            dgvMaterial.Columns[2].Width = 150;
            dgvMaterial.Columns[3].Width = 300;


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaterial.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        // cargar combos para producto
        private void LlenarCombos()
        {
            try
            {
                cboCategoria.ValueMember = "Id_Cat";
                cboCategoria.DisplayMember = "Nombre_Cat";
                cboCategoria.DataSource = negProducto.Instancia.ListarCategoria();

                cboUnidMed.ValueMember = "Id_Umed";
                cboUnidMed.DisplayMember = "Descripcion_Umed";
                cboUnidMed.DataSource = negProducto.Instancia.ListarUnidMed();

                cboProveedor.ValueMember = "Id_Proveedor";
                cboProveedor.DisplayMember = "RazSocial_Proveedor";
                cboProveedor.DataSource = negProducto.Instancia.ListarProveedor();

                cboMaterial.ValueMember = "Id";
                cboMaterial.DisplayMember = "Nombre";
                cboMaterial.DataSource = negProducto.Instancia.ListarMaterial();


            }
            catch (Exception)
            {
                throw;
            }
        }
        // funcion validar entrada solo caracteres validos 
        private Boolean EntradaDecimales(KeyPressEventArgs e)
        {
            try
            {
                Boolean result;
                String cadena = "1234567890," + (char)5;
                if (cadena.Contains(e.KeyChar))
                {
                    result = true;
                }
                else
                {
                    MessageBox.Show("Esta intentando ingresar un caracter no válido", "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning); result = false;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
