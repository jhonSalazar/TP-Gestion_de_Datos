using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Login
{
    class Login
    {
        public static bool Autenticar(string username, string password)
        {
            string hash = SeguridadLogin.EncriptarPassword(string.Concat(username, password));
            string queryUsuario = string.Format(@"SELECT COUNT(*) FROM [AVENGERS].[USUARIO] WHERE [USERNAME] = '{0}' AND [PASSWORD] = '{1}'",username, hash);

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBDHotelFrba"].ToString()))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(queryUsuario, conn);
                command.Parameters.AddWithValue("@nombre", username);

                //string hash = Helper.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", hash);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
