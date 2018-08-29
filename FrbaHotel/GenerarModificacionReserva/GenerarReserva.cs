using FrbaHotel.AbmHabitacion.Clases;
using FrbaHotel.CapaDatos;
using FrbaHotel.GenerarModificacionReserva.Clases;
using FrbaHotel.Login;
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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReserva : Form
    {   
        /*Faltaria devolver la clave de la reserva, utilizar sp o triggers, es muy completa 
         esta parte, las modificaciones */

        private static double precioDolar = 26.39;
        public String mail{ get; set; }
        public Boolean clientEncontrado { get; set; }
        public String tipoDoc { get; set; }
        public String numeroDoc{ get; set; }
        public Boolean seDioDeAlta { get; set; }
        private String idCliente="";
        private String idRegimen="";
        private Boolean fechaCambio = true;
        private String id_reserva = "";
        ValidadorFecha valiadorFecha;
        private List<Validaciones> validaciones;
        private BuscarCliente buscar;

        public GenerarReserva()
        {
            InitializeComponent();
            agregarComponentes();


            if (!SesionLogin.Rol.Equals(3))
            {
                /*
                comboBoxHotel.Text = SesionLogin.HotelNombre;
                comboBoxHotel.Enabled = false;
                regimenesDelHotel(SesionLogin.Hotel);*/
                TipoUsuario usuario = new Usuario(SesionLogin.Hotel, comboBoxHotel,
                                               comboBoxTipoRegimen, comboBoxTipoHabitacion);
                usuario.consultarHoteles();
            }
            else
            {
                TipoUsuario usuario = new Guest(comboBoxHotel,
                                              comboBoxTipoRegimen, comboBoxTipoHabitacion);
                usuario.consultarHoteles();  
                comboBoxHotel.Enabled = true;
            }
               
        }


        public void agregarIdCliene(String _cliente)
        {
            this.idCliente = _cliente;
        }

        public void agregarComponentes()
        {
            ValidadorcomboBox validadorComboBox;

            validadorComboBox = new ValidadorcomboBox();
            validadorComboBox.agregar(comboBoxTipoHabitacion);
            validadorComboBox.agregar(comboBoxTipoRegimen);
            validadorComboBox.agregarLabel(labelCampoNulo);

            valiadorFecha = new ValidadorFecha(labelFecha);
            valiadorFecha.fechaActualziada(fechaCambio);
            validaciones = new List<Validaciones>();
            validaciones.Add(validadorComboBox);
            validaciones.Add(valiadorFecha);
            
        }

        // este evento pertenece al boton Generar Reserva  <----
        private void buttonFecha_Click(object sender, EventArgs e)
        {
            this.limpiarLabels();      

            if (!this.validarCamposNulos())
            {

                MessageBox.Show(" El precio  total de la reserva es $ : " + string.Format("{0:0.00}",this.obtenerPrecioHabitacion() / precioDolar) + " Dólares"
                        , "PRECIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              this.procesarcliente();      
             
             // this.Close();
            }
        }

        public void generarReserva()
        {
            ConexionDB bd = new ConexionDB();

            CreadorReserva creadorReserva = new CreadorReserva(textBoxCodigoReserva,
            dateTimePickerSistema.Value.ToString("yyyy-MM-dd"),
            dateTimePickerDesde.Value.ToString("yyyy-MM-dd HH:mm:ss"),
            dateTimeHasta.Value.ToString("yyyy-MM-dd HH:mm:ss"),
            int.Parse(textBoxCanitdadNoches.Text),
            int.Parse(idRegimen),
            int.Parse(idCliente),
            comboBoxTipoHabitacion.Text,
            comboBoxHotel.Text);

            creadorReserva.crearReserva();

            }



        public void  procesarcliente() 
        {
            DialogResult result = MessageBox.Show("Es la primera vez que se Hospeda?", "Consulta", MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    this.darDeAltacliente();
                    break;
                   
                case DialogResult.No: 
                     this.buscarCliente();
                     break;
                    
                case DialogResult.Cancel: 
                    this.limpiarTodo();
                    break;                  
            }
        }

        public void darDeAltacliente()
        {
            // se pasa por agumento el objeto this, para que configure los parametros del cliente de alta
            // mail, numero de doc, tipo de doc, un boleando para saber si se avctualizo o no
            AltaclienteReserva altaCliente = new AltaclienteReserva(this);
            altaCliente.ShowDialog();
      
            /*   MessageBox.Show("El nuevo Cliente ha sido registrado exitosamente"+mail+numeroDoc+tipoDoc,
               "Resultado dede la orta ventana", MessageBoxButtons.OK);
          */
          if (this.seDioDeAlta)
           {
               this.obtenerClienteDeAlta();
               this.generarReserva();
           }

         }

        public void  obtenerClienteDeAlta()
        {
            String query = String.Format(
            "SELECT ID " +
            "FROM [AVENGERS].[CLIENTE] " +
            "WHERE [AVENGERS].[CLIENTE].TIPO_ID = '{0}' " +
            "AND [AVENGERS].[CLIENTE].NUMERO_ID = {1} " +
            "AND [AVENGERS].[CLIENTE].MAIL = '{2}' "
            , tipoDoc,
             int.Parse(numeroDoc),
             mail);

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(query);

            if (resultado.Rows.Count > 0)
            {
                this.idCliente = resultado.Rows[0]["ID"].ToString();
            }
        }

        public void buscarCliente()
        {
            buscar = new BuscarCliente(this);
            buscar.ShowDialog();

            if (!this.idCliente.Equals(""))
            {
                MessageBox.Show("fue encontrado con los datos correspondientes"
                ,"Cliente De Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.generarReserva();
            }
            else
            {
                MessageBox.Show(" No fue encontrado con los datos ofrecidos"
             , "No es Cliente De Hotel, registrese Por favor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
          

        }

    

        public float obtenerPrecioHabitacion()
        {
            String precio="";
           
            String query = String.Format(
            "SELECT TOP 1"+
            "[AVENGERS].[REGIMEN].PRECIO * [AVENGERS].[TIPO_HABITACION].PORCENTUAL + [AVENGERS].[HOTEL].ESTRELLAS AS PRECIO , " +
            "[AVENGERS].[REGIMEN].ID " +
            "FROM [AVENGERS].[REGIMEN] , [AVENGERS].[TIPO_HABITACION] ,  "+
            "[AVENGERS].[HOTEL_REGIMEN], [AVENGERS].[HOTEL] "+
            "WHERE "+
            "[AVENGERS].[REGIMEN].DESCRIPCION = '{0}' "+
            "AND [AVENGERS].[TIPO_HABITACION].DESCRIPCION = '{1}' "+
            "AND [AVENGERS].[REGIMEN].ID = [AVENGERS].[HOTEL_REGIMEN].ID_REGIMEN "+
            "AND [AVENGERS].[HOTEL_REGIMEN].ID_HOTEL = [AVENGERS].[HOTEL].ID " +
            "AND [AVENGERS].[HOTEL].NOMBRE = '{2}'"
            ,comboBoxTipoRegimen.Text,
            comboBoxTipoHabitacion.Text,
            comboBoxHotel.Text);

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(query);
            precio = resultado.Rows[0][0].ToString();
            idRegimen = resultado.Rows[0][1].ToString();

            return float.Parse(precio);
        }

        public void regimenesDelHotel(int idHotel)
        {
            String query = String.Format(
                "SELECT  DISTINCT " +
                " [AVENGERS].[REGIMEN].DESCRIPCION " +
                " FROM [AVENGERS].[REGIMEN] , [AVENGERS].[TIPO_HABITACION] ,  " +
                " [AVENGERS].[HOTEL_REGIMEN], [AVENGERS].[HOTEL], [AVENGERS].[HABITACION] " +
                " WHERE " +
                "  [AVENGERS].[REGIMEN].ID = [AVENGERS].[HOTEL_REGIMEN].ID_REGIMEN " +
                " AND [AVENGERS].[HOTEL_REGIMEN].ID_HOTEL = [AVENGERS].[HOTEL].ID " +
                " AND [AVENGERS].[HOTEL].ID = {0}",
                idHotel);

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(query);

            foreach (DataRow fila in resultado.Rows)
            {
                comboBoxTipoRegimen.Items.Add(fila["DESCRIPCION"].ToString());
               
            }


             query = String.Format(
                "SELECT  DISTINCT" +
               "  [AVENGERS].[TIPO_HABITACION].DESCRIPCION  " +
                " FROM [AVENGERS].[REGIMEN] , [AVENGERS].[TIPO_HABITACION] ,  " +
                " [AVENGERS].[HOTEL_REGIMEN], [AVENGERS].[HOTEL], [AVENGERS].[HABITACION] " +
                " WHERE " +
                "  [AVENGERS].[REGIMEN].ID = [AVENGERS].[HOTEL_REGIMEN].ID_REGIMEN " +
                " AND [AVENGERS].[HOTEL_REGIMEN].ID_HOTEL = [AVENGERS].[HOTEL].ID " +
                " AND [AVENGERS].[HOTEL].ID = '{0}'" ,
                SesionLogin.Hotel);

             ConexionDB bd2 = new ConexionDB();
             DataTable resultado2 = bd2.Select(query);

             foreach (DataRow fila in resultado2.Rows)
             {
                
                 comboBoxTipoHabitacion.Items.Add(fila["DESCRIPCION"].ToString());
             }

        
        }


        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }

        public Boolean validarCamposNulos()
        {
            int count = 0;
            validaciones.ForEach(validador => { if (validador.validar()) count++; });

            if (count > 0)
                return true;

            return false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
            this.fechaCambio = false;  

            foreach (Validaciones validador in validaciones)
            {
                if (validador.Equals(valiadorFecha))
                {
                    valiadorFecha.fechaActualziada(fechaCambio);
                }
                
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTodo(); 
        }

        public void limpiarTodo()
        {

            validaciones.ForEach(validador => validador.limpiar());
            this.limpiarLabels();
        }

        private void buttonReservaOtroCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodigoReserva.Text))
            {
               MessageBox.Show("Se debe generar primero el código de reserva",
               "Consulta", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                this.procesarcliente();
              //  this.generarReserva();
            }

        }

    }
}
