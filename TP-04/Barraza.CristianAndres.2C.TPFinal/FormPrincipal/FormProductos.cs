﻿using System;
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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra los productos existentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.richBoxProductos.Text = Fabrica.MostrarInformacion();
        }

       
    }
}
