using FrbaHotel.AbmHabitacion.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Validadores
{
    class ValidadorCampoNumerico : Validador, Validaciones
    {
        public   Boolean  validar()
        {
            List<TextBox> textBoxsNulas = new List<TextBox>();     
           
            foreach(TextBox text in textBoxs )
            {

                if (this.validarcampo(text))
               {            
                   labelCampoNulo.Text = "Ingrese sólo números";
                   labelCampoNulo.ForeColor = System.Drawing.Color.Red;
                   return true;
               }
            
            }
            return false;
        }

        public  Boolean validarcampo(TextBox text)
        {
            int valorCasteado;
          
            if (!string.IsNullOrEmpty(text.Text))
            {
                if (!int.TryParse(text.Text, out valorCasteado))
                    return true;
            }
           
           
            return false;
        }

        public   void limpiarLabel()
        {
            labelCampoNulo.Text = "";

        }


        public void limpiar()
        {
           
        }
    }
}
