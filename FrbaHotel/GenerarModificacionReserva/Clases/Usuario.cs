using FrbaHotel.CapaDatos;
using FrbaHotel.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva.Clases
{
    class Usuario:TipoUsuario
    {
      
        private  ComboBox comboBoxHotel;
        private  ComboBox comboBoxTipoRegimen;
        private  ComboBox comboBoxTipoHabitacion;
        private int  idHotel;
        public Usuario( int idHotel, ComboBox comboBoxHotel,
                        ComboBox comboBoxTipoRegimen, ComboBox comboBoxTipoHabitacion)
        {
            // TODO: Complete member initialization
            this.comboBoxHotel = comboBoxHotel;
            this.comboBoxTipoRegimen = comboBoxTipoRegimen;
            this.comboBoxTipoHabitacion = comboBoxTipoHabitacion;
            this.idHotel = idHotel;
        }

        public void regimenesDelHotel()
        {
            String query = String.Format(
                "SELECT  DISTINCT " +
                " [AVENGERS].[REGIMEN].DESCRIPCION " +
                " FROM [AVENGERS].[REGIMEN] , [AVENGERS].[TIPO_HABITACION] ,  " +
                " [AVENGERS].[HOTEL_REGIMEN], [AVENGERS].[HOTEL], [AVENGERS].[HABITACION] " +
                " WHERE " +
                "  [AVENGERS].[REGIMEN].ID = [AVENGERS].[HOTEL_REGIMEN].ID_REGIMEN " +
                " AND [AVENGERS].[HOTEL_REGIMEN].ID_HOTEL = [AVENGERS].[HOTEL].ID " +
                " AND [AVENGERS].[HOTEL].ID = {0}",
                idHotel);

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(query);

            foreach (DataRow fila in resultado.Rows)
            {
                comboBoxTipoRegimen.Items.Add(fila["DESCRIPCION"].ToString());

            }


            query = String.Format(
               "SELECT  DISTINCT" +
              "  [AVENGERS].[TIPO_HABITACION].DESCRIPCION  " +
               " FROM [AVENGERS].[REGIMEN] , [AVENGERS].[TIPO_HABITACION] ,  " +
               " [AVENGERS].[HOTEL_REGIMEN], [AVENGERS].[HOTEL], [AVENGERS].[HABITACION] " +
               " WHERE " +
               "  [AVENGERS].[REGIMEN].ID = [AVENGERS].[HOTEL_REGIMEN].ID_REGIMEN " +
               " AND [AVENGERS].[HOTEL_REGIMEN].ID_HOTEL = [AVENGERS].[HOTEL].ID " +
               " AND [AVENGERS].[HOTEL].ID = '{0}'",
               SesionLogin.Hotel);

            ConexionDB bd2 = new ConexionDB();
            DataTable resultado2 = bd2.Select(query);

            foreach (DataRow fila in resultado2.Rows)
            {

                comboBoxTipoHabitacion.Items.Add(fila["DESCRIPCION"].ToString());
            }
            comboBoxHotel.Text = SesionLogin.HotelNombre;
            comboBoxHotel.Enabled = false;

        }

        public void consultarHoteles()
        {
            this.regimenesDelHotel( );
        }
    }
}
