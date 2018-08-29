using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            SesionLogin.CargarUsuario(username);

            if (SesionLogin.Estado == "1")
            {
            if (Login.Autenticar(username, password))
            {
                
                    SesionLogin.ResetearIntentos();
                    LoginRolHotel frmLoginRH = new LoginRolHotel();
                    frmLoginRH.ShowDialog();

                    if (frmLoginRH.DialogResult == DialogResult.OK)
                        this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show(string.Format("Contraseña incorrecta!"));
                SesionLogin.IncrementarIntentos();
                if (SesionLogin.IntentosLogin > 2)
                {
                    SesionLogin.BloquearUsuario();
                    MessageBox.Show("Demasiados intentos fallidos. Se bloqueó el usuario!");
                }
            }
            }
            else
            {
                MessageBox.Show("Usuario bloqueado.");
            }
            
        }

        private void buttonIngresarGuest_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            /*TODO: grabar guest en sesion*/
            SesionLogin.CargarUsuario("guest");
            SesionLogin.Rol = 3;
        }
    }
}
