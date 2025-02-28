using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de coches en formato XML.
    /// </summary>
    public static class CochesDaoXml
    {
        /// <summary>
        /// Serializa y guarda la lista de coches en un archivo XML llamado "coches.xml".
        /// </summary>
        /// <param name="coches">Lista de coches a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirXML(List<Coche> coches)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "coches.xml");

                using (var writer = new StreamWriter(xmlFilePath))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(coches.GetType());
                    serializer.Serialize(writer, coches, namespaces);
                }
            }
            catch (Exception eii)
            {
                MessageBox.Show($"Error al escribir XML: {eii.Message}\n{eii.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de coches desde el archivo "coches.xml".
        /// </summary>
        /// <param name="coches">Referencia a la lista de coches donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml(ref List<Coche> coches)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "coches.xml");

                if (File.Exists(xmlFilePath))
                {
                    string xml = File.ReadAllText(xmlFilePath);
                    using (var reader = new StringReader(xml))
                    {
                        XmlSerializer serializer = new XmlSerializer(coches.GetType());
                        coches = (List<Coche>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error leyendo XML: {e.Message}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa la lista de coches desde "coches.xml" y actualiza la lista proporcionada si los datos se cargan correctamente.
        /// </summary>
        /// <param name="coches">Lista de coches donde se añadirán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml2(List<Coche> coches)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "coches.xml");

                if (File.Exists(xmlFilePath))
                {
                    using (var reader = new StreamReader(xmlFilePath))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Coche>));
                        List<Coche> cocheLeido = (List<Coche>)serializer.Deserialize(reader);

                        if (cocheLeido != null)
                        {
                            coches.Clear();
                            coches.AddRange(cocheLeido);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error leyendo XML: {e.Message}");
            }
            return "OK";
        }
    }
}
