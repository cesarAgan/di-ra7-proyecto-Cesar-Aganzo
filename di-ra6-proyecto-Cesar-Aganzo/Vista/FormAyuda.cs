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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{

    /// <summary>
    /// Formulario de ayuda que proporciona indicaciones sobre el uso de la aplicación.
    /// Muestra videos explicativos y descripciones según la selección del usuario.
    /// </summary>
    public partial class FormAyuda : Form
    {
        /// <summary>
        /// Formulario principal asociado a este formulario (para navegación entre formularios).
        /// </summary>
        private FormPrincipal formPrincipal;

        /// <summary>
        /// Constructor del formulario de ayuda.
        /// Inicializa componentes, configura el reproductor y bloquea edición del texto.
        /// </summary>
        public FormAyuda()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "mini";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            this.StartPosition = FormStartPosition.CenterScreen;
            richTextBox1.ReadOnly = true;
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "helperAyuda.html");
            this.helpProvider1.SetHelpKeyword(this.buttonFAQ, "PreguntasFAQ");
            this.helpProvider1.SetHelpNavigator(this.buttonFAQ, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonFAQ, true);
            this.helpProvider1.SetHelpKeyword(this.listBox1, "AyudaInsert");
            this.helpProvider1.SetHelpNavigator(this.listBox1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox1, true);
            this.helpProvider1.SetHelpKeyword(this.listBox2, "AyudaModConEliminObjeto");
            this.helpProvider1.SetHelpNavigator(this.listBox2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox2, true);
            this.helpProvider1.SetHelpKeyword(this.listBox3, "AyudaExportImport");
            this.helpProvider1.SetHelpNavigator(this.listBox3, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.listBox3, true);
        }

        /// <summary>
        /// Evento al cargar el formulario. Configura los ToolTips para la interfaz.
        /// </summary>
        private void FormAyuda_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonFAQ,"Botón para ir a la ventana de Preguntas frecuentes");
            toolTip1.SetToolTip(listBox1, "Indicaciones sobre cómo insertar un objeto");
            toolTip1.SetToolTip(listBox2, "Indicaciones sobre cómo consultar, modificar o eliminar un objeto");
            toolTip1.SetToolTip(listBox3, "Indicaciones sobre cómo importar y exportar objetos");
        }

        /// <summary>
        /// Evento al cerrar el formulario. Asegura que el formulario principal reaparezca si no se está cerrando la aplicación.
        /// </summary>
        private void FormAyuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Controlador.ControlApp.salir)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item is FormPrincipal)
                    {
                        formPrincipal = (FormPrincipal)item;
                    }
                }
                formPrincipal?.Show();
            }
        }

        /// <summary>
        /// Evento al hacer clic en el botón FAQ. Cierra la ventana actual y marca el acceso a FAQs.
        /// </summary>
        private void buttonFAQ_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.aFaq = true;
            this.Close();
        }

        /// <summary>
        /// Evento al seleccionar la primera opción. Muestra video y descripción sobre la inserción de objetos.
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox1.ClearSelected();
                richTextBox1.Text = "Para añadir un objeto lo primero que tenemos que hacer es seleccionar el tipo de objeto y rellenar los campos obligatorios."+
                    "\n\nDespues de rellenar los campos obligatorios, presionamos Aceptar."+
                    "\n\nEn ese momento puedes o bien cancelar la creacion con el boton Cancelar o confirmala con el boton Guardar" +
                    "\n\nTras refrescar la lista podras ver el objeto nuevo insertado";
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string videoFolder = Path.Combine(installationPath, "Resources", "videos");
                string videoPath = Path.Combine(videoFolder, "insertar.mp4");
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }

        /// <summary>
        /// Evento al seleccionar la segunda opción. Muestra video y descripción sobre consulta, modificación y eliminación.
        /// </summary>
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {
                listBox2.ClearSelected();
                richTextBox1.Text = "Para modificar, consultar o eliminar un objeto lo primero que tenemos que hacer es seleccionar el tipo de objeto," +
                    " el tipo de operación e indicarle la ID." +
                    "\n\nAquí mismo podemos cambiar los datos, presionamos Modificar." +
                    "\n\nEn ese momento puedes o bien cancelar la modificacion con el boton Cancelar o confirmala con el boton Guardar" +
                    "\n\nPara eliminar es muy similar, seleccionamos el tipo de operacion eliminar, seleccionamos la ID deseada y presionamos Eliminar" +
                    "\n\nEn ese momento puedes o bien cancelar la eliminacion con el boton Cancelar o confirmala con el boton Guardar\n";
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string videoFolder = Path.Combine(installationPath, "Resources", "videos");
                string videoPath = Path.Combine(videoFolder, "conModElimi.mp4");
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        /// <summary>
        /// Evento al seleccionar la tercera opción. Muestra video y descripción sobre importación y exportación.
        /// </summary>
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox3.SelectedIndex == 0)
            {
                listBox3.ClearSelected();
                richTextBox1.Text = "Podemos exportar o importar objetos en este caso objetos cliente, empleados, productos y coches" +
                    " en formato JSON o formato XML" +
                    "\n\nDe igual manera podemos grabar los datos en objetos cliente, empleados, productos y coches "+
                    " en formato JSON o formato XML";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
                string installationPath = AppDomain.CurrentDomain.BaseDirectory;
                string videoFolder = Path.Combine(installationPath, "Resources", "videos");
                string videoPath = Path.Combine(videoFolder, "importExport.mp4");
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        /// <summary>
        /// Evento al hacer clic en "Volver Atrás". Cierra el formulario actual.
        /// </summary>
        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}