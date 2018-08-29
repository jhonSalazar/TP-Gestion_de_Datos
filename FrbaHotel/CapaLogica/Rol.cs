using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.CapaLogica
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

        public Rol(string nombreRol)
        {
            string query = String.Format(@"SELECT ID, ID_ESTADO FROM AVENGERS.ROL WHERE NOMBRE = '{0}'",nombreRol);
            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(query);

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    Estado = int.Parse(fila["ID_ESTADO"].ToString());
                    Id = int.Parse(fila["ID"].ToString());
                    Nombre = nombreRol;
                }
            }
        }
    }
}
