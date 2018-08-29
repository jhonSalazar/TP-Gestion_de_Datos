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
    class ValidadorClienteEmailUnico : Validador, Validaciones
    {
        private TextBox txtCliente_Email;
        private Label labelEmail;

        public ValidadorClienteEmailUnico()
        {
            txtCliente_Email = new TextBox();
        }

        public bool validar()
        {
            return this.validarEmailUnico();
        }

        public Boolean validarEmailUnico()
        {
            String query;
            if (!string.IsNullOrEmpty(txtCliente_Email.Text))
            {
                ConexionDB bd = new ConexionDB();
                query = this.armarQuery();
                DataTable resultado = bd.Select(query);

                if (resultado.Rows.Count > 0)
                {
                    labelEmail.Text = "Ya existe un Cliente con el Mail: " + txtCliente_Email.Text;
                    labelEmail.ForeColor = System.Drawing.Color.Red;
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
            String query = String.Format("SELECT ID FROM AVENGERS.CLIENTE WHERE MAIL = '{0}'", txtCliente_Email.Text);
            return query;
        }

        public void agregarLabel(Label _labelEmail)
        {
            this.labelEmail = _labelEmail;
        }

        public void agregarEmail(TextBox _textEmail)
        {
            txtCliente_Email = _textEmail;
        }

        public void limpiar()
        {
            txtCliente_Email.Clear();
            AvisoTextBoxs(Color.White, textBoxs);
        }


        public void limpiarLabel()
        {
            labelEmail.Text = "";
        }
    }
}
