using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva.Clases
{
    class CreadorReserva
    {
        private TextBox textBoxCodigoReserva;
        private string idReserva;
        private string fechaCreacion;
        private string fechaDesde;
        private string fechaHasta;
        private int cantNoches;
        private int idRegimen;
        private int idCliente;
        private string tipoHabitacion;
        private string NombreHotel;

        public CreadorReserva(TextBox textBoxReserva,
                               string p1,
                               string p2, 
                               string p3, 
                                int p4, int p5, int p6, string p7, String NombreHotel)
        {
            // TODO: Complete member initialization
            textBoxCodigoReserva = textBoxReserva;
            this.fechaCreacion = p1;
            this.fechaDesde = p2;
            this.fechaHasta = p3;
            this.cantNoches = p4;
            this.idRegimen = p5;
            this.idCliente = p6;
            this.tipoHabitacion = p7;
            this.NombreHotel = NombreHotel;
        }

    

        public void crearReserva()
        {
            ConexionDB bd = new ConexionDB();

            // se configura el StoreProcedure
            bd.configurarStoredProcedure("AVENGERS.SP_GENERAR_RESERVA");
            bd.agregarParametros("@FECHA_CREACION", SqlDbType.Date, fechaCreacion);
            bd.agregarParametros("@FECHA_DESDE", SqlDbType.Date, fechaDesde);
            bd.agregarParametros("@FECHA_HASTA", SqlDbType.Date, fechaHasta);
            bd.agregarParametros("@CANT_NOCHES", SqlDbType.Int, cantNoches);
            bd.agregarParametros("@ID_REGIMEN", SqlDbType.Int, idRegimen);
            bd.agregarParametros("@ID_CLIENTE", SqlDbType.Int, idCliente);
            bd.agregarParametros("@TIPO_HABITACION", SqlDbType.NVarChar, tipoHabitacion);
            bd.agregarParametros("@NOMBRE", SqlDbType.NVarChar, NombreHotel);

            /* configuramos el retorno del valor del SP, en este caso un unico valor de tipoo
          int, que corresponde al  id reserva*/
            idReserva = bd.ejecutarStoredProcedure("@ID_RESERVA", SqlDbType.Int).ToString();

            if (idReserva.Equals("0"))
            {
                MessageBox.Show("No se puede generar la Reserva, intente en otro momento "
                          , "No hay Habitación disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Se generó exitosamente la Reserva" + " Guarde el código de reserva para futuras modificaciones"
                            , "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxCodigoReserva.Text = idReserva;
        }


    }
}
