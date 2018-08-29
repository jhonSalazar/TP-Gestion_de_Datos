using FrbaHotel.AbmHabitacion.Clases;
using FrbaHotel.CapaDatos;
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

namespace FrbaHotel.AbmCliente
{
    public partial class ModificacionCliente : Form
    {
        private ValidadorTextBoxnull validadorTextBoxNull;
        private List<Validaciones> validaciones;
        private String id;

        public ModificacionCliente(String _idCliente, String _nombreCliente, String _apellidoCliente, String _tipoIdCliente, String _nroIdCliente, String _mailCliente, String _telCliente, String _calleCliente,
                                   String _calleNroCliente, String _callePisoCliente, String _calleDptoCliente, String _localidadCliente, String _paisCliente, String _nacionCliente, String _fechaNacCliente)
        {
            InitializeComponent();
            agregarComponentes();

            id = _idCliente;
            
            txtCliente_Nombre.Text =_nombreCliente;
            txtCliente_Apellido.Text = _apellidoCliente;
            cmbCliente_TipoID.Text = _tipoIdCliente;
            txtCliente_ID.Text = _nroIdCliente;
            txtCliente_Mail.Text = _mailCliente; 
            txtCliente_Telefono.Text = _telCliente;
            txtCliente_Dir_Calle.Text = _calleCliente;
            txtCliente_Dir_Nro.Text = _calleNroCliente;
            txtCliente_Dir_Piso.Text = _callePisoCliente;
            txtCliente_Dir_Dpto.Text = _calleDptoCliente;
            txtCliente_Localidad.Text = _localidadCliente;
            txtCliente_Pais_Origen.Text = _paisCliente;
            txtCliente_Nacionalidad.Text = _nacionCliente;
            dateTPCliente_Fec_Nacimiento.Text = _fechaNacCliente;
        }

        public void agregarComponentes()
        {
            validadorTextBoxNull = new ValidadorTextBoxnull();
            validadorTextBoxNull.agregar(txtCliente_Nombre);
            validadorTextBoxNull.agregar(txtCliente_Apellido);
            validadorTextBoxNull.agregar(txtCliente_ID);
            validadorTextBoxNull.agregar(txtCliente_Mail);
            validadorTextBoxNull.agregar(txtCliente_Telefono);
            validadorTextBoxNull.agregar(txtCliente_Dir_Calle);
            validadorTextBoxNull.agregar(txtCliente_Dir_Nro);
            validadorTextBoxNull.agregar(txtCliente_Localidad);
            validadorTextBoxNull.agregar(txtCliente_Pais_Origen);
            validadorTextBoxNull.agregar(txtCliente_Nacionalidad);
            validadorTextBoxNull.agregarLabel(lblClienteTextoNulo);

            ValidadorcomboBox validadorCBNull = new ValidadorcomboBox();
            validadorCBNull.agregar(cmbCliente_TipoID);
            validadorCBNull.agregarLabel(lblClienteTextoNulo);
            /*
            ValidadorCampoTexto validadorCampoTexto = new ValidadorCampoTexto();
            validadorCampoTexto.agregar(txtCliente_Nombre);
            validadorCampoTexto.agregar(txtCliente_Apellido);
            validadorCampoTexto.agregar(txtCliente_Mail);
            validadorCampoTexto.agregar(txtCliente_Dir_Calle);
            validadorCampoTexto.agregar(txtCliente_Dir_Dpto);
            validadorCampoTexto.agregar(txtCliente_Localidad);
            validadorCampoTexto.agregar(txtCliente_Pais_Origen);
            validadorCampoTexto.agregar(txtCliente_Nacionalidad);
            
            ValidadorCampoNumerico validadorNumerico = new ValidadorCampoNumerico();
            validadorNumerico.agregar(txtCliente_ID);
            validadorNumerico.agregar(txtCliente_Telefono);
            validadorNumerico.agregar(txtCliente_Dir_Nro);
            validadorNumerico.agregar(txtCliente_Dir_Piso);
            validadorNumerico.agregarLabel(lblClienteTextNumerico);

            ValidadorClienteTipoNroIDUnico validadorTipoNroIDUnico = new ValidadorClienteTipoNroIDUnico();
            validadorTipoNroIDUnico.agregarTipoID(cmbCliente_TipoID);
            validadorTipoNroIDUnico.agregarNroID(txtCliente_ID);
            validadorTipoNroIDUnico.agregarLabel(lblClienteIDUnico);

            ValidadorClienteEmailUnico validadorEmailUnico = new ValidadorClienteEmailUnico();
            validadorEmailUnico.agregarEmail(txtCliente_Mail);
            validadorEmailUnico.agregarLabel(lblClienteMailUnico);
            
            ValidadorFormatoEmail validadorFormatoEmail = new ValidadorFormatoEmail();
            validadorEmailUnico.agregar(txtCliente_Mail);
            validadorEmailUnico.agregarLabel(lblCliFormatoMail);
            */
            validaciones = new List<Validaciones>();
            validaciones.Add(validadorTextBoxNull);
            validaciones.Add(validadorCBNull);
            //validaciones.Add(validadorCampoTexto);
            //validaciones.Add(validadorNumerico);
            //validaciones.Add(validadorEmailUnico);
            //validaciones.Add(validadorFormatoEmail); //validar formato de email sadasdasdsa@asdasdasd.com.ar ej
            //validaciones.Add(validadorTipoNroIDUnico);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está seguro que desea modificar ?", "0 Resultado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            string updateCliente = armarSqlUpdate();
            ConexionDB conexion = new ConexionDB();
            string resultado = conexion.InsertUpdateDelete(updateCliente);

            if (resultado == "OK")
            {
                //Mensaje de éxito
                MessageBox.Show("El Cliente ha sido actualizado exitosamente", resultado, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Mensaje de falla
                MessageBox.Show("El Cliente no ha sido actualizado. Intente nuevamente", resultado, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private string armarSqlUpdate()
        {
             int id = 0;
             int estadoActivo = 1;
             string updateCliente = String.Format("UPDATE AVENGERS.CLIENTE SET NOMBRE = '{0}', APELLIDO = '{1}', TIPO_ID = '{2}', NUMERO_ID = '{3}', " +
                                                   "MAIL = '{4}' ,TELEFONO = '{5}' , CALLE = '{6}', CALLE_NRO = '{7}', CALLE_DEPTO = '{8}', CALLE_PISO = '{9}', " +
                                                   "LOCALIDAD = '{10}', PAIS = '{11}', NACIONALIDAD = '{12}', FECHA_NACIMIENTO = '{13}', ESTADO = '{14}' " +
                                                   "FROM AVENGERS.CLIENTE WHERE ID = '{15}')", txtCliente_Nombre.Text, txtCliente_Apellido.Text, cmbCliente_TipoID.Text, txtCliente_ID.Text,
                                                   txtCliente_Mail.Text, txtCliente_Telefono.Text, txtCliente_Dir_Calle.Text, txtCliente_Dir_Nro.Text, txtCliente_Dir_Piso.Text, txtCliente_Dir_Dpto.Text,
                                                   txtCliente_Localidad.Text, txtCliente_Pais_Origen.Text, txtCliente_Nacionalidad.Text, dateTPCliente_Fec_Nacimiento.Text, estadoActivo, id);

            return updateCliente;
        }


    }
}