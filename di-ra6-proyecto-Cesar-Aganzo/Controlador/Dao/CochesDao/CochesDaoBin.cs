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
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de coches en formato binario.
    /// </summary>
    public static class CochesDaoBin
    {
        /// <summary>
        /// Serializa y guarda la lista de coches en un archivo binario llamado "coches.bin".
        /// </summary>
        /// <param name="coches">Lista de coches a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirBin(List<Coche> coches)
        {
            try
            {
                Stream SaveFileStream = File.Create("coches.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, coches);
                SaveFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir BIN: {ex.Message}\n{ex.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de coches desde el archivo "coches.bin".
        /// </summary>
        /// <param name="coches">Referencia a la lista de coches donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin(ref List<Coche> coches)
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("coches.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                coches = (List<Coche>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al leer BIN: {e.Message}\n{e.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de coches desde el archivo "coches.bin" solo si el archivo existe.
        /// </summary>
        /// <param name="coches">Lista de coches donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin2(List<Coche> coches)
        {
            try
            {
                if (File.Exists("coches.bin"))
                {
                    using (Stream openFileStream = File.OpenRead("coches.bin"))
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        var listaDeserializada = (List<Coche>)deserializer.Deserialize(openFileStream);

                        coches.Clear();
                        coches.AddRange(listaDeserializada);
                    }
                    Console.WriteLine("Datos cargados desde coches.bin");
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
