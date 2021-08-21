using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador
    {
        
        /// <summary>
        /// Serialización archivo XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool SerializarXml<T>(T obj, string path)
        {
            XmlTextWriter escrituraXml = new XmlTextWriter(path, Encoding.UTF8);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            escrituraXml.Formatting = Formatting.Indented;
            bool retorno = false;

            try
            {
                xmlSerializer.Serialize(escrituraXml, obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al instanciar", ex);
            }
            finally
            {
                if (!(escrituraXml is null))
                {
                    escrituraXml.Close();
                    retorno = true;
                }
            }

            return retorno;
        }
     
        /// <summary>
        /// Deserealización del archivo XML
        /// Si no existe devuelvo defaul ya que no tendria sentido continuar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T DeserializarXml<T>(string path)
        {
            XmlTextReader escritorXml = new XmlTextReader(path);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T retorno = default(T);
            try
            {
                retorno = (T)xmlSerializer.Deserialize(escritorXml);                        
                
            }
            catch (Exception ex)
            {
                throw new FallaArchivoException("Error al instanciar el lector", ex);
            }
            finally
            {
                if (!(escritorXml is null))
                {
                    escritorXml.Close();
                }
            }

            return retorno;

        }

        
    }
}
