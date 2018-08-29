using FrbaHotel.AbmHabitacion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Validadores
{
    class ValidadorFecha: Validador,Validaciones
    {
        private Boolean fechaCambiada = true;
        
        public ValidadorFecha() { }
        
        public ValidadorFecha(Label _labelCAmbioFecha)
        {
           
            this.labelCampoNulo = _labelCAmbioFecha;   
        }

        public void fechaActualziada(Boolean _fechaCambiada)
        {
            fechaCambiada = _fechaCambiada;
        }

        public bool validar()
        {
            if (fechaCambiada)
            {
                labelCampoNulo.Text = "Actualice la fecha ....";
                labelCampoNulo.ForeColor = System.Drawing.Color.Red;
                return fechaCambiada;
            }   
            return fechaCambiada;
        }

        public void limpiar()
        {
          //  labelCampoNulo.Text = "";
        }

        public void limpiarLabel()
        {
            labelCampoNulo.Text = "";
        }
    }
}
