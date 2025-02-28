using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de productos en formato XML.
    /// </summary>
    public static class ProductoDaoXml
    {
        /// <summary>
        /// Serializa y guarda la lista de productos en un archivo XML llamado "productos.xml".
        /// </summary>
        /// <param name="productos">Lista de productos a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirXML(List<Producto> productos)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "productos.xml");

                using (var writer = new StreamWriter(xmlFilePath))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(typeof(List<Producto>));
                    serializer.Serialize(writer, productos, namespaces);
                }
            }
            catch (Exception eii)
            {
                MessageBox.Show($"Error al escribir XML: {eii.Message}\n{eii.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de empleados desde el archivo "empleados.xml".
        /// </summary>
        /// <param name="productos">Referencia a la lista de empleados donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml(ref List<Producto> productos)
        {
            string installationPath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlFilePath = Path.Combine(installationPath, "productos.xml");

            if (File.Exists(xmlFilePath))
            {
                try
                {
                    string xml = File.ReadAllText(xmlFilePath);
                    using (var reader = new StringReader(xml))
                    {
                        XmlSerializer serializer = new XmlSerializer(productos.GetType());
                        productos = (List<Producto>)serializer.Deserialize(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error leyendo xml " + e.Message);
                }
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de productos desde el archivo "productos.xml".
        /// </summary>
        /// <param name="productos">Lista de productos donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml2(List<Producto> productos)
        {
            string installationPath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlFilePath = Path.Combine(installationPath, "productos.xml");

            if (File.Exists(xmlFilePath))
            {
                try
                {
                    using (var reader = new StreamReader(xmlFilePath))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
                        List<Producto> productosLeidos = (List<Producto>)serializer.Deserialize(reader);

                        if (productosLeidos != null)
                        {
                            productos.Clear();
                            productos.AddRange(productosLeidos);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error leyendo XML: " + e.Message);
                }
            }
            return "OK";
        }

    }
}
