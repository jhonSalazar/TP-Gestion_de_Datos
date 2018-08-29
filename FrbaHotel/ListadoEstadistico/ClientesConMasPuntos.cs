using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ClientesConMasPuntos : Form
    {
        string where = "";
        int puntos = 0;
        double totalEstadia = 0, totalConsumibles = 0;
        

        public ClientesConMasPuntos(string anio, string trimestre)
        {
            InitializeComponent();

            where = String.Format(@" WHERE YEAR(FECHA) = {0} ",anio);

            if (trimestre == "1")
            {
                where += " AND MONTH(FECHA) BETWEEN 01 AND 03 ";
            }
            if (trimestre == "2")
            {
                where += " AND MONTH(FECHA) BETWEEN 04 AND 06 ";
            }
            if (trimestre == "3")
            {
                where += " AND MONTH(FECHA) BETWEEN 07 AND 09 ";
            }
            if (trimestre == "4")
            {
                where += " AND MONTH(FECHA) BETWEEN 10 AND 12 ";
            }


            string query = String.Format(@"SELECT TOP 5 [ID_CLIENTE]
      ,[NOMBRE_CLIENTE]
      ,SUM([TOTAL_ESTADIA]) 'TOTAL_ESTADIA'
      ,SUM([TOTAL_CONSUMIBLES]) 'TOTAL_CONSUMIBLES'
  FROM [GD1C2018].[AVENGERS].[VW_CLIENTE_TOP]
  {0}
  GROUP BY MONTH(FECHA), ID_CLIENTE,[NOMBRE_CLIENTE]
  ORDER BY TOTAL_ESTADIA DESC, TOTAL_CONSUMIBLES DESC", where);
            
            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(query);


            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    totalEstadia = double.Parse(fila["TOTAL_ESTADIA"].ToString());
                    totalConsumibles = double.Parse(fila["TOTAL_CONSUMIBLES"].ToString());
                    puntos = 0;

                    double montoEstadia = 20, montoConsumible = 10;
                    while (montoEstadia <= totalEstadia)
                    {
                        puntos++;
                        montoEstadia += 20;
                    }
                    while (montoConsumible <= totalConsumibles)
                    {
                        puntos++;
                        montoConsumible += 10;
                    }

                    dataGridView1.Rows.Add(
                        fila["ID_CLIENTE"].ToString(),
                        fila["NOMBRE_CLIENTE"].ToString(),
                        puntos.ToString()
                        );
                }
            }
        }
    }
}
