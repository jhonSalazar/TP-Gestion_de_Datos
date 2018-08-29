using FrbaHotel.CapaDatos;
using FrbaHotel.CapaLogica;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrbaHotel.ABMUsuario
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            CargarRoles();
            CargarHoteles();
            CargarTipoDocu();
        }

        private void CargarTipoDocu()
        {
            comboBoxTipoDocu.Items.Add("DNI");
            comboBoxTipoDocu.Items.Add("Pasaporte");
        }

        private void CargarRoles()
        {
            string queryRoles = "SELECT [NOMBRE] FROM [AVENGERS].[ROL] WHERE [ID_ESTADO] = 1";
            ConexionDB dbR = new ConexionDB();
            DataTable resultadoR = dbR.Select(queryRoles);

            if (resultadoR != null)
                foreach (DataRow fila in resultadoR.Rows)
                {
                    checkedListBoxRoles.Items.Add(fila["NOMBRE"].ToString());
                }
        }

        private void CargarHoteles()
        {
            string queryHoteles = "SELECT [NOMBRE] FROM [GD1C2018].[AVENGERS].[HOTEL] WHERE [ESTADO] = 1";
            ConexionDB dbH = new ConexionDB();
            DataTable resultadoH = dbH.Select(queryHoteles);

            if (resultadoH != null)
                foreach (DataRow fila in resultadoH.Rows)
                {
                    checkedListBoxHoteles.Items.Add(fila["NOMBRE"].ToString());
                }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControls();
        }

        private void LimpiarControls()
        {
            ClearTextBoxes();
            foreach (int i in checkedListBoxRoles.CheckedIndices)
            {
                checkedListBoxRoles.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in checkedListBoxHoteles.CheckedIndices)
            {
                checkedListBoxHoteles.SetItemCheckState(i, CheckState.Unchecked);
            }
            comboBoxTipoDocu.SelectedIndex = -1;
            checkBoxHabilitado.CheckState = CheckState.Unchecked;
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

        private void buttonFechaNac_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuarioNuevo = new Usuario();
                usuarioNuevo.Username = textBoxUsername.Text;
                usuarioNuevo.Password = textBoxPassword.Text;
                usuarioNuevo.Nombre = textBoxNombre.Text;
                usuarioNuevo.Apellido = textBoxApellido.Text;
                usuarioNuevo.Mail = textBoxMail.Text;
                usuarioNuevo.Telefono = textBoxTelefono.Text;
                usuarioNuevo.TipoDocu = comboBoxTipoDocu.Text;
                usuarioNuevo.NumeroDocu = textBoxNumeroDocu.Text;
                usuarioNuevo.Direccion = textBoxDireccion.Text;
                usuarioNuevo.FechaNacimiento = Convert.ToDateTime(textBoxFechaNac.Text);
                if (checkBoxHabilitado.Checked) usuarioNuevo.Estado = 1; else usuarioNuevo.Estado = 2;

                string resultado = Usuario.Insert(usuarioNuevo);

                if (resultado == "OK")
                {
                    MessageBox.Show("Se guardo el usuario.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se completo el guardado. El username, mail o documento pueden ya existir en la base");
                }
            }
        }

        private bool ValidarCampos()
        {
            //Chequeo los datos personales
                foreach (Control control in this.groupBox1.Controls)
                    if (control is TextBox)
                        if (string.IsNullOrWhiteSpace((control as TextBox).Text))
                        {
                            MessageBox.Show("Debe completar todos los campos.");
                            return false;
                        }
                //Chequeo los datos de usuario
                foreach (Control control in this.groupBox2.Controls)
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
        
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;

            textBoxFechaNac.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
