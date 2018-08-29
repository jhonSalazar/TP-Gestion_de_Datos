using System;
using FrbaHotel.CapaDatos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmHabitacion.Clases;

namespace FrbaHotel.AbmHabitacion
{
    public partial class ListadoHabitacion : Form
    {
        public ListadoHabitacion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listado_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

        public void mostrarListado(DataTable Listado)
        {
            limpiarTodo();
            foreach(DataRow fila in Listado.Rows)
            {
                dGvListadoHabitacion.Rows.Add(fila["NUMERO"].ToString(), 
                                              fila["PISO"].ToString(),
                                              fila["FRENTE"].ToString(),
                                              fila["TIPO"].ToString(),
                                              fila["DESCRIPCION"].ToString(),
                                              fila["COMODIDADES"].ToString(),
                                              fila["ESTADO"].ToString(),
                                               "Dar Baja",
                                               "Modificar",
                                              fila["ID"].ToString(),
                                              fila["ID_HOTEL"].ToString()
                                               );
            }

            labelCantidadTotal.Text = "Cantidad Total de Registros:" + Listado.Rows.Count;
        }


        public List<String> agregarCondiciones()
        {
            List<String> condicones = new List<String>();
            condicones.Add(textNumeroHabitacion.Text);
            condicones.Add(textUbicacion.Text);
            condicones.Add(textTipoHabitacion.Text);
            condicones.Add(textPiso.Text);
            return condicones;
        }

        public List<String> filtrarConciones(List<String> condiciones)
        {
            List<String> condiconesFiltradas = condiciones
                                                  .Where(condicion => !condicion.Equals(""))
                                                  .ToList();
            return condiconesFiltradas;
        }

        public String queryDinamica()
        {
            String queryFinal = "SELECT ID,ID_HOTEL ,NUMERO,PISO,FRENTE,TIPO ,DESCRIPCION,COMODIDADES,ESTADO FROM [AVENGERS].[HABITACION]  WHERE 1 = 1";

                //"SELECT TOP 10 NUMERO,PISO,FRENTE,TIPO , [AVENGERS].[HABITACION].DESCRIPCION,COMODIDADES,[AVENGERS].[ESTADO].DESCRIPCION FROM [AVENGERS].[HABITACION] AS EST INNER JOIN [AVENGERS].[ESTADO] ON [AVENGERS].[HABITACION].ESTADO =  [AVENGERS].[ESTADO].ID  WHERE 1 = 1";

           // List<String> condicones = agregarCondiciones();
           // List<String> condiconesFiltradas = filtrarConciones(condicones);
            //podriamos utilizar tuplas para hacer más dinámica esta parte
            
            
            if (!string.IsNullOrEmpty(textNumeroHabitacion.Text))
                queryFinal += string.Format("AND NUMERO  LIKE '%{0}%'", textNumeroHabitacion.Text);

            if (!string.IsNullOrEmpty(textUbicacion.Text))
                queryFinal += string.Format("AND FRENTE LIKE '%{0}%'", textUbicacion.Text);

            if (!string.IsNullOrEmpty(textTipoHabitacion.Text))
                queryFinal += string.Format("AND TIPO LIKE '%{0}%'", textTipoHabitacion.Text);

            if (!string.IsNullOrEmpty(textPiso.Text))
                queryFinal += string.Format("AND PISO LIKE '%{0}%'", textPiso.Text);

            return queryFinal;
        
        }
        public void limpiarTodo()
        {
            dGvListadoHabitacion.Rows.Clear();
            textNumeroHabitacion.Clear();
            textUbicacion.Clear();
            textPiso.Clear();
            textTipoHabitacion.Clear();

        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTodo();
            dGvListadoHabitacion.Refresh();
        }

        private void dGvListadoHabitacion_CellMouseDoubleClick(object sender, 
                                                               DataGridViewCellMouseEventArgs e)
        {

        }





        private void instanciarMoficiacion(DataGridViewCellMouseEventArgs e)
        {
            String id,id_hotel,textNumeroHabitacion, textPiso, comboBoxUbicacion, comboBoxTipoDeHabitacion, textBoxDescripción;

            textNumeroHabitacion = dGvListadoHabitacion.Rows[e.RowIndex].Cells[0].Value.ToString();
            textPiso = dGvListadoHabitacion.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxUbicacion = dGvListadoHabitacion.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxTipoDeHabitacion = dGvListadoHabitacion.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxDescripción = dGvListadoHabitacion.Rows[e.RowIndex].Cells[5].Value.ToString();
            id = dGvListadoHabitacion.Rows[e.RowIndex].Cells[9].Value.ToString();
            id_hotel = dGvListadoHabitacion.Rows[e.RowIndex].Cells[10].Value.ToString();

            var ventanaModificar = new ModificacionHabitacion(textNumeroHabitacion,
                                                                     textPiso,
                                                                     comboBoxUbicacion,
                                                                     comboBoxTipoDeHabitacion,
                                                                     textBoxDescripción,
                                                                       id);
            ventanaModificar.Show();

        
        }


        private void dGvListadoHabitacion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String LinkLabel = "";
            LinkLabel = dGvListadoHabitacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
   
            if (e.RowIndex != -1)
            {
                if (LinkLabel.Equals("Dar Baja"))
                {
                    MessageBox.Show("Seguro de la Baja ?"
                                , "0 Resultado",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    Actualizador actualizador = new Actualizador(dGvListadoHabitacion.
                                                                  Rows[e.RowIndex].Cells[9].
                                                                  Value.ToString());
                    actualizador.darBaja();
                  
                }

                if (LinkLabel.Equals("Modificar"))
                {
                     
                   
                    this.instanciarMoficiacion(e);

                }
            }
        }

        private void buttonNuevoRegimen_Click(object sender, EventArgs e)
        {
            AltaHabitacion alta = new AltaHabitacion();
            alta.Show();
        }
    }
}
