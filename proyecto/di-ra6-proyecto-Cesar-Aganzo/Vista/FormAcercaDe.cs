using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{
    /// <summary>
    /// Formulario de "Acerca de" que muestra información sobre el programa.
    /// </summary>
    public partial class FormAcercaDe : Form
    {
        /// <summary>
        /// Variable para almacenar la referencia al formulario principal, utilizada para mostrarlo después de cerrar este formulario.
        /// </summary>
        private FormPrincipal formPrincipal;

        /// <summary>
        /// Constructor del formulario "Acerca de". Inicializa los componentes y configura la pantalla de inicio.
        /// </summary>
        public FormAcercaDe()
        {
            InitializeComponent();
            // Configura el richTextBox para que sea solo lectura (el usuario no puede editar el contenido)
            richTextBox1.ReadOnly = true;
            // Establece la posición del formulario al centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga. Muestra la información sobre el programa en el richTextBox.
        /// </summary>
        private void FormAcercaDe_Load(object sender, EventArgs e)
        {
            // Establece el texto que se mostrará en el richTextBox
            richTextBox1.Text = "**Acerca de**\n\n\n" +
                                "Nombre del programa:  Gestor de Objetos\n\n" +
                                "Versión:  1.0.0 - Febrero 2025\n\n" +
                                "Descripción:  " +
                                "Gestor de Objetos es una aplicación diseñada para facilitar la gestión de datos (xml o json) " +
                                "relacionados con clientes, empleados, productos y coches. Con esta herramienta, " +
                                "los usuarios pueden agregar, modificar, eliminar y consultar información de manera " +
                                "sencilla y eficiente.\n\n" +
                                "Desarrollado por:  " +
                                "César Aganzo Yeves\n\n" +
                                "Contacto:  " +
                                "Email: cesidamdam@gmail.com\n\n" +
                                "Licencia:  " +
                                "© 2025 César Aganzo. Todos los derechos reservados.  " +
                                "Este software es de uso exclusivo para fines educativos y no comercial.";
        }

        /// <summary>
        /// Evento que se ejecuta cuando el formulario se está cerrando. Muestra el formulario principal si no se está cerrando la aplicación.
        /// </summary>
        private void FormAcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si la aplicación no está siendo cerrada
            if (!Controlador.ControlApp.salir)
            {
                // Busca la referencia al formulario principal dentro de los formularios abiertos
                foreach (Form item in Application.OpenForms)
                {
                    if (item is FormPrincipal)
                    {
                        formPrincipal = (FormPrincipal)item;
                    }
                }

                // Si se encuentra el formulario principal, lo muestra
                if (formPrincipal != null)
                {
                    formPrincipal.Show();
                }
            }
        }
    }
}
