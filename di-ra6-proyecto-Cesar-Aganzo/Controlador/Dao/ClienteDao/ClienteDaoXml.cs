using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de clientes en formato XML.
    /// </summary>
    public static class ClienteDaoXml
    {
        /// <summary>
        /// Serializa y guarda la lista de clientes en un archivo XML llamado "clientes.xml".
        /// </summary>
        /// <param name="clientes">Lista de clientes a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirXML(List<Cliente> clientes)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "clientes.xml");

                using (var writer = new StreamWriter(xmlFilePath))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(clientes.GetType());
                    serializer.Serialize(writer, clientes, namespaces);
                }
            }
            catch (Exception eii)
            {
                MessageBox.Show($"Error al escribir XML: {eii.Message}\n{eii.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de clientes desde el archivo "clientes.xml".
        /// </summary>
        /// <param name="clientes">Referencia a la lista de clientes donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml(ref List<Cliente> clientes)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "clientes.xml");

                if (File.Exists(xmlFilePath))
                {
                    string xml = File.ReadAllText(xmlFilePath);
                    using (var reader = new StringReader(xml))
                    {
                        XmlSerializer serializer = new XmlSerializer(clientes.GetType());
                        clientes = (List<Cliente>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de clientes desde el archivo "clientes.xml".
        /// </summary>
        /// <param name="clientes">Lista de clientes donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml2(List<Cliente> clientes)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "clientes.xml");

                if (File.Exists(xmlFilePath))
                {
                    using (var reader = new StreamReader(xmlFilePath))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
                        List<Cliente> clientesLeidos = (List<Cliente>)serializer.Deserialize(reader);

                        if (clientesLeidos != null)
                        {
                            clientes.Clear();
                            clientes.AddRange(clientesLeidos);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
            return "OK";
        }
    }
}
