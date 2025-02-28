using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de productos en formato JSON.
    /// </summary>
    public static class ProductoDaoJson
    {
        /// <summary>
        /// Serializa y guarda la lista de productos en un archivo JSON llamado "productos.json".
        /// </summary>
        /// <param name="productos">Lista de productos a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirJson(List<Producto> productos)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "productos.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = JsonSerializer.Serialize(productos);
                    File.WriteAllText(jsonFilePath, jsonString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los productos no se han guardado, " +
                    "al cerrar la aplicación se perderán los datos");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de productos desde el archivo "productos.json".
        /// </summary>
        /// <param name="productos">Lista de productos donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerJson(List<Producto> productos)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "productos.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath);
                    List<Producto> productosLeidos = JsonSerializer.Deserialize<List<Producto>>(jsonString);

                    if (productosLeidos != null)
                    {
                        productos.Clear();
                        productos.AddRange(productosLeidos);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los productos no se han cargado desde JSON");
            }
            return "OK";
        }
    }
}
