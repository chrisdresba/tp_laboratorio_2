using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el char ingresado como operador, en caso de no recibir (*, / , - ) se asignara el operador +; 
        /// </summary>
        /// <param char name="operador"></param>
        /// <returns>retorna el operador validado en String</returns>
        private static string ValidarOperador(char operador)
        {
            string auxOperador;

                switch (operador)
                {
                    case '-':
                        auxOperador = "-";
                        break;
                    case '/':
                        auxOperador = "/";
                        break;
                    case '*':
                        auxOperador = "*";
                        break;
                    default:
                        auxOperador = "+";
                        break;
                }

            return auxOperador;
        }

        /// <summary>
        /// Realiza una operacion matematica con dos numeros, en caso de no recibir operador,realiza una suma
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operación</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;
            char calculo;

                if (!("".Equals(operador)))
                {
                    operador = ValidarOperador(Convert.ToChar(operador));
                    calculo = Convert.ToChar(operador);
                }
                else
                {
                    calculo = '+';
                }
           

                switch (calculo)
                {
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '/':
                        resultado = num1 / num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    default:
                        resultado = num1 + num2;
                        break;
                }
            return resultado;
        }

    }
}
