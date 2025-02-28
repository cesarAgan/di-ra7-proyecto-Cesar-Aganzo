using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de empleados en formato JSON.
    /// </summary>
    public static class EmpleadoDaoJson
    {
        /// <summary>
        /// Serializa y guarda la lista de empleados en un archivo JSON llamado "empleados.json".
        /// </summary>
        /// <param name="empleados">Lista de empleados a serializar.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string escribirJson(List<Empleado> empleados)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "empleados.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = JsonSerializer.Serialize(empleados);
                    File.WriteAllText(jsonFilePath, jsonString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los empleados no se han guardado, " +
                    "al cerrar la aplicación se perderán los datos");
            }
            return "OK";
        }

        /// <summary>
        /// Deserializa y carga la lista de empleados desde el archivo "empleados.json".
        /// </summary>
        /// <param name="empleados">Lista de empleados donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerJson(List<Empleado> empleados)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "empleados.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath);
                    List<Empleado> empleadosAux = JsonSerializer.Deserialize<List<Empleado>>(jsonString);

                    if (empleadosAux != null)
                    {
                        empleados.Clear();
                        empleados.AddRange(empleadosAux);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los empleados no se han cargado desde JSON");
            }
            return "OK";
        }
    }
}
