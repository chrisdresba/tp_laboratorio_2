using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFabrica
{
    public partial class FormFabrica : Form
    {
      
        Thread hilo;
        Thread hiloBase;
        const string FILE = "stockInstrumentos.xml";
       
     
        public FormFabrica()
        {
            InitializeComponent();
            this.hilo = null;
            this.hiloBase = null;

        }

        /// <summary>
        /// Carga del formulario, inicia el hilo con la lectura del archivo de instrumentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
          

            if (this.hilo == null || !this.hilo.IsAlive)
            {
                this.hilo = new Thread(this.DescargaDeLista);
                this.hilo.Start();
               
            }

            if (this.hiloBase == null || !this.hiloBase.IsAlive)
            {
               
                this.hiloBase = new Thread(this.CargarListaDesdeBase);
                this.hiloBase.Start(); 
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

        /// <summary>
        /// Al cierre corroboro los hilos y si no son null, los finalizo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFabrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo != null)
            {
                this.hilo.Abort();
            }

            if (this.hiloBase != null)
            {
                this.hiloBase.Abort();
            }
        }

        /// <summary>
        /// Descarga la lista nde instrumentos desde un archivo XML
        /// </summary>
        private void DescargaDeLista()
        {
            if (FILE != null)
            {    
                Fabrica.listaGuitarras = Serializador.DeserializarXml<List<Guitarra>>(FILE);
                if (Fabrica.listaGuitarras == null)
                {
                    Fabrica.listaGuitarras = new List<Guitarra>();
                }
            }
        }
        /// <summary>
        /// Realiza la carga desde la base de datos, si la listaGuitarras es null o tiene valor 0;
        /// Asigna el valor obtenido desde la base
        /// La primera carga de la lista se realiza desde el XML
        /// </summary>
        private void CargarListaDesdeBase()
        {
             List<Guitarra> listaAux = SqlInstrumentos.RegistroInstrumentos();

             if (Fabrica.listaGuitarras == null || Fabrica.listaGuitarras.Count == 0)
             {
                if (!(listaAux is null))
                {
                    Fabrica.listaGuitarras = listaAux;
                }
                else
                {
                    Fabrica.listaGuitarras = new List<Guitarra>();
                }
            
             }
        }

    }
}
