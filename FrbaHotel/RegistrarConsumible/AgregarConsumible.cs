using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class AgregarConsumible : Form
    {
        private RegistrarConsumible formPrevio;
        int indexModificado = -1;

        public AgregarConsumible(RegistrarConsumible form)
        {
            InitializeComponent();
            this.formPrevio = form;
            CargarConsumibles();
            CargarHabitaciones(int.Parse(formPrevio.textBoxCodigoEstadia.Text));
        }

        public AgregarConsumible(RegistrarConsumible form, int index)
        {
            InitializeComponent();
            this.formPrevio = form;
            CargarConsumibles();
            CargarHabitaciones(int.Parse(formPrevio.textBoxCodigoEstadia.Text));
            PreCargarSegunItemSeleccionado(index);
            indexModificado = index;
        }

        private void PreCargarSegunItemSeleccionado(int index)
        {
            dataGridViewConsumibles.FirstDisplayedScrollingRowIndex = index;
            numericUpDownCantidad.Value = decimal.Parse(formPrevio.dataGridViewConsumibles.Rows[index].Cells["ColumnCantidad"].Value.ToString());
            comboBoxHabitaciones.Text = formPrevio.dataGridViewConsumibles.Rows[index].Cells["ColumnHabitacion"].Value.ToString();
        }

        private void CargarHabitaciones(int idReserva)
        {
            //TODO: llenar combobox
            string queryConsu = String.Format(@"SELECT H.NUMERO
  FROM [GD1C2018].[AVENGERS].[RESERVA_HABITACION] RH
  INNER JOIN AVENGERS.HABITACION H ON RH.ID_HABITACION = H.ID
  WHERE ID_RESERVA = {0}", idReserva);
            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(queryConsu);

            if (resultado != null)
                foreach (DataRow fila in resultado.Rows)
                {
                    comboBoxHabitaciones.Items.Add(fila["NUMERO"].ToString());
                }
        }

        private void CargarConsumibles()
        {
            string queryConsu = "SELECT ID,DESCRIPCION,[PRECIO] FROM [GD1C2018].[AVENGERS].[CONSUMIBLE]";
            ConexionDB db = new ConexionDB();
            DataTable resultado = db.Select(queryConsu);

            if (resultado != null) dataGridViewConsumibles.DataSource = resultado;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                //TODO: agregar a gridview
                DataGridViewRow seleccion = this.dataGridViewConsumibles.SelectedRows[0];

                string idConsumible = seleccion.Cells["ID"].Value.ToString();
                string consumible = seleccion.Cells["DESCRIPCION"].Value.ToString();
                string precio = seleccion.Cells["PRECIO"].Value.ToString();
                string cantidad = numericUpDownCantidad.Value.ToString();
                string habitacion = comboBoxHabitaciones.Text;

                //Si se esta modificando quito el viejo para agregar el nuevo
                if (indexModificado > -1)
                    formPrevio.dataGridViewConsumibles.Rows.RemoveAt(indexModificado);

                formPrevio.dataGridViewConsumibles.Rows.Add(idConsumible, consumible, precio, cantidad, habitacion, "Modificar", "Quitar");
                
                this.Close();
            }
        }

        private bool Validar()
        {
            if (dataGridViewConsumibles.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione un consumible.");
                return false;
            }

            if (comboBoxHabitaciones.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una habitación.");
                return false;
            }
            return true;
        }
    }
}
