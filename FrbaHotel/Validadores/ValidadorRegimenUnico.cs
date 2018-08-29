using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Validadores
{
    class ValidadorRegimenUnico :FrbaHotel.AbmHabitacion.Clases.Validaciones
    {
        private TextBox textRegimen;
        private Label labelRegimen;

        public ValidadorRegimenUnico()
        {
            textRegimen = new TextBox();
        }
        //me quede aquui

        public bool validar()
        {
            return this.validarRegimen();
        }

        public Boolean validarRegimen()
        {
            String query;
            if (!string.IsNullOrEmpty(textRegimen.Text))
            {
                ConexionDB bd = new ConexionDB();
                query = this.armarQuery();
                DataTable resultado = bd.Select(query);

                if (resultado.Rows.Count > 0)
                {
                    labelRegimen.Text = "Ya existe Este Regimen: " + textRegimen.Text;
                    labelRegimen.ForeColor = System.Drawing.Color.Red;
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
            String query = "SELECT 1 NUMERO FROM [AVENGERS].[REGIMEN] WHERE ";
            query += string.Format(" DESCRIPCION  = '{0}'",
                       textRegimen.Text);
            return query;
        }
        public void limpiar()
        {
           
        }

        public void agregarLabel(Label _labelRegimen)
        {
            this.labelRegimen = _labelRegimen;
        }

        public void agregarRegimenId(TextBox _textRegimen)
        {
            textRegimen = _textRegimen;
        }
        public void limpiarLabel()
        {
            labelRegimen.Text = "";

        }
    }
}
