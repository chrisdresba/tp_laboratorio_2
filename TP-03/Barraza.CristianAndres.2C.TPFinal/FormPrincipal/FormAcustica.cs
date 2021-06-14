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
    public partial class FormAcustica : Form
    {
        private Acustica acustica;
        private EColor color;
        private EEq eq;
        public FormAcustica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al cargar el formulario inicializa los label Error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAcustica_Load(object sender, EventArgs e)
        {
            inicializarLabelError();
        }

        /// <summary>
        /// Inicializa los label de error
        /// </summary>
        private void inicializarLabelError()
        {
            this.lblErrorModeloAcustica.Text = "";
            this.lblErrorColorAcustica.Text = "";
            this.lblErrorClavijasAcustica.Text = "";
            this.lblErrorEncordadoAcustica.Text = "";
        }
        /// <summary>
        /// Carga del instrumento a la lista y el archivo, validando previamente los datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarAcustica_Click(object sender, EventArgs e)
        {
            if (checkBoxEqAc.Checked == true) { eq = EEq.Si;} else { eq = EEq.No; }
           
                if (!(String.IsNullOrWhiteSpace(textBoxAcustica.Text)) && cmbBoxColorAcustica.SelectedItem != null && checkBoxClavijasAcustica.Checked == true && checkBoxCuerdasAc.Checked == true)
                {
                     this.SeleccionColor();
                     acustica = new Acustica(eq, textBoxAcustica.Text, EClavijeros.TresMasTres, color, ECuerdas.DaddarioAcustica);

                    //Si se dispone de stock de los materiales se agrega a la lista
                    if (acustica.DisminuirStock())
                    {
                        Fabrica.Guitarra = acustica;
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

         
            if (!(String.IsNullOrWhiteSpace(textBoxAcustica.Text)))
            { 
                this.lblErrorModeloAcustica.Text = " ";
            } else {
                this.lblErrorModeloAcustica.Text = "X";
            }
        

            if (cmbBoxColorAcustica.SelectedItem == null)
            { 
                this.lblErrorColorAcustica.Text = "X"; 
            } 

            if (cmbBoxColorAcustica.SelectedItem != null)
            {
                this.lblErrorColorAcustica.Text = " ";
            }

            if (checkBoxClavijasAcustica.Checked == false){
                this.lblErrorClavijasAcustica.Text = "X"; 
            } else { 
                this.lblErrorClavijasAcustica.Text = " "; 
            }

            if (checkBoxCuerdasAc.Checked == false){
                this.lblErrorEncordadoAcustica.Text = "X"; 
            } else {
                this.lblErrorEncordadoAcustica.Text = " "; 
            }
        }

        /// <summary>
        /// Corrobora el color del instrumento
        /// </summary>
        private void SeleccionColor()
        {
            switch (cmbBoxColorAcustica.SelectedItem.ToString())
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
        private void btnCerrarAcustica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
