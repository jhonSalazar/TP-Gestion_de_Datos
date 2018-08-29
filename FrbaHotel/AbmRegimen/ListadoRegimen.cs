using FrbaHotel.AbmRegimen.Clases;
using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class ListadoRegimen : Form
    {
        public ListadoRegimen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConexionDB bd = new ConexionDB();
            String query = this.queryDinamica();
            DataTable resultado = bd.Select(query);

            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encotraron registros"
                                , "0 Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarTodo();
            }


            this.mostrarListado(resultado);
        }

        public void limpiarTodo()
        {
            dGvListado.Rows.Clear();
            textDescripcion.Clear();
            textPrecioBase.Clear();
            textEstado.Clear();
            textBoxCodigo.Clear();

        }


        public void mostrarListado(DataTable Listado)
        {
            limpiarTodo();
            foreach (DataRow fila in Listado.Rows)
            {
                dGvListado.Rows.Add(fila["ID"].ToString(),
                                              fila["DESCRIPCION"].ToString(),
                                              fila["PRECIO"].ToString(),
                                              fila["ESTADO"].ToString(),
                                              "Dar Baja",
                                              "Modificar"
                                               );
            }

            labelCantidadTotal.Text = "Cantidad Total de Registros:" + Listado.Rows.Count;
        }

        public String queryDinamica()
        {
            String queryFinal = "SELECT * FROM [AVENGERS].[REGIMEN]  WHERE 1 = 1";

            if (!string.IsNullOrEmpty(textDescripcion.Text))
                queryFinal += string.Format("AND DESCRIPCION  LIKE '%{0}%'", textDescripcion.Text);

            if (!string.IsNullOrEmpty(textPrecioBase.Text))
                queryFinal += string.Format("AND PRECIO = '{0}'", textPrecioBase.Text);

            if (!string.IsNullOrEmpty(textEstado.Text))
                queryFinal += string.Format("AND ESTADO = '{0}'", textEstado.Text);

            if (!string.IsNullOrEmpty(textBoxCodigo.Text))
                queryFinal += string.Format("AND ID = '{0}'", textBoxCodigo.Text);

            return queryFinal;

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void instanciarMoficiacion(DataGridViewCellMouseEventArgs e)
        {
            String id, textBoxDescripción,textBoxPrecio,textBoxEstado;

            id = dGvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxDescripción = dGvListado.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPrecio = dGvListado.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxEstado = dGvListado.Rows[e.RowIndex].Cells[3].Value.ToString();


            var ventanaModificar =
            new ModificacionRegimen(id,
            textBoxDescripción,textBoxPrecio);
            ventanaModificar.Show();
        }
        private void dGvListado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String LinkLabel = "";
            LinkLabel = dGvListado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
   
            if (e.RowIndex != -1)
            {
                     if (LinkLabel.Equals("Dar Baja"))
                     {
                         MessageBox.Show("Seguro de la Baja ?"
                         , "0 Resultado",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                           ActualizadorRegimen actualizador = new ActualizadorRegimen(dGvListado.
                                                                  Rows[e.RowIndex].Cells[0].
                                                                  Value.ToString());
                           actualizador.darBaja();      
                     }

                     if (LinkLabel.Equals("Modificar"))
                     {
                        this.instanciarMoficiacion(e);
                     }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AltaRegimen alta = new AltaRegimen();
            alta.Show();
        }
      
    }
}
