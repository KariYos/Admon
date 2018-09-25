using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refrescar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void cargarDatagrid ()
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select id, nombre,estado  from refresh where estado = 1", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                /*dataGridView1.Rows.Add(tabla.Rows[0][0].ToString(), tabla.Rows[0][1].ToString(), tabla.Rows[0][2].ToString());
                dataGridView1.Rows.Add(tabla.Rows[1][0].ToString(), tabla.Rows[1][1].ToString(), tabla.Rows[1][2].ToString());*/

               
    


                dataGridView1.DataSource = tabla;

                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }

        public void cargarCombobox()
        {
            try
            {
               // comboBox1.Items.Clear();
                comboBox1.Text = "Seleccione ";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select id as ID, nombre as Nombre from refresh", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["nombre"] = "Seleccione";
                tabla.Rows.InsertAt(fila, 0);

                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "nombre";

                comboBox1.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        private void Actualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cargarCombobox();
            cargarDatagrid();
        
        }
    }
}
