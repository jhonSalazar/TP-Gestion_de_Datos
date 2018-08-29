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



namespace FrbaHotel.AbmHabitacion
{
    public partial class AltaHabitacion : Form
    {
       
        private List<FrbaHotel.AbmHabitacion.Clases.Validaciones> validaciones;
        public AltaHabitacion()
        {
            InitializeComponent();
            agregarComponentes();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
             
            this.limpiarLabels();
            if (!this.validarCamposNulos())
            {
               
                this.ingresarHabitacion();
               
            }
           
            
        }

        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }


        public void ingresarHabitacion()
        {
            ConexionDB bd = new ConexionDB();
            String query = this.queryInsertar();

            String resultado = bd.InsertUpdateDelete(query);
            MessageBox.Show("Se agrego exitosamente la Habitacion Nro::" + textNumeroHabitacion.Text + " " + resultado
                          , "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
        }

        public String  obtenerTipoHabitacion()
        {
            String idTipo="";
           
            String query = 
            String.Format("SELECT ID FROM [AVENGERS].[TIPO_HABITACION]" +
            " WHERE [AVENGERS].[TIPO_HABITACION].DESCRIPCION ='{0}'",
            comboBoxTipoHabitacion.Text);
          
            ConexionDB bd = new ConexionDB();
            DataTable resultado = bd.Select(query);
           
            foreach (DataRow fila in resultado.Rows)
            {
                idTipo = fila["ID"].ToString();
                return idTipo; 
            }

            return idTipo;
        }

        public String queryInsertar()
        {
            String id_habitacion;
            String ubicacion ="N";
            id_habitacion = obtenerTipoHabitacion();
            
            if(comboBoxUbicacion.Text == "Vista al exterior")
                               ubicacion = "S";
 
            string queryInsert =
            string.Format("INSERT INTO [AVENGERS].[HABITACION]"+
            "VALUES ('{0}', '{1}',  '{2}',{3}, '{4}','{5}','{6}','{7}')",
            textNumeroHabitacion.Text,
            textPiso.Text,
            ubicacion,
            id_habitacion,
            comboBoxTipoHabitacion.Text,
            "Prueba1",
            1,
            9);

            return queryInsert;
        }

        public void agregarComponentes()
        {

            ValidadorCampoNumerico valiadorNumerico1;
            ValidadorCampoNumerico valiadorNumerico2;
            FrbaHotel.AbmHabitacion.Clases.ValidadorTextBoxnull validadorTextBoxs;
            FrbaHotel.AbmHabitacion.Clases.ValidadorcomboBox validadorComboBox;
           
            //valida campos nulos en textBox
            validadorTextBoxs = new ValidadorTextBoxnull();
            validadorTextBoxs.agregar(textDescripcion);
            validadorTextBoxs.agregar(textPiso);
            validadorTextBoxs.agregar(textNumeroHabitacion);
            validadorTextBoxs.agregarLabel(labelCampoNulo);
           
            //valida campos nulos en comboBox
            validadorComboBox = new ValidadorcomboBox();
            validadorComboBox.agregar(comboBoxUbicacion);
            validadorComboBox.agregar(comboBoxTipoHabitacion);
            validadorComboBox.agregarLabel(labelCampoNulo);

            // valida campos numericos TextBox
            valiadorNumerico1 = new ValidadorCampoNumerico();
            valiadorNumerico1.agregarLabel(labelNumerico1);
            valiadorNumerico1.agregar(textNumeroHabitacion);

            // valida campos numericos TextBox
            valiadorNumerico2 = new ValidadorCampoNumerico();
            valiadorNumerico2.agregarLabel(labelNumerico2);
            valiadorNumerico2.agregar(textPiso);

            //valida habitación unica
            ValidadorHabitacionUnica validadorHabitacionunica = new ValidadorHabitacionUnica();
            validadorHabitacionunica.agregarHabitacion(textNumeroHabitacion);
            validadorHabitacionunica.agregarLabel(labelHabitacionUnica);
            validaciones = new List<Validaciones>();
           
            
            validaciones.Add(validadorTextBoxs);
            validaciones.Add(validadorComboBox);
        //    validaciones.Add(validadorHabitacionunica);
            validaciones.Add(valiadorNumerico1);
            validaciones.Add(valiadorNumerico2);
        }

        public Boolean validarCamposNulos()
        {
            int count =0;
            validaciones.ForEach(validador => { if(validador.validar())
                                                                count++;} );

            if (count > 0)
                return true;

           
            return false;

        }

        public void  limpiarTodo()
        {

            validaciones.ForEach(validador => validador.limpiar());

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

            this.limpiarTodo();
            this.limpiarLabels();
        }

        private void AltaHabitacion_Load(object sender, EventArgs e)
        {

        }

      

    }
}
