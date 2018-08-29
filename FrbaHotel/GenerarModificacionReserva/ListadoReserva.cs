using FrbaHotel.AbmHabitacion.Clases;
using FrbaHotel.CapaDatos;
using FrbaHotel.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ListadoReserva : Form
    {
        private List<Validaciones> validaciones;
        public ListadoReserva()
        {
            InitializeComponent();
            agregarComponentes();
        }
        public void agregarComponentes()
        {
            ValidadorTextBoxnull validadorCampoNull = new ValidadorTextBoxnull();
            validadorCampoNull.agregar(textCodigoReserva);
            validadorCampoNull.agregarLabel(labelReserva);

            ValidadorCampoNumerico validadorCampoNumerico = new ValidadorCampoNumerico();
            validadorCampoNumerico.agregar(textCodigoReserva);
            validadorCampoNumerico.agregarLabel(labelNumerico);

            validaciones = new List<Validaciones>();
            validaciones.Add(validadorCampoNull);
            validaciones.Add(validadorCampoNumerico);
        }

        public Boolean ejecutarValidaciones()
        {
            int count = 0;
            validaciones.ForEach(validador => { if (validador.validar()) count++; });

            if (count > 0)
                return true;

            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerarReserva_Click(object sender, EventArgs e)
        {
            GenerarReserva generarReserva = new GenerarReserva();
            generarReserva.ShowDialog();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            limpiarLabels();
            if (!ejecutarValidaciones())
            {
                ConexionDB bd = new ConexionDB();
                String query = this.armarQuery();
                DataTable resultado = bd.Select(query);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encotraron registros"
                                    , "0 Resultado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    
                }


                this.mostrarReserva(resultado);

            }

        }

        public string armarQuery()
        {

            string query = String.Format("SELECT [AVENGERS].[RESERVA].ID , [AVENGERS].[RESERVA].FECHA_CREACION, " +
		  " [AVENGERS].[RESERVA].FECHA_DESDE, " +
		  " [AVENGERS].[RESERVA].FECHA_HASTA, " +
		  " [AVENGERS].[RESERVA].CANTIDAD_NOCHES , " +
          " [AVENGERS].[TIPO_HABITACION].DESCRIPCION, "+ 
		  " [AVENGERS].[REGIMEN].DESCRIPCION AS REGIMEN_DESC  " +
          " FROM [AVENGERS].[RESERVA], [AVENGERS].[TIPO_HABITACION], [AVENGERS].[HABITACION], "+ 
          " [AVENGERS].[RESERVA_HABITACION],  [AVENGERS].[REGIMEN] "+
          " WHERE  [AVENGERS].[RESERVA].ID = [AVENGERS].[RESERVA_HABITACION].ID_RESERVA "+
          " AND [AVENGERS].[HABITACION].ID = [AVENGERS].[RESERVA_HABITACION].ID_HABITACION "+ 
          " AND [AVENGERS].[HABITACION].OCUPADA = 1 "+
          " AND [AVENGERS].[HABITACION].TIPO =  [AVENGERS].[TIPO_HABITACION].ID " +  
          " AND  [AVENGERS].[REGIMEN].ID = [AVENGERS].[RESERVA].ID_REGIMEN "+
          " AND [AVENGERS].[RESERVA].ID = '{0}' ",
          textCodigoReserva.Text);

            return query;
        }

        public void mostrarReserva(DataTable Listado)
        {
            dataGridViewListado.Rows.Clear();

            foreach (DataRow fila in Listado.Rows)
            {
                dataGridViewListado.Rows.Add(fila["ID"].ToString(),
                                              fila["FECHA_CREACION"].ToString(),
                                              fila["FECHA_DESDE"].ToString(),
                                              fila["FECHA_HASTA"].ToString(),
                                              fila["CANTIDAD_NOCHES"].ToString(),
                                              fila["DESCRIPCION"].ToString(),
                                               fila["REGIMEN_DESC"].ToString(),
                                              "Modificar"
                                               );
            }

            
        }

        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }

        private void dataGridViewListado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String LinkLabel = "";
            LinkLabel = dataGridViewListado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (e.RowIndex != -1)
            {
                if (LinkLabel.Equals("Modificar"))
                {                                          
                    this.instanciarMoficiacion(e);                                    
                }             
            }

           
           
        }

        private void instanciarMoficiacion(DataGridViewCellMouseEventArgs e)
        {
            String id, fechaCreacion, fechaHasta, fechaDesde,cantidadNoches, tipoHabitacion,tipoRegimen;

            id = dataGridViewListado.Rows[e.RowIndex].Cells[0].Value.ToString();

            fechaCreacion = dataGridViewListado.Rows[e.RowIndex].Cells[1].Value.ToString();
            fechaDesde = dataGridViewListado.Rows[e.RowIndex].Cells[2].Value.ToString();
            fechaHasta = dataGridViewListado.Rows[e.RowIndex].Cells[3].Value.ToString();
            cantidadNoches = dataGridViewListado.Rows[e.RowIndex].Cells[4].Value.ToString();
            tipoHabitacion = dataGridViewListado.Rows[e.RowIndex].Cells[5].Value.ToString();
            tipoRegimen = dataGridViewListado.Rows[e.RowIndex].Cells[6].Value.ToString();
           


            ModificarReserva modificarReseva = new ModificarReserva(id, fechaCreacion,
                                                fechaDesde,
                                                fechaHasta,
                                                cantidadNoches,
                                                tipoHabitacion,
                                                tipoRegimen);
            // me quede aquí
             modificarReseva.ShowDialog();
        }

    }
}
