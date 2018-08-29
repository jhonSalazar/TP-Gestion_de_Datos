using FrbaHotel.AbmCliente;
using FrbaHotel.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    class AltaclienteReserva: AltaCliente
    {
        private GenerarReserva generarReserva;
        private String mail;
        private String numero;
        private String tipo_docu;

        public AltaclienteReserva(GenerarReserva generarReserva)
        {
            // TODO: Complete member initialization
            this.generarReserva = generarReserva;
        }


        public String  armarQuery()
        {
            string query = String.Format("INSERT INTO AVENGERS.CLIENTE (NOMBRE,APELLIDO,TIPO_ID,NUMERO_ID,MAIL,TELEFONO,CALLE,CALLE_NRO,CALLE_PISO,CALLE_DEPTO,LOCALIDAD,PAIS,NACIONALIDAD,FECHA_NACIMIENTO,ESTADO) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
            txtCliente_Nombre.Text,
            txtCliente_Apellido.Text,
            cmbCliente_TipoID.Text,
            txtCliente_ID.Text,
            txtCliente_Mail.Text,
            txtCliente_Telefono.Text,
            txtCliente_Dir_Calle.Text,
            txtCliente_Dir_Nro.Text,
            txtCliente_Dir_Piso.Text,
            txtCliente_Dir_Dpto.Text,
            txtCliente_Localidad.Text,
            txtCliente_Pais_Origen.Text,
            txtCliente_Nacionalidad.Text,
            dateTPCliente_Fec_Nacimiento.Value.ToString("yyyy-MM-dd"),
            1);
            return query;
        }

        public override void insertarCliente()
        {
      
            String sqlInsertCliente = this.armarQuery();
            ConexionDB conexion = new ConexionDB();
            string resultado = conexion.InsertUpdateDelete(sqlInsertCliente);

            if (resultado.Equals("OK"))
            {
                //Mensaje de éxito
                MessageBox.Show("El nuevo Cliente ha sido registrado exitosamente", resultado, MessageBoxButtons.OK, MessageBoxIcon.Information);
             // actualizamos los valores de la otra ventana,
                generarReserva.mail = txtCliente_Mail.Text;
                generarReserva.tipoDoc = cmbCliente_TipoID.Text;
                generarReserva.numeroDoc = txtCliente_ID.Text;
                generarReserva.seDioDeAlta = true;
                this.limpiarTodo();
            }
            else
            {
                //Mensaje de falla
                MessageBox.Show("El Cliente no ha sido registrado. Intente nuevamente");
                generarReserva.seDioDeAlta = false;
            }
              this.Close();
        }



    }
}
