using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void CargarGuitarra();

    [XmlInclude(typeof(Acustica))]
    [XmlInclude(typeof(Clasica))]
    [XmlInclude(typeof(Electrica))]
    
    public abstract class Guitarra
    {
        public string modelo;
        public string categoria;
        public EClavijeros clavijas;
        public EColor color;
        public ECuerdas encordado;

        #region Constructores

        /// <summary>
        /// Constructor de Guitarra
        /// </summary>
        public Guitarra()
        {

        }

        /// <summary>
        /// Constructor de Guitarra
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="clavijas"></param>
        /// <param name="color"></param>
        /// <param name="encordado"></param>
        protected Guitarra(string modelo, EClavijeros clavijas, EColor color, ECuerdas encordado)
        {
            this.modelo = modelo;
            this.clavijas = clavijas;
            this.color = color;
            this.encordado = encordado;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad lectura y escritura
        /// </summary>
        public abstract string Modelo { get; set; }
        /// <summary>
        /// Propiedad lectura y escritura
        /// </summary>
        public abstract string Categoria { get; set; }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public abstract EClavijeros Clavijas { get;}
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public abstract EColor Color { get;}
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public abstract ECuerdas Encordado { get;}

        #endregion
        /// <summary>
        /// Sobrecarga operador
        /// </summary>
        /// <param name="listaGuitarras"></param>
        /// <param name="guitarra"></param>
        /// <returns></returns>
        public static bool operator ==(List<Guitarra> listaGuitarras, Guitarra guitarra)
        {

            foreach (Guitarra g in listaGuitarras)
            {
                if (g.GetType() == guitarra.GetType() && g.Modelo == guitarra.Modelo)
                {
                    return true;
                }

            }

            return false;
        }

        /// <summary>
        /// Sobrecarga operador
        /// </summary>
        /// <param name="listaGuitarras"></param>
        /// <param name="guitarra"></param>
        /// <returns></returns>
        public static bool operator !=(List<Guitarra> listaGuitarras, Guitarra guitarra)
        {
            return !(listaGuitarras == guitarra);
        }
      
       /// <summary>
       /// Sobrecarga operador
       /// </summary>
       /// <param name="listaGuitarras"></param>
       /// <param name="guitarra"></param>
       /// <returns></returns>
        public static List<Guitarra> operator +(List<Guitarra> listaGuitarras, Guitarra guitarra)
        {

            listaGuitarras.Add(guitarra);

            return listaGuitarras;
        }

        /// <summary>
        /// Comprobar si el stock es mayor al requerido por el producto
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ValidarControlStock(int stock, int producto)
        {
            if(stock >= producto)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Modelo}, ");
            sb.AppendLine($"Categoria: {this.Categoria}, ");
            sb.AppendLine($"Clavijas: {this.Clavijas}, ");
            sb.AppendLine($"Color: {this.Color}, ");
            sb.AppendLine($"Encordado: {this.Encordado}");

            return (sb.ToString());
        }
    }
}
