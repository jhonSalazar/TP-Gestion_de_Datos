using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion.Clases
{
    class ValidadorHabitacionUnica :Validaciones
    {
        private TextBox textNumeroHabitacion;
        private Label labelHabitacion;

        public ValidadorHabitacionUnica()
        {
            textNumeroHabitacion = new TextBox();
        }

        public void agregarHabitacion(TextBox numeroHabitacion) 
        {
            textNumeroHabitacion = numeroHabitacion;
        }
    
        public void agregarLabel(Label _label)
        {
            this.labelHabitacion = _label;
        }



        public bool validar()
        {
            return this.validarNumeroHabitacion();
        }

        public void limpiar()
        {
           
        }

        public String armarQuery()
        {
             String query = "SELECT 1 NUMERO FROM [AVENGERS].[HABITACION] WHERE ";  
             query += string.Format(" NUMERO  = '{0}'", textNumeroHabitacion.Text);
             return query;
        }

        public Boolean validarNumeroHabitacion()
        {
             String query;
             if (!string.IsNullOrEmpty(textNumeroHabitacion.Text))
             {

                 ConexionDB bd = new ConexionDB();
                 query = this.armarQuery();
                 DataTable resultado = bd.Select(query);

                 if (resultado.Rows.Count > 0)
                 {
                     labelHabitacion.Text = "Ya existe ese numero de Habitacion Nro: " + textNumeroHabitacion.Text;
                     labelHabitacion.ForeColor = System.Drawing.Color.Red;
                     return true;
                 }
                 return false;

             }
             else
             {
                 return true;
             }


            

        }


        public void limpiarLabel()
        {
            labelHabitacion.Text = "";

        }
    }
}
