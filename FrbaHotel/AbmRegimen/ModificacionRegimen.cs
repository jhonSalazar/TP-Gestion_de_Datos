using FrbaHotel.AbmRegimen.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class ModificacionRegimen : Form
    {

        private ActualizadorRegimen actualizador;
        private String id;

        public ModificacionRegimen()
        {
            InitializeComponent();
        }

        public ModificacionRegimen(String _id, String _descripcion,
                                    String _precio)
        {
            InitializeComponent();
            textCodigo.Text = _id;
            textDescripcion.Text = _descripcion;
            textBoxPrecio.Text = _precio;
            textCodigo.Enabled = false;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro de Modificar ?"
                              , "0 Resultado",
                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            actualizador =
            new ActualizadorRegimen(textCodigo.Text,
            textDescripcion.Text, textBoxPrecio.Text);
            actualizador.actualizar();
        }
    }
}
