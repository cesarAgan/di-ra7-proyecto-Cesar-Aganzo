using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{
    /// <summary>
    /// Formulario que muestra las preguntas frecuentes (FAQ) y sus respuestas relacionadas con la aplicación.
    /// </summary>
    public partial class FormPreguntasFAQ : Form
    {
        /// <summary>
        /// Variable para almacenar la referencia al formulario principal, utilizada para mostrarlo después de cerrar este formulario.
        /// </summary>
        private FormPrincipal formPrincipal = new FormPrincipal();

        /// <summary>
        /// Constructor del formulario "Preguntas FAQ". Inicializa los componentes y configura la pantalla de inicio.
        /// </summary>
        public FormPreguntasFAQ()
        {
            InitializeComponent();
            // Establece la posición del formulario al centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
            // Configura el richTextBox para que sea solo lectura (el usuario no puede editar el contenido)
            richTextBox1.ReadOnly = true;
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "helperPreguntasPAQ.html");
            this.helpProvider1.SetHelpKeyword(this.buttonAyuda, "BotonAyuda");
            this.helpProvider1.SetHelpNavigator(this.buttonAyuda, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonAyuda, true);
            this.helpProvider1.SetHelpKeyword(this.listBox1, "Pregunta1");
            this.helpProvider1.SetHelpNavigator(this.listBox1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox1, true);
            this.helpProvider1.SetHelpKeyword(this.listBox2, "Pregunta2");
            this.helpProvider1.SetHelpNavigator(this.listBox2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox2, true);
            this.helpProvider1.SetHelpKeyword(this.listBox3, "Pregunta3");
            this.helpProvider1.SetHelpNavigator(this.listBox3, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox3, true);
            this.helpProvider1.SetHelpKeyword(this.listBox4, "Pregunta4");
            this.helpProvider1.SetHelpNavigator(this.listBox4, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox4, true);
            this.helpProvider1.SetHelpKeyword(this.listBox5, "Pregunta5");
            this.helpProvider1.SetHelpNavigator(this.listBox5, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox5, true);
            this.helpProvider1.SetHelpKeyword(this.listBox6, "Pregunta6");
            this.helpProvider1.SetHelpNavigator(this.listBox6, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox6, true);
            this.helpProvider1.SetHelpKeyword(this.listBox7, "Pregunta7");
            this.helpProvider1.SetHelpNavigator(this.listBox7, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox7, true);
            this.helpProvider1.SetHelpKeyword(this.listBox8, "Pregunta8");
            this.helpProvider1.SetHelpNavigator(this.listBox8, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox8, true);
            this.helpProvider1.SetHelpKeyword(this.listBox9, "Pregunta9");
            this.helpProvider1.SetHelpNavigator(this.listBox9, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox9, true);
            this.helpProvider1.SetHelpKeyword(this.listBox10, "Pregunta10");
            this.helpProvider1.SetHelpNavigator(this.listBox10, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox10, true);
        }

        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga. Configura los ToolTips para los elementos de la interfaz.
        /// </summary>
        private void FormPreguntasFAQ_Load(object sender, EventArgs e)
        {
            // Configura los ToolTips para varios controles del formulario
            toolTip1.SetToolTip(buttonAyuda, "Boton para ir a la ventana de Ayuda");
            toolTip1.SetToolTip(listBox1, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox2, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox3, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox4, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox5, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox6, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox7, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox8, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox9, "Selector de pregunta frecuente");
            toolTip1.SetToolTip(listBox10, "Selector de pregunta frecuente");
        }

        /// <summary>
        /// Evento que se ejecuta cuando el formulario se está cerrando. Muestra el formulario principal si no se está cerrando la aplicación.
        /// </summary>
        private void FormPreguntasFAQ_FormClosing(object sender, FormClosingEventArgs e)
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

        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en "Volver Atrás". Cierra el formulario de preguntas frecuentes.
        /// </summary>
        private void volverAtrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Ayuda". Muestra el formulario de ayuda.
        /// </summary>
        private void buttonAyuda_Click_1(object sender, EventArgs e)
        {
            // Marca que se accedió a la ayuda y cierra el formulario de preguntas frecuentes
            Controlador.ControlApp.aAyuda = true;
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la primera pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la primera pregunta en el richTextBox
            richTextBox1.Text = "\n\nPuede cerrarla desde la 'X' de la esquina superior derecha.\n\n" +
                                "Tambien puedes cerrar la aplicacion desde la mayoria de los menus superiores o pulsando 'Ctrl + Q'";
            listBox1.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la segunda pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la segunda pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes Insertar Objetos, pulsa sobre el boton " +
                                "\n'Insertar Objeto' en el menu principal.";
            listBox2.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la cuarta pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la cuarta pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes consultar Objetos por id, pulsa sobre el boton" +
                                "\n 'Consultar / Modificar / Eliminar' en el menu principal.";
            listBox4.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la tercera pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la tercera pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes modificar Objetos por id, pulsa sobre el boton" +
                                "\n 'Consultar / Modificar / Eliminar' en el menu principal.";
            listBox3.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la quinta pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la quinta pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes eliminar varios Objetos a la vez, pulsa sobre el boton" +
                                "'Consultar / Modificar / Eliminar' en el menu principal.";
            listBox5.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la décima pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la décima pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes modificar varios Objetos a la vez, pulsa sobre el boton" +
                                "'Consultar / Modificar / Eliminar' en el menu principal.";
            listBox10.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la séptima pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la séptima pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes eliminar varios Objetos por id, pulsa sobre el boton " +
                                "'Consultar / Modificar / Eliminar' en el menu principal.";
            listBox7.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la octava pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la octava pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes Importar Objetos, pulsa sobre el " +
                                "\nboton 'Exportar /Importar' en el menu principal.";
            listBox8.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la novena pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la novena pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes Exportar Objetos, pulsa sobre el " +
                                "\nboton 'Exportar /Importar' en el menu principal.";
            listBox9.ClearSelected();
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar la sexta pregunta en la lista de preguntas frecuentes. Muestra la respuesta en el richTextBox.
        /// </summary>
        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establece la respuesta para la sexta pregunta en el richTextBox
            richTextBox1.Text = "\n\nSi puedes Importar Objetos desde un fichero 'json', ademas puedes tambien, en '.xml'," +
                                " pulsa sobre el boton 'Exportar /Importar' en el menu principal.";
            listBox6.ClearSelected();
        }
    }
}