using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class Test_Fabrica
    {

        /// <summary>
        /// Test del metodo ValidarControlStock
        /// </summary>
        [TestMethod]

        public void ProbarValidacionStock()
        {
            bool respuesta;
            Electrica electrica = new Electrica(EMicrofonos.TresSimple, "Stratocaster SB45", EClavijeros.SeisEnLinea, EColor.Azul, ECuerdas.ErnieBallElectrica);
            //ARRANGE
            int stock1 = 100;
            int producto1 = 2;

            //ACT
            respuesta = electrica.ValidarControlStock(stock1, producto1);

            //ASSERT
            Assert.IsTrue(respuesta);

            //ARRANGE
            int stock2 = 5;
            int producto2 = 6;

            //ACT
            respuesta = electrica.ValidarControlStock(stock2, producto2);

            //ASSERT
            Assert.IsFalse(respuesta);
        }


        /// <summary>
        /// Test del constructor de Acustica
        /// </summary>
        /// <param name="ecualizador"></param>
        /// <param name="modelo"></param>
        /// <param name="clavijas"></param>
        /// <param name="color"></param>
        /// <param name="encordado"></param>
        [TestMethod]
        [DataRow(EEq.Si, "39KEC", EClavijeros.TresMasTres, EColor.Rojo, ECuerdas.DaddarioAcustica)]

        public void InstanciarAcustica(EEq ecualizador, string modelo, EClavijeros clavijas, EColor color, ECuerdas encordado)
        {
            //ARRANGE
            Acustica acustica;

            //ACT
            acustica = new Acustica(ecualizador, modelo, clavijas, color, encordado);

            //ASSERT
            Assert.IsNotNull(acustica);


        }

        /// <summary>
        /// Test Archivos Serialización
        /// </summary>
        [TestMethod]

        public void TestearSerializacionArchivos()
        {
            //ARRANGE
            const string FILE = "stockInstrumentos.xml";
            bool retorno;
            List<Guitarra> listaInstrumentos;

            //ACT
            listaInstrumentos = new List<Guitarra>();
            retorno = Serializador.SerializarXml<List<Guitarra>>(listaInstrumentos, FILE);

            //ASSERT
            Assert.IsTrue(retorno);

        }

     
    }
}
