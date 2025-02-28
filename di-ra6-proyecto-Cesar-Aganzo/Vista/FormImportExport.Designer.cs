namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{
    partial class FormImportExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Boton para guardar objetos clientes en xml";
            this.button1.AccessibleName = "GrabarClientesXML";
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(216, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 69;
            this.button1.Text = "Escribir XML Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Boton para refrescar la lista de objetos";
            this.button2.AccessibleName = "RefrescarLista";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 30);
            this.button2.TabIndex = 66;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = "Menu superior";
            this.menuStrip1.AccessibleName = "MenuSup";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.edicionToolStripMenuItem,
            this.tipoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 27);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.AccessibleDescription = "Boton para delplegar el menu superior";
            this.archivoToolStripMenuItem1.AccessibleName = "BotonMenu";
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAtrasToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(50, 23);
            this.archivoToolStripMenuItem1.Text = "Menu";
            // 
            // volverAtrasToolStripMenuItem1
            // 
            this.volverAtrasToolStripMenuItem1.AccessibleDescription = "Boton para regresar a la pantalla de inicio";
            this.volverAtrasToolStripMenuItem1.AccessibleName = "BontonAtras";
            this.volverAtrasToolStripMenuItem1.Image = global::di_ra5_proyecto_Cesar_Aganzo.Properties.Resources.undo_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.volverAtrasToolStripMenuItem1.Name = "volverAtrasToolStripMenuItem1";
            this.volverAtrasToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.volverAtrasToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.volverAtrasToolStripMenuItem1.Text = "Volver atras";
            this.volverAtrasToolStripMenuItem1.Click += new System.EventHandler(this.volverAtrasToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AccessibleDescription = "Boton para salir de la aplicación";
            this.salirToolStripMenuItem.AccessibleName = "BontonSalir";
            this.salirToolStripMenuItem.Image = global::di_ra5_proyecto_Cesar_Aganzo.Properties.Resources.close_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.AccessibleDescription = "Boton para editar texto";
            this.edicionToolStripMenuItem.AccessibleName = "BotonEditar";
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem1});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // copiarToolStripMenuItem1
            // 
            this.copiarToolStripMenuItem1.AccessibleDescription = "Boton para copiar las celdas seleccionadas";
            this.copiarToolStripMenuItem1.AccessibleName = "BotonCopiar";
            this.copiarToolStripMenuItem1.Image = global::di_ra5_proyecto_Cesar_Aganzo.Properties.Resources.content_copy_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            this.copiarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.copiarToolStripMenuItem1.Text = "Copiar";
            this.copiarToolStripMenuItem1.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click_1);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.AccessibleDescription = "Selector para elegir el tipo de Objeto para ver";
            this.tipoToolStripMenuItem.AccessibleName = "SelectorTipoObjeto";
            this.tipoToolStripMenuItem.Items.AddRange(new object[] {
            "Clientes",
            "Empleados",
            "Productos",
            "Coches"});
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.tipoToolStripMenuItem.Text = "Tipo objeto";
            this.tipoToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.tipoToolStripMenuItem_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "Lista con objetos";
            this.dataGridView1.AccessibleName = "ListaObjetos";
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 615);
            this.dataGridView1.TabIndex = 85;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "Boton para cargar objetos clientes en xml";
            this.button3.AccessibleName = "CargarClientesXML";
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(216, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 70;
            this.button3.Text = "Leer XML Cliente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "Boton para cargar objetos clientes en json";
            this.button4.AccessibleName = "CargarClientesJson";
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.ForeColor = System.Drawing.Color.Chocolate;
            this.button4.Location = new System.Drawing.Point(94, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 30);
            this.button4.TabIndex = 68;
            this.button4.Text = "Leer JSON Cliente";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "Boton para guardar objetos clientes en json";
            this.button5.AccessibleName = "GrabarClientesJson";
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.ForeColor = System.Drawing.Color.Chocolate;
            this.button5.Location = new System.Drawing.Point(94, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 30);
            this.button5.TabIndex = 67;
            this.button5.Text = "Escribir JSON Cliente";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "Boton para cargar objetos empleados en json";
            this.button6.AccessibleName = "CargarEmpleadosJson";
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.ForeColor = System.Drawing.Color.Chocolate;
            this.button6.Location = new System.Drawing.Point(344, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 30);
            this.button6.TabIndex = 72;
            this.button6.Text = "Leer JSON Empleados";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.AccessibleDescription = "Boton para guardar objetos empleados en json";
            this.button7.AccessibleName = "GrabarEmpleadosJson";
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.ForeColor = System.Drawing.Color.Chocolate;
            this.button7.Location = new System.Drawing.Point(344, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 30);
            this.button7.TabIndex = 71;
            this.button7.Text = "Escribir JSON Empleados";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AccessibleDescription = "Boton para cargar objetos empleados en xml";
            this.button8.AccessibleName = "CargarEmpleadosXML";
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Location = new System.Drawing.Point(487, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 30);
            this.button8.TabIndex = 74;
            this.button8.Text = "Leer XML Empleados";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.AccessibleDescription = "Boton para guardar objetos empleados en xml";
            this.button9.AccessibleName = "GrabarEmpleadosXML";
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button9.Location = new System.Drawing.Point(487, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 30);
            this.button9.TabIndex = 73;
            this.button9.Text = "Escribir XML Empleados";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.AccessibleDescription = "Boton para cargar objetos productos en xml";
            this.button10.AccessibleName = "CargarProductosXML";
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button10.Location = new System.Drawing.Point(777, 98);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 30);
            this.button10.TabIndex = 78;
            this.button10.Text = "Leer XML Productos";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.AccessibleDescription = "Boton para guardar objetos productos enxml";
            this.button11.AccessibleName = "GrabarProductosXML";
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button11.Location = new System.Drawing.Point(777, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(129, 30);
            this.button11.TabIndex = 77;
            this.button11.Text = "Escribir XML Productos";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.AccessibleDescription = "Boton para cargar objetos productos en json";
            this.button12.AccessibleName = "CargarProductosJson";
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.ForeColor = System.Drawing.Color.Chocolate;
            this.button12.Location = new System.Drawing.Point(634, 98);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(137, 30);
            this.button12.TabIndex = 76;
            this.button12.Text = "Leer JSON Productos";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.AccessibleDescription = "Boton para guardar objetos productos en json";
            this.button13.AccessibleName = "GrabarProductosJson";
            this.button13.BackColor = System.Drawing.SystemColors.Control;
            this.button13.ForeColor = System.Drawing.Color.Chocolate;
            this.button13.Location = new System.Drawing.Point(634, 44);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(137, 30);
            this.button13.TabIndex = 75;
            this.button13.Text = "Escribir JSON Productos";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button17
            // 
            this.button17.AccessibleDescription = "Boton para guardar objetos coches en json";
            this.button17.AccessibleName = "GrabarCochesJson";
            this.button17.BackColor = System.Drawing.SystemColors.Control;
            this.button17.ForeColor = System.Drawing.Color.Chocolate;
            this.button17.Location = new System.Drawing.Point(924, 44);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(129, 30);
            this.button17.TabIndex = 80;
            this.button17.Text = "Escribir JSON  Coches";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.AccessibleDescription = "Boton para guardar objetos coches en xml";
            this.button15.AccessibleName = "GrabarCochesXML";
            this.button15.BackColor = System.Drawing.SystemColors.Control;
            this.button15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button15.Location = new System.Drawing.Point(1059, 44);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(129, 30);
            this.button15.TabIndex = 82;
            this.button15.Text = "Escribir XML Coches";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.AccessibleDescription = "Boton para cargar objetos coches en json";
            this.button16.AccessibleName = "CargarCochesJson";
            this.button16.BackColor = System.Drawing.SystemColors.Control;
            this.button16.ForeColor = System.Drawing.Color.Chocolate;
            this.button16.Location = new System.Drawing.Point(924, 98);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(129, 30);
            this.button16.TabIndex = 81;
            this.button16.Text = "Leer JSON Coches";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.AccessibleDescription = "Boton para cargar objetos coches en xml";
            this.button14.AccessibleName = "CargarCochesXML";
            this.button14.BackColor = System.Drawing.SystemColors.Control;
            this.button14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button14.Location = new System.Drawing.Point(1059, 98);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(129, 30);
            this.button14.TabIndex = 83;
            this.button14.Text = "Leer XML Coches";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // FormImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 761);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormImportExport";
            this.Text = "FormBuscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuscar_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem volverAtrasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox tipoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}