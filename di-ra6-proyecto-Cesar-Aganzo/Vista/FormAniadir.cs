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
    /// Formulario para añadir nuevos objetos (Clientes, Empleados, Productos, Coches).
    /// Este formulario gestiona la creación de los distintos tipos de objetos mediante un sistema de selección
    /// y validación de campos. Además, permite refrescar y limpiar los datos mostrados en la interfaz.
    /// </summary>
    public partial class FormAniadir : Form
    {
        /// <summary>
        /// Formulario principal asociado a este formulario (para navegación entre formularios).
        /// </summary>
        private FormPrincipal formPrinciapal;

        /// <summary>
        /// Lista para almacenar objetos de tipo Cliente.
        /// </summary>
        private List<Cliente> clientes = new List<Cliente>();

        /// <summary>
        /// Lista auxiliar para almacenar temporalmente objetos de tipo Cliente.
        /// </summary>
        private List<Cliente> clientesAux = new List<Cliente>();

        /// <summary>
        /// Lista para almacenar objetos de tipo Empleado.
        /// </summary>
        private List<Empleado> empleados = new List<Empleado>();

        /// <summary>
        /// Lista auxiliar para almacenar temporalmente objetos de tipo Empleado.
        /// </summary>
        private List<Empleado> empleadosAux = new List<Empleado>();

        /// <summary>
        /// Lista para almacenar objetos de tipo Producto.
        /// </summary>
        private List<Producto> productos = new List<Producto>();

        /// <summary>
        /// Lista auxiliar para almacenar temporalmente objetos de tipo Producto.
        /// </summary>
        private List<Producto> productosAux = new List<Producto>();

        /// <summary>
        /// Lista para almacenar objetos de tipo Coche.
        /// </summary>
        private List<Coche> coches = new List<Coche>();

        /// <summary>
        /// Lista auxiliar para almacenar temporalmente objetos de tipo Coche.
        /// </summary>
        private List<Coche> cochesAux = new List<Coche>();

        /// <summary>
        /// Inicializa el formulario de añadir objetos. Este método se encarga de configurar todos los controles visuales del formulario, 
        /// como botones, campos de texto, y listas desplegables. Además, establece las listas de datos necesarias para los controles, 
        /// proporcionando los datos iniciales desde el controlador. La configuración incluye la habilitación de eventos, 
        /// la asignación de valores predeterminados a los controles, y la preparación del formulario para interactuar con el usuario.
        /// </summary>
        public FormAniadir()
        {
            InitializeComponent();
            coches = Controlador.ControlApp.listCoches;
            clientes = Controlador.ControlApp.clienteList;
            productos = Controlador.ControlApp.productList;
            empleados = Controlador.ControlApp.empleadosList;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.ReadOnly = true;
            pictureBox1.Hide();
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "helperAniadir.html");
            toolTip1.SetToolTip(buttonRefrescar, "Boton para refrescar la lista de objetos");
            toolTip1.SetToolTip(buttonAceptar, "Boton para añadir un objeto nuevo");
            toolTip1.SetToolTip(buttonLimpiar, "Boton para limiar los campos");
            toolTip1.SetToolTip(buttonCancelar, "Boton para cancelar la creacion de objetos nuevos");
            toolTip1.SetToolTip(buttonGuardar, "Boton para guardar la creacion de objetos nuevos");
            toolTip1.SetToolTip(radioButtonClie, "Selector de tipo de objeto cliente");
            toolTip1.SetToolTip(radioButtonCoche, "Selector de tipo de objeto coche");
            toolTip1.SetToolTip(radioButtonEmpl, "Selector de tipo de objeto empleado");
            toolTip1.SetToolTip(radioButtonProduc, "Selector de tipo de objeto producto");
            toolTip1.SetToolTip(richTextBox1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(checkBoxMenu, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(dateTimePicker1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(numericUpDown1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(numericUpDown2, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(textBox2, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(textBox1, "Seleccione primero un tipo de objeto");
            toolTip1.SetToolTip(comboBox1, "Seleccione primero un tipo de objeto");            

            this.helpProvider1.SetHelpKeyword(this.buttonRefrescar, "RefrescarLista");
            this.helpProvider1.SetHelpNavigator(this.buttonRefrescar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonRefrescar, true);

            this.helpProvider1.SetHelpKeyword(this.buttonAceptar, "AceptarObjeto");
            this.helpProvider1.SetHelpNavigator(this.buttonAceptar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonAceptar, true);

            this.helpProvider1.SetHelpKeyword(this.buttonLimpiar, "LimpiarCampos");
            this.helpProvider1.SetHelpNavigator(this.buttonLimpiar, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.buttonLimpiar, true);

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

            this.helpProvider1.SetHelpKeyword(this.menuStrip1, "MenuSup");
            this.helpProvider1.SetHelpNavigator(this.menuStrip1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetShowHelp(this.menuStrip1, true);

        }

        /// <summary>
        /// Configura la visibilidad de los controles del formulario cuando se carga el formulario.
        /// </summary>
        private void FormAniadir_Load(object sender, EventArgs e)
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

            labelEmpl.Hide();
            labelCli.Hide();
            labelCantCli.Hide();
            labelCantEmpl.Hide();
            labelProd.Hide();
            labelCoch.Hide();
            labelCantProd.Hide();
            label11.Hide();
            comboBox1.Text = "Seleccione";
        }

        /// <summary>
        /// Copia el texto o valor del control activo al portapapeles.
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
        /// Pega el texto del portapapeles en el control activo (TextBox).
        /// </summary>
        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase texto)
            {
                texto.Paste();
            }
        }
        /// <summary>
        /// Corta el texto seleccionado del control activo (TextBox) y lo copia al portapapeles.
        /// </summary>
        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase texto && texto.SelectedText != "")
            {
                texto.Cut();
            }
        }
        /// <summary>
        /// Borra el texto seleccionado del control activo (TextBox).
        /// </summary>
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase texto && texto.SelectedText != "")
            {
                texto.SelectedText = string.Empty;
            }
        }
        /// <summary>
        /// Cierra el formulario actual y vuelve al formulario anterior sin guardar los cambios.
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.salir = true;
            Application.Exit();
        }
        /// <summary>
        /// Cierra el formulario actual y vuelve al formulario anterior sin guardar los cambios.
        /// </summary>
        private void volverAtrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controlador.ControlApp.salir = false;
            this.Close();
        }
        /// <summary>
        /// Corta el texto seleccionado del control activo (TextBox) y lo copia al portapapeles, desde el menu contextual.
        /// </summary>
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cortarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Copia el texto o valor del control activo al portapapeles, desde el menu contextual.
        /// </summary>
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Pega el texto del portapapeles en el control activo (TextBox), desde el menu contextual.
        /// </summary>
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pegarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Borra el texto seleccionado del control activo (TextBox), desde el menu contextual.
        /// </summary>
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarToolStripMenuItem1_Click(sender, e);
        }
        /// <summary>
        /// Limpia los campos del formulario y restablece los valores predeterminados de los controles, desde el menu cotextual.
        /// </summary>
        private void limpiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonLimpiar_Click(sender, e);
        }
        /// <summary>
        /// Cancela la creación de objetos nuevos y borra cualquier dato ingresado, desde el menu contextual.
        /// </summary>
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCancelar_Click(sender, e);
        }
        /// <summary>
        /// Guarda los objetos creados en las listas correspondientes y muestra el número de objetos guardados.
        /// </summary>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int cantidad = Controlador.ControlCliente.aniadirCliente(clientesAux) +
                Controlador.ControlEmpleado.aniadirEmpleado(empleadosAux) +
                Controlador.ControlProducto.aniadirProducto(productosAux) +
                Controlador.ControlCoche.aniadirCoche(cochesAux);

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
            MessageBox.Show("Se han guardado " + cantidad
                + " objeto\\s nuevo\\s.", "INFORMACION",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Cancela la creación de objetos nuevos y borra cualquier dato ingresado.
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (clientesAux.Count != 0 || empleadosAux.Count != 0
                || productosAux.Count != 0 || cochesAux.Count != 0)
            {

                DialogResult diaRes = MessageBox.Show("¿Desea cancelar la creacion de todos los objetos?",
                    "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                    buttonLimpiar_Click(sender, e);
                }
            }
        }
        /// <summary>
        /// Limpia los campos del formulario y restablece los valores predeterminados de los controles.
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
                comboBox1.Text = "Seleccione";
                dateTimePicker1.MinDate = DateTime.Today.AddDays(-3);
                dateTimePicker1.MaxDate = DateTime.Today.AddDays(3);
                dateTimePicker1.Value = DateTime.Today.Date;
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
        /// Evento que se ejecuta cuando se hace clic en el botón "Aceptar". 
        /// Realiza validaciones y crea un nuevo objeto dependiendo de la selección del tipo de objeto.
        /// </summary>
        private void buttonAceptar_Click(object sender, EventArgs e)
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
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Rellene todos los campos", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (radioButtonClie.Checked)
                {
                    if (String.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Rellene todos los campos", "AVISO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
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
                            Cliente cliente = new Cliente(0,
                                textBox1.Text,
                                textBox2.Text,
                                dateTimePicker1.Value.Date,
                                checkBoxMenu.Checked,
                                0.0);
                            clientesAux.Add(cliente);
                            labelCantCli.Text = clientesAux.Count.ToString();
                            labelCli.Show();
                            labelCantCli.Show();

                            cancelarToolStripMenuItem.Visible = true;
                            guardarToolStripMenuItem.Visible = true;
                            buttonGuardar.Show();
                            buttonCancelar.Show();
                        }
                    }

                }
                else if (radioButtonEmpl.Checked)
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Rellene todos los campos", "AVISO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Empleado empleado = new Empleado(0,
                            textBox1.Text,
                            textBox2.Text,
                            dateTimePicker1.Value.Date,
                            comboBox1.SelectedIndex + 1 ,
                            (double)numericUpDown1.Value,
                            checkBoxMenu.Checked
                            );

                        empleadosAux.Add(empleado);
                        labelCantEmpl.Text = empleadosAux.Count.ToString();
                        labelEmpl.Show();
                        labelCantEmpl.Show();

                        cancelarToolStripMenuItem.Visible = true;
                        guardarToolStripMenuItem.Visible = true;
                        buttonGuardar.Show();
                        buttonCancelar.Show();
                    }
                }
                else if (radioButtonProduc.Checked)
                {
                    if (String.IsNullOrEmpty(richTextBox1.Text))
                    {
                        MessageBox.Show("Rellene todos los campos", "AVISO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Producto producto = new Producto(0,
                        textBox1.Text, richTextBox1.Text,
                        (double)numericUpDown1.Value,
                        dateTimePicker1.Value.Date,
                        (int)numericUpDown2.Value);
                        labelCantProd.Show();
                        labelProd.Show();

                        productosAux.Add(producto);
                        labelCantProd.Text = productosAux.Count.ToString();

                        cancelarToolStripMenuItem.Visible = true;
                        guardarToolStripMenuItem.Visible = true;
                        buttonGuardar.Show();
                        buttonCancelar.Show();
                    }
                }
                else if (radioButtonCoche.Checked)
                {
                    if (String.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Rellene todos los campos", "AVISO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        Coche coche = new Coche(0,
                        textBox1.Text, textBox2.Text,
                        (int)numericUpDown2.Value,
                        (double)numericUpDown1.Value,
                        dateTimePicker1.Value.Date,
                        checkBoxMenu.Checked);

                        labelCoch.Show();
                        label11.Show();


                        cochesAux.Add(coche);
                        label11.Text = cochesAux.Count.ToString();

                        cancelarToolStripMenuItem.Visible = true;
                        guardarToolStripMenuItem.Visible = true;
                        buttonGuardar.Show();
                        buttonCancelar.Show();

                        cancelarToolStripMenuItem.Visible = true;
                        guardarToolStripMenuItem.Visible = true;
                        buttonGuardar.Show();
                        buttonCancelar.Show();
                    }
                }

                MessageBox.Show("Objeto creado.\nPuede Seguir creando objetos.\n" +
                    "Puede GUARDAR los nuevos objetos.\n" +
                    "Puede CANCELAR la creacion de objetos.\n", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta al cerrar el formulario. 
        /// Verifica si hay cambios sin guardar y muestra un mensaje de advertencia.
        /// </summary>
        private void FormAniadir_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = DialogResult.OK;
            
            if (buttonGuardar.Visible == true)
            {
                dl = MessageBox.Show("Si sale sin Guardar se perderán los cambios\n" +
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
        /// Evento que se ejecuta cuando el estado del radioButton para "Empleado" cambia.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el radioButton.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void radioButtonEmpl_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                dateTimePicker1.MinDate = DateTime.Today.AddDays(-3);
                dateTimePicker1.MaxDate = DateTime.Today.AddDays(3);
                dateTimePicker1.Value = DateTime.Today.Date;
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
                buttonLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el estado del radioButton para "Producto" cambia.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el radioButton.</param>
        /// <param name="e">Los argumentos del evento.</param>
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
                buttonLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el estado del radioButton para "Cliente" cambia.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el radioButton.</param>
        /// <param name="e">Los argumentos del evento.</param>
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
                buttonLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el estado del radioButton para "Coche" cambia.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el radioButton.</param>
        /// <param name="e">Los argumentos del evento.</param>
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
                toolTip1.SetToolTip(textBox2, "Campo para el modelo");
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
                buttonLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de refrescar.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el botón de refrescar.</param>
        /// <param name="e">Los argumentos del evento.</param>
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
            }
            else
            {
                if (radioButtonClie.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = clientes;
                }
                else if (radioButtonEmpl.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = empleados;
                }
                else if (radioButtonProduc.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = productos;
                }
                else if (radioButtonCoche.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = coches;
                }
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el grupo de tipo de objeto recibe el foco.
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento, en este caso el groupBox de tipo de objeto.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void groupBoxTipoObj_Enter(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

    }
}