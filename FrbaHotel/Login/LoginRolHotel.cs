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

namespace FrbaHotel.Login
{
    public partial class LoginRolHotel : Form
    {
        string consultaRoles = "SELECT UR.ID_USUARIO, [ID_ROL], R.NOMBRE AS NOMBREROL " +
                                "FROM [AVENGERS].[USUARIO_ROL] UR " +
                                "INNER JOIN AVENGERS.USUARIO U ON UR.ID_USUARIO = U.ID " +
                                "INNER JOIN [AVENGERS].[ROL] R ON UR.ID_ROL = R.ID " +
                                "WHERE u.USERNAME = '" + SesionLogin.Username + "' AND R.ID_ESTADO = 1 ";

        string consultaHoteles = "SELECT UH.ID_USUARIO, [ID_HOTEL], H.NOMBRE AS NOMBREHOTEL " +
                                 "FROM [GD1C2018].[AVENGERS].[USUARIO_HOTEL] UH " +
                                 "INNER JOIN AVENGERS.USUARIO U ON UH.ID_USUARIO = U.ID " +
                                 "INNER JOIN [AVENGERS].HOTEL H ON UH.ID_HOTEL = H.ID " +
                                 "WHERE U.USERNAME = '" + SesionLogin.Username + "' AND H.ESTADO = 1 ";

        public LoginRolHotel()
        {
            InitializeComponent();

            ConexionDB bd = new ConexionDB();
            DataTable resultadoRoles = bd.Select(consultaRoles);
            if (resultadoRoles != null)
            {
                
                comboBoxRoles.ValueMember = resultadoRoles.Columns["ID_ROL"].ToString();
                comboBoxRoles.DisplayMember = resultadoRoles.Columns["NOMBREROL"].ToString();
                comboBoxRoles.DataSource = resultadoRoles;
            }

            ConexionDB bdHotel = new ConexionDB();
            DataTable resultadoHoteles = bdHotel.Select(consultaHoteles);
            if (resultadoHoteles != null)
            {
                
                comboBoxHoteles.ValueMember = resultadoHoteles.Columns["ID_HOTEL"].ToString();
                comboBoxHoteles.DisplayMember = resultadoHoteles.Columns["NOMBREHOTEL"].ToString();
                comboBoxHoteles.DataSource = resultadoHoteles;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            /*TODO: grabar en sesion rol y hotel*/
            SesionLogin.Rol = int.Parse(comboBoxRoles.SelectedValue.ToString());
            SesionLogin.Hotel = int.Parse(comboBoxHoteles.SelectedValue.ToString());
            SesionLogin.HotelNombre = comboBoxHoteles.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
