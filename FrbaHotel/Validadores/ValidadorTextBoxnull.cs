using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FrbaHotel.Validadores;

namespace FrbaHotel.AbmHabitacion.Clases
{
    class ValidadorTextBoxnull : Validador,Validaciones
    {


        public ValidadorTextBoxnull() {}

         public ValidadorTextBoxnull(List<TextBox> _textBoxs)
        {
            textBoxs = new List<TextBox>();
            textBoxs = _textBoxs;
           
        }
        public Boolean validar()
        {
            List<TextBox> textBoxsNulas = new List<TextBox>();

            textBoxsNulas = textBoxs.Where(unTextBoxs => this.validarcampo(unTextBoxs))
                                   .ToList();
            if (textBoxsNulas.Count > 0)
            {
                this.AvisoTextBoxs(Color.DarkGray, textBoxsNulas);
                labelCampoNulo.Text = "Complete los campos obligatorios (*)";
                labelCampoNulo.ForeColor = System.Drawing.Color.Red;

                return true;
            }
            return false;
        }

        public Boolean validarcampo(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
                return true;

            return false;
        }





        public void limpiar()
        {
            foreach (TextBox tex in textBoxs)
            {
                tex.Clear();
            }

            AvisoTextBoxs(Color.White, textBoxs);

        }

        public void limpiarLabel()
        {
            labelCampoNulo.Text = "";

        }
    }
}
