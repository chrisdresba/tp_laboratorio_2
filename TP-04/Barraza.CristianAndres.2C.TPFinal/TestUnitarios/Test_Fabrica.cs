using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;


namespace TestUnitarios
{
    [TestClass]
    public class Test_Fabrica
    {
        /// <summary>
        /// Prueba de lanzamiento de FallaArchivoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FallaArchivoException))]
        public void CuandoLaRutaEsInvalidaException()
        {
            List<Guitarra> lista;

            lista = new List<Guitarra>();

            lista = Serializador.DeserializarXml<List<Guitarra>>("unArchivo.xml");
        }

        /// <summary>
        /// Comprueba que serializa y que genere el archivo
        /// </summary>
        [TestMethod]
        public void ComprobracionSiGeneraElArchivo()
        {
            //ARRANGE
            string ruta = "comidas.xml";
            List<Guitarra> listaInstrumentos;
            Clasica clasica;
            Acustica acustica;

            //ACT
            listaInstrumentos = new List<Guitarra>();

            clasica = new Clasica(EEq.No, "Am120", EClavijeros.ClasicaImportado, EColor.Negro, ECuerdas.DaddarioClasica);
            acustica = new Acustica(EEq.Si, "39KEC", EClavijeros.TresMasTres, EColor.Rojo, ECuerdas.DaddarioAcustica);

            listaInstrumentos.Add(clasica);
            listaInstrumentos.Add(acustica);

            Serializador.SerializarXml<List<Guitarra>>(listaInstrumentos, ruta);

            //ASSERT
            Assert.IsTrue(File.Exists(ruta) && listaInstrumentos.Count > 0);

        }

        /// <summary>
        /// Comprueba si la cantidad de objetos leidos en la base es mayor a 0
        /// </summary>
        [TestMethod]
        public void ComprobarBaseDeDatos()
        {
            //ARRANGE
            List<Guitarra> listaGuitarra;

            //ACT
            listaGuitarra = SqlInstrumentos.RegistroInstrumentos();

            //ASSERT
            Assert.IsTrue(listaGuitarra.Count > 0);
        }


    }
}
