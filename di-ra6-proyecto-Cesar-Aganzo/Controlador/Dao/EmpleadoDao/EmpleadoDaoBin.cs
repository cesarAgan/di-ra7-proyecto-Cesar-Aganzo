using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de empleados en formato binario.
    /// </summary>
    public static class EmpleadoDaoBin
    {
        /// <summary>
        /// Serializa y guarda la lista de empleados en un archivo binario llamado "empleado.bin".
        /// </summary>
        /// <param name="empleados">Lista de empleados a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirBin(List<Empleado> empleados)
        {
            try
            {
                Stream SaveFileStream = File.Create("empleado.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, empleados);
                SaveFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir BIN: {ex.Message}\n{ex.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de empleados desde el archivo "empleado.bin".
        /// </summary>
        /// <param name="empleados">Referencia a la lista de empleados donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin(ref List<Empleado> empleados)
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("empleado.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                empleados = (List<Empleado>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al leer BIN: {e.Message}\n{e.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de empleados desde el archivo "empleados.bin" solo si el archivo existe.
        /// </summary>
        /// <param name="empleados">Lista de empleados donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin2(List<Empleado> empleados)
        {
            try
            {
                if (File.Exists("empleados.bin"))
                {
                    using (Stream openFileStream = File.OpenRead("empleados.bin"))
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        var listaDeserializada = (List<Empleado>)deserializer.Deserialize(openFileStream);

                        empleados.Clear();
                        empleados.AddRange(listaDeserializada);
                    }
                    Console.WriteLine("Datos cargados desde empleados.bin");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al leer BIN: {e.Message}\n{e.InnerException}");
            }
            return "OK";
        }
    }
}
