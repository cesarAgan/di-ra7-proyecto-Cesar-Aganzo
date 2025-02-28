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

namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{
    /// <summary>
    /// Formulario para actualizar y eliminar objetos (Clientes, Empleados, Productos, Coches).
    /// Este formulario gestiona las operaciones de actualización y eliminación de distintos tipos de objetos
    /// mediante un sistema de selección, validación de campos y visualización de los datos.
    /// </summary>
    public partial class FormUpdateDelete : Form
    {
        /// <summary>
        /// Formulario principal asociado a este formulario (para navegación entre formularios).
        /// </summary>
        private FormPrincipal formPrinciapal;

        /// <summary>
        /// Lista de clientes que se utilizará para mostrar y gestionar la información de clientes.
        /// </summary>
        private List<Cliente> clientes = new List<Cliente>();

        /// <summary>
        /// Lista auxiliar de clientes para realizar búsquedas y filtrados sin modificar la lista original.
        /// </summary>
        private List<Cliente> clientesAux = new List<Cliente>();

        /// <summary>
        /// Lista de empleados que se utilizará para mostrar y gestionar la información de empleados.
        /// </summary>
        private List<Empleado> empleados = new List<Empleado>();

        /// <summary>
        /// Lista auxiliar de empleados para realizar búsquedas y filtrados sin modificar la lista original.
        /// </summary>
        private List<Empleado> empleadosAux = new List<Empleado>();

        /// <summary>
        /// Lista de productos que se utilizará para mostrar y gestionar la información de productos.
        /// </summary>
        private List<Producto> productos = new List<Producto>();

        /// <summary>
        /// Lista auxiliar de productos para realizar búsquedas y filtrados sin modificar la lista original.
        /// </summary>
        private List<Producto> productosAux = new List<Producto>();

        /// <summary>
        /// Lista de coches que se utilizará para mostrar y gestionar la información de coches.
        /// </summary>
        private List<Coche> coches = new List<Coche>();

        /// <summary>
        /// Lista auxiliar de coches para realizar búsquedas y filtrados sin modificar la lista original.
        /// </summary>
        private List<Coche> cochesAux = new List<Coche>();

        /// <summary>
        /// Indica si el objeto ha sido mostrado en la interfaz.
        /// </summary>
        private bool mostradoObjeto = false;

        /// <summary>
        /// Cliente seleccionado en el formulario para realizar operaciones de actualización o eliminación.
        /// </summary>
        private Cliente cli = new Cliente();

        /// <summary>
        /// Empleado seleccionado en el formulario para realizar operaciones de actualización o eliminación.
        /// </summary>
        private Empleado emp = new Empleado();

        /// <summary>
        /// Producto seleccionado en el formulario para realizar operaciones de actualización o eliminación.
        /// </summary>
        private Producto pro = new Producto();

        /// <summary>
        /// Coche seleccionado en el formulario para realizar operaciones de actualización o eliminación.
        /// </summary>
        private Coche coch = new Coche();

        /// <summary>
        /// Inicializa el formulario de actualización y eliminación de objetos. Este método configura todos los controles visuales
        /// del formulario, como botones, campos de texto, listas desplegables y asigna las listas de objetos para su manipulación. 
        /// También habilita los eventos y establece valores predeterminados para los controles del formulario.
        /// </summary>
        public FormUpdateDelete()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.ReadOnly = true;
            pictureBox1.Hide();
            radioButtonConsult.Select();
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "helperUpdateDelete.html");
            toolTip1.SetToolTip(buttonRefrescar, "Boton para refrescar la lista de objetos");
            toolTip1.SetToolTip(buttonAceptar, "Boton para ver un objeto");
            toolTip1.SetToolTip(buttonCancelar, "Boton para cancelar la modificacion o eliminacion de objetos");
            toolTip1.SetToolTip(buttonGuardar, "Boton para guardar la modificacion o eliminacion de objetos");
            toolTip1.SetToolTip(radioButtonClie, "Selector de tipo de objeto cliente");
            toolTip1.SetToolTip(radioButtonCoche, "Selector de tipo de objeto coche");
            toolTip1.SetToolTip(radioButtonEmpl, "Selector de tipo de objeto empleado");
            toolTip1.SetToolTip(radioButtonProduc, "Selector de tipo de objeto producto");
            toolTip1.SetToolTip(radioButtonElimi, "Selector para eliminar por 'id'");
            toolTip1.SetToolTip(radioButtonModif, "Selector para modificar por 'id'");
            toolTip1.SetToolTip(radioButtonConsult, "Selector de consulta por 'id'");
            toolTip1.SetToolTip(richTextBox1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(checkBoxMenu, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(dateTimePicker1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(numericUpDown1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(numericUpDown2, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(numericUpDown3, "Selecccione de 'id' de objeto");
            toolTip1.SetToolTip(textBox2, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(textBox1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(comboBox1, "Seleccione primero un tipo de objeto");

            this.helpProvider1.SetHelpKeyword(this.radioButtonElimi, "SelectorEliminar");
            this.helpProvider1.SetHelpNavigator(this.radioButtonElimi, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonElimi, true);


            this.helpProvider1.SetHelpKeyword(this.radioButtonModif, "SelectorModificar");
            this.helpProvider1.SetHelpNavigator(this.radioButtonModif, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonModif, true);


            this.helpProvider1.SetHelpKeyword(this.radioButtonConsult, "SelectorConsulta");
            this.helpProvider1.SetHelpNavigator(this.radioButtonConsult, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonConsult, true);


            this.helpProvider1.SetHelpKeyword(this.buttonRefrescar, "RefrescarLista");
            this.helpProvider1.SetHelpNavigator(this.buttonRefrescar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonRefrescar, true);

            this.helpProvider1.SetHelpKeyword(this.buttonAceptar, "AceptarObjeto");
            this.helpProvider1.SetHelpNavigator(this.buttonAceptar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonAceptar, true);

            this.helpProvider1.SetHelpKeyword(this.buttonCancelar, "CancelarCreacion");
            this.helpProvider1.SetHelpNavigator(this.buttonCancelar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonCancelar, true);

            this.helpProvider1.SetHelpKeyword(this.buttonGuardar, "GuardarObjeto");
            this.helpProvider1.SetHelpNavigator(this.buttonGuardar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonGuardar, true);

            this.helpProvider1.SetHelpKeyword(this.radioButtonClie, "SelectorCliente");
            this.helpProvider1.SetHelpNavigator(this.radioButtonClie, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonClie, true);

            this.helpProvider1.SetHelpKeyword(this.radioButtonCoche, "SelectorCoche");
            this.helpProvider1.SetHelpNavigator(this.radioButtonCoche, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonCoche, true);

            this.helpProvider1.SetHelpKeyword(this.radioButtonEmpl, "SelectorEmpleado");
            this.helpProvider1.SetHelpNavigator(this.radioButtonEmpl, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonEmpl, true);

            this.helpProvider1.SetHelpKeyword(this.radioButtonProduc, "SelectorProducto");
            this.helpProvider1.SetHelpNavigator(this.radioButtonProduc, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.radioButtonProduc, true);

            this.helpProvider1.SetHelpKeyword(this.richTextBox1, "RichTextBoxObjeto");
            this.helpProvider1.SetHelpNavigator(this.richTextBox1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.richTextBox1, true);

            this.helpProvider1.SetHelpKeyword(this.checkBoxMenu, "CheckBoxMenuObjeto");
            this.helpProvider1.SetHelpNavigator(this.checkBoxMenu, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.checkBoxMenu, true);

            this.helpProvider1.SetHelpKeyword(this.dateTimePicker1, "DateTimePickerObjeto");
            this.helpProvider1.SetHelpNavigator(this.dateTimePicker1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.dateTimePicker1, true);

            this.helpProvider1.SetHelpKeyword(this.numericUpDown1, "NumericUpDownObjeto");
            this.helpProvider1.SetHelpNavigator(this.numericUpDown1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.numericUpDown1, true);

            this.helpProvider1.SetHelpKeyword(this.numericUpDown2, "NumericUpDown2Objeto");
            this.helpProvider1.SetHelpNavigator(this.numericUpDown2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.numericUpDown2, true);

            this.helpProvider1.SetHelpKeyword(this.textBox2, "TextBox2Objeto");
            this.helpProvider1.SetHelpNavigator(this.textBox2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.textBox2, true);

            this.helpProvider1.SetHelpKeyword(this.textBox1, "TextBox1Objeto");
            this.helpProvider1.SetHelpNavigator(this.textBox1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.textBox1, true);

            this.helpProvider1.SetHelpKeyword(this.comboBox1, "ComoBox1Objeto");
            this.helpProvider1.SetHelpNavigator(this.comboBox1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.comboBox1, true);

            this.helpProvider1.SetHelpKeyword(this.numericUpDown3, "IdObjeto");
            this.helpProvider1.SetHelpNavigator(this.numericUpDown3, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.numericUpDown3, true);

            this.helpProvider1.SetHelpKeyword(this.menuStrip1, "MenuSup");
            this.helpProvider1.SetHelpNavigator(this.menuStrip1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.menuStrip1, true);
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga.
        /// Inicializa los controles de la interfaz de usuario, ocultando y deshabilitando varios elementos.
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Visible = false;
            cancelarToolStripMenuItem.Visible = false;
            buttonGuardar.Hide();
            buttonCancelar.Hide();
            labelCategoria.Hide();
            comboBox1.Hide();
            numericUpDown1.Hide();
            numericUpDown2.Hide();
            labelSueldoEmpl.Hide();
            richTextBox1.Hide();
            buttonLimpiar.Hide();

            labelEmpl.Hide();
            labelCli.Hide();
            labelCantCli.Hide();
            labelCantEmpl.Hide();
            labelProd.Hide();
            labelCoch.Hide();
            labelCantProd.Hide();
            label11.Hide();
            
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            richTextBox1.Enabled = false;
            checkBoxMenu.Enabled = false;
            dateTimePicker1.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            comboBox1.Enabled = false;
            
        }
        /// <summary>
        /// Evento para copiar el texto del control activo al portapapeles.
        /// Dependiendo del tipo de control activo, se copia el texto, fecha o datos de un DataGridView.
        /// </summary>
        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (ActiveControl is TextBoxBase texto && texto.SelectedText != "")
            {
                texto.Copy();
            }
            else if (ActiveControl is DateTimePicker date)
            {
                String s = date.Value.ToShortDateString();
                Clipboard.SetText(s);
            }
            else if (ActiveControl is DataGridView dataGridView)
            {
                String list = "";
                foreach (DataGridViewCell item in dataGridView.SelectedCells)
                {
                    list += (item.Value.ToString() + " ; ");
                }
                Clipboard.SetText(list);
            }
            else if (ActiveControl is NumericUpDown num)
            {

                Clipboard.SetText(num.Value.ToString());
            }
        }
        /// <summary>
        /// Evento para pegar el contenido del portapapeles en el control activo.
        /// </summary>
        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase texto)
            {
                texto.Paste();
            }
        }
        /// <summary>
        /// Evento para cortar el texto seleccionado en el control activo y copiarlo al portapapeles.
        /// </summary>
        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase texto && texto.SelectedText != "")
            {
                texto.Cut();
            }
        }
        /// <summary>
        /// Evento para borrar el texto seleccionado en el control activo.
        /// </summary>
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase texto && texto.SelectedText != "")
            {
                texto.SelectedText = string.Empty;
            }
        }
        /// <summary>
        /// Evento para cortar el texto seleccionado en el control activo y copiarlo al portapapeles
        /// desde el menu contextual.
        /// </summary>
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cortarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Evento para copiar el texto seleccionado en el control activo y copiarlo al portapapeles
        /// desde el menu contextual.
        /// </summary>
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Evento para salir de la aplicación.
        /// Se marca la variable para indicar que la aplicación debe cerrarse y luego se cierra.
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.salir = true;
            Application.Exit();
        }
        /// <summary>
        /// Evento para volver al formulario anterior, cerrando este formulario.
        /// </summary>
        private void volverAtrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.salir = false;
            this.Close();
        }
        /// <summary>
        /// Evento para pegar el contenido del portapapeles en el control activo
        /// desde el menu contextual.
        /// </summary>
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pegarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Evento para borrar el texto seleccionado en el control activo.
        /// </summary>
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Evento para cancelar la operación de edición de objetos.
        /// Se confirma la cancelación y se limpian los objetos y controles
        /// desde el menu contextual.
        /// </summary>
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCancelar_Click(sender, e);
        }
        /// <summary>
        /// Evento para guardar los cambios realizados en los objetos.
        /// Según el valor de la variable `toDelete`, se eliminan o modifican objetos
        /// desde el menu contextual.
        /// </summary>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonGuardar_Click(sender, e);
        }
        /// <summary>
        /// Evento para guardar los cambios realizados en los objetos.
        /// Según el valor de la variable `toDelete`, se eliminan o modifican objetos.
        /// </summary>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (Controlador.ControlApp.toDelete == false)
            {
                int cantidad = Controlador.ControlCliente.modificarCliente(clientesAux) +
                    Controlador.ControlEmpleado.modificarEmpleado(empleadosAux) +
                    Controlador.ControlProducto.modificarProducto(productosAux) +
                    Controlador.ControlCoche.modificarCoche(cochesAux);

                MessageBox.Show("Se han modificado " + cantidad
                    + " objetos.", "INFORMACION",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (Controlador.ControlApp.toDelete == true)
            {
                int cantidad = Controlador.ControlCliente.eliminarCliente(clientesAux) +
                    Controlador.ControlEmpleado.eliminarEmpleado(empleadosAux) +
                    Controlador.ControlProducto.eliminarProducto(productosAux) +
                    Controlador.ControlCoche.eliminarCoche(cochesAux);

                MessageBox.Show("Se han eliminado " + cantidad
                    + " objetos.", "INFORMACION",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            productosAux.Clear();
            empleadosAux.Clear();
            clientesAux.Clear();
            cochesAux.Clear();
            guardarToolStripMenuItem.Visible = false;
            cancelarToolStripMenuItem.Visible = false;
            buttonGuardar.Hide();
            buttonCancelar.Hide();
            labelCantCli.Hide();
            labelCantEmpl.Hide();
            labelEmpl.Hide();
            labelCli.Hide();
            labelCoch.Hide();
            labelProd.Hide();
            labelCantProd.Hide();
            label11.Hide();
            buttonLimpiar_Click(sender, e);
        }
        /// <summary>
        /// Evento para cancelar la edición de objetos.
        /// Muestra un mensaje de confirmación antes de limpiar los objetos modificados.
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = DialogResult.OK;
            if (clientesAux.Count != 0 || empleadosAux.Count != 0
                || productosAux.Count != 0 || cochesAux.Count != 0)
            {
                if (!Controlador.ControlApp.noPregunta)
                {
                    diaRes = MessageBox.Show("¿Desea cancelar la edición de todos los objetos?",
                        "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                if (diaRes == DialogResult.OK)
                {
                    productosAux.Clear();
                    empleadosAux.Clear();
                    clientesAux.Clear();
                    cochesAux.Clear();
                    guardarToolStripMenuItem.Visible = false;
                    cancelarToolStripMenuItem.Visible = false;
                    buttonGuardar.Hide();
                    buttonCancelar.Hide();
                    labelCantCli.Hide();
                    labelCantEmpl.Hide();
                    labelEmpl.Hide();
                    labelCli.Hide();
                    labelCoch.Hide();
                    labelProd.Hide();
                    labelCantProd.Hide();
                    label11.Hide();
                    //buttonLimpiar_Click(sender, e);
                }
            }
        }
        /// <summary>
        /// Evento para limpiar los campos del formulario según el tipo de objeto seleccionado.
        /// Configura valores predeterminados según el tipo de objeto.
        /// </summary>
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            checkBoxMenu.Checked = false;

            if (radioButtonClie.Checked == true)
            {
                dateTimePicker1.MaxDate = DateTime.Today.Date;
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-100);
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                dateTimePicker1.ResetText();
            }
            else if (radioButtonEmpl.Checked == true)
            {
                numericUpDown1.Minimum = 2000;
                numericUpDown1.Maximum = 1000000000000;
                numericUpDown1.Value = numericUpDown1.Minimum;
                comboBox1.SelectedIndex = -1;
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-35);
                dateTimePicker1.MaxDate = DateTime.Today.Date;
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                dateTimePicker1.ResetText();
            }
            else if (radioButtonProduc.Checked == true)
            {
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = 100000;
                numericUpDown1.Value = numericUpDown1.Minimum;
                numericUpDown2.Maximum = 100;
                numericUpDown2.Minimum = 0;
                numericUpDown2.Value = numericUpDown2.Minimum;
                richTextBox1.Text = "";
                dateTimePicker1.MaxDate = DateTime.Today.AddDays(50000);
                dateTimePicker1.MinDate = DateTime.Today.Date;
                dateTimePicker1.Value = dateTimePicker1.MinDate;
                dateTimePicker1.ResetText();
            }
            else if (radioButtonCoche.Checked == true)
            {
                numericUpDown1.Minimum = 1500;
                numericUpDown1.Maximum = 100000000;
                numericUpDown1.Value = numericUpDown1.Minimum;
                numericUpDown2.Maximum = 9000;
                numericUpDown2.Minimum = 0;
                numericUpDown2.Value = numericUpDown2.Minimum;
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-100);
                dateTimePicker1.MaxDate = DateTime.Today.Date;
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                dateTimePicker1.ResetText();
            }
            else
            {
                dateTimePicker1.Value = DateTime.Today.Date;
                dateTimePicker1.ResetText();
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el valor de un control NumericUpDown cambia.
        /// </summary>
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            mostradoObjeto = false;
            buttonAceptar_Click(sender, e);
        }
        /// <summary>
        /// Evento que maneja el clic en el botón "Aceptar". Permite modificar, eliminar o consultar objetos como clientes, empleados, productos y coches.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el botón "Aceptar".</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            Cliente auxC = new Cliente();
            Empleado auxE = new Empleado();
            Producto auxP = new Producto();
            Coche auxCo = new Coche();
            if (radioButtonClie.Checked == false &&
               radioButtonEmpl.Checked == false &&
               radioButtonCoche.Checked == false &&
               radioButtonProduc.Checked == false)
            {
                pictureBox1.Show();
                MessageBox.Show("Selecione primero un \"Tipo de objeto\"", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (radioButtonClie.Checked)
                {
                    if (numericUpDown3.Value > clientes.Count)
                    {
                        MessageBox.Show("Selecione una \"Id\" valida", "INFO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (!mostradoObjeto)
                        {
                            cli = clientes.FirstOrDefault(u => u.Id == numericUpDown3.Value);
                            textBox1.Text = cli.Name;
                            textBox2.Text = cli.Correo;
                            if (cli.Vip)
                            {
                                checkBoxMenu.Checked = true;
                            }
                            else
                            {
                                checkBoxMenu.Checked = false;
                            }
                            dateTimePicker1.Text = cli.FechaNaci.ToShortDateString();
                        }
                        if (radioButtonModif.Checked && mostradoObjeto)
                        {
                            Controlador.ControlApp.toDelete = false;
                            DateTime fechaNacimiento = dateTimePicker1.Value;
                            fechaNacimiento.AddYears(18);
                            int diferencia = DateTime.Today.Year - fechaNacimiento.Year;

                            if (DateTime.Today.Month > fechaNacimiento.Month ||
                                DateTime.Today.Month == fechaNacimiento.Month &&
                                DateTime.Today.Day < fechaNacimiento.Day)
                            {
                                diferencia--;
                            }

                            if (diferencia < 18)
                            {
                                MessageBox.Show("No es posible registar un cliente menor de edad.",
                                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                Cliente cliente = new Cliente((int)numericUpDown3.Value,
                                    textBox1.Text,
                                    textBox2.Text,
                                    dateTimePicker1.Value.Date,
                                    checkBoxMenu.Checked,
                                    cli.Monedero);

                                auxC = clientesAux.FirstOrDefault(c => c.Id == (int)numericUpDown3.Value);
                                if (auxC == null)
                                {
                                    clientesAux.Add(cliente);
                                }
                                else
                                {
                                    clientesAux.Remove(auxC);
                                    clientesAux.Add(cliente);
                                }
                                MessageBox.Show("Objeto modificado.\nRecuerde Guardar los cambios", "INFO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                labelCantCli.Text = clientesAux.Count.ToString();
                                labelCli.Show();
                                labelCantCli.Show();

                                cancelarToolStripMenuItem.Visible = true;
                                guardarToolStripMenuItem.Visible = true;
                                buttonGuardar.Show();
                                buttonCancelar.Show();
                            }
                        }
                        if (radioButtonElimi.Checked && mostradoObjeto)
                        {
                            Controlador.ControlApp.toDelete = true;
                            auxC = clientesAux.FirstOrDefault(cl => cl.Id == numericUpDown3.Value);
                            if (auxC == null)
                            {
                                clientesAux.Add(cli);
                            }
                            MessageBox.Show("Objeto eliminado.\nRecuerde Guardar los cambios", "INFO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelCantCli.Text = clientesAux.Count.ToString();
                            labelCli.Show();
                            labelCantCli.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();
                        }
                    }
                    mostradoObjeto = true;
                }
                else if (radioButtonEmpl.Checked)
                {
                    if (numericUpDown3.Value > empleados.Count || numericUpDown3.Value == 0)
                    {
                        MessageBox.Show("Selecione una \"Id\" valida", "INFO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (!mostradoObjeto)
                        {
                            emp = empleados.FirstOrDefault(em => em.Id == numericUpDown3.Value);
                            textBox1.Text = emp.Name;
                            textBox2.Text = emp.Correo;
                            numericUpDown1.Value = (decimal)emp.Salario;
                            comboBox1.SelectedIndex = emp.Nivel - 1;
                            if (emp.JornadaReducida)
                            {
                                checkBoxMenu.Checked = true;
                            }
                            else
                            {
                                checkBoxMenu.Checked = false;
                            }
                            dateTimePicker1.Text = emp.FechaAlta.ToShortDateString();
                            comboBox1.SelectedIndex = emp.Nivel - 1;
                        }
                        if (radioButtonModif.Checked && mostradoObjeto)
                        {
                            Empleado empleado = new Empleado((int)numericUpDown3.Value,
                                        textBox1.Text,
                                        textBox2.Text,
                                        dateTimePicker1.Value.Date,
                                        comboBox1.SelectedIndex,
                                        (double)numericUpDown1.Value,
                                        checkBoxMenu.Checked
                                        );

                            auxE = empleadosAux.FirstOrDefault(em => em.Id == (int)numericUpDown3.Value);
                            if (auxE == null)
                            {
                                empleadosAux.Add(empleado);
                            }
                            else
                            {
                                empleadosAux.Remove(auxE);
                                empleadosAux.Add(empleado);
                            }
                            MessageBox.Show("Objeto modificado.\nRecuerde Guardar los cambios", "INFO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelCantEmpl.Text = empleadosAux.Count.ToString();
                            labelEmpl.Show();
                            labelCantEmpl.Show();
                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();

                        }
                        if (radioButtonElimi.Checked && mostradoObjeto)
                        {
                            Controlador.ControlApp.toDelete = true;
                            auxE = empleadosAux.FirstOrDefault(cl => cl.Id == numericUpDown3.Value);
                            if (auxE == null)
                            {
                                empleadosAux.Add(emp);
                            }
                            MessageBox.Show("Objeto modificado.\nRecuerde Guardar los cambios", "INFO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelCantEmpl.Text = empleadosAux.Count.ToString();
                            labelEmpl.Show();
                            labelCantEmpl.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();
                        }
                        
                    }
                    mostradoObjeto = true;
                }
                else if (radioButtonProduc.Checked)
                {
                    if (numericUpDown3.Value > productos.Count || numericUpDown3.Value == 0)
                    {
                        MessageBox.Show("Selecione una \"Id\" valida", "INFO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (!mostradoObjeto)
                        {
                            pro = productos.FirstOrDefault(p => p.Id == numericUpDown3.Value);
                            textBox1.Text = pro.Name;
                            richTextBox1.Text = pro.Description;
                            numericUpDown1.Value = (decimal)pro.Precio;
                            dateTimePicker1.Text = pro.FechaCaduca.ToShortDateString();
                            numericUpDown2.Value = (int)pro.Descuento;
                        }
                        if (radioButtonModif.Checked && mostradoObjeto)
                        {
                            Producto producto = new Producto((int)numericUpDown3.Value,
                                textBox1.Text, richTextBox1.Text,
                                (double)numericUpDown1.Value,
                                dateTimePicker1.Value.Date,
                                (int)numericUpDown2.Value);

                            auxP = productosAux.FirstOrDefault(p => p.Id == (int)numericUpDown3.Value);
                            if (auxP == null)
                            {
                                productosAux.Add(producto);
                            }
                            else
                            {
                                productosAux.Remove(auxP);
                                productosAux.Add(producto);
                            }
                            MessageBox.Show("Objeto modificado.\nRecuerde Guardar los cambios", "INFO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelCantProd.Text = productosAux.Count.ToString();
                            labelProd.Show();
                            labelCantProd.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();

                        }
                        if (radioButtonElimi.Checked && mostradoObjeto)
                        {
                            Controlador.ControlApp.toDelete = true;
                            auxP = productosAux.FirstOrDefault(pr => pr.Id == numericUpDown3.Value);
                            if (auxP == null)
                            {
                                productosAux.Add(pro);
                            }

                            MessageBox.Show("Objeto eliminado.\nRecuerde Guardar los cambios", "INFO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelCantProd.Text = productosAux.Count.ToString();
                            labelProd.Show();
                            labelCantProd.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();
                        }
                    }
                    mostradoObjeto = true;
                }
                else if (radioButtonCoche.Checked)
                {
                    if (numericUpDown3.Value > coches.Count || numericUpDown3.Value == 0)
                    {
                        MessageBox.Show("Selecione una \"Id\" valida", "INFO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numericUpDown3.Value = 0;
                        return;
                    }
                    else
                    {
                        if (!mostradoObjeto)
                        {
                            coch = coches.FirstOrDefault(u => u.Id == numericUpDown3.Value);
                            textBox1.Text = coch.Nombre;
                            textBox2.Text = coch.Modelo;
                            if (coch.Descapotable)
                            {
                                checkBoxMenu.Checked = true;
                            }
                            else
                            {
                                checkBoxMenu.Checked = false;
                            }
                            numericUpDown2.Value = (int)coch.Cilindrada;
                            dateTimePicker1.Text = coch.Matriculacion.ToShortDateString();
                            numericUpDown1.Value = (decimal)coch.Precio;
                        }
                        if (radioButtonModif.Checked && mostradoObjeto)
                        {                           
                            Coche coche = new Coche((int)numericUpDown3.Value,
                                textBox1.Text, textBox2.Text,
                                (int)numericUpDown2.Value,
                                (double)numericUpDown1.Value,
                                dateTimePicker1.Value.Date,
                                checkBoxMenu.Checked);

                            auxCo = cochesAux.FirstOrDefault(co => co.Id == (int)numericUpDown3.Value);
                            if (auxCo == null)
                            {
                                cochesAux.Add(coche); 
                            }
                            else
                            {
                                cochesAux.Remove(auxCo);
                                cochesAux.Add(coche);
                            }
                            MessageBox.Show("Objeto modificado.\nRecuerde Guardar los cambios", "INFO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label11.Text = cochesAux.Count.ToString();
                            labelCoch.Show();
                            label11.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();
                        }
                        if (radioButtonElimi.Checked && mostradoObjeto)
                        {
                            Controlador.ControlApp.toDelete = true;
                            auxCo = cochesAux.FirstOrDefault(co => co.Id == (int)numericUpDown3.Value);
                            if (auxCo == null)
                            {
                                cochesAux.Add(coch);
                            }
                            MessageBox.Show("Objeto eliminado.\nRecuerde Guardar los cambios", "INFO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label11.Text = cochesAux.Count.ToString();
                            labelCoch.Show();
                            label11.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();
                        }
                    }
                    mostradoObjeto = true;
                }//buttonLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario está a punto de cerrarse.
        /// Verifica si hay cambios sin guardar y muestra un mensaje de advertencia.
        /// Si el usuario decide salir, se asegura de que el formulario principal se muestre nuevamente.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (en este caso, el formulario).</param>
        /// <param name="e">Los argumentos del evento que proporcionan información sobre el cierre del formulario.</param>

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = DialogResult.OK;
            if (buttonGuardar.Visible == true)
            {
                dl = MessageBox.Show("Si sale sin Guardar se perdederan los cambios\n" +
                   "¿Desea salir?", "AVISO",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }


            if (dl == DialogResult.OK)
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
                    if (formPrinciapal != null)
                    {
                        formPrinciapal.Show();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de tipo "Empleado".
        /// Actualiza los controles del formulario según las opciones específicas para empleados.
        /// </summary>
        private void radioButtonEmpl_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-35);
                dateTimePicker1.MaxDate = DateTime.Today.Date;
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                numericUpDown1.Minimum = 2000;
                numericUpDown1.Maximum = 1000000000000;
                numericUpDown1.Value = numericUpDown1.Minimum;
                labelNick.Text = "Nombre";
                labelCorreo.Text = "Correo";
                labelVip.Text = "Jornada reducida";
                labelFech.Text = "Fecha de alta";
                labelCategoria.Text = "Categoria";
                labelSueldoEmpl.Text = "Sueldo";

                toolTip1.SetToolTip(textBox1, "Campo para el nombre");
                toolTip1.SetToolTip(textBox2, "Campo para el correo");
                toolTip1.SetToolTip(checkBoxMenu, "Selector de jornada reducida ('v' SI)");
                toolTip1.SetToolTip(dateTimePicker1, "Selector de fecha de alta en la empresa");
                toolTip1.SetToolTip(numericUpDown1, "Campo para el sueldo del empleado nuevo");
                toolTip1.SetToolTip(comboBox1, "Selector de categoria del nuevo empleado");

                labelCategoria.Show();
                comboBox1.Show();
                labelSueldoEmpl.Show();
                numericUpDown1.Show();
                checkBoxMenu.Show();
                labelVip.Show();
                textBox2.Show();
                numericUpDown2.Hide();
                richTextBox1.Hide();
                buttonRefrescar_Click(sender, e);
               // buttonLimpiar_Click(sender, e);
                numericUpDown3.Minimum = 1;
                numericUpDown3.Maximum = empleados.Count();

                mostradoObjeto = false;
                buttonAceptar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de tipo "Producto".
        /// Actualiza los controles del formulario según las opciones específicas para productos.
        /// </summary>
        private void radioButtonProduc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                dateTimePicker1.MaxDate = DateTime.Today.AddDays(50000);
                dateTimePicker1.MinDate = DateTime.Today.Date;
                dateTimePicker1.Value = dateTimePicker1.MinDate;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = 100000;
                numericUpDown1.Value = numericUpDown1.Minimum;
                numericUpDown2.Maximum = 100;
                numericUpDown2.Minimum = 0;
                numericUpDown2.Value = numericUpDown2.Minimum;
                labelNick.Text = "Nombre";
                labelCorreo.Text = "Descripcion";
                labelFech.Text = "Fecha de caducidad";
                labelSueldoEmpl.Text = "Precio";
                labelCategoria.Text = "Descuento";
                toolTip1.SetToolTip(textBox1, "Campo para el nombre");
                toolTip1.SetToolTip(richTextBox1, "Campo para la descripcion del producto");
                toolTip1.SetToolTip(dateTimePicker1, "Selector de fecha de caducidad");
                toolTip1.SetToolTip(numericUpDown1, "Campo para el precio del producto nuevo");
                toolTip1.SetToolTip(numericUpDown2, "Campo para descuento del producto (%)");
                labelSueldoEmpl.Show();
                labelCategoria.Show();
                numericUpDown2.Show();
                numericUpDown1.Show();
                richTextBox1.Show();
                labelVip.Hide();
                comboBox1.Hide();
                checkBoxMenu.Hide();
                textBox2.Hide();
                buttonRefrescar_Click(sender, e);
                //buttonLimpiar_Click(sender, e);
                numericUpDown3.Minimum = 1;
                numericUpDown3.Maximum = productos.Count();

                mostradoObjeto = false;
                buttonAceptar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de tipo "Cliente".
        /// Actualiza los controles del formulario según las opciones específicas para clientes.
        /// </summary>
        private void radioButtonClie_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                dateTimePicker1.MaxDate = DateTime.Today.Date;
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-100);
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                labelNick.Text = "Nombre";
                labelCorreo.Text = "Correo";
                labelVip.Text = "VIP";
                labelFech.Text = "Fecha de nacimiento";
                toolTip1.SetToolTip(textBox1, "Campo para el nombre");
                toolTip1.SetToolTip(textBox2, "Campo para el correo");
                toolTip1.SetToolTip(checkBoxMenu, "Selector cliente VIP ('v' SI)");
                toolTip1.SetToolTip(dateTimePicker1, "Selector de fecha de nacimiento");
                numericUpDown1.Hide();
                labelSueldoEmpl.Hide();
                labelVip.Show();
                labelCategoria.Hide();
                comboBox1.Hide();
                numericUpDown2.Hide();
                checkBoxMenu.Show();
                textBox2.Show();
                richTextBox1.Hide();
                buttonRefrescar_Click(sender, e);
                //buttonLimpiar_Click(sender, e);
                numericUpDown3.Minimum = 1;
                numericUpDown3.Maximum = clientes.Count();

                mostradoObjeto = false;
                buttonAceptar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de tipo "Coche".
        /// Actualiza los controles del formulario según las opciones específicas para coches.
        /// </summary>
        private void radioButtonCoche_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-100);
                dateTimePicker1.MaxDate = DateTime.Today;
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                numericUpDown1.Minimum = 1500;
                numericUpDown1.Maximum = 100000000;
                numericUpDown1.Value = numericUpDown1.Minimum;
                numericUpDown2.Maximum = 9000;
                numericUpDown2.Minimum = 0;
                numericUpDown2.Value = numericUpDown2.Minimum;
                labelNick.Text = "Marca";
                labelCorreo.Text = "Modelo";
                labelSueldoEmpl.Text = "Precio";
                labelVip.Text = "Descapotable";
                labelFech.Text = "Fecha de matriculación";
                labelCategoria.Text = "Cilindrada";
                toolTip1.SetToolTip(textBox1, "Campo para la marca");
                toolTip1.SetToolTip(textBox2, "Campo para el correo");
                toolTip1.SetToolTip(checkBoxMenu, "Selector de techo descapotable ('v' SI)");
                toolTip1.SetToolTip(dateTimePicker1, "Selector de fecha de matriculación");
                toolTip1.SetToolTip(numericUpDown1, "Campo para el precio del coche");
                toolTip1.SetToolTip(numericUpDown2, "Campo para la cilindradad del coche");
                labelSueldoEmpl.Show();
                labelVip.Show();
                labelCategoria.Show();
                checkBoxMenu.Show();
                textBox2.Show();
                numericUpDown2.Show();
                numericUpDown1.Show();
                comboBox1.Hide();
                richTextBox1.Hide();
                buttonRefrescar_Click(sender, e);
                //buttonLimpiar_Click(sender, e);
                numericUpDown3.Minimum = 1;
                numericUpDown3.Maximum = coches.Count();

                mostradoObjeto = false;
                buttonAceptar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón "Refrescar".
        /// Actualiza la vista de la grilla de acuerdo con el tipo de objeto seleccionado.
        /// </summary>
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            if (radioButtonClie.Checked == false &&
                radioButtonEmpl.Checked == false &&
                radioButtonCoche.Checked == false &&
                radioButtonProduc.Checked == false)
            {
                pictureBox1.Show();
                MessageBox.Show("Selecione primero un \"Tipo de objeto\"", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                // comboBox1.BackColor = Color.FromArgb(128; 255; 128);
            }
            else
            {
                if (radioButtonClie.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    clientes = Controlador.ControlCliente.listClients;
                    List<Cliente> clientesOrdenados = clientes.OrderBy(c => c.Id).ToList();
                    dataGridView1.DataSource = clientesOrdenados;
                }
                else if (radioButtonEmpl.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    empleados = Controlador.ControlEmpleado.listEmple;
                    List<Empleado> empleadosOrdenados = empleados.OrderBy(em => em.Id).ToList();
                    dataGridView1.DataSource = empleadosOrdenados;
                }
                else if (radioButtonProduc.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    productos = Controlador.ControlProducto.listProductos;
                    List<Producto> productosOrdenados = productos.OrderBy(p => p.Id).ToList();
                    dataGridView1.DataSource = productosOrdenados;
                }
                else if (radioButtonCoche.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    coches = Controlador.ControlCoche.listCoche;
                    List<Coche> cochesOrdenados = coches.OrderBy(co => co.Id).ToList();
                    dataGridView1.DataSource = cochesOrdenados;
                }
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de "Modificar".
        /// Habilita los controles para modificar los datos del objeto seleccionado.
        /// </summary>
        private void radioButtonModif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModif.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                richTextBox1.Enabled = true;
                checkBoxMenu.Enabled = true;
                dateTimePicker1.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                comboBox1.Enabled = true;
                buttonAceptar.Text = "Modificar";
                toolTip1.SetToolTip(buttonAceptar, "Boton para modificar un objeto");
                Controlador.ControlApp.noPregunta = true;
                buttonCancelar_Click(sender, e);
                buttonAceptar.BackColor = Color.FromArgb(128, 255, 128);
                MessageBox.Show("Modo editar ON\nRecuerde GUARDAR los cambios", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                richTextBox1.Enabled = false;
                checkBoxMenu.Enabled = false;
                dateTimePicker1.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                comboBox1.Enabled = false;
                buttonAceptar.Text = "Consultar";
                toolTip1.SetToolTip(buttonAceptar, "Boton para ver un objeto");
                buttonAceptar.BackColor = SystemColors.ControlLightLight;
            }

        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de "Eliminar".
        /// Prepara el formulario para eliminar el objeto seleccionado.
        /// </summary>
        private void radioButtonElimi_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonElimi.Checked == true)
            {
                buttonAceptar.Text = "Eliminar";
                toolTip1.SetToolTip(buttonAceptar, "Boton para eliminar un objeto");
                Controlador.ControlApp.noPregunta = true;
                buttonCancelar_Click(sender, e);
                buttonAceptar.BackColor = Color.FromArgb(200, 128, 128);
                MessageBox.Show("Modo editar ON\nRecuerde GUARDAR los cambios", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Evento que se ejecuta cuando el grupo de radio buttons de tipo de objeto recibe el enfoque.
        /// Oculta la imagen de información en el formulario.
        /// </summary>
        private void groupBoxTipoObj_Enter(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }
        /// <summary>
        /// Evento que se ejecuta cuando cambia el estado del radioButton de "Consultar".
        /// Prepara el formulario para visualizar los datos del objeto seleccionado.
        /// </summary>
        private void radioButtonConsult_CheckedChanged(object sender, EventArgs e)
        {
            buttonAceptar.Text = "Consultar";
            buttonAceptar.BackColor = SystemColors.ControlLightLight;
        }


    }
}