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
using FrbaHotel.Validadores;
using FrbaHotel.AbmHabitacion.Clases;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class BuscarCliente : Form 
    {
        private GenerarReserva generadorReserva;
        private String idCliente = "";
        private List<Validaciones> validaciones;


        public BuscarCliente()
        {
            InitializeComponent();
            this.agregarComponentes();
        }

        public void agregarComponentes()
        {


            ValidadorCampoNumerico valiadorNumerico1;
            ValidadorTextBoxnull validadorTextBoxs;
            ValidadorcomboBox validadorComboBox;

            validadorTextBoxs = new ValidadorTextBoxnull();
            validadorTextBoxs.agregar(textBoxMail);
            validadorTextBoxs.agregar(textBoxNumeroDocumento);
            validadorTextBoxs.agregarLabel(labelCampoNulo);

            validadorComboBox = new ValidadorcomboBox();
            validadorComboBox.agregar(comboBoxTipoDocumento);
            validadorComboBox.agregarLabel(labelCampoNulo);

            valiadorNumerico1 = new ValidadorCampoNumerico();
            valiadorNumerico1.agregarLabel(labelNumeroDoc);
            valiadorNumerico1.agregar(textBoxNumeroDocumento);

            validaciones = new List<Validaciones>();

            validaciones.Add(validadorTextBoxs);   
            validaciones.Add(validadorComboBox);
            validaciones.Add(valiadorNumerico1);
        }

        public BuscarCliente(GenerarReserva _generadorReserva)
        {
            InitializeComponent();
            this.generadorReserva = _generadorReserva;
            this.agregarComponentes();
        }
     
        public String obtenerCliente(){

           return  this.idCliente;
        }

        private void BuscarCliente_FormClosing(object sender, FormClosingEventArgs e)
        { 
            this.limpiarTodo();
            this.limpiarLabels();
        }

        public String buscarCliente()
        {
           String query = String.Format(
           "SELECT ID "+
           "FROM [AVENGERS].[CLIENTE] "+
           "WHERE [AVENGERS].[CLIENTE].TIPO_ID = '{0}' "+
           "AND [AVENGERS].[CLIENTE].NUMERO_ID = {1} " +
           "AND [AVENGERS].[CLIENTE].MAIL = '{2}' "
           ,comboBoxTipoDocumento.Text,
            int.Parse(textBoxNumeroDocumento.Text),
            textBoxMail.Text);

            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(query);

            if (resultado.Rows.Count > 0)
            {
                this.idCliente = resultado.Rows[0]["ID"].ToString();
            }
            else
            {
                idCliente = "";
                return idCliente;
            }
         //   MessageBox.Show("El id del cliente es :: " + idCliente, "Consulta", MessageBoxButtons.OK);
            return idCliente;
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {

             this.limpiarLabels();
             if (!this.validarCamposNulos())
             {
                 this.generadorReserva.agregarIdCliene(this.buscarCliente());
                 this.Close();
             }
        }


        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }


        public Boolean validarCamposNulos()
        {
            int count = 0;
            validaciones.ForEach(validador =>
            {
                if (validador.validar())
                    count++;
            });

            if (count > 0)
                return true;

            return false;

        }

        public void limpiarTodo()
        {

            validaciones.ForEach(validador => validador.limpiar());

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarTodo();
            this.limpiarLabels();
        }
    }
}
