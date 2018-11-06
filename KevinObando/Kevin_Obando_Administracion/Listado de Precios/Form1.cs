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
