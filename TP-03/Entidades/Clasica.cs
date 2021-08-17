using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clasica : Guitarra,IAmplificacion,IProduccion
    {
        public EEq ecualizador;
        const int PINTURA = 180;

        #region Constructores
        /// <summary>
        /// Constructor Clasica
        /// </summary>
        public Clasica()
        {

        }

        /// <summary>
        /// Constructor Clasica
        /// </summary>
        /// <param name="ecualizador"></param>
        /// <param name="modelo"></param>
        /// <param name="clavijas"></param>
        /// <param name="color"></param>
        /// <param name="encordado"></param>
        public Clasica(EEq ecualizador, string modelo, EClavijeros clavijas, EColor color, ECuerdas encordado) : base(modelo, clavijas, color, encordado)
        {
            this.categoria = "Clasica";
        
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
        public EEq Ecualizador
        {
            get { return this.ecualizador; }
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
            sb.AppendLine($"Ecualizador: {this.Ecualizador}");
            return (sb.ToString());
        }

        #region Interfaces
        /// <summary>
        /// Reduce un ecualizador del stock disponible, si es que se incorporo al instrumento
        /// </summary>
        /// <returns></returns>
        public bool ReducirEcualizadores()
        {
            if (this.Ecualizador is EEq.Si && ValidarControlStock(StockElementos.ecualizador, 1))
            {
                StockElementos.ecualizador -= 1;
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
        /// Reduce las clavijas utilizadas del stock disponible
        /// </summary>
        /// <returns></returns>
        public bool DisminuirStockClavijeros()
        {
            if (this.Clavijas is EClavijeros.ClasicaNacional && ValidarControlStock(StockElementos.clavijerosClasicaNacional, 1))
            {
                StockElementos.clavijerosClasicaNacional -= 1;
                return true;
            }
            if (this.Clavijas is EClavijeros.ClasicaImportado && ValidarControlStock(StockElementos.clavijerosClasicaImportado, 1))
            {
                StockElementos.clavijerosClasicaImportado -= 1;
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
            if (this.Encordado is ECuerdas.DaddarioClasica && ValidarControlStock(StockElementos.encordadosDaddarioClasica, 1))
            {
                StockElementos.encordadosDaddarioClasica -= 1;
                return true;
            }

            if (this.Encordado is ECuerdas.ErnieBallClasica && ValidarControlStock(StockElementos.encordadosErnieBallClasica, 1))
            {
                StockElementos.encordadosErnieBallClasica -= 1;
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

            bool clavijeroValidado = false;
            bool encordadoValidado = false;
            bool retorno = false;

            if ((this.Clavijas is EClavijeros.ClasicaNacional && ValidarControlStock(StockElementos.clavijerosClasicaNacional, 1)) || (this.Clavijas is EClavijeros.ClasicaImportado && ValidarControlStock(StockElementos.clavijerosClasicaImportado, 1)))
            {
                clavijeroValidado = true;
            }

            if ((this.Encordado is ECuerdas.DaddarioClasica && ValidarControlStock(StockElementos.encordadosDaddarioClasica, 1)) || (this.Encordado is ECuerdas.ErnieBallClasica && ValidarControlStock(StockElementos.encordadosErnieBallClasica, 1)))
            {
                encordadoValidado = true;
            }

            if (ValidarControlStock(StockElementos.ecualizador, 1) && clavijeroValidado && encordadoValidado)
            {
                if (this.DisminuirStockPintura())
                {
                    this.ReducirEcualizadores();
                    this.DisminuirStockClavijeros();
                    this.DisminuirStockCuerdas();
                    retorno = true;
                }
            }

            return retorno;
        }

    }


}
