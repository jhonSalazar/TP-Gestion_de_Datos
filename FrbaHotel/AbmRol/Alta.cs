using FrbaHotel.CapaDatos;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            CargarFuncionalidades();
        }

        private void CargarFuncionalidades()
        {
            string queryFunc = "SELECT [DESCRIPCION] FROM [AVENGERS].[FUNCIONALIDAD] WHERE [ID_ESTADO] = 1";
            ConexionDB db = new ConexionDB();
            DataTable resultadoF = db.Select(queryFunc);

            if(resultadoF != null)
                foreach (DataRow fila in resultadoF.Rows)
                {
                    checkedListBoxFuncionalidadesRol.Items.Add(fila["DESCRIPCION"].ToString());
                }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreRol.Text = "";
            checkBoxRolHabilitado.Checked = false;
            foreach (int i in checkedListBoxFuncionalidadesRol.CheckedIndices)
            {
                checkedListBoxFuncionalidadesRol.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int estadoRol = 2; //desahilitado por defecto
                if (checkBoxRolHabilitado.Checked) estadoRol = 1;

                string queryNuevoRol = String.Format(@"INSERT INTO [AVENGERS].[ROL] VALUES ('{0}',{1})", textBoxNombreRol.Text, estadoRol);

                ConexionDB dbRol = new ConexionDB();
                string resultado = dbRol.InsertUpdateDelete(queryNuevoRol);
                if (resultado == "OK")
                {
                    InsertarFuncionalidades(textBoxNombreRol.Text);
                    MessageBox.Show("Alta de Rol exitosa");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el rol.");
                }
            }
        }

        private void InsertarFuncionalidades(string nombreRol)
        {
            int idRol = 0;
            int idFunc = 0;
            string queryIdRol = String.Format(@"SELECT [ID] FROM [GD1C2018].[AVENGERS].[ROL] WHERE [NOMBRE] = '{0}'",nombreRol);
            ConexionDB db = new ConexionDB();
            DataTable resultadoR = db.Select(queryIdRol);
            foreach (DataRow filaR in resultadoR.Rows)
            {
                idRol = int.Parse(filaR["ID"].ToString());
            }
            
            foreach (int i in checkedListBoxFuncionalidadesRol.CheckedIndices)
            {
                if (checkedListBoxFuncionalidadesRol.GetItemChecked(i))
                {
                    string func = checkedListBoxFuncionalidadesRol.Items[i].ToString();
                    string queryIdFunc = String.Format(@"SELECT ID FROM [AVENGERS].[FUNCIONALIDAD] WHERE DESCRIPCION = '{0}'", func);
                    ConexionDB dbFunc = new ConexionDB();
                    DataTable resultadoF = db.Select(queryIdFunc);
                    foreach (DataRow filaF in resultadoF.Rows)
                    {
                        idFunc = int.Parse(filaF["ID"].ToString());
                    }
                    ConexionDB dbFuncRol = new ConexionDB();
                    string queryRolFunc = String.Format(@"INSERT INTO [AVENGERS].[ROL_FUNCIONALIDAD] VALUES ({0},{1})", idRol, idFunc);
                    string resutladoInsert = dbFuncRol.InsertUpdateDelete(queryRolFunc);
                }
            }

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreRol.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }
            if (checkedListBoxFuncionalidadesRol.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una funcionalidad");
                return false;
            }
            //chequeo si existe un rol con ese nombre
            string queryRol = String.Format(@"SELECT COUNT(*) FROM [GD1C2018].[AVENGERS].[ROL] WHERE [NOMBRE] = '{0}'", textBoxNombreRol.Text);
            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(queryRol);
            if (resultado != null)
            {
                MessageBox.Show("Ya existe un rol con ese nombre. Pruebe con otro.");
                return false;
            }
            //Si todo esta ok:
            return true;
        }
    }
}
