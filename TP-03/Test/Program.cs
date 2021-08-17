using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test TP3 Barraza 2C";

            Clasica clasica1;
            Clasica clasica2;
            Acustica acustica1;
            Acustica acustica2;
            Electrica electrica1;
            Electrica electrica2;
            List<Guitarra> listaAux = new List<Guitarra>();

            clasica1 = new Clasica(EEq.Si, "Ad335Eq", EClavijeros.ClasicaNacional, EColor.Natural, ECuerdas.DaddarioClasica);
            clasica2 = new Clasica(EEq.No, "Am120", EClavijeros.ClasicaImportado, EColor.Negro, ECuerdas.DaddarioClasica);
            acustica1 = new Acustica(EEq.Si, "39KEC", EClavijeros.TresMasTres, EColor.Rojo, ECuerdas.DaddarioAcustica);
            acustica2 = new Acustica(EEq.No, "31p", EClavijeros.TresMasTres, EColor.Azul, ECuerdas.DaddarioAcustica);
            electrica1 = new Electrica(EMicrofonos.DosHumbucker, "Les Paul M10", EClavijeros.TresMasTres, EColor.Verde, ECuerdas.ErnieBallElectrica);
            electrica2 = new Electrica(EMicrofonos.TresSimple, "Stratocaster SB45", EClavijeros.SeisEnLinea, EColor.Azul, ECuerdas.ErnieBallElectrica);

            listaAux.Add(clasica1);
            listaAux.Add(clasica2);
            listaAux.Add(acustica1);
            listaAux.Add(acustica2);
            listaAux.Add(electrica1);
            listaAux.Add(electrica2); /// agrego los instrumentos a una lista AUXILIAR


            Serializador.SerializarXml<List<Guitarra>>(listaAux, $"archivo.xml"); // Serializo la lista auxiliar
            Fabrica.listaGuitarras = Serializador.DeserializarXml<List<Guitarra>>($"archivo.xml"); // Deserealizo el archivo xml
            //Primero serializo los valores de listaAux en archivo.xml
            //Luego deserealizo el archivo y asigno su valor a listaGuitarras
            //De esta manera corroboramos el funcionamiento de Serializar y de Deserealizar

            Console.WriteLine("Se agregaron 6 instrumentos a la lista");

            Console.ReadKey();

            Console.WriteLine(Fabrica.MostrarInformacion().ToString()); //Muestra la lista de instrumentos

            Console.ReadKey();

            //Guitarras clasica
            clasica1.ReducirEcualizadores(); //Reduce ecualizadores del stock general si 
            clasica2.DisminuirStockPintura(); // Reduce pintura del color correspondiente del stock
            Console.WriteLine("Guitarra Clasica1 dispone de Eq : {0}", clasica1.Ecualizador.ToString());
            Console.WriteLine("Color de Guitarra Clasica2 : {0}", clasica2.Color.ToString());
            //Llamado a Propiedades de los elementos de guitarras clasicas
            Console.WriteLine("");

            Console.ReadKey();

            //Guitarras acustica
            acustica1.DisminuirStockClavijeros(); //Reduce los Clavijeros del instrumento  
            acustica2.DisminuirStockCuerdas();  // Reduce las cuerdas del stock general
            Console.WriteLine("Guitarra Acustica1 dispone de clavijas : {0}", acustica1.Clavijas.ToString());
            Console.WriteLine("Guitarra Acustica2 dispone de cuerdas : {0}", acustica2.Encordado.ToString());
            Console.WriteLine("");
            //Llamado a Propiedades de los elementos de guitarras acusticas
            Console.ReadKey();

            //Guitarras electrica
            electrica1.ReducirMicrofonos();// Reduce los microfonos del stock general
            electrica2.DisminuirStock();// Reduce todos los componentes que posee del stock general(microfonos,pintura,clavijas,cuerdas)
            Console.WriteLine("Microfonos de guitarra Electrica1 : {0}", electrica1.Microfonos.ToString());
            Console.WriteLine("Microfonos guitarra Electrica2 : {0}", electrica2.Microfonos.ToString());
            //Llamado a Propiedades de los elementos de guitarras electricas
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("Stock de microfonos humbucker disponibles: {0} unidades", StockElementos.MicrofonosHumbucker); //Cantidad de microfonos humbucker disponibles
            Console.WriteLine("Stock de pintura azul disponible: {0} Ml", StockElementos.ColorAzulML); //Cantidad de pintura azul disponible
            //Propiedades del Stock de elementos
            Console.WriteLine("");
            Console.ReadKey();

            //STOCK DE ELEMENTOS (Cuerda,Clavijeros, Microfonos, Pintura,Ecualizadores)
            Console.WriteLine(StockElementos.MostrarStockElementos().ToString()); // Muestra la lista de Stock de accesorios y elementos

            Console.ReadKey();


        }
    }
}
