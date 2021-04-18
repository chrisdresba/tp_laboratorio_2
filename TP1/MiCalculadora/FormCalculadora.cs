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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al recibir el evento click borra los datos de los TextBox, ComboBox y Label llamando al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y Label
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";

        }
        /// <summary>
        /// Al recibir el evento click realiza una operacion de calculo con los datos recibidos y asigna el resultado a Label
        /// En caso de recibir un dato NO Numerico,no realiza la operación .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double num;
            if((double.TryParse(txtNumero1.Text, out num)) && (double.TryParse(txtNumero2.Text, out num)))
                {
                double resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString();
            }
        
        }

        /// <summary>
        /// Llama al metodo Operar de la class Calculadora
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operación</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
                double resultado = Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
          
            return resultado;
        }

        /// <summary>
        /// Genera un MessageBox preguntando si deseamos cerrar, si la respuesta es SI se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Usted realmente desea cerrar la calculadora? ", "Salir", MessageBoxButtons.YesNo).ToString() == "Yes") {
                this.Close();
            }
        }

        /// <summary>
        /// Llama al metodo DecimalBinario de class Numero para realizar la conversion de Bin a Dec
        /// Asigna el valor a Label si puede realizar la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            if (!("".Equals(lblResultado.Text)))
            {
                string resultado = lblResultado.Text;
                lblResultado.Text = Numero.DecimalBinario(resultado);
            }
        }

        /// <summary>
        /// Llama al metodo BinarioDecimal de class Numero para realizar la conversion de Dec a Bin
        /// Asigna el valor a Label si puede realizar la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!("".Equals(lblResultado.Text)))
            {
                string resultado = lblResultado.Text;
                lblResultado.Text = Numero.BinarioDecimal(resultado);
            }
        }
    }
}
