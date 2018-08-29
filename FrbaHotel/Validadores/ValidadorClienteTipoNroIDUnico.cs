using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.AbmHabitacion.Clases;
using System.Windows.Forms;
using FrbaHotel.CapaDatos;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace FrbaHotel.Validadores
{
    class ValidadorClienteTipoNroIDUnico : Validador, Validaciones
    {
        private TextBox txtCliente_NroID;
        private ComboBox cmbCliente_TipoID;
        private Label labelID;

        public ValidadorClienteTipoNroIDUnico()
        {
            txtCliente_NroID = new TextBox();
            cmbCliente_TipoID = new ComboBox();
        }

        public bool validar()
        {
            return this.validarEmailUnico();
        }

        public Boolean validarEmailUnico()
        {
            String query;
            if (!string.IsNullOrEmpty(txtCliente_NroID.Text) && !string.IsNullOrEmpty(cmbCliente_TipoID.Text))
            {
                ConexionDB bd = new ConexionDB();
                query = this.armarQuery();
                DataTable resultado = bd.Select(query);

                if (resultado.Rows.Count > 0)
                {
                    labelID.Text = "Ya existe un Cliente Tipo de id: " + cmbCliente_TipoID.Text + " y Número de identificación: " + txtCliente_NroID.Text;
                    labelID.ForeColor = System.Drawing.Color.Red;
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public String armarQuery()
        {
            String query = String.Format("SELECT ID FROM AVENGERS.CLIENTE WHERE TIPO_ID = '{0}' AND NUMERO_ID = '{1}'", cmbCliente_TipoID.Text, txtCliente_NroID.Text);
            return query;
        }

        public void agregarTipoID(ComboBox _cmbCliente_TipoID)
        {
            cmbCliente_TipoID = _cmbCliente_TipoID;
        }

        public void agregarNroID(TextBox _txtCliente_NroID)
        {
            txtCliente_NroID = _txtCliente_NroID;
        }

        public void agregarLabel(Label _labelID)
        {
            this.labelID = _labelID;
        }

        public void limpiarLabel()
        {
            labelID.Text = "";
        }

        public void limpiar()
        {
            txtCliente_NroID.Clear();
            cmbCliente_TipoID.Text = "";
            AvisoTextBoxs(Color.White, textBoxs);
        }


    }
}
