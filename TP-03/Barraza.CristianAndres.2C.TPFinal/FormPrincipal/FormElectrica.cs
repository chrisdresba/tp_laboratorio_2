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
    public partial class FormElectrica : Form
    {
        private Electrica electrica;
        private EColor color;
        private EMicrofonos microfonos;
        private EClavijeros clavijas;

        public FormElectrica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al cargar el formulario inicializa los label Error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormElectrica_Load(object sender, EventArgs e)
        {
            inicializarLabelError();
        }

        /// <summary>
        /// Inicializa los label de error
        /// </summary>
        private void inicializarLabelError()
        {
            this.lblErrorModeloElectrica.Text = "";
            this.lblErrorColorElectrica.Text = "";
            this.lblErrorClavijasElectrica.Text = "";
            this.lblErrorEncordadoElectrica.Text = "";
            this.lblErrorMicrofonosElectrica.Text = "";
        }

        /// <summary>
        /// Carga del instrumento a la lista y el archivo, validando previamente los datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarElectrica_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrWhiteSpace(txtBoxModeloElectrica.Text)) && cmbBoxColorElectrica.SelectedItem != null && cmbBoxClavijasElectrica.SelectedItem != null && cmbBoxMicrofonosElectrica.SelectedItem != null && checkBoxCuerdasElectrica.Checked == true)
            {
                this.SeleccionColor();
                this.SeleccionClavijas();
                this.SeleccionMicrofonos();

                electrica = new Electrica(microfonos, txtBoxModeloElectrica.Text,clavijas, color, ECuerdas.DaddarioAcustica);

                //Si se dispone de stock de los materiales se agrega a la lista
                if (electrica.DisminuirStock())
                {
                    Fabrica.Guitarra = electrica;
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
          
            if (!(String.IsNullOrWhiteSpace(txtBoxModeloElectrica.Text)))
            {
                this.lblErrorModeloElectrica.Text = " ";
            }
            else
            {
                this.lblErrorModeloElectrica.Text = "X";
            }

            if (cmbBoxColorElectrica.SelectedItem == null)
            {
                this.lblErrorColorElectrica.Text = "X";
            }

            if (cmbBoxColorElectrica.SelectedItem != null)
            {
                this.lblErrorColorElectrica.Text = " ";
            }

            if (cmbBoxClavijasElectrica.SelectedItem == null)
            {
                this.lblErrorClavijasElectrica.Text = "X";
            }

            if (cmbBoxClavijasElectrica.SelectedItem != null)
            {
                this.lblErrorClavijasElectrica.Text = " ";
            }

            if (checkBoxCuerdasElectrica.Checked == false)
            {
                this.lblErrorEncordadoElectrica.Text = "X";
            }
            else
            {
                this.lblErrorEncordadoElectrica.Text = " ";
            }

            if (cmbBoxMicrofonosElectrica.SelectedItem == null)
            {
                this.lblErrorMicrofonosElectrica.Text = "X";
            }

            if (cmbBoxMicrofonosElectrica.SelectedItem != null)
            {
                this.lblErrorMicrofonosElectrica.Text = " ";
            }
        }

        /// <summary>
        /// Corrobora el color del instrumento
        /// </summary>
        private void SeleccionColor()
        {
            switch (cmbBoxColorElectrica.SelectedItem.ToString())
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
        /// Corrobora las clavijas del instrumento
        /// </summary>
        private void SeleccionClavijas()
        {
            switch (cmbBoxClavijasElectrica.SelectedItem.ToString())
            {
                case "TresMasTres":
                    clavijas = EClavijeros.TresMasTres;
                    break;
                case "SeisEnLinea":
                    clavijas = EClavijeros.SeisEnLinea;
                    break;
              
            }
        }

        /// <summary>
        /// Corrobora los microfonos del instrumento
        /// </summary>
        private void SeleccionMicrofonos()
        {
            switch (cmbBoxMicrofonosElectrica.SelectedItem.ToString())
            {
                case "TresSimple":
                    microfonos = EMicrofonos.TresSimple;
                    break;
                case "DosSimpleUnHumbucker":
                    microfonos = EMicrofonos.DosSimpleUnHumbucker;
                    break;
                case "DosHumbucker":
                    microfonos = EMicrofonos.DosHumbucker;
                    break;

            }
        }

        /// <summary>
        /// Boton para cerrar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarElectrica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
