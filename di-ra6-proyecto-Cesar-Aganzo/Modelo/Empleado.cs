using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Modelo
{
    /// <summary>
    /// Representa un empleado con sus datos personales y laborales,
    /// incluyendo nombre, correo, fecha de alta, nivel, salario y tipo de jornada.
    /// </summary>
    [Serializable]
    public class Empleado
    {
        /// <summary>
        /// Identificador único del empleado.
        /// </summary>
        private int id;

        /// <summary>
        /// Nombre completo del empleado.
        /// </summary>
        private string name;

        /// <summary>
        /// Dirección de correo electrónico del empleado.
        /// </summary>
        private string correo;

        /// <summary>
        /// Fecha en que el empleado fue dado de alta en la empresa.
        /// </summary>
        private DateTime fechaAlta;

        /// <summary>
        /// Nivel jerárquico del empleado dentro de la organización.
        /// </summary>
        private int nivel;

        /// <summary>
        /// Salario mensual o anual del empleado, dependiendo de la estructura de pago.
        /// </summary>
        private double salario;

        /// <summary>
        /// Indica si el empleado tiene jornada reducida (menos horas de trabajo).
        /// </summary>
        private bool jornadaReducida;


        /// <summary>
        /// Constructor por defecto de la clase Empleado.
        /// </summary>
        public Empleado() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Empleado"/> con los valores especificados.
        /// </summary>
        /// <param name="id">Identificador único del empleado.</param>
        /// <param name="name">Nombre completo del empleado.</param>
        /// <param name="correo">Correo electrónico del empleado.</param>
        /// <param name="fechaAlta">Fecha en la que el empleado fue dado de alta.</param>
        /// <param name="nivel">Nivel o rango del empleado dentro de la organización.</param>
        /// <param name="salario">Salario mensual del empleado.</param>
        /// <param name="jornadaReducida">Indica si el empleado tiene jornada reducida (true) o completa (false).</param>
        public Empleado(int id, string name, string correo, DateTime fechaAlta, int nivel, double salario, bool jornadaReducida)
        {
            this.id = id;
            this.name = name;
            this.correo = correo;
            this.fechaAlta = fechaAlta;
            this.nivel = nivel;
            this.salario = salario;
            this.jornadaReducida = jornadaReducida;
        }

        /// <summary>
        /// Obtiene o establece el identificador único del empleado.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtiene o establece el nombre completo del empleado.
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Obtiene o establece el correo electrónico del empleado.
        /// </summary>
        public string Correo { get => correo; set => correo = value; }

        /// <summary>
        /// Obtiene o establece la fecha en que el empleado fue dado de alta en la empresa.
        /// </summary>
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }

        /// <summary>
        /// Obtiene o establece el nivel o rango del empleado dentro de la organización.
        /// </summary>
        public int Nivel { get => nivel; set => nivel = value; }

        /// <summary>
        /// Obtiene o establece el salario mensual del empleado.
        /// </summary>
        public double Salario { get => salario; set => salario = value; }

        /// <summary>
        /// Obtiene o establece si el empleado tiene jornada reducida (true) o completa (false).
        /// </summary>
        public bool JornadaReducida { get => jornadaReducida; set => jornadaReducida = value; }
    }
}