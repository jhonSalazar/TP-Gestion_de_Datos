using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel.CapaDatos
{
    class ConexionDB
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionBDHotelFrba"].ConnectionString;
        private SqlConnection cnn;
        private SqlCommand cmd;

        public ConexionDB()
        {
            cnn = new SqlConnection(this.connectionString);
        }

        public string InsertUpdateDelete(string query)
        {
            cnn.Open();
            try
            {
                SqlCommand comando = new SqlCommand(query, cnn);
                comando.ExecuteNonQuery();
                return "OK";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        public DataTable Select(string query)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand(query, cnn);
            SqlDataReader registros = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(registros);
            cnn.Close();
            return tabla;
        }


        // se configura SP
        public void  configurarStoredProcedure(String storedProcedure){

         cmd = new SqlCommand(storedProcedure, cnn);
         cmd.CommandType = CommandType.StoredProcedure;
        
        }


        //// agrega los parametros que de entrada para el stored procedure
        public void agregarParametros(String parametro, SqlDbType tipo, String valor)
        {
            cmd.Parameters.AddWithValue(parametro, tipo).Value = valor;
        }

        // idem pero con el tipo de dato entero (int)
        public void agregarParametros(String parametro, SqlDbType tipo, int valor)
        {
            cmd.Parameters.AddWithValue(parametro, tipo).Value = valor;
           
        } 

        /*Este mpétodo sirve para retorna un Dato de tipo int, se podría sobre-escribir para 
         Tipo String o para que devulva tipo DataTable, depende de lo que se necesite*/
        public int ejecutarStoredProcedure(String campoRetorno, SqlDbType tipo)
        {
            var returnParameter = cmd.Parameters.Add(campoRetorno, tipo);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cnn.Open();
            cmd.ExecuteNonQuery();
            int valorRetorno = (int)returnParameter.Value;
            cnn.Close();
            return valorRetorno;
        }


            
    }
}
