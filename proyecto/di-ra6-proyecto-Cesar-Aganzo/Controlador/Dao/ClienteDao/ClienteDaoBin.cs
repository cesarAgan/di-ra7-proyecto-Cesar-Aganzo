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
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de clientes en formato binario.
    /// </summary>
    public static class ClienteDaoBin
    {
        /// <summary>
        /// Serializa y guarda la lista de clientes en un archivo binario llamado "clientes.bin".
        /// </summary>
        /// <param name="clientes">Lista de clientes a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirBin(List<Cliente> clientes)
        {
            try
            {
                using (Stream SaveFileStream = File.Create("clientes.bin"))
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(SaveFileStream, clientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir BIN: {ex.Message}\n{ex.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de clientes desde el archivo "clientes.bin".
        /// </summary>
        /// <param name="clientes">Referencia a la lista de clientes donde se cargarán los datos.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin(ref List<Cliente> clientes)
        {
            try
            {
                using (Stream OpenFileStream = File.OpenRead("clientes.bin"))
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    clientes = (List<Cliente>)deserializer.Deserialize(OpenFileStream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al leer BIN: {e.Message}\n{e.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa la lista de clientes desde "clientes.bin" solo si el archivo existe.
        /// </summary>
        /// <param name="clientes">Lista de clientes donde se añadirán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin2(List<Cliente> clientes)
        {
            try
            {
                if (File.Exists("clientes.bin"))
                {
                    using (Stream openFileStream = File.OpenRead("clientes.bin"))
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        var listaDeserializada = (List<Cliente>)deserializer.Deserialize(openFileStream);

                        clientes.Clear();
                        clientes.AddRange(listaDeserializada);
                    }
                    Console.WriteLine("Datos cargados desde clientes.bin");
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
