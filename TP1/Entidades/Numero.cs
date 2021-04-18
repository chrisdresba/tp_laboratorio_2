using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores

        public Numero() : this(0)
        {

        }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        #endregion

        /// <summary>
        /// Valida un string recibido como numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>En caso de recibir un numero retorna el mismo, en caso de no recibir un numero retorna 0</returns>
        public double ValidarNumero(string strNumero)
        {
            double retorno;
            if (double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Asigna un valor a numero,validandolo previamente
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }

        }

        /// <summary>
        /// Comprueba si un String contiene un numero binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna True si es binario, False si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            foreach (var item in binario)
            {
                if (item != '0' && item != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un binario a decima
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna el valor de la conversion si se pudo realiza sino retorna Valor inválido</returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";

            if (EsBinario(binario))
            {
                char[] arrayBin = binario.ToCharArray();
                Array.Reverse(arrayBin);

                double numero = 0;

                for (int i = 0; i < arrayBin.Length; i++)
                {
                    if (arrayBin[i] == '1')
                    {
                        if (i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += Math.Pow(2, i);
                        }
                    }
                }

                return numero.ToString();
            }
            else
            {
                return retorno;
            }
        }

        /// <summary>
        /// Convierte un decimal a binario recibiendo un double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el valor de la conversion si se pudo realiza sino retorna Valor inválido</returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido";
            int resto;
            int numDecimal = (int)numero;

            if (numDecimal > 0)
            {
                string resultado = string.Empty;
                while (numDecimal > 0)
                {
                    resto = numDecimal % 2;
                    numDecimal /= 2;
                    resultado = resto.ToString() + resultado;
                }
                return resultado;
            }
            return retorno;

        }

        /// <summary>
        ///  Convierte un decimal a binario recibiendo un string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el valor de la conversion si se pudo realiza sino retorna Valor inválido</returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            double num;

            if (double.TryParse(numero, out num) && (num > 0))
            {
                num = Convert.ToDouble(numero);
            }else
            {
                return retorno;
            }

            return DecimalBinario(num);

        }

        /// <summary>
        /// Sobrecarga el operador resta
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {

            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador producto
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {

            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador divisor
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la operacion si n2 es distinto de 0, sino retorna double.MinValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador suma
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {

            return n1.numero + n2.numero;
        }

    }
}
