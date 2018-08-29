using FrbaHotel.CapaDatos;
using FrbaHotel.Login;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            toolFooter.Text = "Usuario: " + SesionLogin.Username + " - Hotel: " + SesionLogin.HotelNombre;

            // Creacion de los menu en forma dinamica, segun el rol
            this.IsMdiContainer = true;
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem menuPadre = new ToolStripMenuItem("Menus");

            string queryFuncion = string.Format("SELECT [ID_FUNCIONALIDAD], F.DESCRIPCION FROM [AVENGERS].[ROL_FUNCIONALIDAD] RF INNER JOIN [AVENGERS].[FUNCIONALIDAD] F ON RF.ID_FUNCIONALIDAD = F.ID WHERE F.ID_ESTADO = 1 AND RF.ID_ROL = {0}", SesionLogin.Rol);

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(queryFuncion);

            if (resultado != null)
            {
                //agrego las funcionalidades que tiene asignadas el rol y que estan habilitadas
                foreach (DataRow fila in resultado.Rows)
                {
                    string nombreMenu = fila["DESCRIPCION"].ToString();
                    ToolStripMenuItem menuHijo = new ToolStripMenuItem(nombreMenu, null, new EventHandler(menuFuncion_Click)); //TODO: redericcionar al form elegido
                    menuPadre.DropDownItems.Add(menuHijo);
                }
            }

            ((ToolStripDropDownMenu)(menuPadre.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menuPadre.DropDown)).ShowCheckMargin = true;
            ms.MdiWindowListItem = menuPadre;
            ms.Items.Add(menuPadre);
            ms.Dock = DockStyle.Top;
            this.MainMenuStrip = ms;
            this.Controls.Add(ms);
        }

        private void menuFuncion_Click(object sender, EventArgs e) 
        {
            //ABMUsuario.Alta frm = new ABMUsuario.Alta();
            //frm.Show();

            String queryWinForm = "SELECT [WINFORM] FROM [GD1C2018].[AVENGERS].[FUNCIONALIDAD] WHERE [ID_ESTADO] = 1 AND [DESCRIPCION] = '" + sender.ToString() + "'";

    ConexionDB dbMenu = new ConexionDB();
    DataTable dtransaction = dbMenu.Select(queryWinForm);

    Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);

    foreach (Type type in frmAssembly.GetTypes())

    {

       // MessageBox.Show(type.Name);

        if (type.BaseType == typeof(Form))

        {

            if (type.FullName == string.Concat("FrbaHotel.",dtransaction.Rows[0][0].ToString()))

            {

                Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());

                // then we  close all of the child Forms with  simple below code

 

                foreach (Form form in this.MdiChildren)

                {

                    form.Close();

                }

 

                frmShow.MdiParent = this;

                frmShow.WindowState = FormWindowState.Maximized;

                //frmShow.ControlBox = false;

                frmShow.Show();

            }

        }

    }
        }
    }
}
