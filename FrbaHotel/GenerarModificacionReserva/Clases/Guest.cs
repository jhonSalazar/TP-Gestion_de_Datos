using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.GenerarModificacionReserva.Clases
{
    class Guest : TipoUsuario
    {
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.ComboBox comboBoxTipoRegimen;
        private System.Windows.Forms.ComboBox comboBoxTipoHabitacion;

        public Guest(System.Windows.Forms.ComboBox comboBoxHotel, System.Windows.Forms.ComboBox comboBoxTipoRegimen, System.Windows.Forms.ComboBox comboBoxTipoHabitacion)
        {
            // TODO: Complete member initialization
            this.comboBoxHotel = comboBoxHotel;
            this.comboBoxTipoRegimen = comboBoxTipoRegimen;
            this.comboBoxTipoHabitacion = comboBoxTipoHabitacion;
        }


        public void consultarHoteles()
        {
            String queryHotel = string.Format(" SELECT DISTINCT  NOMBRE FROM [AVENGERS].[HOTEL]");
            ConexionDB bd = new ConexionDB();
            DataTable resultadoHotel = bd.Select(queryHotel);


            foreach (DataRow fila in resultadoHotel.Rows)
            {
                comboBoxHotel.Items.Add(fila["NOMBRE"].ToString());            
            }


            String queryrRegimen = string.Format(" SELECT DISTINCT DESCRIPCION FROM [AVENGERS].[REGIMEN]");
            
            DataTable resultadoRegimen = bd.Select(queryrRegimen);
            foreach (DataRow fila in resultadoRegimen.Rows)
            {
                comboBoxTipoRegimen.Items.Add(fila["DESCRIPCION"].ToString());
            }

            String queryrTipoHabitacion = string.Format(" SELECT DISTINCT DESCRIPCION FROM [AVENGERS].[TIPO_HABITACION]");
            
            DataTable resultadoHabitacion = bd.Select(queryrTipoHabitacion);
            foreach (DataRow fila in resultadoHabitacion.Rows)
            {
                comboBoxTipoHabitacion.Items.Add(fila["DESCRIPCION"].ToString());
            }



        }
    }
}
