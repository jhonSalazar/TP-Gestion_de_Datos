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

/********************EJEMPLO PARA USAR LA CLASE ConexionDB************************/

namespace FrbaHotel
{
    public partial class Form1 : Form
    {
        string consultaRoles = "SELECT [ID],[NOMBRE],[ID_ESTADO] FROM [GD1C2018].[AVENGERS].[ROL] ORDER BY [ID]";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(consultaRoles);

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    textBox1.AppendText(fila["ID"].ToString());
                    textBox1.AppendText(" - ");
                    textBox1.AppendText(fila["NOMBRE"].ToString());
                    textBox1.AppendText("\n");
                }

                dataGridView1.DataSource = resultado;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            var c = new ConexionDB();
            DataTable tabla =  c.Select("select top 10 NOMBRE from [AVENGERS].[CLIENTE]");

            foreach (DataRow row in tabla.Rows)
            {
              Console.WriteLine(row["NOMBRE"].ToString());
            }

        }
 
    }

}
