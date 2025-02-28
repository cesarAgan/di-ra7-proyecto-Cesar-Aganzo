using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador
{
    /// <summary>
    /// Clase estática que gestiona las operaciones CRUD para la lista de coches.
    /// </summary>
    public static class ControlCoche
    {
        /// <summary>
        /// Lista principal de coches, obtenida desde el controlador principal de la aplicación.
        /// </summary>
        public static List<Coche> listCoche = Controlador.ControlApp.listCoches;

        /// <summary>
        /// Lista auxiliar de coches, útil para operaciones de filtrado o búsquedas temporales.
        /// </summary>
        public static List<Coche> listCocheAux = new List<Coche>();

        /// <summary>
        /// Identificador único que se incrementará automáticamente al añadir nuevos coches.
        /// </summary>
        public static int id = 1;

        /// <summary>
        /// Añade una lista de coches al registro principal, asignando IDs únicos.
        /// </summary>
        /// <param name="coches">Lista de coches a añadir.</param>
        /// <returns>La cantidad de coches añadidos.</returns>
        public static int aniadirCoche(List<Coche> coches)
        {
            if (listCoche.Count > 0)
            {
                id = listCoche.Last().Id + 1;
            }
            foreach (var item in coches)
            {
                item.Id = id;
                id++;
                listCoche.Add(item);
            }
            return coches.Count;
        }

        /// <summary>
        /// Modifica los datos de los coches existentes basándose en su ID.
        /// </summary>
        /// <param name="coches">Lista de coches con los datos actualizados.</param>
        /// <returns>La cantidad de coches modificados.</returns>
        public static int modificarCoche(List<Coche> coches)
        {
            foreach (Coche item in coches)
            {
                Coche aux = listCoche.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listCoche.Remove(aux);
                    listCoche.Add(item);
                }
            }
            return coches.Count;
        }

        /// <summary>
        /// Elimina coches de la lista principal basándose en su ID.
        /// </summary>
        /// <param name="coches">Lista de coches a eliminar.</param>
        /// <returns>La cantidad de coches eliminados.</returns>
        public static int eliminarCoche(List<Coche> coches)
        {
            foreach (Coche item in coches)
            {
                Coche aux = listCoche.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listCoche.Remove(aux);
                }
            }
            return coches.Count;
        }
    }
}