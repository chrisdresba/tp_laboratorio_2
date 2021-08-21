using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        private static EColor color;
        private static EClavijeros clavijas;
        private static ECuerdas encordado;
        private static EEq eq;
        private static EMicrofonos microfonos;

        /// <summary>
        /// Asignacion de color
        /// </summary>
        /// <param name="colour"></param>
        /// <returns></returns>
        public static EColor AsignacionColor(string colour)
        {
            switch (colour) //Validacion colores
            {
                case "Natural":
                    color = EColor.Natural;
                    break;
                case "Negro":
                    color = EColor.Negro;
                    break;
                case "Verde":
                    color = EColor.Verde;
                    break;
                case "Azul":
                    color = EColor.Azul;
                    break;
                case "Rojo":
                    color = EColor.Rojo;
                    break;
            }

            return color;
        }

        /// <summary>
        /// Asignación de clavijeros
        /// </summary>
        /// <param name="clavijeros"></param>
        /// <returns></returns>
        public static EClavijeros AsignacionClavijas(string clavijeros)
        {

            switch (clavijeros)
            {
                case "SinDato":
                    clavijas = EClavijeros.SinDato;
                    break;
                case "ClasicaNacional":
                    clavijas = EClavijeros.ClasicaNacional;
                    break;
                case "ClasicaImportado":
                    clavijas = EClavijeros.ClasicaImportado;
                    break;
                case "TresMasTresVintage":
                    clavijas = EClavijeros.TresMasTresVintage;
                    break;
                case "TresMasTres":
                    clavijas = EClavijeros.TresMasTres;
                    break;
                case "SeisEnLinea":
                    clavijas = EClavijeros.SeisEnLinea;
                    break;
            }

            return clavijas;
        }

        /// <summary>
        /// Asignación de cuerdas
        /// </summary>
        /// <param name="cuerdas"></param>
        /// <returns></returns>
        public static ECuerdas AsignacionEncordado(string cuerdas)
        {
            switch (cuerdas)
            {
                case "DaddarioAcustica":
                    encordado = ECuerdas.DaddarioAcustica;
                    break;
                case "ErnieBallAcustica":
                    encordado = ECuerdas.ErnieBallAcustica;
                    break;
                case "DaddarioClasica":
                    encordado = ECuerdas.DaddarioClasica;
                    break;
                case "ErnieBallClasica":
                    encordado = ECuerdas.ErnieBallClasica;
                    break;
                case "DaddarioElectrica":
                    encordado = ECuerdas.DaddarioElectrica;
                    break;
                case "ErnieBallElectrica":
                    encordado = ECuerdas.ErnieBallElectrica;
                    break;
            }

            return encordado;
        }

        /// <summary>
        /// Asignación de microfonos
        /// </summary>
        /// <param name="mics"></param>
        /// <returns></returns>
        public static EMicrofonos AsignacionMics(string mics)
        {
            switch (mics)
            {
                case "TresSimple":
                    microfonos = EMicrofonos.TresSimple;
                    break;
                case "DosSimpleUnHumbucker":
                    microfonos = EMicrofonos.DosSimpleUnHumbucker;
                    break;
                case "DosHumbucker":
                    microfonos = EMicrofonos.DosHumbucker;
                    break;
            }

            return microfonos;
        }

        /// <summary>
        /// Asignación de Eq
        /// </summary>
        /// <param name="ecu"></param>
        /// <returns></returns>
        public static EEq AsignacionEq(string ecu)
        {
            switch (ecu)
            {
                case "Si":
                    eq = EEq.Si;
                    break;
                case "No":
                    eq = EEq.No;
                    break;
            }
            return eq;
        }


    }
}
