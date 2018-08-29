using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabelClientesPuntos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(ValidarFiltros())
            {
                ClientesConMasPuntos formPuntos = new ClientesConMasPuntos(txtListado_Año.Text, cmbListado_Trimestre.Text);
                formPuntos.Show();
            }
                
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarFiltros())
            {
                FueraDeServicio fueraDeServicio = new FueraDeServicio();
                fueraDeServicio.Show();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarFiltros())
            {
                HabitacionConMayorCantidad habitacionMayorCantidad = new HabitacionConMayorCantidad();
                habitacionMayorCantidad.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarFiltros())
            {
                ReservasCanceladas hotelReservaCancelada = new ReservasCanceladas();
                hotelReservaCancelada.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarFiltros())
            {
                ConsumiblesFacturados consumibleFacturados = new ConsumiblesFacturados();
                consumibleFacturados.Show();
            }
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarFiltros()
        {
            if (String.IsNullOrWhiteSpace(txtListado_Año.Text) || String.IsNullOrWhiteSpace(cmbListado_Trimestre.Text))
            {
                MessageBox.Show("Elija un año y trimestre!");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
