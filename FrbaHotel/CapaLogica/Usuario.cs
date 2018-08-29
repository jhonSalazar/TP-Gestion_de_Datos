using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.CapaLogica
{
    public class Usuario
    {
        public Usuario() { }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocu { get; set; }
        public string NumeroDocu { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IntentosLogin { get; set; }
        public int Estado { get; set; }
        public List<int> Roles { get; set; }

        
        public static string Insert(Usuario usuario)
        {
            string password = Login.SeguridadLogin.EncriptarPassword(string.Concat(usuario.Username, usuario.Password));

            string queryInsert = String.Format(@"INSERT INTO [AVENGERS].[USUARIO]
           ([USERNAME]
           ,[PASSWORD]
           ,[APELLIDO]
           ,[NOMBRE]
           ,[TIPO_DOC]
           ,[NUMERO_DOC]
           ,[MAIL]
           ,[TELEFONO]
           ,[DIRECCION]
           ,[FECHA_NACIMIENTO]
           ,[INTENTOS_LOGIN]
           ,[ESTADO])
     VALUES
           ('{0}'
           ,'{1}'
           ,'{2}'
           ,'{3}'
           ,'{4}'
           ,'{5}'
           ,'{6}'
           ,'{7}'
           ,'{8}'
           ,'{9}'
           ,{10}
           ,{11})",
                                            usuario.Username,
                                            password, //ya encriptada por SHA256
                                            usuario.Apellido,
                                            usuario.Nombre,
                                            usuario.TipoDocu,
                                            usuario.NumeroDocu,
                                            usuario.Mail,
                                            usuario.Telefono,
                                            usuario.Direccion,
                                            usuario.FechaNacimiento.ToString("yyyyMMdd"),
                                            usuario.IntentosLogin = 0,
                                            usuario.Estado);

            ConexionDB bd = new ConexionDB();
            return bd.InsertUpdateDelete(queryInsert);
        }

        public static string DarBaja(string username)
        {
            string queryUp = String.Format(@"UPDATE AVENGERS.USUARIO SET ESTADO = 2 WHERE USERNAME = '{0}'",username);
            ConexionDB bd = new ConexionDB();
            return bd.InsertUpdateDelete(queryUp);
        }

        public Usuario(string username)
        {
            string queryU = String.Format("SELECT [ID],[USERNAME],[APELLIDO],[NOMBRE],[TIPO_DOC],[NUMERO_DOC],[MAIL],[TELEFONO],[DIRECCION],[FECHA_NACIMIENTO],[INTENTOS_LOGIN],[ESTADO] FROM [GD1C2018].[AVENGERS].[USUARIO] WHERE USERNAME = '{0}'", username);
            ConexionDB db = new ConexionDB();
            DataTable resultadoU = db.Select(queryU);

            if (resultadoU != null)
                foreach (DataRow fila in resultadoU.Rows)
                {
                    Id = Convert.ToInt32(fila["ID"].ToString());
                    Username = fila["USERNAME"].ToString();
                    Apellido = fila["APELLIDO"].ToString();
                    Nombre = fila["NOMBRE"].ToString();
                    TipoDocu = fila["TIPO_DOC"].ToString();
                    NumeroDocu = fila["NUMERO_DOC"].ToString();
                    Mail = fila["MAIL"].ToString();
                    Telefono = fila["TELEFONO"].ToString();
                    Direccion = fila["DIRECCION"].ToString();
                    FechaNacimiento = Convert.ToDateTime(fila["FECHA_NACIMIENTO"].ToString());
                    IntentosLogin = Convert.ToInt32(fila["INTENTOS_LOGIN"].ToString());
                    Estado = Convert.ToInt32(fila["ESTADO"].ToString());
                }
        }
    }
}
