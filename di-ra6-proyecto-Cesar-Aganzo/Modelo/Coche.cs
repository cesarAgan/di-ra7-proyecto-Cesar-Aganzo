using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Modelo
{
    /// <summary>
    /// Representa un coche con sus características como nombre, modelo, cilindrada, precio, fecha de matriculación y si es descapotable.
    /// </summary>
    [Serializable]
    public class Coche
    {
        /// <summary>
        /// Identificador único del coche.
        /// </summary>
        private int id;

        /// <summary>
        /// Nombre del coche, generalmente marca y modelo.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Modelo del coche, especificando la versión o tipo.
        /// </summary>
        private string modelo;

        /// <summary>
        /// Cilindrada del motor del coche, medida en centímetros cúbicos (cc).
        /// </summary>
        private int cilindrada;

        /// <summary>
        /// Precio del coche en la moneda local.
        /// </summary>
        private double precio;

        /// <summary>
        /// Fecha de matriculación del coche, indicando cuándo fue registrado.
        /// </summary>
        private DateTime matriculacion;

        /// <summary>
        /// Indica si el coche es descapotable (tiene techo retráctil).
        /// </summary>
        private bool descapotable;


        /// <summary>
        /// Constructor por defecto de la clase <see cref="Coche"/>.
        /// </summary>
        public Coche() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Coche"/> con los valores especificados.
        /// </summary>
        /// <param name="id">Identificador único del coche.</param>
        /// <param name="nombre">Nombre o marca del coche.</param>
        /// <param name="modelo">Modelo específico del coche.</param>
        /// <param name="cilindrada">Cilindrada del motor del coche en centímetros cúbicos (cc).</param>
        /// <param name="precio">Precio de venta del coche.</param>
        /// <param name="matriculacion">Fecha de matriculación del coche.</param>
        /// <param name="descapotable">Indica si el coche es descapotable (true) o no (false).</param>
        public Coche(int id, string nombre, string modelo, int cilindrada, double precio, DateTime matriculacion, bool descapotable)
        {
            this.id = id;
            this.nombre = nombre;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.precio = precio;
            this.matriculacion = matriculacion;
            this.descapotable = descapotable;
        }

        /// <summary>
        /// Obtiene o establece el identificador único del coche.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtiene o establece el nombre o marca del coche.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el modelo específico del coche.
        /// </summary>
        public string Modelo { get => modelo; set => modelo = value; }

        /// <summary>
        /// Obtiene o establece la cilindrada del motor del coche en centímetros cúbicos (cc).
        /// </summary>
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }

        /// <summary>
        /// Obtiene o establece el precio de venta del coche.
        /// </summary>
        public double Precio { get => precio; set => precio = value; }

        /// <summary>
        /// Obtiene o establece la fecha de matriculación del coche.
        /// </summary>
        public DateTime Matriculacion { get => matriculacion; set => matriculacion = value; }

        /// <summary>
        /// Obtiene o establece si el coche es descapotable (true) o no (false).
        /// </summary>
        public bool Descapotable { get => descapotable; set => descapotable = value; }
    }
}