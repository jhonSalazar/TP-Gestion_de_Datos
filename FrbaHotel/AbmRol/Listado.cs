using FrbaHotel.CapaDatos;
using FrbaHotel.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class Listado : Form
    {
        string queryRoles = "SELECT R.[NOMBRE] AS ROL,E.DESCRIPCION AS ESTADO FROM [AVENGERS].[ROL] R INNER JOIN AVENGERS.ESTADO E ON R.ID_ESTADO = E.ID ";
        string condicionNombre = "";

        public Listado()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreRol.Text = "";
            dataGridViewRoles.Rows.Clear();
            condicionNombre = "";
        }

        private void buttonNuevoRol_Click(object sender, EventArgs e)
        {
            AbmRol.Alta altaRol = new Alta();
            altaRol.Show();
        }
        
        private void buttonBuscarClick(object sender, EventArgs e)
        {
            dataGridViewRoles.Rows.Clear();
            if (textBoxNombreRol.Text != "") condicionNombre = " WHERE [NOMBRE] LIKE '%" + textBoxNombreRol.Text + "%'";

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(queryRoles + condicionNombre);

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    dataGridViewRoles.Rows.Add(
                        fila["ROL"].ToString(),
                        fila["ESTADO"],
                        "Dar Baja",
                        "Modificar");
                }
            }
        }

        private void dataGridViewRoles_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            String LinkLabel = "";
            LinkLabel = dataGridViewRoles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (e.RowIndex != -1)
            {
                if (LinkLabel.Equals("Dar Baja"))
                {
                    string rol = dataGridViewRoles.Rows[e.RowIndex].Cells["ColumnRol"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show(String.Format("Se eliminará el rol: {0}. Confirma?",rol), "Atento", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string update = String.Format("UPDATE [AVENGERS].[ROL] SET [ID_ESTADO] = 2 WHERE [NOMBRE] = '{0}'",rol);
                        ConexionDB dbUp = new ConexionDB();
                        string resultadoUp = dbUp.InsertUpdateDelete(update);
                        if(resultadoUp == "OK") MessageBox.Show(String.Format("Se eliminó el rol: ", rol));
                    }
                    else if (dialogResult == DialogResult.No) { }
                }

                if (LinkLabel.Equals("Modificar"))
                {
                    string nombreRol = dataGridViewRoles.Rows[e.RowIndex].Cells["ColumnRol"].Value.ToString();
                    Rol rol = new Rol(nombreRol);

                    AbmRol.Modificar modificarRol = new Modificar(rol);
                    modificarRol.Show();
                }
            }
        }
    }
}
