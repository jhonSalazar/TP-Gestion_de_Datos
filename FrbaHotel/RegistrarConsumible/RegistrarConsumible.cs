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
    public partial class RegistrarConsumible : Form
    {
        double totalPrecio = 0;
        public RegistrarConsumible()
        {
            InitializeComponent();
            buttonAgregarConsumible.Enabled = false;
        }

        private void buttonBuscarEstadia_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxCodigoEstadia.Text))
            {
                MessageBox.Show("Indique un codigo de estadia!");
            }
            else
            {
                string query = String.Format(@"SELECT TOP 1 E.NUMERO_RESERVA, (C.APELLIDO + ' ' + C.NOMBRE) AS CLIENTE, RG.DESCRIPCION
  FROM [AVENGERS].[ESTADIA] E
  INNER JOIN [AVENGERS].[RESERVA] R
  ON E.NUMERO_RESERVA = R.ID
  INNER JOIN [AVENGERS].[REGIMEN] RG
  ON R.ID_REGIMEN = RG.ID
  INNER JOIN [AVENGERS].[CLIENTE] C
  ON E.ID_CLIENTE = C.ID
  WHERE RG.ESTADO = 1 AND E.ID = {0}", textBoxCodigoEstadia.Text);

                ConexionDB db = new ConexionDB();
                DataTable resultado = db.Select(query);
                foreach (DataRow fila in resultado.Rows)
                {
                    labelReserva.Text = fila["NUMERO_RESERVA"].ToString();
                    labelCliente.Text = fila["CLIENTE"].ToString();
                    labelRegimen.Text = fila["DESCRIPCION"].ToString();
                }
                buttonAgregarConsumible.Enabled = true;
            }
        }

        private void buttonAgregarConsumible_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxCodigoEstadia.Text))
            {
                MessageBox.Show("Indique un codigo de estadia!");
            }
            else
            {
                AgregarConsumible agregar = new AgregarConsumible(this); //IdReserva
                agregar.Show();
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //TODO: grabar en la tabla los datos
            try
            {
                if (dataGridViewConsumibles.Rows.Count > 0)
                {
                    string idEstadia = textBoxCodigoEstadia.Text;
                    foreach (DataGridViewRow row in dataGridViewConsumibles.Rows)
                    {
                        string idConsumible = "", cantidadConsumible = "";

                        idConsumible = row.Cells["ColumnIdConsumible"].Value.ToString();
                        cantidadConsumible = row.Cells["ColumnCantidad"].Value.ToString();

                        string queryInsert = String.Format(@"INSERT INTO [AVENGERS].[CONSUMO]
           ([ID_ESTADIA]
           ,[ID_CONSUMIBLE]
           ,[CANTIDAD])
     VALUES
           ({0},{1},{2})", idEstadia, idConsumible, cantidadConsumible);

                        ConexionDB dbIns = new ConexionDB();
                        string resultadoIns = dbIns.InsertUpdateDelete(queryInsert);
                        if (resultadoIns == "OK")
                        {
                        }
                        else
                        {
                            MessageBox.Show("Algo salió mal. No se registraron los datos.");
                            return;
                        }
                    }
                    MessageBox.Show("Se registraron los datos!");
                    buttonAgregarConsumible.Enabled = false;
                    dataGridViewConsumibles.Columns["ColumnModificar"].Visible = false;
                    dataGridViewConsumibles.Columns["ColumnQuitar"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay elementos para registrar.");
                }
            }
            catch
            {
                MessageBox.Show("Error general. No se registraron los datos.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewConsumibles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotal();
        }

        private void dataGridViewConsumibles_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            String LinkLabel = "";
            LinkLabel = dataGridViewConsumibles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (e.RowIndex != -1)
            {
                if (LinkLabel.Equals("Quitar"))
                {
                    DialogResult dialogResult = MessageBox.Show(String.Format("Esta seguro de quitar el item seleccionado?"), "Atento", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridViewConsumibles.Rows.RemoveAt(dataGridViewConsumibles.CurrentRow.Index);
                        CalcularTotal();
                    }
                    else if (dialogResult == DialogResult.No) { }
                }

                if (LinkLabel.Equals("Modificar"))
                {
                    AgregarConsumible agregar = new AgregarConsumible(this, dataGridViewConsumibles.CurrentRow.Index);
                    agregar.Show();
                }
            }
        }

        private void CalcularTotal()
        {
            totalPrecio = 0;
            foreach (DataGridViewRow row in dataGridViewConsumibles.Rows)
            {
                double precio = double.Parse(row.Cells["ColumnPrecio"].Value.ToString());
                int cantidad = int.Parse(row.Cells["ColumnCantidad"].Value.ToString());
                totalPrecio += precio * cantidad;
            }

            labelTotal.Text = totalPrecio.ToString();
        }

        private void dataGridViewConsumibles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotal();
        }
    }
}
