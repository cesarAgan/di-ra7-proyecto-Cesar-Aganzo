using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador
{
    /// <summary>
    /// Clase estática que gestiona las operaciones CRUD de la lista de productos.
    /// </summary>
    public static class ControlProducto
    {
        /// <summary>
        /// Lista principal que almacena todos los productos disponibles.
        /// </summary>
        public static List<Producto> listProductos = Controlador.ControlApp.productList;

        /// <summary>
        /// Lista auxiliar que puede utilizarse para operaciones intermedias o temporales con productos.
        /// </summary>
        public static List<Producto> listProductosAux = new List<Producto>();

        /// <summary>
        /// Identificador único utilizado para asignar IDs a los nuevos productos.
        /// </summary>
        public static int id = 1;

        /*public static bool confirm = true;
        public static bool lista_cambiada = false;*/

        /// <summary>
        /// Añade una lista de productos a la lista principal, asignando IDs automáticamente.
        /// </summary>
        /// <param name="productos">Lista de productos a añadir.</param>
        /// <returns>El número de productos añadidos.</returns>
        public static int aniadirProducto(List<Producto> productos)
        {
            if (listProductos.Count > 0)
            {
                id = listProductos.Last().Id + 1;
            }

            foreach (var item in productos)
            {
                item.Id = id;
                id++;
                listProductos.Add(item);
            }

            return productos.Count;
        }

        /// <summary>
        /// Modifica productos existentes en la lista principal según el ID proporcionado.
        /// </summary>
        /// <param name="productos">Lista de productos con la información actualizada.</param>
        /// <returns>El número de productos modificados.</returns>
        public static int modificarProducto(List<Producto> productos)
        {
            foreach (Producto item in productos)
            {
                Producto aux = listProductos.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listProductos.Remove(aux);
                    listProductos.Add(item);
                }
            }

            return productos.Count;
        }

        /// <summary>
        /// Elimina productos de la lista principal según sus IDs.
        /// </summary>
        /// <param name="productos">Lista de productos que se desea eliminar.</param>
        /// <returns>El número de productos eliminados.</returns>
        public static int eliminarProducto(List<Producto> productos)
        {
            foreach (Producto item in productos)
            {
                Producto aux = listProductos.FirstOrDefault(c => c.Id == item.Id);
                if (aux != null)
                {
                    listProductos.Remove(aux);
                }
            }

            return productos.Count;
        }
    }
}