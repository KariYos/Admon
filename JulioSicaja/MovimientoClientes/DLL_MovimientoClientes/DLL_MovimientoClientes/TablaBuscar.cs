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

namespace DLL_MovimientoClientes
{
    public partial class TablaBuscar : Form
    {
        Navegador nv = new Navegador();
        static string tab;
        static int ban;
        public TablaBuscar(string tabla, int bandera)
        {
            InitializeComponent();
            tab = tabla;
            ban = bandera;
        }
        private void obtenerFila(params int[] columnas)
        {
            
            int iFilas = Dgv_tablaC.RowCount - 1, iColum = columnas.Count();//numero de filas y columnas

            string[] datosTabla = new string[iColum]; //tabla para guardar los campos de la fila
            DataGridViewRow fila = Dgv_tablaC.CurrentRow;
            for (int i=0; i<iColum; i++)
            {
                //MessageBox.Show("Celda: "+fila.Cells[i].Value.ToString());
                datosTabla[i] = fila.Cells[columnas[i]].Value.ToString();
            }
            IForm formInterface = this.Owner as IForm;

            if (formInterface != null)
            {
                switch (ban)
                {
                    case 1:
                        formInterface.fila(datosTabla);
                        break;
                    case 2:
                        formInterface.fila2(datosTabla);
                        break;
                    case 3:
                        formInterface.fila3(datosTabla);
                        break;
                    case 4:
                        formInterface.fila4(datosTabla);
                        break;
                }
                
            }

        }
        private void Dgv_tablaC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (ban)
            {
                case 1:
                    obtenerFila(0, 1);
                    break;
                case 2:
                    obtenerFila(0, 1, 2);
                    break;
                case 3:
                    obtenerFila(0,1);
                    break;
                case 4:
                    obtenerFila(0, 1);
                    break;
            }

            
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            DataTable table = nv.cargarDatos(tab);
            Dgv_tablaC.DataSource = table;
        }
    }
}
