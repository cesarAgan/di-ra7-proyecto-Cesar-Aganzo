using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Modelo
{
    /// <summary>
    /// Representa un producto con sus atributos como nombre, descripción, precio,
    /// fecha de caducidad y descuento aplicado.
    /// </summary>
    [Serializable]
    public class Producto
    {
        /// <summary>
        /// Identificador único del producto.
        /// </summary>
        private int id;

        /// <summary>
        /// Nombre del producto.
        /// </summary>
        private string name;

        /// <summary>
        /// Descripción detallada del producto, especificando sus características.
        /// </summary>
        private string description;

        /// <summary>
        /// Precio del producto en la moneda local.
        /// </summary>
        private double precio;

        /// <summary>
        /// Fecha en que el producto caduca o pierde su validez.
        /// </summary>
        private DateTime fechaCaduca;

        /// <summary>
        /// Porcentaje de descuento aplicable al producto, si lo tiene.
        /// </summary>
        private int descuento;


        /// <summary>
        /// Constructor por defecto de la clase Producto.
        /// </summary>
        public Producto() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Producto"/> con valores específicos.
        /// </summary>
        /// <param name="id">Identificador único del producto.</param>
        /// <param name="name">Nombre del producto.</param>
        /// <param name="description">Descripción breve del producto.</param>
        /// <param name="precio">Precio unitario del producto.</param>
        /// <param name="fechaCaduca">Fecha de caducidad del producto.</param>
        /// <param name="descuento">Porcentaje de descuento aplicado al producto (0-100).</param>
        public Producto(int id, string name, string description, double precio, DateTime fechaCaduca, int descuento)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.precio = precio;
            this.fechaCaduca = fechaCaduca;
            this.descuento = descuento;
        }

        /// <summary>
        /// Obtiene o establece el identificador único del producto.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtiene o establece el nombre del producto.
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Obtiene o establece la descripción del producto.
        /// </summary>
        public string Description { get => description; set => description = value; }

        /// <summary>
        /// Obtiene o establece el precio del producto.
        /// </summary>
        public double Precio { get => precio; set => precio = value; }

        /// <summary>
        /// Obtiene o establece la fecha de caducidad del producto.
        /// </summary>
        public DateTime FechaCaduca { get => fechaCaduca; set => fechaCaduca = value; }

        /// <summary>
        /// Obtiene o establece el porcentaje de descuento aplicado al producto.
        /// </summary>
        public int Descuento { get => descuento; set => descuento = value; }
    }
}