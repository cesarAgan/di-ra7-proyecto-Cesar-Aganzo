using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Modelo
{
    /// <summary>
    /// Representa un cliente con información personal, estado VIP y saldo en el monedero.
    /// </summary>
    [Serializable]
    public class Cliente
    {
        /// <summary>
        /// Identificador único del cliente.
        /// </summary>
        private int id;
        /// <summary>
        /// Nombre completo del cliente.
        /// </summary>
        private string name;
        /// <summary>
        /// Dirección de correo electrónico del cliente.
        /// </summary>
        private string correo;
        /// <summary>
        /// Fecha de nacimiento del cliente.
        /// </summary>
        private DateTime fechaNaci;
        /// <summary>
        /// Indica si el cliente es un usuario VIP.
        /// </summary>
        private bool vip;
        /// <summary>
        /// Cantidad de dinero disponible en el monedero del cliente.
        /// </summary>
        private double monedero;

        /// <summary>
        /// Constructor por defecto de la clase <see cref="Cliente"/>.
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Cliente"/> con los valores especificados.
        /// </summary>
        /// <param name="id">Identificador único del cliente.</param>
        /// <param name="name">Nombre completo del cliente.</param>
        /// <param name="correo">Correo electrónico del cliente.</param>
        /// <param name="fechaNaci">Fecha de nacimiento del cliente.</param>
        /// <param name="vip">Indica si el cliente tiene estatus VIP (true) o no (false).</param>
        /// <param name="monedero">Saldo disponible en el monedero del cliente.</param>
        public Cliente(int id, string name, string correo, DateTime fechaNaci, bool vip, double monedero)
        {
            this.id = id;
            this.name = name;
            this.correo = correo;
            this.fechaNaci = fechaNaci;
            this.vip = vip;
            this.monedero = monedero;
        }

        /// <summary>
        /// Obtiene o establece el identificador único del cliente.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtiene o establece el nombre completo del cliente.
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Obtiene o establece el correo electrónico del cliente.
        /// </summary>
        public string Correo { get => correo; set => correo = value; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento del cliente.
        /// </summary>
        public DateTime FechaNaci { get => fechaNaci; set => fechaNaci = value; }

        /// <summary>
        /// Obtiene o establece si el cliente tiene estatus VIP.
        /// </summary>
        public bool Vip { get => vip; set => vip = value; }

        /// <summary>
        /// Obtiene o establece el saldo disponible en el monedero del cliente.
        /// </summary>
        public double Monedero { get => monedero; set => monedero = value; }
    }
}