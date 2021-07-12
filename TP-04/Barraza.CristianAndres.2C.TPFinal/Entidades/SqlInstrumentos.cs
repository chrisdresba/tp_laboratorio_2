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
        const string DATABASE = "Guitarras TP4";
        private static string categoria;
        private static string modelo;
        private static EClavijeros clavijas;
        private static EColor color;
        private static ECuerdas cuerdas;
        private static EEq ecu;
        private static EMicrofonos microfonos;

        /// <summary>
        /// Constructor SqlInstrumentos iniciando la conexion
        /// </summary>
        static SqlInstrumentos()
        {
            SqlInstrumentos.conexion = new SqlConnection("server = .; Database= Guitarras TP4; Integrated security = true");
            SqlInstrumentos.comando = new SqlCommand();
            SqlInstrumentos.comando.CommandType = CommandType.Text;
            comando.Connection = SqlInstrumentos.conexion;

        }

        /// <summary>
        /// Registros de los instrumentos.
        /// </summary>
        /// <returns></returns>
        public static List<Guitarra> RegistroInstrumentos()
        {

            List<Guitarra> listaAuxiliar = new List<Guitarra>();
            string consulta = "SELECT * FROM Instrumentos";
            comando.CommandText = consulta;

            try
            {    ///Metodo de Extension
                if (DATABASE.ComprobarConexion() && SqlInstrumentos.conexion.State != System.Data.ConnectionState.Open && SqlInstrumentos.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    SqlInstrumentos.conexion.Open();
                }

                SqlInstrumentos.lector = SqlInstrumentos.comando.ExecuteReader();
             
                while (SqlInstrumentos.lector.Read())
                {
                    SqlInstrumentos.categoria = lector[1].ToString();
                    SqlInstrumentos.modelo = lector[2].ToString();
                    SqlInstrumentos.clavijas = (EClavijeros)lector[3];
                    SqlInstrumentos.color = (EColor)lector[4];
                    SqlInstrumentos.cuerdas = (ECuerdas)lector[5];

                    ///Dependiendo de la categoria, utilizo el constructor correspondiente
                    if (SqlInstrumentos.categoria == "Acustica")
                    {
                        SqlInstrumentos.ecu = (EEq)lector[6];
                        Acustica guitarraAcus = new Acustica(ecu, modelo,clavijas, color, cuerdas);
                        listaAuxiliar.Add(guitarraAcus);
                    }
                    if (SqlInstrumentos.categoria == "Clasica")
                    {
                        SqlInstrumentos.ecu = (EEq)lector[6];
                        Clasica guitarraClas = new Clasica(ecu, modelo, clavijas, color, cuerdas);
                        listaAuxiliar.Add(guitarraClas);
                    }
                    if (SqlInstrumentos.categoria == "Electrica")
                    {
                        SqlInstrumentos.microfonos = (EMicrofonos)lector[6];
                        Electrica guitarraElec = new Electrica(microfonos, modelo, clavijas, color, cuerdas);
                        listaAuxiliar.Add(guitarraElec);
                    }
                
                }
            }
            catch
            {
                listaAuxiliar = null;

            }
            finally
            {
                if (SqlInstrumentos.conexion.State != System.Data.ConnectionState.Open)
                    SqlInstrumentos.conexion.Close();
            }

            return listaAuxiliar;
        }


        /// <summary>
        /// Inserta la guitarra recibida en la tabla de la base de datos.
        /// </summary>
        /// <param name="guitarra"></param>
        /// <returns></returns>

        public static void InsertarGuitarra(Guitarra guitarra)
        {
           
            string statement = "INSERT INTO Instrumentos (gCategoria,gModelo,gClavijas,gColor,gCuerdas,gMicrofonos) values(@categoria,@modelo,@clavijas,@color,@cuerdas,@microfonos)";
            SqlInstrumentos.comando.CommandText = statement;
            SqlInstrumentos.comando.Parameters.AddWithValue("@categoria", guitarra.Categoria);
            SqlInstrumentos.comando.Parameters.AddWithValue("@modelo", guitarra.Modelo);
            SqlInstrumentos.comando.Parameters.AddWithValue("@clavijas", guitarra.Clavijas);
            SqlInstrumentos.comando.Parameters.AddWithValue("@color", guitarra.Color);
            SqlInstrumentos.comando.Parameters.AddWithValue("@cuerdas", guitarra.Encordado);

            //Compruebo el tipo para llamar a la Propiedad correspondiente
            if (guitarra is Electrica)
            {
            Electrica auxElec = (Electrica)guitarra;
            SqlInstrumentos.comando.Parameters.AddWithValue("@microfonos", auxElec.Microfonos);
            }
            if (guitarra is Acustica)
            {
                Acustica auxAcus = (Acustica)guitarra;
                SqlInstrumentos.comando.Parameters.AddWithValue("@microfonos", auxAcus.Ecualizador);
            }
            if (guitarra is Clasica)
            {
                Clasica auxClas = (Clasica)guitarra;
                SqlInstrumentos.comando.Parameters.AddWithValue("@microfonos", auxClas.Ecualizador);
            }


            try
            {   
                if (SqlInstrumentos.conexion.State != ConnectionState.Open)
                {
                    SqlInstrumentos.conexion.Open();
                }

            }
            finally
            {
                if (SqlInstrumentos.conexion.State == ConnectionState.Open)
                {
                    SqlInstrumentos.conexion.Close();
                }

                SqlInstrumentos.comando.Parameters.Clear();
            }


        }


    }
}
