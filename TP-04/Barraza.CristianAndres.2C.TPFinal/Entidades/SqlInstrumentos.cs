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
    public static class SqlInstrumentos
    {
        private static SqlCommand comando;
        public static SqlConnection conexion;
        private static SqlDataReader lector;
        public const string DATABASE = "FabricaGuitarras";
        private static string categoria;
        private static string modelo;
        private static EColor color;
        private static EClavijeros clavijas;
        private static ECuerdas encordado;
        private static EEq eq;
        private static EMicrofonos microfonos;

        /// <summary>
        /// Constructor SqlInstrumentos iniciando la conexion
        /// </summary>
        static SqlInstrumentos()
        {
            SqlInstrumentos.conexion = new SqlConnection("Data Source=.;Initial Catalog=FabricaGuitarras ;Integrated Security=True");
            SqlInstrumentos.comando = new SqlCommand();
            SqlInstrumentos.comando.CommandType = CommandType.Text;
            SqlInstrumentos.comando.Connection = SqlInstrumentos.conexion;

        }

        /// <summary>
        /// Registros de los instrumentos.
        /// </summary>
        /// <returns></returns>
        public static List<Guitarra> RegistroInstrumentos()
        {

            List<Guitarra> listaAuxiliar = new List<Guitarra>();
            string consulta = "SELECT * FROM instrumentos";
            comando.CommandText = consulta;

            try
            {    ///Metodo de Extension
                if (DATABASE.ComprobarConexion() && SqlInstrumentos.conexion.State != System.Data.ConnectionState.Open)
                {
                    SqlInstrumentos.conexion.Open();
                }

                SqlInstrumentos.lector = SqlInstrumentos.comando.ExecuteReader();
             
                while (SqlInstrumentos.lector.Read())
                {
                    SqlInstrumentos.categoria = lector[1].ToString();
                    modelo = lector[2].ToString();
                    clavijas = Validaciones.AsignacionClavijas(lector[3].ToString());
                    color = Validaciones.AsignacionColor(lector[4].ToString());
                    encordado = Validaciones.AsignacionEncordado(lector[5].ToString());
                    eq = Validaciones.AsignacionEq(lector[6].ToString());
                    microfonos = Validaciones.AsignacionMics(lector[6].ToString());

                    ///Dependiendo de la categoria, utilizo el constructor correspondiente
                    if (SqlInstrumentos.categoria == "Acustica")
                    {

                        Acustica guitarraAcus = new Acustica(eq, modelo, clavijas, color, encordado);
                        guitarraAcus.Categoria = SqlInstrumentos.categoria;

                        listaAuxiliar.Add(guitarraAcus);
                    }
                    if (SqlInstrumentos.categoria == "Clasica")
                    {

                        Clasica guitarraClas = new Clasica(eq, modelo, clavijas, color, encordado);
                        guitarraClas.Categoria = SqlInstrumentos.categoria;

                        listaAuxiliar.Add(guitarraClas);
                    }
                    if (SqlInstrumentos.categoria == "Electrica")
                    {

                        Electrica guitarraElec = new Electrica(microfonos, modelo, clavijas, color, encordado);
                        guitarraElec.Categoria = SqlInstrumentos.categoria;

                        listaAuxiliar.Add(guitarraElec);
                    }
                
                }
            }
            catch(Exception)
            {
                listaAuxiliar.Clear();

            }
            finally
            {
                if (SqlInstrumentos.conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaAuxiliar;
        }


        /// <summary>
        /// Inserta la guitarra recibida en la tabla de la base de datos.
        /// </summary>
        /// <param name="guitarra"></param>
        /// <returns></returns>

        public static bool InsertarGuitarra(Guitarra guitarra)
        {
            string statement = "INSERT INTO instrumentos (categoria,modelo,clavijas,color,cuerdas,microfono) VALUES (@categoria,@modelo,@clavijas,@color,@cuerdas,@microfonos)";
            SqlInstrumentos.comando.CommandText = statement;
            SqlInstrumentos.comando.Parameters.AddWithValue("@categoria", guitarra.Categoria);
            SqlInstrumentos.comando.Parameters.AddWithValue("@modelo", guitarra.Modelo);
            SqlInstrumentos.comando.Parameters.AddWithValue("@clavijas", guitarra.Clavijas.ToString());
            SqlInstrumentos.comando.Parameters.AddWithValue("@color", guitarra.Color.ToString());
            SqlInstrumentos.comando.Parameters.AddWithValue("@cuerdas", guitarra.Encordado.ToString());
  
            try
            {
               
                  //Compruebo el tipo para llamar a la Propiedad correspondiente
                   if (guitarra is Electrica)
                   {
                   Electrica auxElec = (Electrica)guitarra;
                   SqlInstrumentos.comando.Parameters.AddWithValue("@microfonos", auxElec.Microfonos.ToString());
                   }
                   if (guitarra is Acustica)
                   {
                       Acustica auxAcus = (Acustica)guitarra;
                       SqlInstrumentos.comando.Parameters.AddWithValue("@microfonos", auxAcus.Ecualizador.ToString());
                   }
                   if (guitarra is Clasica)
                   {
                       Clasica auxClas = (Clasica)guitarra;
                       SqlInstrumentos.comando.Parameters.AddWithValue("@microfonos", auxClas.Ecualizador.ToString());
                   }

                

                if (SqlInstrumentos.conexion.State != ConnectionState.Open)
                {
                    SqlInstrumentos.conexion.Open();
                }
            
                 SqlInstrumentos.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
           
            }
            finally
            {
                if (SqlInstrumentos.conexion.State == ConnectionState.Open)
                {
                    SqlInstrumentos.conexion.Close();
                }

                SqlInstrumentos.comando.Parameters.Clear();
            }

               return true;
     
        }
        


    }
}
