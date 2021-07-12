using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Fabrica
    {
        public static List<Guitarra> listaGuitarras;

        #region Constructores
        /// <summary>
        /// Constructor de Fabrica
        /// </summary>
        static Fabrica()
        {
            Fabrica.listaGuitarras = new List<Guitarra>();
        }
        #endregion

        /// <summary>
        /// Propiedad de escritura de Guitarra
        /// </summary>
        public static Guitarra Guitarra
        {
            set
            {
                
                 if (value is Acustica)
                 {
                     listaGuitarras += (Acustica)value;
                 }
                 if (value is Clasica)
                 {
                    listaGuitarras += (Clasica)value;
                 }   
                 if (value is Electrica)
                 {
                     listaGuitarras += (Electrica)value;
                 }
                

            }
        }

       
        /// <summary>
        /// Muestra la lista de guitarras
        /// </summary>
        /// <returns></returns>
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            if (Fabrica.listaGuitarras != null)
            {
                foreach (Guitarra item in Fabrica.listaGuitarras)
                {
                    if (item is Acustica)
                    {
                        sb.AppendLine($"Acustica");
                        sb.AppendLine(item.ToString());
                    }
                    if (item is Clasica)
                    {
                        sb.AppendLine($"Clasica");
                        sb.AppendLine(item.ToString());
                    }
                    if (item is Electrica)
                    {
                        sb.AppendLine($"Electrica");
                        sb.AppendLine(item.ToString());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
