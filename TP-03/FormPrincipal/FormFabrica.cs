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
    public partial class FormFabrica : Form
    {
        const string FILE = "stockInstrumentos.xml";

        public FormFabrica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del formulario y lectura del archivo de instrumentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
             Fabrica.listaGuitarras = Serializador.DeserializarXml<List<Guitarra>>(FILE);
             if (Fabrica.listaGuitarras == null)
             {
                 Fabrica.listaGuitarras = new List<Guitarra>();
             }

        }

        /// <summary>
        /// Apertura del formulario de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos frmProductos = new FormProductos();

            frmProductos.Show();

        }

        /// <summary>
        /// Apertura del formulario de materiales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FormMateriales frmMateriales = new FormMateriales();

            frmMateriales.Show();

        }

        /// <summary>
        /// Apertura del formulario de guitarras acustica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuitarraAcustica_Click(object sender, EventArgs e)
        {
            FormAcustica frmmAcustica = new FormAcustica();

            frmmAcustica.Show();
        }

        /// <summary>
        /// Apertura del formulario de guitarras clasica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuitarraClasica_Click(object sender, EventArgs e)
        {
            FormClasica frmClasica = new FormClasica();

            frmClasica.Show();
        }

        /// <summary>
        /// Apertura del formulario de guitarras electrica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuitarraElectrica_Click(object sender, EventArgs e)
        {
            FormElectrica frmElectrica = new FormElectrica();

            frmElectrica.Show();
        }


    }
}
