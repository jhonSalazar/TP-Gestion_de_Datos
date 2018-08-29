using FrbaHotel.AbmHabitacion.Clases;
using FrbaHotel.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.CancelarReservaT

{
    public partial class CancelarReserva : Form
    {
        private List<Validaciones> validaciones;
        private ValidadorFecha valiadorFecha;
        private Boolean fechaCambio = true;

        public CancelarReserva()
        {
            InitializeComponent();
            agregarComponentes();
        }


        public void agregarComponentes()
        {

            ValidadorTextBoxnull validadorTexBoxNull;
            validadorTexBoxNull = new ValidadorTextBoxnull();
            validadorTexBoxNull.agregar(textBoxNumeroReserva);
            validadorTexBoxNull.agregarLabel(labelCampoNulo);
            validadorTexBoxNull.agregar(textBoxMotivo);
            validadorTexBoxNull.agregar(textBoxUsuario);


            valiadorFecha = new ValidadorFecha(labelFecha);
            valiadorFecha.fechaActualziada(fechaCambio);

            ValidadorCampoNumerico validadorCampoNumerico = new ValidadorCampoNumerico();
            validadorCampoNumerico.agregar(textBoxNumeroReserva);
            validadorCampoNumerico.agregarLabel(labelNumerico);
            
            
            validaciones = new List<Validaciones>();
            validaciones.Add(validadorTexBoxNull);
            validaciones.Add(valiadorFecha);
            validaciones.Add(validadorCampoNumerico);


        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.limpiarLabels();

            if (!this.EjecutarValidaciones())
            {

                MessageBox.Show(" Se ejeuto todo n orden$ :",
                                "PRECIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.darDeBaja();// dar baja a traves de SP
            }
        }


        public void darDeBaja()
        {
            this.Close();
        }
        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }

        public Boolean EjecutarValidaciones()
        {
            int count = 0;
            validaciones.ForEach(validador => { if (validador.validar()) count++; });

            if (count > 0)
                return true;

            return false;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.fechaCambio = false;

            foreach (Validaciones validador in validaciones)
            {
                if (validador.Equals(valiadorFecha))
                {
                    valiadorFecha.fechaActualziada(fechaCambio);
                }

            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTodo(); 
        }

        public void limpiarTodo()
        {

            validaciones.ForEach(validador => validador.limpiar());
            this.limpiarLabels();
        }
    }
}
