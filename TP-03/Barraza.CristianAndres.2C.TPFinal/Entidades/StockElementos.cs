using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StockElementos
    {
        public static int ecualizador;
        public static int clavijerosClasica;
        public static int clavijerosTresMasTres;
        public static int clavijerosSeisEnLinea;
        public static int colorNaturalML;
        public static int colorNegroML;
        public static int colorVerdeML;
        public static int colorAzulML;
        public static int colorRojoML;
        public static int encordadosDaddarioClasica;
        public static int encordadosDaddarioAcustica;
        public static int encordadosErnieBallElectrica;
        public static int microfonosSimple;
        public static int microfonosHumbucker;

        /// <summary>
        /// Constructor estatico de StockElementos
        /// </summary>

        #region constructores
        static StockElementos()
        {
            StockElementos.ecualizador = 50;
            StockElementos.clavijerosClasica = 100;
            StockElementos.clavijerosTresMasTres = 100;
            StockElementos.clavijerosSeisEnLinea = 100;
            StockElementos.colorNaturalML = 1000;
            StockElementos.colorNegroML = 1000;
            StockElementos.colorVerdeML = 1000;
            StockElementos.colorAzulML = 1000;
            StockElementos.colorRojoML = 1000;
            StockElementos.encordadosDaddarioClasica = 100;
            StockElementos.encordadosDaddarioAcustica = 100;
            StockElementos.encordadosErnieBallElectrica = 100;
            StockElementos.microfonosSimple = 100;
            StockElementos.microfonosHumbucker = 100;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int Ecualizador { get { return StockElementos.ecualizador; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosClasica { get { return StockElementos.clavijerosClasica; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosTresMasTres { get { return StockElementos.clavijerosTresMasTres; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosSeisEnLinea { get { return StockElementos.clavijerosSeisEnLinea; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorNaturalML { get { return StockElementos.colorNaturalML; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorNegroML { get { return StockElementos.colorNegroML; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorVerdeML { get { return StockElementos.colorVerdeML; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorAzulML { get { return StockElementos.colorAzulML; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorRojoML { get { return StockElementos.colorRojoML; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosDaddarioClasica { get { return StockElementos.encordadosDaddarioClasica; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosDaddarioAcustica { get { return StockElementos.encordadosDaddarioAcustica; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosErnieBallElectrica { get { return StockElementos.encordadosErnieBallElectrica; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int MicrofonosSimple { get { return StockElementos.microfonosSimple; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int MicrofonosHumbucker { get { return StockElementos.microfonosHumbucker; } }

        #endregion
        /// <summary>
        /// Muestra stock de los elementos disponibles
        /// </summary>
        /// <returns></returns>
        public static string MostrarStockElementos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"<-----Stock de Producción y sus elementos----->");
            sb.AppendLine($"");
            sb.AppendLine($"Ecualizadores {StockElementos.Ecualizador} unidades");
            sb.AppendLine($"Clavijeros Clasica {StockElementos.ClavijerosClasica} unidades");
            sb.AppendLine($"Clavijeros 3+3 {StockElementos.ClavijerosTresMasTres} unidades");
            sb.AppendLine($"Clavijeros 6 en Linea {StockElementos.ClavijerosSeisEnLinea} unidades");
            sb.AppendLine($"Pintura color Natural {StockElementos.ColorNaturalML} Ml");
            sb.AppendLine($"Pintura color Negro {StockElementos.ColorNegroML} Ml");
            sb.AppendLine($"Pintura color Verde {StockElementos.ColorVerdeML} Ml");
            sb.AppendLine($"Pintura color Azul {StockElementos.ColorAzulML} Ml");
            sb.AppendLine($"Pintura color Rojo {StockElementos.ColorRojoML} Ml");
            sb.AppendLine($"Encordado Clasica {StockElementos.EncordadosDaddarioClasica} unidades");
            sb.AppendLine($"Encordado Acustica {StockElementos.EncordadosDaddarioAcustica} unidades");
            sb.AppendLine($"Encordado Electrica {StockElementos.EncordadosErnieBallElectrica} unidades");
            sb.AppendLine($"Microfonos simple {StockElementos.MicrofonosSimple} unidades");
            sb.AppendLine($"Microfonos Humbucker {StockElementos.MicrofonosHumbucker} unidades");

            return sb.ToString();
        }

    }
}
