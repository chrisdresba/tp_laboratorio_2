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

    public partial class FormClasica : Form
    {
        private Clasica clasica;
        private EColor color;
        private EClavijeros clavijas;
        private ECuerdas encordado;
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
            InicializarLabelError();
            Clasica.ClasicaAgregada += this.LimpiarForm;
            Clasica.ClasicaAgregada += this.InicializarLabelError;
            this.btnCargarClasica.Click += this.SeleccionColor;
            this.btnCargarClasica.Click += this.SeleccionClavijas;
            this.btnCargarClasica.Click += this.SeleccionEncordado;

        }

        /// <summary>
        /// Inicializa los label de error
        /// </summary>
        private void InicializarLabelError()
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

            if (!(String.IsNullOrWhiteSpace(txtBoxModeloClasica.Text)) && cmbBoxColorClasica.SelectedItem != null && cmbBoxClavijasClasica.SelectedItem != null && cmbBoxEncordadoClasica.SelectedItem != null)
            {

                clasica = new Clasica(eq, txtBoxModeloClasica.Text, clavijas, color, encordado);

                //Si se dispone de stock de los materiales se agrega a la lista
                if (clasica.DisminuirStock())
                    {
                        Fabrica.Guitarra = clasica;
                        Serializador.SerializarXml<List<Guitarra>>(Fabrica.listaGuitarras, $"stockInstrumentos.xml");
                        SqlInstrumentos.InsertarGuitarra(clasica);   ///Inserta en base de datos
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

            if (cmbBoxClavijasClasica.SelectedItem == null)
            {
                this.lblErrorClavijasClasica.Text = "X";
            }

            if (cmbBoxClavijasClasica.SelectedItem != null)
            {
                this.lblErrorClavijasClasica.Text = " ";
            }

            if (cmbBoxEncordadoClasica.SelectedItem == null)
            {
                this.lblErrorEncordadoClasica.Text = "X";
            }

            if (cmbBoxEncordadoClasica.SelectedItem != null)
            {
                this.lblErrorEncordadoClasica.Text = " ";
            }
        }

        /// <summary>
        /// Corrobora el color del instrumento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionColor(object sender, EventArgs e)
        {
            if(cmbBoxColorClasica.SelectedItem != null)
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
        }

        /// <summary>
        /// Corrobora los encordados del instrumento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionEncordado(object sender, EventArgs e)
        {
            if(cmbBoxEncordadoClasica.SelectedItem != null)
            {
                switch (cmbBoxEncordadoClasica.SelectedItem.ToString())
                {
                    case "Daddario":
                        encordado = ECuerdas.DaddarioClasica;
                        break;
                    case "ErnieBall":
                        encordado = ECuerdas.ErnieBallClasica;
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
            if(cmbBoxClavijasClasica.SelectedItem != null)
            {
                switch (cmbBoxClavijasClasica.SelectedItem.ToString())
                {
                    case "Nacional":
                        clavijas = EClavijeros.ClasicaNacional;
                        break;
                    case "Importado":
                        clavijas = EClavijeros.ClasicaImportado;
                        break;
                }
            }
        }

        /// <summary>
        /// Limpiar Formulario
        /// </summary>
        private void LimpiarForm()
        {
            this.txtBoxModeloClasica.Text = "";
            this.cmbBoxColorClasica.SelectedItem = null;
            this.cmbBoxClavijasClasica.SelectedItem = null;
            this.cmbBoxEncordadoClasica.SelectedItem = null;
            this.checkBoxEqClasica.Checked = false;

        }

        private void FormClasica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clasica.ClasicaAgregada -= this.LimpiarForm;
            Clasica.ClasicaAgregada -= this.InicializarLabelError;
            this.btnCargarClasica.Click -= this.SeleccionColor;
            this.btnCargarClasica.Click -= this.SeleccionClavijas;
            this.btnCargarClasica.Click -= this.SeleccionEncordado;

        }
    }
}
