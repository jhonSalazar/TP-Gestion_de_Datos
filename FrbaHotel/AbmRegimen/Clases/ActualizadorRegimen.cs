using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen.Clases
{
    class ActualizadorRegimen
    {
        private String id;
        private String textDescripcion;
        private String textBoxPrecio;
        public ActualizadorRegimen(String _id)
        {
            id = _id;
        }

        public ActualizadorRegimen(String _textCodigo,
                                   String _textDescripcion,      
                                   String _textBoxPrecio)
        {
            id = _textCodigo;
            textDescripcion = _textDescripcion;
            textBoxPrecio = _textBoxPrecio;
        }


        public void actualizar()
        {
            String query = this.armarQueryUpdate();
            update(query);
        }

        public void update(String query)
        {
            ConexionDB bd = new ConexionDB();
            String resultado = bd.InsertUpdateDelete(query);
            MessageBox.Show("Se actualizó exitosamente  Codigo::" + id + 
                            " Estado = " + resultado
                            ,"Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void darBaja()
        {
            String query = this.armarQueryBaja();
            update(query);
        }

        private String armarQueryBaja()
        {
            String queryInsert = String.Format("UPDATE  [AVENGERS].[REGIMEN] " +
                                         "SET  [AVENGERS].[REGIMEN].[ESTADO]=2 " +
                                         "FROM [AVENGERS].[REGIMEN] " +
                                         "WHERE [AVENGERS].[REGIMEN].ID ='{0}' ", id);
            return queryInsert;
        }

        private String armarQueryUpdate()
        {
            string queryInsert =
           string.Format("UPDATE  [AVENGERS].[REGIMEN] " +" SET DESCRIPCION = '{0}'," +
                         "PRECIO = '{1}' " +"FROM [AVENGERS].[REGIMEN] " +
                          " WHERE[AVENGERS].[REGIMEN].ID = '{2}' ",
                           textDescripcion, textBoxPrecio, id);
            return queryInsert;
        }

    }
}
