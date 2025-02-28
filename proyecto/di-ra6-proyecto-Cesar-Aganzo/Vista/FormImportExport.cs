using di_ra5_proyecto_Cesar_Aganzo.Controlador;
using di_ra5_proyecto_Cesar_Aganzo.Modelo;
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
    /// Formulario para la importación y exportación de datos de diferentes entidades (Clientes, Empleados, Productos, Coches).
    /// </summary>
    public partial class FormImportExport : Form
    {/// <summary>
     /// Lista de productos actual, utilizada para almacenar los productos cargados en la aplicación.
     /// </summary>
        private List<Producto> productosList = Controlador.ControlProducto.listProductos;

        /// <summary>
        /// Lista de clientes actual, utilizada para almacenar los clientes cargados en la aplicación.
        /// </summary>
        private List<Cliente> clientesList = Controlador.ControlCliente.listClients;

        /// <summary>
        /// Lista de empleados actual, utilizada para almacenar los empleados cargados en la aplicación.
        /// </summary>
        private List<Empleado> empleadosList = Controlador.ControlEmpleado.listEmple;

        /// <summary>
        /// Lista auxiliar de productos leídos desde un archivo, utilizada para almacenar productos
        /// cargados de un archivo JSON o XML.
        /// </summary>
        private List<Producto> productosListLeido = Controlador.ControlProducto.listProductosAux;

        /// <summary>
        /// Lista auxiliar de clientes leídos desde un archivo, utilizada para almacenar clientes
        /// cargados de un archivo JSON o XML.
        /// </summary>
        private List<Cliente> clientesListLeido = Controlador.ControlCliente.listClientsAux;

        /// <summary>
        /// Lista auxiliar de empleados leídos desde un archivo, utilizada para almacenar empleados
        /// cargados de un archivo JSON o XML.
        /// </summary>
        private List<Empleado> empleadosListLeido = Controlador.ControlEmpleado.listEmpleAux;

        /// <summary>
        /// Lista de coches actual, utilizada para almacenar los coches cargados en la aplicación.
        /// </summary>
        private List<Coche> cochesList = Controlador.ControlCoche.listCoche;

        /// <summary>
        /// Lista auxiliar de coches leídos desde un archivo, utilizada para almacenar coches
        /// cargados de un archivo JSON o XML.
        /// </summary>
        private List<Coche> cochesListLeido = Controlador.ControlCoche.listCocheAux;

        /// <summary>
        /// Instancia del formulario principal, que puede ser utilizada para realizar acciones entre formularios.
        /// </summary>
        private FormPrincipal formPrinciapal;


        /// <summary>
        /// Constructor del formulario de importación y exportación de datos. 
        /// Este constructor inicializa la interfaz de usuario del formulario y configura varios aspectos visuales,
        /// incluyendo la ubicación de la ventana en la pantalla. Además, se encarga de configurar las herramientas de ayuda 
        /// (ToolTips) para cada botón en el formulario, proporcionando información adicional sobre la función de cada botón 
        /// cuando el usuario pasa el cursor sobre ellos. Los botones permiten cargar y grabar datos de diferentes entidades 
        /// (clientes, empleados, productos, coches) en archivos de formato JSON y XML.
        /// </summary>
        public FormImportExport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.ReadOnly = true;
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "helperImportExport.html");
            toolTip1.SetToolTip(button2, "Boton para refrescar la lista de objetos");
            toolTip1.SetToolTip(button4, "Cargar datos de Clientes desde un archivo Json");
            toolTip1.SetToolTip(button5, "Grabar datos de Clientes en un archivo Json");
            toolTip1.SetToolTip(button1, "Grabar datos de Clientes en un archivo XML");
            toolTip1.SetToolTip(button3, "Cargar datos de Clientes desde un archivo XML");
            toolTip1.SetToolTip(button6, "Cargar datos de Empleados desde un archivo Json");
            toolTip1.SetToolTip(button7, "Grabar datos de Empleados en un archivo Json");
            toolTip1.SetToolTip(button8, "Cargar datos de Empleados desde un archivo XML");
            toolTip1.SetToolTip(button9, "Grabar datos de Empleados en un archivo XML");
            toolTip1.SetToolTip(button13, "Grabar datos de Productos en un archivo Json");
            toolTip1.SetToolTip(button12, "Cargar datos de Productos desde un archivo Json");
            toolTip1.SetToolTip(button10, "Cargar datos de Productos desde un archivo XML");
            toolTip1.SetToolTip(button11, "Grabar datos de Productos en un archivo XML");
            toolTip1.SetToolTip(button14, "Cargar datos de Coches desde un archivo XML");
            toolTip1.SetToolTip(button15, "Grabar datos de Coches en un archivo XML");
            toolTip1.SetToolTip(button16, "Cargar datos de Coches desde un archivo Json");
            toolTip1.SetToolTip(button17, "Grabar datos de Coches en un archivo Json");

            this.helpProvider1.SetHelpKeyword(this.button2, "RefrescarLista");
            this.helpProvider1.SetHelpNavigator(this.button2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button2, true);

            this.helpProvider1.SetHelpKeyword(this.button4, "CargarClientesJson");
            this.helpProvider1.SetHelpNavigator(this.button4, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button4, true);

            this.helpProvider1.SetHelpKeyword(this.button5, "GrabarClientesJson");
            this.helpProvider1.SetHelpNavigator(this.button5, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button5, true);

            this.helpProvider1.SetHelpKeyword(this.button1, "GrabarClientesXML");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button1, true);

            this.helpProvider1.SetHelpKeyword(this.button3, "CargarClientesXML");
            this.helpProvider1.SetHelpNavigator(this.button3, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button3, true);

            this.helpProvider1.SetHelpKeyword(this.button6, "CargarEmpleadosJson");
            this.helpProvider1.SetHelpNavigator(this.button6, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button6, true);

            this.helpProvider1.SetHelpKeyword(this.button7, "GrabarEmpleadosJson");
            this.helpProvider1.SetHelpNavigator(this.button7, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button7, true);

            this.helpProvider1.SetHelpKeyword(this.button8, "CargarEmpleadosXML");
            this.helpProvider1.SetHelpNavigator(this.button8, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button8, true);

            this.helpProvider1.SetHelpKeyword(this.button9, "GrabarEmpleadosXML");
            this.helpProvider1.SetHelpNavigator(this.button9, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button9, true);

            this.helpProvider1.SetHelpKeyword(this.button13, "GrabarProductosJson");
            this.helpProvider1.SetHelpNavigator(this.button13, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button13, true);

            this.helpProvider1.SetHelpKeyword(this.button12, "CargarProductosJson");
            this.helpProvider1.SetHelpNavigator(this.button12, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button12, true);

            this.helpProvider1.SetHelpKeyword(this.button10, "CargarProductosXML");
            this.helpProvider1.SetHelpNavigator(this.button10, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button10, true);

            this.helpProvider1.SetHelpKeyword(this.button11, "GrabarProductosXML");
            this.helpProvider1.SetHelpNavigator(this.button11, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button11, true);

            this.helpProvider1.SetHelpKeyword(this.button14, "CargarCochesXML");
            this.helpProvider1.SetHelpNavigator(this.button14, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button14, true);

            this.helpProvider1.SetHelpKeyword(this.button15, "GrabarCochesXML");
            this.helpProvider1.SetHelpNavigator(this.button15, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button15, true);

            this.helpProvider1.SetHelpKeyword(this.button16, "CargarCochesJson");
            this.helpProvider1.SetHelpNavigator(this.button16, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button16, true);

            this.helpProvider1.SetHelpKeyword(this.button17, "GrabarCochesJson");
            this.helpProvider1.SetHelpNavigator(this.button17, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.button17, true);

            this.helpProvider1.SetHelpKeyword(this.menuStrip1, "MenuSup");
            this.helpProvider1.SetHelpNavigator(this.menuStrip1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.menuStrip1, true);
        }
        /// <summary>
        /// Refresca los datos de acuerdo al tipo seleccionado en el ComboBox tipoToolStripMenuItem.
        /// </summary>
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tipoToolStripMenuItem.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientesList;
            }
            else if (tipoToolStripMenuItem.SelectedIndex == 1)
            {

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empleadosList;
            }
            else if (tipoToolStripMenuItem.SelectedIndex == 2)
            {

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productosList;
            }
            else if (tipoToolStripMenuItem.SelectedIndex == 3)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cochesList;
            }
            else
            {
                MessageBox.Show("Seleccione primero un tipo de usuario", "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem1_Click_1(sender, e);
        }
        /// <summary>
        /// Cierra el formulario y controla la salida de la aplicación.
        /// </summary>
        private void volverAtrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.salir = false;
            this.Close();
        }
        /// <summary>
        /// Cierra la aplicación completamente.
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.salir = true;
            Application.Exit();
        }
        /// <summary>
        /// Copia el texto seleccionado en un control TextBox o las celdas seleccionadas en el DataGridView al portapapeles.
        /// </summary>
        private void copiarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase text && text.SelectedText != "")
            {
                Clipboard.SetText(text.SelectedText.ToString());
                text.Copy();
            }

            if (ActiveControl is DataGridView dataGridView)
            {
                String list = "";
                foreach (DataGridViewCell item in dataGridView.SelectedCells)
                {
                    list += (item.Value.ToString() + "; ");
                }
                Clipboard.SetText(list);
            }
        }
        /// <summary>
        /// Maneja el cambio de selección del ComboBox tipoToolStripMenuItem, refrescando la vista del DataGridView según el tipo seleccionado.
        /// </summary>
        private void tipoToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoToolStripMenuItem.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientesList;
            }
            else if (tipoToolStripMenuItem.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empleadosList;
            }
            else if (tipoToolStripMenuItem.SelectedIndex == 2)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productosList;
            }
            else if (tipoToolStripMenuItem.SelectedIndex == 3)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cochesList;
            }
        }
        /// <summary>
        /// Se ejecuta al cerrar el formulario y gestiona el comportamiento del cierre, mostrando el formulario principal si es necesario.
        /// </summary>
        private void FormBuscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Controlador.ControlApp.salir)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item is FormPrincipal)
                    {
                        formPrinciapal = (FormPrincipal)item;
                    }
                }
                if (formPrinciapal.Visible == false && formPrinciapal != null)
                {
                    formPrinciapal.Show();
                }
            }
        }
        /// <summary>
        /// Carga los datos de Clientes desde un archivo Json.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Clientes de un archivo Json?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ClienteDaoJson.leerJson(clientesListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientesListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
            
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Clientes en un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de clientes en un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Clientes en un archivo Json?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ClienteDaoJson.escribirJson(clientesList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Clientes en un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de clientes en un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Clientes en un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ClienteDaoXml.escribirXML(clientesList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Clientes desde un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de clientes desde un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Clientes de un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ClienteDaoXml.leerXml2(clientesListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientesListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Empleados desde un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de empleados desde un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                 "¿Quieres cargar los datos de Empleados de un archivo Json?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.EmpleadoDaoJson.leerJson(empleadosListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empleadosListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Empleados en un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de empleados en un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                 "¿Quieres grabar los datos de Empleados en un archivo json?", "Confirmación",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.EmpleadoDaoJson.escribirJson(empleadosList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Empleados desde un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de empleados desde un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Empleados de un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.EmpleadoDaoXml.leerXml2(empleadosListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empleadosListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Empleados en un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de empleados en un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Empleados en un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.EmpleadoDaoXml.escribirXML(empleadosList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Productos en un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de productos en un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Productos en un archivo json?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ProductoDaoJson.escribirJson(productosList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Productos desde un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de productos desde un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Productos de un archivo Json?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ProductoDaoJson.leerJson(productosListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productosListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Productos desde un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de productos desde un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Productos de un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ProductoDaoXml.leerXml2(productosListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productosListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Productos en un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de productos en un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Productos en un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.ProductoDaoXml.escribirXML(productosList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Coches desde un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de coches desde un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Coches de un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.CochesDaoXml.leerXml2(cochesListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cochesListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Coches en un archivo XML.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de coches en un archivo XML.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Coches en un archivo XML?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.CochesDaoXml.escribirXML(cochesList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cargar datos de Coches desde un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se carga la lista de coches desde un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres cargar los datos de Coches de un archivo Json?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.CochesDaoJson.leerJson(cochesListLeido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cochesListLeido;
                MessageBox.Show("Datos cargados");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la carga");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de grabar datos de Coches en un archivo Json.
        /// Se muestra un mensaje de confirmación y, si se acepta, se guarda la lista de coches en un archivo Json.
        /// </summary>
        /// <param name="sender">El control que dispara el evento (el botón).</param>
        /// <param name="e">Argumentos del evento del clic.</param>
        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Quieres grabar los datos de Coches en un archivo json?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Controlador.Dao.CochesDaoJson.escribirJson(cochesList);
                MessageBox.Show("Datos escritos");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Cancelaste la escritura");
            }
        }
    }

}