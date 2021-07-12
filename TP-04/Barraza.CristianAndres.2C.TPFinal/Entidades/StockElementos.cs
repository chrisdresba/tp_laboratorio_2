using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public static class StockElementos
    {
        public static int ecualizador;
        public static int clavijerosClasicaNacional;
        public static int clavijerosClasicaImportado;
        public static int clavijerosTresMasTresVintage;
        public static int clavijerosTresMasTres;
        public static int clavijerosSeisEnLinea;
        public static int colorNaturalML;
        public static int colorNegroML;
        public static int colorVerdeML;
        public static int colorAzulML;
        public static int colorRojoML;
        public static int encordadosDaddarioClasica;
        public static int encordadosDaddarioAcustica;
        public static int encordadosDaddarioElectrica;
        public static int encordadosErnieBallClasica;
        public static int encordadosErnieBallAcustica;
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
            StockElementos.clavijerosClasicaNacional = 100;
            StockElementos.clavijerosClasicaImportado = 100;
            StockElementos.clavijerosTresMasTresVintage = 100;
            StockElementos.clavijerosTresMasTres = 100;
            StockElementos.clavijerosSeisEnLinea = 100;
            StockElementos.colorNaturalML = 1000;
            StockElementos.colorNegroML = 1000;
            StockElementos.colorVerdeML = 1000;
            StockElementos.colorAzulML = 1000;
            StockElementos.colorRojoML = 1000;
            StockElementos.encordadosDaddarioClasica = 100;
            StockElementos.encordadosDaddarioAcustica = 100;
            StockElementos.encordadosDaddarioElectrica = 100;
            StockElementos.encordadosErnieBallClasica = 100;
            StockElementos.encordadosErnieBallAcustica = 100;
            StockElementos.encordadosErnieBallElectrica = 100;
            StockElementos.microfonosSimple = 100;
            StockElementos.microfonosHumbucker = 100;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int Ecualizador { get { return StockElementos.ecualizador; } set { StockElementos.ecualizador = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosClasicaNacional { get { return StockElementos.clavijerosClasicaNacional; } set { StockElementos.clavijerosClasicaNacional = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosClasicaImportado { get { return StockElementos.clavijerosClasicaImportado; } set { StockElementos.clavijerosClasicaImportado = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosTresMasTres { get { return StockElementos.clavijerosTresMasTres; } set { StockElementos.clavijerosTresMasTres = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosTresMasTresVintage { get { return StockElementos.clavijerosTresMasTresVintage; } set { StockElementos.clavijerosTresMasTresVintage = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ClavijerosSeisEnLinea { get { return StockElementos.clavijerosSeisEnLinea; } set { StockElementos.clavijerosSeisEnLinea = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorNaturalML { get { return StockElementos.colorNaturalML; } set { StockElementos.colorNaturalML = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorNegroML { get { return StockElementos.colorNegroML; } set { StockElementos.colorNegroML = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorVerdeML { get { return StockElementos.colorVerdeML; } set { StockElementos.colorVerdeML = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorAzulML { get { return StockElementos.colorAzulML; } set { StockElementos.colorAzulML = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int ColorRojoML { get { return StockElementos.colorRojoML; } set { StockElementos.colorRojoML = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosDaddarioClasica { get { return StockElementos.encordadosDaddarioClasica; } set { StockElementos.encordadosDaddarioClasica = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosDaddarioAcustica { get { return StockElementos.encordadosDaddarioAcustica; } set { StockElementos.encordadosDaddarioAcustica = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosDaddarioElectrica { get { return StockElementos.encordadosDaddarioElectrica; } set { StockElementos.encordadosDaddarioElectrica = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosErnieBallClasica { get { return StockElementos.encordadosErnieBallClasica; } set { StockElementos.encordadosErnieBallClasica = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosErnieBallAcustica { get { return StockElementos.encordadosErnieBallAcustica; } set { StockElementos.encordadosErnieBallAcustica = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int EncordadosErnieBallElectrica { get { return StockElementos.encordadosErnieBallElectrica; } set { StockElementos.encordadosErnieBallElectrica = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int MicrofonosSimple { get { return StockElementos.microfonosSimple; } set { StockElementos.microfonosSimple = value; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public static int MicrofonosHumbucker { get { return StockElementos.microfonosHumbucker; } set { StockElementos.microfonosHumbucker = value; } }

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
            sb.AppendLine($"Clavijeros Clasica Nacional {StockElementos.ClavijerosClasicaNacional} unidades");
            sb.AppendLine($"Clavijeros Clasica Importado {StockElementos.ClavijerosClasicaImportado} unidades");
            sb.AppendLine($"Clavijeros 3+3 {StockElementos.ClavijerosTresMasTres} unidades");
            sb.AppendLine($"Clavijeros 3+3 Vintage {StockElementos.ClavijerosTresMasTresVintage} unidades");
            sb.AppendLine($"Clavijeros 6 en Linea {StockElementos.ClavijerosSeisEnLinea} unidades");
            sb.AppendLine($"Pintura color Natural {StockElementos.ColorNaturalML} Ml");
            sb.AppendLine($"Pintura color Negro {StockElementos.ColorNegroML} Ml");
            sb.AppendLine($"Pintura color Verde {StockElementos.ColorVerdeML} Ml");
            sb.AppendLine($"Pintura color Azul {StockElementos.ColorAzulML} Ml");
            sb.AppendLine($"Pintura color Rojo {StockElementos.ColorRojoML} Ml");
            sb.AppendLine($"Encordado Clasica Daddario {StockElementos.EncordadosDaddarioClasica} unidades");
            sb.AppendLine($"Encordado Clasica Ernie Ball {StockElementos.EncordadosErnieBallClasica} unidades");
            sb.AppendLine($"Encordado Acustica Daddario {StockElementos.EncordadosDaddarioAcustica} unidades");
            sb.AppendLine($"Encordado Acustica Ernie Ball {StockElementos.EncordadosErnieBallAcustica} unidades");
            sb.AppendLine($"Encordado Electrica Daddario {StockElementos.EncordadosDaddarioElectrica} unidades");
            sb.AppendLine($"Encordado Electrica Ernie Ball {StockElementos.EncordadosErnieBallElectrica} unidades");
            sb.AppendLine($"Microfonos Simple {StockElementos.MicrofonosSimple} unidades");
            sb.AppendLine($"Microfonos Humbucker {StockElementos.MicrofonosHumbucker} unidades");

            return sb.ToString();
        }


    }
}
