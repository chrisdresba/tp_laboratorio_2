using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFabrica
{

    public partial class FormClasica : Form
    {
        private Clasica clasica;
        private EColor color;
        private EEq eq;
        public FormClasica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al cargar el formulario inicializa los label Error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClasica_Load(object sender, EventArgs e)
        {
            inicializarLabelError();
        }

        /// <summary>
        /// Inicializa los label de error
        /// </summary>
        private void inicializarLabelError()
        {
            this.lblErrorModeloClasica.Text = "";
            this.lblErrorColorClasica.Text = "";
            this.lblErrorClavijasClasica.Text = "";
            this.lblErrorEncordadoClasica.Text = "";
        }
        /// <summary>
        /// Carga del instrumento a la lista y el archivo, validando previamente los datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarClasica_Click(object sender, EventArgs e)
        {
            if (checkBoxEqClasica.Checked == false) { eq = EEq.Si;} else {eq = EEq.No;}

            if (!(String.IsNullOrWhiteSpace(txtBoxModeloClasica.Text)) && cmbBoxColorClasica.SelectedItem != null && checkBoxClavijasClasica.Checked == true && checkBoxCuerdasClasica.Checked == true)
            {
                this.SeleccionColor();
                clasica = new Clasica(eq, txtBoxModeloClasica.Text, EClavijeros.Clasica, color, ECuerdas.DaddarioAcustica);

                //Si se dispone de stock de los materiales se agrega a la lista
                if (clasica.DisminuirStock())
                    {
                        Fabrica.Guitarra = clasica;
                        Serializador.SerializarXml<List<Guitarra>>(Fabrica.listaGuitarras, $"stockInstrumentos.xml");
                        inicializarLabelError();
                        MessageBox.Show("Instrumento cargado con exito");
                    }
            }
            else
            {
                ComprobarDatosIngresos();
            }
        }

        
         /// <summary>
        /// Comprobar los campos
        /// </summary>
        private void ComprobarDatosIngresos()
        {
          
            if (!(String.IsNullOrWhiteSpace(txtBoxModeloClasica.Text)))
            {
                this.lblErrorModeloClasica.Text = " ";
            } else {
                this.lblErrorModeloClasica.Text = "X";
            }

            if (cmbBoxColorClasica.SelectedItem == null)
            { 
                this.lblErrorColorClasica.Text = "X"; 
            } 

            if (cmbBoxColorClasica.SelectedItem != null)
            {
                this.lblErrorColorClasica.Text = " ";
            }

            if (checkBoxClavijasClasica.Checked == false){
                this.lblErrorClavijasClasica.Text = "X"; 
            } else { 
                this.lblErrorClavijasClasica.Text = " "; 
            }

            if (checkBoxCuerdasClasica.Checked == false){
                this.lblErrorEncordadoClasica.Text = "X"; 
            } else {
                this.lblErrorEncordadoClasica.Text = " "; 
            }
        }
        
        /// <summary>
        /// Corrobora el color del instrumento
        /// </summary>
        private void SeleccionColor()
        {
            switch (cmbBoxColorClasica.SelectedItem.ToString())
            {
                case "Natural":
                    color = EColor.Natural;
                    break;
                case "Negro":
                    color = EColor.Negro;
                    break;
                case "Verde":
                    color = EColor.Verde;
                    break;
                case "Azul":
                    color = EColor.Azul;
                    break;
                case "Rojo":
                    color = EColor.Rojo;
                    break;
            }

        }

        /// <summary>
        /// Boton para cerrar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarClasica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
