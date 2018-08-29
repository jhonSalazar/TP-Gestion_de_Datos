using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmHabitacion.Clases;
using FrbaHotel.CapaDatos;

namespace FrbaHotel.AbmHabitacion
{
    public partial class ModificacionHabitacion : Form
    {
        private Actualizador actualizador;
        private String id;
        public ModificacionHabitacion()
        {
            InitializeComponent();
        }

        public ModificacionHabitacion(
                                      String _textNumeroHabitacion,
                                      String _textPiso,
                                      String _comboBoxUbicacion,
                                      String _comboBoxTipoDeHabitacion,
                                      String _textBoxDescripción,
                                      String _id)
        {
            InitializeComponent();
            
            textNumeroHabitacion.Text = _textNumeroHabitacion;
            textPiso.Text = _textPiso;
            comboBoxUbicacion.Text = _comboBoxUbicacion;
            comboBoxTipoDeHabitacion.Text = _comboBoxTipoDeHabitacion;
            textBoxDescripción.Text = _textBoxDescripción;
            this.id = _id;
            textNumeroHabitacion.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro de Modificar ?"
                               , "0 Resultado",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            actualizador =new Actualizador( textNumeroHabitacion.Text, 
                                        textPiso.Text,
                                        comboBoxUbicacion.Text,
                                        comboBoxTipoDeHabitacion.Text,
                                        textBoxDescripción.Text,
                                       id);

            actualizador.actualizar();
        }
    }
}
