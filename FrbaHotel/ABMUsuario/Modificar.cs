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
    public partial class Modificar : Form
    {
        public Modificar(string username)
        {
            InitializeComponent();

            Usuario usuario = new Usuario(username);
            CargarDatos(usuario.Id);
            CargarRoles(usuario.Id);
            CargarHoteles(usuario.Id);
            CargarTipoDocu(usuario.Id);
        }

        private void CargarDatos(int p)
        {
            //TODO:
        }

        private void CargarTipoDocu(int userId)
        {
            //TODO:
        }

        private void CargarHoteles(int userId)
        {
            string queryHotel = "SELECT [NOMBRE] FROM [GD1C2018].[AVENGERS].[HOTEL] WHERE ESTADO = 1";
            ConexionDB db = new ConexionDB();
            DataTable resultadoH = db.Select(queryHotel);

            if (resultadoH != null)
                foreach (DataRow fila in resultadoH.Rows)
                {
                    checkedListBoxRoles.Items.Add(fila["NOMBRE"].ToString(), PerteneceHotelAUsuario(userId, fila["NOMBRE"].ToString()));
                }
        }

        private CheckState PerteneceHotelAUsuario(int p1, string p2)
        {
            //TODO:
            return CheckState.Unchecked;
        }

        private void CargarRoles(int userId)
        {
            string queryRool = "SELECT [NOMBRE] FROM [GD1C2018].[AVENGERS].[ROL] WHERE ID_ESTADO = 1";
            ConexionDB db = new ConexionDB();
            DataTable resultadoF = db.Select(queryRool);

            if (resultadoF != null)
                foreach (DataRow fila in resultadoF.Rows)
                {
                    checkedListBoxRoles.Items.Add(fila["NOMBRE"].ToString(), PerteneceRolAUsuario(userId, fila["NOMBRE"].ToString()));
                }
        }

        private CheckState PerteneceRolAUsuario(int userId, string rol)
        {
            string query = String.Format(@"SELECT * FROM [AVENGERS].[USUARIO_ROL] UR
INNER JOIN AVENGERS.ROL R ON UR.ID_ROL = R.ID
WHERE UR.ID_USUARIO = {0} AND R.NOMBRE = '{1}'", userId, rol);
            ConexionDB dbUR = new ConexionDB();
            DataTable resultadoUR = dbUR.Select(query);
            if (resultadoUR.Rows.Count > 0)
            {
                return CheckState.Checked;
            }
            return CheckState.Unchecked;
        }

        private void buttonElegirFecha_Click(object sender, EventArgs e)
        {
            monthCalendarFechaNacimiento.Visible = true;
        }

        private void monthCalendarFechaNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendarFechaNacimiento.Visible = false;

            textBoxFechaNacimiento.Text = monthCalendarFechaNacimiento.SelectionStart.ToShortDateString();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private bool ValidarCampos()
        {
            //Chequeo los datos personales
            foreach (Control control in this.groupBoxDatosUser.Controls)
                if (control is TextBox)
                    if (string.IsNullOrWhiteSpace((control as TextBox).Text))
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                        return false;
                    }
            //Chequeo los datos de usuario
            foreach (Control control in this.groupBoxDatosPersonales.Controls)
                if (control is TextBox)
                    if (string.IsNullOrWhiteSpace((control as TextBox).Text))
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                        return false;
                    }

            //Chequeo roles y hoteles, al menos uno seleccionado de cada uno
            if (checkedListBoxRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un rol.");
                return false;
            }
            if (checkedListBoxHoteles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un Hotel.");
                return false;
            }
            //si todo ok entonces:
            return true;
        }
    }
}
