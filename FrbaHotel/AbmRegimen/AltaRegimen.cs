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
using FrbaHotel.AbmHabitacion.Clases;
using FrbaHotel.CapaDatos;
namespace FrbaHotel.AbmRegimen
{
    public partial class AltaRegimen: Form
    {
        private ValidadorTextBoxnull validadorTextBoxs;
        private List<Validaciones> validaciones;
       
        public AltaRegimen()
        {
            InitializeComponent();
            agregarComponentes();
        }

        public void agregarComponentes()
        {
            validadorTextBoxs = new ValidadorTextBoxnull();
            validadorTextBoxs.agregar(textDescripcion);
            validadorTextBoxs.agregar(textBoxPrecio);
            validadorTextBoxs.agregar(textBoxEstado);
            validadorTextBoxs.agregarLabel(labelCampoNulo);

            ValidadorCampoNumerico validadorNumerico = new ValidadorCampoNumerico();
            validadorNumerico.agregar(textBoxPrecio);
            validadorNumerico.agregarLabel(labelNumerico);

            ValidadorRegimenUnico validadorRegimenUnico = new ValidadorRegimenUnico();
            validadorRegimenUnico.agregarRegimenId(textDescripcion);
            validadorRegimenUnico.agregarLabel(labelRegimenUnico);
            validaciones = new List<Validaciones>();
            
            validaciones.Add(validadorTextBoxs);
            //validaciones.Add(validadorRegimenUnico);
            validaciones.Add(validadorNumerico);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            this.limpiarLabels();
            if (!this.validarCamposNulos())
            {
                
                this.ingresarRegimen();

            }

          
        }

        public void limpiarLabels()
        {
            validaciones.ForEach(validador => validador.limpiarLabel());
        }

        public void ingresarRegimen()
        {
            ConexionDB bd = new ConexionDB();
            String query = this.queryInsertar();

            String resultado = bd.InsertUpdateDelete(query);
            MessageBox.Show("Se agrego exitosamente Regimen::" + textDescripcion.Text + " " + resultado
                          , "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public String queryInsertar()
        {
         
            string queryInsert =
            string.Format("INSERT INTO  [AVENGERS].[REGIMEN]" +
            "VALUES ('{0}', '{1}',  '{2}')",
            textDescripcion.Text,
            textBoxPrecio.Text,
            1);

            return queryInsert;
        }


        public Boolean validarCamposNulos()
        {
            int count = 0;
            validaciones.ForEach(validador => { if (validador.validar()) count++; });

            if (count > 1)
                return true;

            return false;
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTodo();   
        }

        public void limpiarTodo()
        {

            validaciones.ForEach(validador => validador.limpiar());
            limpiarLabels();
        }

    }
}
