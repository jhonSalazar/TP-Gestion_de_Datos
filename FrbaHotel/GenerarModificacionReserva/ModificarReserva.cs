using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ModificarReserva : Form
    {
        private ListadoReserva listadoReserva;
        private string id;
        private string fechaCreacion;
        private string fechaDesde;
        private string fechaHasta;
        private string cantidadNoches;
        private string tipoHabitacion;
        private string tipoRegimen;

        public ModificarReserva()
        {
            InitializeComponent();
        }

        public ModificarReserva(ListadoReserva listadoReserva)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            agregarCompponentes();
            this.listadoReserva = listadoReserva;
           
        }

        private void agregarCompponentes()
        {
            //throw new NotImplementedException();
        }

        public ModificarReserva(string id, string fechaCreacion, string fechaDesde, string fechaHasta, string cantidadNoches, string tipoHabitacion, string tipoRegimen)
        {
            // TODO: Complete member initialization
            InitializeComponent();
        
            /*String formato = "dd/MM/yyyy";
            DateTime parsedDate;
            this.id = id;
             DateTime.TryParseExact(fechaCreacion,formato,null,
                                         System.Globalization.DateTimeStyles.None, out parsedDate);
             parsedDate= DateTime.Parse(fechaCreacion);
             
             */
            dateTimePickerSistema.Text = fechaCreacion;
            dateTimePickerDesde.Text = fechaDesde;
            dateTimeHasta.Text = fechaHasta;
            textBoxCanitdadNoches.Text = cantidadNoches;
            comboBoxTipoHabitacion.Text = tipoHabitacion;
            comboBoxTipoRegimen.Text = tipoRegimen;
            textBoxCodigoReserva.Text = id;
            
            agregarCompponentes();

        }

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro de realziar la modificación ?"
                   , "0 Resultado",
                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    ActualizadorReserva actualizadorReserva = new ActualizadorReserva(dateTimePickerSistema.Text,
                                                                 dateTimePickerDesde.Text,
                                                                 dateTimeHasta.Text,
                                                                 textBoxCanitdadNoches.Text,
                                                                 comboBoxTipoHabitacion.Text,
                                                                 comboBoxTipoRegimen.Text,
                                                                 textBoxCodigoReserva.Text);
                    actualizadorReserva.modificar();
                    break;

                case DialogResult.No:

                    break;

                case DialogResult.Cancel:

                    break;
            }    
        }

    }
}
