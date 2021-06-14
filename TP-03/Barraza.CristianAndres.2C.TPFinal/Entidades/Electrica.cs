using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Electrica : Guitarra,ICircuito,IProduccion
    {
        public EMicrofonos microfonos;
        const int PINTURA = 120;

        #region Constructores
        /// <summary>
        /// Constructor Electrica
        /// </summary>
        public Electrica()
        {

        }

        /// <summary>
        /// Constructor Electrica
        /// </summary>
        /// <param name="microfonos"></param>
        /// <param name="modelo"></param>
        /// <param name="clavijas"></param>
        /// <param name="color"></param>
        /// <param name="encordado"></param>
        public Electrica(EMicrofonos microfonos, string modelo, EClavijeros clavijas, EColor color,ECuerdas encordado) : base(modelo, clavijas, color,encordado)
        {     
            this.microfonos = microfonos;
            this.categoria = "Electrica";
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public override string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public override string Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public override EClavijeros Clavijas
        {
            get { return this.clavijas; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public override EColor Color
        {
            get { return this.color; }

        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public override ECuerdas Encordado
        {
            get { return this.encordado; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public EMicrofonos Microfonos
        {
            get { return this.microfonos; }
        }
        #endregion

        /// <summary>
        /// Muestra la informacion del producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Microfonos: {this.Microfonos}");
            return (sb.ToString());
        }

        #region Interfaces
        /// <summary>
        /// Reduce los microfonos utilizados del stock disponible
        /// </summary>
        /// <returns></returns>
        public bool ReducirMicrofonos()
        {
            if (this.Microfonos is EMicrofonos.TresSimple && ValidarControlStock(StockElementos.microfonosSimple, 3))
            {
                StockElementos.microfonosSimple -= 3;
                return true;
            }
            if (this.Microfonos is EMicrofonos.DosHumbucker && ValidarControlStock(StockElementos.microfonosHumbucker, 2))
            {
                StockElementos.microfonosHumbucker -= 2;
                return true;
            }
            if (this.Microfonos is EMicrofonos.DosSimpleUnHumbucker && ValidarControlStock(StockElementos.microfonosSimple, 2) && ValidarControlStock(StockElementos.microfonosHumbucker, 1))
            {
                StockElementos.microfonosHumbucker -= 1;
                StockElementos.microfonosSimple -= 2;
                return true;
            }

            return false;

        }

        /// <summary>
        /// Reduce la pintura utilizada del stock disponible
        /// </summary>
        /// <returns></returns>
        public bool DisminuirStockPintura()
        {
            if (this.Color is EColor.Azul && ValidarControlStock(StockElementos.colorAzulML, PINTURA))
            {
                StockElementos.colorAzulML -= PINTURA;
                return true;
            }
            if (this.Color is EColor.Natural && ValidarControlStock(StockElementos.colorNaturalML, PINTURA))
            {
                StockElementos.colorNaturalML -= PINTURA;
                return true;
            }
            if (this.Color is EColor.Negro && ValidarControlStock(StockElementos.colorNegroML, PINTURA))
            {
                StockElementos.colorNegroML -= PINTURA;
                return true;
            }
            if (this.Color is EColor.Rojo && ValidarControlStock(StockElementos.colorRojoML, PINTURA))
            {
                StockElementos.colorRojoML -= PINTURA;
                return true;
            }
            if (this.Color is EColor.Verde && ValidarControlStock(StockElementos.colorVerdeML, PINTURA))
            {
                StockElementos.colorVerdeML -= PINTURA;
                return true;
            }
           
            return false;

        }
        /// <summary>
        /// Reduce los clavijeros utilizados del stock disponible
        /// </summary>
        /// <returns></returns>
        public bool DisminuirStockClavijeros()
        {
            if (this.Clavijas is EClavijeros.TresMasTres && ValidarControlStock(StockElementos.clavijerosTresMasTres, 1))
            {
                StockElementos.clavijerosTresMasTres -= 1;
                return true;
            }
            if (this.Clavijas is EClavijeros.SeisEnLinea && ValidarControlStock(StockElementos.clavijerosSeisEnLinea, 1))
            {
                StockElementos.clavijerosSeisEnLinea -= 1;
                return true;
            }

            return false;

        }
        /// <summary>
        /// Reduce las cuerdas utilizadas del stock disponible
        /// </summary>
        /// <returns></returns>
        public bool DisminuirStockCuerdas()
        {
            if(ValidarControlStock(StockElementos.encordadosErnieBallElectrica, 1))
            {
                StockElementos.encordadosErnieBallElectrica -= 1;
                return true;
            }
            return false;
        }
        #endregion

        /// <summary>
        /// Disminuye del stock de componentes, todos los articulos utilizados para su construccion
        /// </summary>
        /// <returns></returns>
        public bool DisminuirStock()
        {
            bool micValidado = false;
            bool clavijeroValidado = false;

            if((this.Microfonos is EMicrofonos.TresSimple && ValidarControlStock(StockElementos.microfonosSimple,3))||(this.Microfonos is EMicrofonos.DosHumbucker && ValidarControlStock(StockElementos.microfonosHumbucker, 2)) || (this.Microfonos is EMicrofonos.DosSimpleUnHumbucker && ValidarControlStock(StockElementos.microfonosSimple, 2) && ValidarControlStock(StockElementos.microfonosHumbucker, 1)))
            {
                micValidado = true;
            }

            if((this.Clavijas is EClavijeros.TresMasTres && ValidarControlStock(StockElementos.clavijerosTresMasTres, 1)) || (this.Clavijas is EClavijeros.SeisEnLinea && ValidarControlStock(StockElementos.clavijerosSeisEnLinea, 1)))
            {
                clavijeroValidado = true;
            }

            if (micValidado && clavijeroValidado && ValidarControlStock(StockElementos.encordadosErnieBallElectrica, 1))
            {
                if (this.DisminuirStockPintura())
                {
                    this.ReducirMicrofonos();
                    this.DisminuirStockClavijeros();
                    this.DisminuirStockCuerdas();
                    return true;
                }
            }

            return false;
        }
    }

}
