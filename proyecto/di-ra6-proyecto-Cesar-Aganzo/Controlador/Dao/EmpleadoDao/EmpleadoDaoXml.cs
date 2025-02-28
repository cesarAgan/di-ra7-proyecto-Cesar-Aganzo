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
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de empleados en formato XML.
    /// </summary>
    public static class EmpleadoDaoXml
    {
        /// <summary>
        /// Serializa y guarda la lista de empleados en un archivo XML llamado "empleados.xml".
        /// </summary>
        /// <param name="empleados">Lista de empleados a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirXML(List<Empleado> empleados)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string xmlFilePath = Path.Combine(installationPath, "empleados.xml");

                using (var writer = new StreamWriter(xmlFilePath))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(empleados.GetType());
                    serializer.Serialize(writer, empleados, namespaces);
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
        /// <param name="empleados">Referencia a la lista de empleados donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml(ref List<Empleado> empleados)
        {
            string installationPath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlFilePath = Path.Combine(installationPath, "empleados.xml");

            if (File.Exists(xmlFilePath))
            {
                try
                {
                    string xml = File.ReadAllText(xmlFilePath);
                    using (var reader = new StringReader(xml))
                    {
                        XmlSerializer serializer = new XmlSerializer(empleados.GetType());
                        empleados = (List<Empleado>)serializer.Deserialize(reader);
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
        /// Deserializa la lista de empleados desde "empleados.xml" y actualiza la lista proporcionada si los datos se cargan correctamente.
        /// </summary>
        /// <param name="empleados">Lista de empleados donde se añadirán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerXml2(List<Empleado> empleados)
        {
            string installationPath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlFilePath = Path.Combine(installationPath, "empleados.xml");

            if (File.Exists(xmlFilePath))
            {
                try
                {
                    using (var reader = new StreamReader(xmlFilePath))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Empleado>));
                        List<Empleado> empleadosLeidos = (List<Empleado>)serializer.Deserialize(reader);

                        if (empleadosLeidos != null)
                        {
                            empleados.Clear();
                            empleados.AddRange(empleadosLeidos);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error leyendo xml " + e.Message);
                }
            }
            return "OK";
        }
    }
}
