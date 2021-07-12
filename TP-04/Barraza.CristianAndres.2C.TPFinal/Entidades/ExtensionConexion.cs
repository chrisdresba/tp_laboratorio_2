using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionConexion
    {
        public static bool ComprobarConexion(this string data)
        {
            bool retorno = false;

            if(SqlInstrumentos.conexion.Database == data)
            {
                retorno = true;
            }

            return retorno;
        }


    }
}
