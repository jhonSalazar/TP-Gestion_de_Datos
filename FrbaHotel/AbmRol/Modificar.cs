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
    public partial class Modificar : Form
    {
        int rolID;
        public Modificar(Rol rol)
        {
            rolID = rol.Id;
            InitializeComponent();
            CargarFuncionalidades(rol.Nombre);
            textBoxNombreRol.Text = rol.Nombre;
            checkBoxRolHabilitado.Checked = rol.Estado == 1;
        }

        private void CargarFuncionalidades(string nomRol)
        {
            string queryFunc = "SELECT [DESCRIPCION] FROM [AVENGERS].[FUNCIONALIDAD] WHERE [ID_ESTADO] = 1";
            ConexionDB db = new ConexionDB();
            DataTable resultadoF = db.Select(queryFunc);

            if (resultadoF != null)
                foreach (DataRow fila in resultadoF.Rows)
                {
                    checkedListBoxFuncionalidadesRol.Items.Add(fila["DESCRIPCION"].ToString(), PerteneceAlRol(rolID, fila["DESCRIPCION"].ToString()));
                }
        }

        private CheckState PerteneceAlRol(int idRol, string func)
        {
            string query = String.Format(@"SELECT F.DESCRIPCION FROM [GD1C2018].[AVENGERS].[ROL_FUNCIONALIDAD] RF
INNER JOIN AVENGERS.FUNCIONALIDAD F ON RF.ID_FUNCIONALIDAD = F.ID
WHERE RF.ID_ROL = {0} AND F.DESCRIPCION = '{1}'", idRol, func);
            ConexionDB dbRF = new ConexionDB();
            DataTable resultadoRF = dbRF.Select(query);
            if (resultadoRF.Rows.Count > 0)
            {
                return CheckState.Checked;
            }
            return CheckState.Unchecked;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            int estadoRol = 2; //desahilitado por defecto
            if (checkBoxRolHabilitado.Checked) estadoRol = 1;

            string queryNuevoRol = String.Format(@"UPDATE [AVENGERS].[ROL] SET NOMBRE = '{0}', ID_ESTADO = {1} WHERE ID = {2}", textBoxNombreRol.Text, estadoRol,rolID);

            ConexionDB dbRol = new ConexionDB();
            string resultado = dbRol.InsertUpdateDelete(queryNuevoRol);
            if (resultado == "OK")
            {
                ConexionDB dbDel = new ConexionDB();
                string queryDel = String.Format(@"DELETE FROM [AVENGERS].[ROL_FUNCIONALIDAD] WHERE ID_ROL = {0}",rolID);
                InsertarFuncionalidades(textBoxNombreRol.Text);
                MessageBox.Show("Actualizacion de Rol exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el rol.");
            }
        }


        private void InsertarFuncionalidades(string nombreRol)
        {
            int idFunc = 0;

            foreach (int i in checkedListBoxFuncionalidadesRol.CheckedIndices)
            {
                if (checkedListBoxFuncionalidadesRol.GetItemChecked(i))
                {
                    string func = checkedListBoxFuncionalidadesRol.Items[i].ToString();
                    string queryIdFunc = String.Format(@"SELECT ID FROM [AVENGERS].[FUNCIONALIDAD] WHERE DESCRIPCION = '{0}'", func);
                    ConexionDB dbFunc = new ConexionDB();
                    DataTable resultadoF = dbFunc.Select(queryIdFunc);
                    foreach (DataRow filaF in resultadoF.Rows)
                    {
                        idFunc = int.Parse(filaF["ID"].ToString());
                    }
                    ConexionDB dbFuncRol = new ConexionDB();
                    string queryRolFunc = String.Format(@"INSERT INTO [AVENGERS].[ROL_FUNCIONALIDAD] VALUES ({0},{1})", rolID, idFunc);
                    string resutladoInsert = dbFuncRol.InsertUpdateDelete(queryRolFunc);
                }
            }
        }

        private void ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreRol.Text)) MessageBox.Show("Debe ingresar un nombre");
            if (checkedListBoxFuncionalidadesRol.CheckedItems.Count == 0) MessageBox.Show("Debe seleccionar al menos una funcionalidad");
        }
    }
}
