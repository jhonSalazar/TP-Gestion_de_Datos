using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Validadores
{
    class Validador
    {

        protected List<TextBox> textBoxs { get; set; }
        protected Label labelCampoNulo { get; set; }


        public Validador()
        {
            textBoxs = new List<TextBox>();
        }


        public void agregarLabel(Label _labelCampoNulo)
        {
            this.labelCampoNulo = _labelCampoNulo;
        }

      
        public void agregar(TextBox text)
        {
            textBoxs.Add(text);
        }

        public void AvisoTextBoxs(Color color, List<TextBox> textBoxs)
        {

            foreach (TextBox tex in textBoxs)
            {
                tex.BackColor = Color.DarkGray;
                switch (color.Name)
                {
                    case "DarkGray":
                        {
                            tex.BackColor = Color.DarkGray; ;
                            break;
                        }
                    case "White":
                        {
                            tex.BackColor = Color.White; ;
                            break;
                        }
                }
            }

        }
    }
}
