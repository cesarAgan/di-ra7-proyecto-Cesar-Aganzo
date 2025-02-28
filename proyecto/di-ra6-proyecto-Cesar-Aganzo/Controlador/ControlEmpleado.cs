using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador
{
    /// <summary>
    /// Clase estática que gestiona las operaciones CRUD de la lista de empleados.
    /// </summary>
    public static class ControlEmpleado
    {
        /// <summary>
        /// Lista principal de empleados que se utilizará para las operaciones CRUD.
        /// </summary>
        public static List<Empleado> listEmple = Controlador.ControlApp.empleadosList;
        /// <summary>
        /// Lista auxiliar de empleados que podría usarse para filtrados o búsquedas temporales.
        /// </summary>
        public static List<Empleado> listEmpleAux = new List<Empleado>();

        /// <summary>
        /// Identificador único que se incrementará automáticamente al añadir nuevos empleados.
        /// </summary>
        public static int id = 1;

        /// <summary>
        /// Añade una lista de empleados al registro principal, asignando IDs únicos.
        /// </summary>
        /// <param name="empleados">Lista de empleados a añadir.</param>
        /// <returns>La cantidad de empleados añadidos.</returns>
        public static int aniadirEmpleado(List<Empleado> empleados)
        {
            if (listEmple.Count > 0)
            {
                id = listEmple.Last().Id + 1;
            }
            foreach (var item in empleados)
            {
                item.Id = id;
                id++;
                listEmple.Add(item);
            }

            return empleados.Count;
        }

        /// <summary>
        /// Modifica los datos de los empleados existentes basándose en su ID.
        /// </summary>
        /// <param name="empleados">Lista de empleados con los datos actualizados.</param>
        /// <returns>La cantidad de empleados modificados.</returns>
        public static int modificarEmpleado(List<Empleado> empleados)
        {
            foreach (Empleado item in empleados)
            {
                Empleado aux = listEmple.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listEmple.Remove(aux);
                    listEmple.Add(item);
                }
            }

            return empleados.Count;
        }

        /// <summary>
        /// Elimina empleados de la lista principal basándose en su ID.
        /// </summary>
        /// <param name="empleados">Lista de empleados a eliminar.</param>
        /// <returns>La cantidad de empleados eliminados.</returns>
        public static int eliminarEmpleado(List<Empleado> empleados)
        {
            foreach (Empleado item in empleados)
            {
                Empleado aux = listEmple.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listEmple.Remove(aux);
                }
            }

            return empleados.Count;
        }
    }
}