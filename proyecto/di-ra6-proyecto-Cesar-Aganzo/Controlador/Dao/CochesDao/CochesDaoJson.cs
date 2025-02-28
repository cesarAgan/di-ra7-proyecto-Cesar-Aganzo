using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de coches en formato JSON.
    /// </summary>
    public static class CochesDaoJson
    {
        /// <summary>
        /// Serializa y guarda la lista de coches en un archivo JSON llamado "coches.json".
        /// </summary>
        /// <param name="coches">Lista de coches a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static void escribirJson(List<Coche> coches)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "coches.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = JsonSerializer.Serialize(coches);
                    File.WriteAllText(jsonFilePath, jsonString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los coches no se han guardado, " +
                    "al cerrar la aplicación se perderán los datos");
            }
        }

        /// <summary>
        /// Deserializa y carga la lista de coches desde el archivo "coches.json".
        /// </summary>
        /// <param name="coches">Lista de coches donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerJson(List<Coche> coches)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "coches.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath);
                    List<Coche> cochesLeidos = JsonSerializer.Deserialize<List<Coche>>(jsonString);

                    if (cochesLeidos != null)
                    {
                        coches.Clear();
                        coches.AddRange(cochesLeidos);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los coches no se han cargado desde JSON");
            }
            return "OK";
        }
    }
}
