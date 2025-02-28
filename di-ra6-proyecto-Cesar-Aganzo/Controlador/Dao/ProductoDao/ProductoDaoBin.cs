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
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de productos en formato binario.
    /// </summary>
    public static class ProductoDaoBin
    {
        /// <summary>
        /// Serializa y guarda la lista de productos en un archivo binario llamado "productos.bin".
        /// </summary>
        /// <param name="productos">Lista de productos a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirBin(List<Producto> productos)
        {
            try
            {
                Stream SaveFileStream = File.Create("productos.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, productos);
                SaveFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir BIN: {ex.Message}\n{ex.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de productos desde el archivo "productos.bin".
        /// </summary>
        /// <param name="productos">Referencia a la lista de productos donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin(ref List<Producto> productos)
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("productos.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                productos = (List<Producto>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al leer BIN: {e.Message}\n{e.InnerException}");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de productos desde el archivo "productos.bin" solo si el archivo existe.
        /// </summary>
        /// <param name="productos">Lista de productos donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerBin2(List<Producto> productos)
        {
            try
            {
                if (File.Exists("productos.bin"))
                {
                    using (Stream openFileStream = File.OpenRead("productos.bin"))
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        var listaDeserializada = (List<Producto>)deserializer.Deserialize(openFileStream);

                        productos.Clear();
                        productos.AddRange(listaDeserializada);
                    }
                    Console.WriteLine("Datos cargados desde productos.bin");
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
