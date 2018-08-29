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
    public partial class ConsumiblesFacturados : Form
    {

        string query = "SELECT * FROM  AVENGERS.VW_HOTEL_CONSUMIBLES_FACTURADOS ";

        public ConsumiblesFacturados()
        {
            InitializeComponent();

            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(query);

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    dataGridView1.Rows.Add(
                        fila["NOMBRE"].ToString()
                        );
                }
            }
        }
    }
}
