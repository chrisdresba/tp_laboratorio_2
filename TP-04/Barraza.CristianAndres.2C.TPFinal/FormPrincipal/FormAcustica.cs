using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;




namespace FormFabrica
{
    public partial class FormAcustica : Form
    {
        private Acustica acustica;
        private EColor color;
        private EClavijeros clavijas;
        private ECuerdas encordado;
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
            InicializarLabelError();
            Acustica.AcusticaAgregada += this.LimpiarForm;
            Acustica.AcusticaAgregada += this.InicializarLabelError;
            this.btnCargarAcustica.Click += this.SeleccionColor;
            this.btnCargarAcustica.Click += this.SeleccionClavijas;
            this.btnCargarAcustica.Click += this.SeleccionEncordado;
            


        }

        /// <summary>
        /// Inicializa los label de error
        /// </summary>
        public void InicializarLabelError()
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
           
                if (!(String.IsNullOrWhiteSpace(textBoxAcustica.Text)) && cmbBoxColorAcustica.SelectedItem != null && cmbBoxClavijasAcustica.SelectedItem != null && cmbBoxEncordadoAcustica.SelectedItem != null)
                {
                     acustica = new Acustica(eq, textBoxAcustica.Text, clavijas, color, encordado);

                    //Si se dispone de stock de los materiales se agrega a la lista
                    if (acustica.DisminuirStock())
                    {
                        Fabrica.Guitarra = acustica;
                        Serializador.SerializarXml<List<Guitarra>>(Fabrica.listaGuitarras, $"stockInstrumentos.xml");
                       // SqlInstrumentos.InsertarGuitarra(acustica); ///Inserta en base de datos
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

            if (cmbBoxClavijasAcustica.SelectedItem == null)
            {
                this.lblErrorClavijasAcustica.Text = "X";
            }

            if (cmbBoxClavijasAcustica.SelectedItem != null)
            {
                this.lblErrorClavijasAcustica.Text = " ";
            }

            if (cmbBoxEncordadoAcustica.SelectedItem == null)
            {
                this.lblErrorEncordadoAcustica.Text = "X";
            }

            if (cmbBoxEncordadoAcustica.SelectedItem != null)
            {
                this.lblErrorEncordadoAcustica.Text = " ";
            }
        }

        /// <summary>
        /// Corrobora el color del instrumento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionColor(object sender, EventArgs e)
        {
            if (cmbBoxColorAcustica.SelectedItem != null)
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
        }


        /// <summary>
        /// Corrobora los encordados del instrumento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionEncordado(object sender, EventArgs e)
        {
            if(cmbBoxEncordadoAcustica.SelectedItem != null)
            { 
                switch (cmbBoxEncordadoAcustica.SelectedItem.ToString())
                {
                    case "Daddario":
                        encordado = ECuerdas.DaddarioAcustica;
                        break;
                    case "ErnieBall":
                        encordado = ECuerdas.ErnieBallAcustica;
                        break;

                }
            }
        }

        /// <summary>
        /// Corrobora las clavijas del instrumento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionClavijas(object sender, EventArgs e)
        {
            if(cmbBoxClavijasAcustica.SelectedItem != null)
            {
                switch (cmbBoxClavijasAcustica.SelectedItem.ToString())
                {
                    case "TresMasTres":
                        clavijas = EClavijeros.TresMasTres;
                        break;
                    case "TresMasTresVintage":
                        clavijas = EClavijeros.TresMasTresVintage;
                        break;
                }
            }
        }

        /// <summary>
        /// Limpiar Formulario
        /// </summary>
        public void LimpiarForm()
        {
            this.textBoxAcustica.Text = "";
            this.cmbBoxColorAcustica.SelectedItem = null;
            this.cmbBoxClavijasAcustica.SelectedItem = null;
            this.cmbBoxEncordadoAcustica.SelectedItem = null;
            this.checkBoxEqAc.Checked = false;

        }

        private void FormAcustica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acustica.AcusticaAgregada -= this.LimpiarForm;
            Acustica.AcusticaAgregada -= this.InicializarLabelError;
            this.btnCargarAcustica.Click -= this.SeleccionColor;
            this.btnCargarAcustica.Click -= this.SeleccionClavijas;
            this.btnCargarAcustica.Click -= this.SeleccionEncordado;
        }
    }
}
