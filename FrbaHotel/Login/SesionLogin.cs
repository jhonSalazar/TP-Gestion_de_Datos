using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Login
{
    public static class SesionLogin
    {
        public static int Id { get; set; }
        public static int IntentosLogin { get; set; }
        public static int Rol { get; set; }
        public static String Username { get; set; }
        public static String Estado { get; set; }
        public static int Hotel { get; set; }
        public static string HotelNombre { get; set; } //El hotel se guarda en el segundo logIn

        public static void CargarUsuario(string username)
        {
            string query = string.Format("SELECT ID, ESTADO,INTENTOS_LOGIN FROM AVENGERS.USUARIO WHERE USERNAME = '{0}'", username);
            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(query);
            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    Id = int.Parse(fila["ID"].ToString());
                    Estado = fila["ESTADO"].ToString();
                    IntentosLogin = int.Parse(fila["INTENTOS_LOGIN"].ToString());
                    Username = username;
                    HotelNombre = ""; //si es cliente no tiene hotel
                }
            }
        }

        public static void BloquearUsuario()
        {
            string update = String.Format("UPDATE [AVENGERS].[USUARIO] SET [ESTADO] = 2 WHERE [ID] = '{0}'", Id);
            ConexionDB dbUp = new ConexionDB();
            string resultadoUp = dbUp.InsertUpdateDelete(update);
        }

        public static void ResetearIntentos()
        {
            IntentosLogin = 0;
            string update = String.Format("UPDATE [AVENGERS].[USUARIO] SET [INTENTOS_LOGIN] = 0 WHERE [ID] = '{0}'", Id);
            ConexionDB dbUp = new ConexionDB();
            string resultadoUp = dbUp.InsertUpdateDelete(update);
        }

        public static void IncrementarIntentos()
        {
            IntentosLogin++;
            string update = String.Format("UPDATE [AVENGERS].[USUARIO] SET [INTENTOS_LOGIN] = {0} WHERE [ID] = '{1}'",IntentosLogin, Id);
            ConexionDB dbUp = new ConexionDB();
            string resultadoUp = dbUp.InsertUpdateDelete(update);
        }

        public static int id { get; set; }
    }
}
