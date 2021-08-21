using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StockElementosDAO
    {
        private static SqlCommand comando;
        public static SqlConnection conexion;
        private static SqlDataReader lector;
        public const string DATABASE = "FabricaGuitarras";

        /// <summary>
        /// Constructor SqlInstrumentos iniciando la conexion
        /// </summary>
        static StockElementosDAO()
        {
            StockElementosDAO.conexion = new SqlConnection("Data Source=.;Initial Catalog=FabricaGuitarras ;Integrated Security=True");
            StockElementosDAO.comando = new SqlCommand();
            StockElementosDAO.comando.CommandType = CommandType.Text;
            StockElementosDAO.comando.Connection = StockElementosDAO.conexion;

        }

        /// <summary>
        /// Lectura del stock de elementos.
        /// </summary>
        /// <returns></returns>
        public static bool LecturaStock()
        {

            string consulta = "SELECT * FROM stockElementos";
            comando.CommandText = consulta;

            try
            {    ///Metodo de Extension
                if (DATABASE.ComprobarConexion() && StockElementosDAO.conexion.State != System.Data.ConnectionState.Open)
                {
                    StockElementosDAO.conexion.Open();
                }

                StockElementosDAO.lector = StockElementosDAO.comando.ExecuteReader();

                while (StockElementosDAO.lector.Read())
                {
                    StockElementos.ecualizador = (int)lector[1];
                    StockElementos.clavijerosClasicaNacional = (int)lector[2];
                    StockElementos.clavijerosClasicaImportado = (int)lector[3];
                    StockElementos.clavijerosTresMasTresVintage = (int)lector[4];
                    StockElementos.clavijerosTresMasTres = (int)lector[5];
                    StockElementos.clavijerosSeisEnLinea = (int)lector[6];
                    StockElementos.colorNaturalML = (int)lector[7];
                    StockElementos.colorNegroML = (int)lector[8];
                    StockElementos.colorVerdeML = (int)lector[9];
                    StockElementos.colorAzulML = (int)lector[10];
                    StockElementos.colorRojoML = (int)lector[11];
                    StockElementos.encordadosDaddarioClasica = (int)lector[12];
                    StockElementos.encordadosDaddarioAcustica = (int)lector[13];
                    StockElementos.encordadosDaddarioElectrica = (int)lector[14];
                    StockElementos.encordadosErnieBallClasica = (int)lector[15];
                    StockElementos.encordadosErnieBallAcustica = (int)lector[16];
                    StockElementos.encordadosErnieBallElectrica = (int)lector[17];
                    StockElementos.microfonosSimple = (int)lector[18];
                    StockElementos.microfonosHumbucker = (int)lector[19];

                }
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                if (StockElementosDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return true;
        }

        /// <summary>
        /// Modificar el stock de los elementos que se utilizan para la construcción
        /// </summary>
        /// <returns></returns>
        public static bool ModificarStock()
        {
            string codigo = "Guitarras";

            try
            {

                string sentencia = "UPDATE stockElementos SET ecualizador=@eq, clavijerosClasicaNacional=@clavNac, clavijerosClasicaImportado=@clavImp, clavijerosTresMasTresVintage=@clav3V, clavijerosTresMasTres=@clav3, clavijerosSeisEnLinea=@clav6, colorNaturalML=@coNa, colorNegroML=@coNe, colorVerdeML=@coVe, colorAzulML=@coAz, colorRojoML=@coRo, encordadosDaddarioClasica=@encDC, encordadosDaddarioAcustica=@encDA, encordadosDaddarioElectrica=@encDE, encordadosErnieBallClasica=@encEC, encordadosErnieBallAcustica=@encEA, encordadosErnieBallElectrica=@encEE, microfonosSimple=@micS, microfonosHumbucker=@micH WHERE clave=@clave";

                StockElementosDAO.comando.CommandText = sentencia;
               
                StockElementosDAO.comando.Parameters.AddWithValue("@eq", StockElementos.ecualizador);
                StockElementosDAO.comando.Parameters.AddWithValue("@clavNac", StockElementos.clavijerosClasicaNacional);
                StockElementosDAO.comando.Parameters.AddWithValue("@clavImp", StockElementos.clavijerosClasicaImportado);
                StockElementosDAO.comando.Parameters.AddWithValue("@clav3V", StockElementos.clavijerosTresMasTresVintage);
                StockElementosDAO.comando.Parameters.AddWithValue("@clav3", StockElementos.clavijerosTresMasTres);
                StockElementosDAO.comando.Parameters.AddWithValue("@clav6", StockElementos.clavijerosSeisEnLinea);
                StockElementosDAO.comando.Parameters.AddWithValue("@coNa", StockElementos.colorNaturalML);
                StockElementosDAO.comando.Parameters.AddWithValue("@coNe", StockElementos.colorNegroML);
                StockElementosDAO.comando.Parameters.AddWithValue("@coVe", StockElementos.colorVerdeML);
                StockElementosDAO.comando.Parameters.AddWithValue("@coAz", StockElementos.colorAzulML);
                StockElementosDAO.comando.Parameters.AddWithValue("@coRo", StockElementos.colorRojoML);
                StockElementosDAO.comando.Parameters.AddWithValue("@encDC", StockElementos.encordadosDaddarioClasica);
                StockElementosDAO.comando.Parameters.AddWithValue("@encDA", StockElementos.encordadosDaddarioAcustica);
                StockElementosDAO.comando.Parameters.AddWithValue("@encDE", StockElementos.encordadosDaddarioElectrica);
                StockElementosDAO.comando.Parameters.AddWithValue("@encEC", StockElementos.encordadosErnieBallClasica);
                StockElementosDAO.comando.Parameters.AddWithValue("@encEA", StockElementos.encordadosErnieBallAcustica);
                StockElementosDAO.comando.Parameters.AddWithValue("@encEE", StockElementos.encordadosErnieBallElectrica);
                StockElementosDAO.comando.Parameters.AddWithValue("@micS", StockElementos.microfonosSimple);
                StockElementosDAO.comando.Parameters.AddWithValue("@micH", StockElementos.microfonosHumbucker);
                StockElementosDAO.comando.Parameters.AddWithValue("@clave", codigo);


                if (StockElementosDAO.conexion.State != ConnectionState.Open)
                {
                    StockElementosDAO.conexion.Open();
                }

                StockElementosDAO.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                if (StockElementosDAO.conexion.State == ConnectionState.Open)
                {
                    StockElementosDAO.conexion.Close();
                }

                StockElementosDAO.comando.Parameters.Clear();
            }

            return true;
        }

        

    }
}
