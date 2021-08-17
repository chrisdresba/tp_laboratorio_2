using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FallaArchivoException : Exception
    {
        /// <summary>
        /// Constructor de instancia con mensaje como parametro
        /// </summary>
        /// <param name="message"></param>
        public FallaArchivoException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor de instancia de la exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public FallaArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        
    }
}
