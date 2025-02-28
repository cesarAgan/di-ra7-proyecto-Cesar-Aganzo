using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador
{
    /// <summary>
    /// Clase estática que gestiona las operaciones CRUD para la lista de clientes.
    /// </summary>
    public static class ControlCliente
    {
        /// <summary>
        /// Lista principal de clientes, obtenida desde el controlador principal de la aplicación.
        /// </summary>
        public static List<Cliente> listClients = Controlador.ControlApp.clienteList;

        /// <summary>
        /// Lista auxiliar de clientes que puede usarse para operaciones de filtrado o búsquedas temporales.
        /// </summary>
        public static List<Cliente> listClientsAux = new List<Cliente>();

        /// <summary>
        /// Identificador único que se incrementará automáticamente al añadir nuevos clientes.
        /// </summary>
        public static int id = 1;

        /// <summary>
        /// Añade una lista de clientes al registro principal, asignando IDs únicos.
        /// </summary>
        /// <param name="clientes">Lista de clientes a añadir.</param>
        /// <returns>La cantidad de clientes añadidos.</returns>
        public static int aniadirCliente(List<Cliente> clientes)
        {
            if (listClients.Count > 0)
            {
                id = listClients.Last().Id + 1;
            }
            foreach (var item in clientes)
            {
                item.Id = id;
                id++;
                listClients.Add(item);
            }
            return clientes.Count;
        }

        /// <summary>
        /// Modifica los datos de los clientes existentes basándose en su ID.
        /// </summary>
        /// <param name="clientes">Lista de clientes con los datos actualizados.</param>
        /// <returns>La cantidad de clientes modificados.</returns>
        public static int modificarCliente(List<Cliente> clientes)
        {
            foreach (Cliente item in clientes)
            {
                Cliente aux = listClients.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listClients.Remove(aux);
                    listClients.Add(item);
                }
            }
            return clientes.Count;
        }

        /// <summary>
        /// Elimina clientes de la lista principal basándose en su ID.
        /// </summary>
        /// <param name="clientes">Lista de clientes a eliminar.</param>
        /// <returns>La cantidad de clientes eliminados.</returns>
        public static int eliminarCliente(List<Cliente> clientes)
        {
            foreach (Cliente item in clientes)
            {
                Cliente aux = listClients.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listClients.Remove(aux);

                    Console.WriteLine(listClients.FirstOrDefault(c => c.Id == item.Id));
                }
            }

            return clientes.Count;
        }
    }
}
