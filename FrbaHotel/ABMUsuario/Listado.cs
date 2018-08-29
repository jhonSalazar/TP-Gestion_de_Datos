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

namespace FrbaHotel.ABMUsuario
{
    public partial class Listado : Form
    {
        string queryUsuarios = "SELECT U.[USERNAME] AS USERNAME, U.MAIL, U.NOMBRE, U.APELLIDO,E.DESCRIPCION AS ESTADO FROM [AVENGERS].USUARIO U INNER JOIN AVENGERS.ESTADO E ON U.ESTADO = E.ID ";
        string condicionUsername = "";

        public Listado()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControls();
        }

        private void LimpiarControls()
        {
            ClearTextBoxes();
            dataGridViewUsuarios.Rows.Clear();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(textBoxUsername.Text)) condicionUsername = " WHERE [USERNAME] LIKE '%" + textBoxUsername.Text + "%'";

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(queryUsuarios + condicionUsername);

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    dataGridViewUsuarios.Rows.Add(
                        fila["USERNAME"].ToString(),
                        fila["MAIL"].ToString(),
                        fila["NOMBRE"].ToString(),
                        fila["APELLIDO"].ToString(),
                        fila["ESTADO"],
                        "Dar Baja",
                        "Modificar");
                }
            }
        }
        
        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {
            ABMUsuario.Alta altaRol = new Alta();
            altaRol.Show();
        }

        private void dataGridViewUsuarios_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            String LinkLabel = "";
            LinkLabel = dataGridViewUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (e.RowIndex != -1)
            {
                if (LinkLabel.Equals("Dar Baja"))
                {
                    string username = dataGridViewUsuarios.Rows[e.RowIndex].Cells["ColumnUsername"].Value.ToString();

                    

                    DialogResult dialogResult = MessageBox.Show(String.Format("Se eliminará el rol: {0}. Confirma?", username), "Atento", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string resultadoUp = Usuario.DarBaja(username);

                        if (resultadoUp == "OK")
                        {
                            MessageBox.Show(String.Format("Se eliminó el usuario: ", username));
                        }
                        else
                        {
                            MessageBox.Show("Algo salió mal. No se eliminó el usuario");
                        }
                    }
                    else if (dialogResult == DialogResult.No) { }
                }

                if (LinkLabel.Equals("Modificar"))
                {
                    string username = dataGridViewUsuarios.Rows[e.RowIndex].Cells["ColumnUsername"].Value.ToString();
                    
                    ABMUsuario.Modificar modificarUsuario = new Modificar(username);
                    modificarUsuario.Show();
                }
            }
        }
    }
}
