using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaHotel.CapaDatos;
using FrbaHotel.Validadores;
using FrbaHotel.AbmHabitacion.Clases;

namespace FrbaHotel.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private ValidadorTextBoxnull validadorTextBoxNull;
        private List<Validaciones> validaciones;

        public AltaCliente()
        {
            InitializeComponent();
            agregarComponentes();
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
            */
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
            /*
            ValidadorFormatoEmail validadorFormatoEmail = new ValidadorFormatoEmail();
            validadorEmailUnico.agregar(txtCliente_Mail);
            validadorEmailUnico.agregarLabel(lblCliFormatoMail);
            */
            validaciones = new List<Validaciones>();
            validaciones.Add(validadorTextBoxNull);
            validaciones.Add(validadorCBNull);
            //validaciones.Add(validadorCampoTexto);
            validaciones.Add(validadorNumerico);
            validaciones.Add(validadorEmailUnico);
            //validaciones.Add(validadorFormatoEmail); //validar formato de email sadasdasdsa@asdasdasd.com.ar ej
            validaciones.Add(validadorTipoNroIDUnico);
        }

        private void buttonGuardarCli_Click(object sender, EventArgs e)
        {

            //this.limpiarTodo();
            this.validarEmailUnico();
            this.completarCamposNoObligatorios();
            if (!this.validarCamposNulos())
             {
                this.insertarCliente();
             }            
        }

        public virtual void insertarCliente()
        {
            int estadoActivo = 1;
            
            string sqlInsertCliente = String.Format("INSERT INTO AVENGERS.CLIENTE (NOMBRE,APELLIDO,TIPO_ID,NUMERO_ID,MAIL,TELEFONO,CALLE,CALLE_NRO,CALLE_PISO,CALLE_DEPTO,LOCALIDAD,PAIS,NACIONALIDAD,FECHA_NACIMIENTO,ESTADO) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
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
            dateTPCliente_Fec_Nacimiento.Text,
            estadoActivo);

            ConexionDB conexion = new ConexionDB();
            string resultado = conexion.InsertUpdateDelete(sqlInsertCliente);

            if (resultado == "OK")
            {
                //Mensaje de éxito
                MessageBox.Show("El nuevo Cliente ha sido registrado exitosamente", resultado, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Mensaje de falla
                MessageBox.Show("El Cliente no ha sido registrado. Intente nuevamente");
            }
        }

        private void completarCamposNoObligatorios()
        {
             if (string.IsNullOrEmpty(txtCliente_Dir_Piso.Text))
             {
             }

             if (string.IsNullOrEmpty(txtCliente_Dir_Dpto.Text))
             {
                 //txtCliente_Dir_Piso.Text = DBNull.Value;
             }
        }

        private Boolean validarEmailUnico()
        {
            
            if (!string.IsNullOrEmpty(txtCliente_Mail.Text))
            {
                ConexionDB bd = new ConexionDB();
                String query = String.Format("SELECT ID FROM AVENGERS.CLIENTE WHERE MAIL = '{0}'", txtCliente_Mail.Text);
                DataTable resultado = bd.Select(query);

                if (resultado.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un cliente con el Mail" + txtCliente_Mail.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //lblClienteMailUnico.Text = "Ya existe un Cliente con el Mail: " + txtCliente_Mail.Text;
                    //lblClienteMailUnico.ForeColor = System.Drawing.Color.Red;
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_Limpiar_Cliente_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
           txtCliente_Nombre.Clear();
           txtCliente_Apellido.Clear();
           txtCliente_ID.Clear();
           cmbCliente_TipoID.Text = "";
           txtCliente_Mail.Clear();
           txtCliente_Telefono.Clear();
           txtCliente_Dir_Calle.Clear();
           txtCliente_Dir_Nro.Clear();
           txtCliente_Dir_Dpto.Clear();
           txtCliente_Dir_Piso.Clear();
           txtCliente_Nacionalidad.Clear();
           txtCliente_Localidad.Clear();
           txtCliente_Pais_Origen.Clear();
           dateTPCliente_Fec_Nacimiento.Text = "";// clear es fecha de nacimiento
           this.limpiarTodo();
        }

        public void limpiarTodo()
        {

            validaciones.ForEach(validador => validador.limpiar());
            limpiarLabels();
        }

        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }

        public Boolean validarCamposNulos()
        {
            int count = 0;
            validaciones.ForEach(validador => { if (validador.validar()) count++; });

            if (count > 1)
                return true;

            return false;
        }

        private void txtCliente_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
