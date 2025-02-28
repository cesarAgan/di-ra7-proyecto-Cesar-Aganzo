using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using di_ra5_proyecto_Cesar_Aganzo.Vista;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace di_ra5_proyecto_Cesar_Aganzo
{
    /// <summary>
    /// Clase principal del formulario. Hereda de la clase base <see cref="Form"/> y contiene la lógica para la interfaz principal de la aplicación.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Instancia del formulario de añadir elementos. Se utilizará para abrir una ventana de creación de nuevos objetos.
        /// </summary>
        private FormAniadir formAniadir;

        /// <summary>
        /// Inicializa el formulario principal de la aplicación, centra la ventana en pantalla
        /// y configura las descripciones emergentes (tooltips) para los botones principales.
        /// </summary>
        public FormPrincipal() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            toolTip1.SetToolTip(button1, "Boton para añadir objetos");
            toolTip1.SetToolTip(button2, "Boton para importar o exportar objetos");
            toolTip1.SetToolTip(button3, "Boton para modificar o eliminar objetos");
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "helperPrincipal.html");
            this.helpProvider1.SetHelpKeyword(this.button1, "BotonInsertObjeto");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.helpProvider1.SetHelpKeyword(this.button2, "BotonExportarImportarObjeto");
            this.helpProvider1.SetHelpNavigator(this.button2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.helpProvider1.SetHelpKeyword(this.button3, "BotonModificarBorrarObjeto");
            this.helpProvider1.SetHelpNavigator(this.button3, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button3, true);

        }

        /// <summary>
        /// Abre el formulario de Importación/Exportación y oculta el formulario principal.
        /// </summary>
        /// <param name="sender">El botón que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del botón.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormImportExport formBuscarUsuario = new FormImportExport();
            this.Hide();
            formBuscarUsuario.Show();
        }

        /// <summary>
        /// Abre el formulario para añadir nuevos registros y oculta el formulario principal.
        /// </summary>
        /// <param name="sender">El botón que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del botón.</param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            formAniadir = new FormAniadir();
            this.Hide();
            formAniadir.Show();
        }

        /// <summary>
        /// Abre el formulario con la tabla de clientes y oculta el formulario principal.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteTabla formClienteTabla = new FormClienteTabla();
            this.Hide();
            formClienteTabla.Show();
        }

        /// <summary>
        /// Cierra la aplicación cuando el usuario selecciona la opción "Salir" del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Abre el formulario de actualización y eliminación cuando el usuario hace clic en el botón correspondiente.
        /// </summary>
        /// <param name="sender">El botón que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del botón.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateDelete formUpdateDelete = new FormUpdateDelete();
            this.Hide();
            formUpdateDelete.Show();
        }

        /// <summary>
        /// Abre el formulario de gráficos para empleados cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void gráficosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmpleadosGrf formInforme = new FormEmpleadosGrf();
            this.Hide();
            formInforme.Show();
        }

        /// <summary>
        /// Abre el formulario de gráficos para clientes cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void gráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesGrf formClientesInformeGrf = new FormClientesGrf();
            this.Hide();
            formClientesInformeGrf.Show();
        }

        /// <summary>
        /// Abre el formulario de tablas para empleados cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void tablasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmpleadosTabla formEmpleadosTabla = new FormEmpleadosTabla();
            this.Hide();
            formEmpleadosTabla.Show();
        }

        /// <summary>
        /// Abre el formulario de tablas para productos cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void tablasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProductosTabla formProductosTabla = new FormProductosTabla();
            this.Hide();
            formProductosTabla.Show();
        }

        /// <summary>
        /// Abre el formulario de gráficos para productos cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void gráficosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProductosGrf formProductosGrf = new FormProductosGrf();
            this.Hide(); 
            formProductosGrf.Show();
        }

        /// <summary>
        /// Abre el formulario de tablas para coches cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void tablasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormCochesTabla formCochesTabla = new FormCochesTabla();
            this.Hide();
            formCochesTabla.Show();
        }

        /// <summary>
        /// Abre el formulario de gráficos para coches cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCochesGrf formCochesGrf = new FormCochesGrf();
            this.Hide(); 
            formCochesGrf.Show();
        }

        /// <summary>
        /// Abre el formulario de ayuda de la aplicacion.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void ayudaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda formAyuda = new FormAyuda();
            this.Hide();
            formAyuda.Show();
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario principal se activa. Verifica si es necesario abrir las pantallas de Preguntas Frecuentes o Ayuda.
        /// </summary>
        /// <param name="sender">El formulario que ha sido activado.</param>
        /// <param name="e">Argumentos del evento de activación.</param>
        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            if (Controlador.ControlApp.aFaq)
            {
                FormPreguntasFAQ formPreguntasFAQ = new FormPreguntasFAQ();
                this.Hide();
                formPreguntasFAQ.Show();
                Controlador.ControlApp.aFaq=false;
            }
            if (Controlador.ControlApp.aAyuda)
            {
                FormAyuda formAyuda = new FormAyuda();
                this.Hide();
                formAyuda.Show();
                Controlador.ControlApp.aAyuda = false;
            }
        }
        /// <summary>
        /// Abre el formulario de Preguntas Frecuentes cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>

        private void preguntasFrecuentesFAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreguntasFAQ formPreguntasFAQ = new FormPreguntasFAQ();
            this.Hide();
            formPreguntasFAQ.Show();
            Controlador.ControlApp.aFaq = false;
        }
        /// <summary>
        /// Abre el formulario "Acerca de" cuando el usuario selecciona la opción correspondiente del menú.
        /// </summary>
        /// <param name="sender">El elemento del menú que desencadenó este evento.</param>
        /// <param name="e">Argumentos del evento del menú.</param>
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAcercaDe formAcercaDe = new FormAcercaDe();
            this.Hide();
            formAcercaDe.Show();
            Controlador.ControlApp.aFaq = false;

        }
    }
}
