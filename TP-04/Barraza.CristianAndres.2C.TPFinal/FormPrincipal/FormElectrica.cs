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
using Entidades;

namespace FormFabrica
{
    public partial class FormElectrica : Form
    {
        private Electrica electrica;
        private EColor color;
        private ECuerdas encordado;
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
            InicializarLabelError();
            Electrica.ElectricaAgregada += this.LimpiarForm;
            Electrica.ElectricaAgregada += this.InicializarLabelError;

        }

        /// <summary>
        /// Inicializa los label de error
        /// </summary>
        private void InicializarLabelError()
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

            if (!(String.IsNullOrWhiteSpace(txtBoxModeloElectrica.Text)) && cmbBoxColorElectrica.SelectedItem != null && cmbBoxClavijasElectrica.SelectedItem != null && cmbBoxMicrofonosElectrica.SelectedItem != null && cmbBoxEncordadoElectrica.SelectedItem != null)
            {
                SeleccionColor();
                SeleccionClavijas();
                SeleccionEncordado();
                SeleccionMicrofonos();
                electrica = new Electrica(microfonos, txtBoxModeloElectrica.Text,clavijas, color, encordado);

                //Si se dispone de stock de los materiales se agrega a la lista
                if (electrica.DisminuirStock())
                {
                    Fabrica.Guitarra = electrica;
                    Serializador.SerializarXml<List<Guitarra>>(Fabrica.listaGuitarras, $"stockInstrumentos.xml");
                    SqlInstrumentos.InsertarGuitarra(electrica);  ///Inserta en base de datos
                    StockElementosDAO.ModificarStock();//modifica stock de elementos de produccion
                    MessageBox.Show("Instrumento cargado con exito");
                }
            }
            else
            {
                ComprobarDatosIngresados();
            }
        }

        /// <summary>
        /// Comprobar los campos
        /// </summary>
        private void ComprobarDatosIngresados()
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
            

            if (cmbBoxEncordadoElectrica.SelectedItem == null)
            {
                this.lblErrorEncordadoElectrica.Text = "X";
            }

            if (cmbBoxEncordadoElectrica.SelectedItem != null)
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
            if(cmbBoxColorElectrica.SelectedItem != null)
            {
                color = Validaciones.AsignacionColor(cmbBoxColorElectrica.SelectedItem.ToString());
               
            }
        }

        /// <summary>
        /// Corrobora los encordados del instrumento
        /// </summary>
        private void SeleccionEncordado()
        {
            if(cmbBoxEncordadoElectrica.SelectedItem != null)
            {
                encordado = Validaciones.AsignacionEncordado(cmbBoxEncordadoElectrica.SelectedItem.ToString()+"Electrica");
                
            }
        }

        /// <summary>
        /// Corrobora las clavijas del instrumento
        /// </summary>
        private void SeleccionClavijas()
        {
            if(cmbBoxClavijasElectrica.SelectedItem != null) 
            {
                clavijas = Validaciones.AsignacionClavijas(cmbBoxClavijasElectrica.SelectedItem.ToString());
              
            }
        }

        /// <summary>
        /// Corrobora los microfonos del instrumento
        /// </summary>
        private void SeleccionMicrofonos()
        {
            if(cmbBoxMicrofonosElectrica.SelectedItem != null)
            {
                microfonos = Validaciones.AsignacionMics(cmbBoxMicrofonosElectrica.SelectedItem.ToString());
              
            }
        }


        /// <summary>
        /// Limpiar Formulario
        /// </summary>
        private void LimpiarForm()
        {
            this.txtBoxModeloElectrica.Text = "";
            this.cmbBoxColorElectrica.SelectedItem = null;
            this.cmbBoxClavijasElectrica.SelectedItem = null;
            this.cmbBoxMicrofonosElectrica.SelectedItem = null;
            this.cmbBoxEncordadoElectrica.SelectedItem = null;

        }

        private void FormElectrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Electrica.ElectricaAgregada -= this.LimpiarForm;
            Electrica.ElectricaAgregada -= this.InicializarLabelError;

        }
    }
}
