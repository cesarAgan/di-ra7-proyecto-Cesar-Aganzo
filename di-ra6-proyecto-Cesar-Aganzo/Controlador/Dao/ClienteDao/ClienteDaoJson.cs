using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador.Dao
{
    /// <summary>
    /// Clase DAO (Data Access Object) para gestionar la serialización y deserialización de datos de clientes en formato JSON.
    /// </summary>
    public static class ClienteDaoJson
    {
        /// <summary>
        /// Serializa y guarda la lista de clientes en un archivo JSON llamado "clientes.json".
        /// </summary>
        /// <param name="clientes">Lista de clientes a serializar.</param>
        /// <returns>Devuelve un mensaje que indica si la operación se realizó correctamente o no.</returns>
        public static void escribirJson(List<Cliente> clientes)
        {
            try
            {
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "clientes.json");

                string jsonString = JsonSerializer.Serialize(clientes);
                File.WriteAllText(jsonFilePath, jsonString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Los clientes no se han guardado, " +
                    "al cerrar la aplicación se perderán los datos");
            }
        }

        /// <summary>
        /// Deserializa y carga la lista de clientes desde el archivo "clientes.json".
        /// </summary>
        /// <param name="clienteList">Lista de clientes donde se cargarán los datos deserializados.</param>
        /// <returns>Devuelve "OK" si la operación se realiza correctamente, de lo contrario muestra un mensaje de error.</returns>
        public static string leerJson(List<Cliente> clienteList)
        {
            try
            {

                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(installationPath, "clientes.json");

                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath);
                    List<Cliente> clientesLeidos = JsonSerializer.Deserialize<List<Cliente>>(jsonString);

                    if (clientesLeidos != null)
                    {
                        clienteList.Clear();
                        clienteList.AddRange(clientesLeidos);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Los clientes no se han cargado desde Json");
            }
            return "OK";
        }
    }
}

