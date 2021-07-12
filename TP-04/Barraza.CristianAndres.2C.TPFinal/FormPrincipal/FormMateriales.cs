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
    public partial class FormMateriales : Form
    {
        
        public FormMateriales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra los materiales disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMateriales_Load(object sender, EventArgs e)
        {
            this.richBoxMateriales.Text = StockElementos.MostrarStockElementos();
        }

        private void richBoxMateriales_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
