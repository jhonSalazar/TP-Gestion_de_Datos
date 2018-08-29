using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FrbaHotel.CapaDatos;
using System.Data;

namespace FrbaHotel.AbmHabitacion.Clases
{
    class Actualizador
    {

        private String textNumeroHabitacion;
        private String textPiso;
        private String comboBoxUbicacion;
        private String comboBoxTipoDeHabitacion;
        private String textBoxDescripción;
        private String id;

        public Actualizador(String _id)
        {
            this.id = _id;
        }

        public Actualizador(      String _textNumeroHabitacion,
                                  String _textPiso,
                                  String _comboBoxUbicacion,
                                  String _comboBoxTipoDeHabitacion,
                                  String _textBoxDescripción,
                                  String _id)
        {
            this.textNumeroHabitacion = _textNumeroHabitacion;
            this.textPiso = _textPiso;
            this.comboBoxUbicacion = _comboBoxUbicacion;
            this.comboBoxTipoDeHabitacion = _comboBoxTipoDeHabitacion;
            this.textBoxDescripción = _textBoxDescripción;
            this.id = _id;
        }
        public void actualizar()
        {
            String query = this.armarQueryInsert();
            update(query);
        }

        public void update(String query)
        {
            ConexionDB bd = new ConexionDB();
            String resultado = bd.InsertUpdateDelete(query);
            MessageBox.Show("Se actualizó exitosamente la Habitacion Nro::" + textNumeroHabitacion + " Estado = " + resultado
                         , "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        public void darBaja()
        {
            String query = this.armarQueryBaja();
            update(query);
        }

        private String  armarQueryBaja()
        {
            String queryInsert = String.Format("UPDATE  [AVENGERS].[HABITACION] " +
                                         "SET  [AVENGERS].[HABITACION].[ESTADO]=2 " +
                                         "FROM [AVENGERS].HABITACION "+
                                         "WHERE [AVENGERS].[HABITACION].ID ='{0}' ",id);
            return queryInsert;
        }

        private String armarQueryInsert()
        {  
            string queryInsert = string.
                                 Format("UPDATE  [AVENGERS].[HABITACION]" +
                                         "SET PISO = '{0}',"+
                                         "TIPO = [AVENGERS].[TIPO_HABITACION].ID ," +
                                         "DESCRIPCION = '{2}',"+
                                         "FRENTE = '{3}',"+
                                         "ESTADO ='{4}'"+
                                         "FROM [AVENGERS].[HABITACION], [AVENGERS].[TIPO_HABITACION] " +
                                         "WHERE HABITACION.ID = '{5}' "+
                                         "AND [AVENGERS].[TIPO_HABITACION].DESCRIPCION ='{6}' ", 
                                          textPiso,
                                          1003,
                                          comboBoxTipoDeHabitacion,
                                          comboBoxUbicacion,
                                          2,
                                          id,
                                          comboBoxTipoDeHabitacion);
            return queryInsert;
        }

        
    }
}
