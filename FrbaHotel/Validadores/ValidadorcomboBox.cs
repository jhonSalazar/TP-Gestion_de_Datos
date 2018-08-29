using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion.Clases
{
    class ValidadorcomboBox :Validaciones
    {
        private List<ComboBox> comboBoxs;
        public Label labelCampoNulo;

        public ValidadorcomboBox()
        {
            comboBoxs = new List<ComboBox>();
        }

        public void agregarLabel(Label _labelCampoNulo)
        {
            this.labelCampoNulo = _labelCampoNulo;
        }

        public void  agregar(ComboBox combo)
        {
            comboBoxs.Add(combo);
        }

        public Boolean validarcampo(ComboBox combo)
        {
            if (string.IsNullOrEmpty(combo.Text))
                return true;

            return false;
        }

        public bool validar()
        {
            List<ComboBox> comboBoxsNulos = new List<ComboBox>();
            comboBoxsNulos = comboBoxs.Where(unCombo => this.validarcampo(unCombo))
                                      .ToList();
            if (comboBoxsNulos.Count > 0)
            {
                this.AvisoComboxBoxs(Color.Gray, comboBoxsNulos);
                labelCampoNulo.Text = "Complete todos los campos "
                                     + "Campos Obligatorios (*)";
                labelCampoNulo.ForeColor = System.Drawing.Color.Red;
                return true;
                
            }
            return false;
        }

        public void AvisoComboxBoxs(Color color, List<ComboBox> comboBoxs)
        {

            foreach (ComboBox combo in comboBoxs)
            {
                switch (color.Name)
                {
                    case "Gray":
                        {
                            combo.BackColor = Color.Gray;
                            break;
                        }
                    case "White":
                        {
                            combo.BackColor = Color.White;
                            break;
                        }
                }


            }

        }


        public void limpiar()
        {
             AvisoComboxBoxs(Color.White,comboBoxs);
        }

        public void limpiarLabel()
        {
           

        }
    }
}
