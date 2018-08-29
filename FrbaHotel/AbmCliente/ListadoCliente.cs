using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.CapaDatos;

namespace FrbaHotel.AbmCliente
{
    public partial class ListadoCliente : Form
    {
        public ListadoCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarParametrosEntrada();
        }

        public void limpiarParametrosEntrada()
        {
            dGV_Tabla_Clientes.Rows.Clear();
            txtCliente_Nombre.Clear();
            txtCliente_Apellido.Clear();
            cmbCliente_Tipo_ID.Text = "";
            txtCliente_ID.Clear(); ;
            txtCliente_Mail.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaCliente pantallaAltaCliente = new AltaCliente();
            pantallaAltaCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String queryDinamica = armarQueryDinamica();
            ConexionDB conexion = new ConexionDB();
            DataTable tablaDeClientes = conexion.Select(queryDinamica);

            if (tablaDeClientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encotraron registros", "0 Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            mostrarListado(tablaDeClientes);
        }

        private String armarQueryDinamica()
        {
            String queryFinal = "SELECT * FROM AVENGERS.CLIENTE WHERE 1 = 1 ";

            if (!string.IsNullOrEmpty(txtCliente_Nombre.Text))
                queryFinal += string.Format("AND NOMBRE LIKE '%{0}%' ", txtCliente_Nombre.Text);
            if (!string.IsNullOrEmpty(txtCliente_Apellido.Text))
                queryFinal += string.Format("AND APELLIDO LIKE '%{0}%' ", txtCliente_Apellido.Text);
            if (!string.IsNullOrEmpty(cmbCliente_Tipo_ID.Text))
                queryFinal += string.Format("AND TIPO_ID = '{0}' ", cmbCliente_Tipo_ID.Text);
            if (!string.IsNullOrEmpty(txtCliente_ID.Text))
                queryFinal += string.Format("AND NUMERO_ID = '{0}' ", txtCliente_ID.Text);
            if (!string.IsNullOrEmpty(txtCliente_Mail.Text))
                queryFinal += string.Format("AND MAIL = '%{0}%' ", txtCliente_Mail.Text);

            return queryFinal;
        }

        private void mostrarListado(DataTable listaClientes) 
        {
            limpiarParametrosEntrada();
            foreach (DataRow unCliente in listaClientes.Rows)
            {
                dGV_Tabla_Clientes.Rows.Add(unCliente["ID"].ToString(), unCliente["NOMBRE"].ToString(), unCliente["APELLIDO"].ToString(),
                                            unCliente["TIPO_ID"].ToString(), unCliente["NUMERO_ID"].ToString(), unCliente["MAIL"].ToString(),
                                            unCliente["TELEFONO"].ToString(), unCliente["CALLE"].ToString(), unCliente["CALLE_NRO"].ToString(),
                                            unCliente["CALLE_PISO"].ToString(), unCliente["CALLE_DEPTO"].ToString(), unCliente["LOCALIDAD"].ToString(),
                                            unCliente["PAIS"].ToString(), unCliente["NACIONALIDAD"].ToString(), unCliente["FECHA_NACIMIENTO"].ToString(), 
                                            unCliente["ESTADO"].ToString(),"Eliminar","Modificar");
                
            }

            labelCantidadTotal.Text = "Cantidad Total de Registros:" + listaClientes.Rows.Count;
        }

        private void dGV_Tabla_Clientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             String LinkLabel = "";
             LinkLabel = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

             if (e.RowIndex != -1)
             {
                 if (LinkLabel.Equals("Eliminar"))
                 {
                     MessageBox.Show("Seguro de la Baja ?", "0 Resultado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                     //ActualizadorRegimen actualizador = new (dGvListado.
                       //                                     Rows[e.RowIndex].Cells[0].
                         //                                   Value.ToString());
                     //actualizador.darBaja();          
                 }

                 if (LinkLabel.Equals("Modificar"))
                 {
                     this.instanciarModificacion(e);
                 }

             }
         }

         private void instanciarModificacion(DataGridViewCellMouseEventArgs e)
         {
             String idCliente, nombreCliente, apellidoCliente, tipoIdCliente, nroIdCliente,
                    mailCliente, telCliente, calleCliente, calleNroCliente, callePisoCliente, 
                    calleDptoCliente, localidadCliente, paisCliente, nacionCliente, fechaNacCliente;

             idCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
             nombreCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
             apellidoCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
             tipoIdCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
             nroIdCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[4].Value.ToString();
             mailCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[5].Value.ToString();
             telCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[6].Value.ToString();
             calleCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[7].Value.ToString();
             calleNroCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[8].Value.ToString();
             callePisoCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[9].Value.ToString();
             calleDptoCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[10].Value.ToString();
             localidadCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[11].Value.ToString();
             paisCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[12].Value.ToString();
             nacionCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[13].Value.ToString();
             fechaNacCliente = dGV_Tabla_Clientes.Rows[e.RowIndex].Cells[14].Value.ToString();

             var ventanaModificarCliente = new ModificacionCliente(idCliente, nombreCliente, apellidoCliente, tipoIdCliente, nroIdCliente, 
                                                                   mailCliente, telCliente, calleCliente, calleNroCliente, callePisoCliente, 
                                                                   calleDptoCliente, localidadCliente, paisCliente, nacionCliente, fechaNacCliente);
             ventanaModificarCliente.Show();
         }

         private void dGV_Tabla_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }
    }
}
