namespace di_ra5_proyecto_Cesar_Aganzo
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cochesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasFrecuentesFAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Consultar, Modificar y Eliminar objetos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Exportar e Importar objetos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Añadir objeto";
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "Boton para ir a la pantalla de consulta, modificacion o elminacion de objetos";
            this.button3.AccessibleName = "BotonModificarBorrarObjeto";
            this.button3.Location = new System.Drawing.Point(85, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 33);
            this.button3.TabIndex = 71;
            this.button3.Text = "Consultar / Modificar / Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Boton para ir a la pantalla de exportacion e importacion de objetos";
            this.button2.AccessibleName = "BotonExportarImportarObjeto";
            this.button2.Location = new System.Drawing.Point(85, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 33);
            this.button2.TabIndex = 70;
            this.button2.Text = "Exportar / Importar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Boton para ir a la pantalla de insercion de objetos";
            this.button1.AccessibleName = "BotonInsertObjeto";
            this.button1.Location = new System.Drawing.Point(85, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 35);
            this.button1.TabIndex = 69;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 34);
            this.label1.TabIndex = 68;
            this.label1.Text = "Bienvenido a Gestor de Objetos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.informesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.AccessibleDescription = "Boton para delplegar el menu superior";
            this.archivoToolStripMenuItem1.AccessibleName = "BotonMenu";
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.archivoToolStripMenuItem1.Text = "Menu";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AccessibleDescription = "Boton para salir de la aplicacion";
            this.salirToolStripMenuItem.AccessibleName = "BontonSalir";
            this.salirToolStripMenuItem.Image = global::di_ra5_proyecto_Cesar_Aganzo.Properties.Resources.close_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.AccessibleDescription = "Boton para desplegar menu informes";
            this.informesToolStripMenuItem.AccessibleName = "BontonMenuInformes";
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.cochesToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.AccessibleDescription = "Boton para desplegar menu informes de clientes";
            this.clienteToolStripMenuItem.AccessibleName = "BontonMenuInformesCliente";
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.AccessibleDescription = "Boton para ir la pantalla de tablas de usuarios";
            this.tablasToolStripMenuItem.AccessibleName = "BotonTablaUsuarios";
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.tablasToolStripMenuItem.Text = "Tablas";
            this.tablasToolStripMenuItem.Click += new System.EventHandler(this.tablasToolStripMenuItem_Click);
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.AccessibleDescription = "Boton para ir la pantalla de graficos de usuarios";
            this.gráficosToolStripMenuItem.AccessibleName = "BotonGraficosUsuarios";
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            this.gráficosToolStripMenuItem.Click += new System.EventHandler(this.gráficosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.AccessibleDescription = "Boton para desplegar menu informes de empleados";
            this.empleadosToolStripMenuItem.AccessibleName = "BontonMenuInformesEmpleados";
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem1,
            this.gráficosToolStripMenuItem1});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // tablasToolStripMenuItem1
            // 
            this.tablasToolStripMenuItem1.AccessibleDescription = "Boton para ir la pantalla de tablas de empleados";
            this.tablasToolStripMenuItem1.AccessibleName = "BotonTablaEmpleados";
            this.tablasToolStripMenuItem1.Name = "tablasToolStripMenuItem1";
            this.tablasToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.tablasToolStripMenuItem1.Text = "Tablas";
            this.tablasToolStripMenuItem1.Click += new System.EventHandler(this.tablasToolStripMenuItem1_Click);
            // 
            // gráficosToolStripMenuItem1
            // 
            this.gráficosToolStripMenuItem1.AccessibleDescription = "Boton para ir la pantalla de graficos de empleados";
            this.gráficosToolStripMenuItem1.AccessibleName = "BotonGraficosEmpleados";
            this.gráficosToolStripMenuItem1.Name = "gráficosToolStripMenuItem1";
            this.gráficosToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.gráficosToolStripMenuItem1.Text = "Gráficos";
            this.gráficosToolStripMenuItem1.Click += new System.EventHandler(this.gráficosToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.AccessibleDescription = "Boton para desplegar menu informes de productos";
            this.productosToolStripMenuItem.AccessibleName = "BontonMenuInformesProductos";
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem2,
            this.gráficosToolStripMenuItem2});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // tablasToolStripMenuItem2
            // 
            this.tablasToolStripMenuItem2.AccessibleDescription = "Boton para ir la pantalla de tablas de productos";
            this.tablasToolStripMenuItem2.AccessibleName = "BotonTablaProducto";
            this.tablasToolStripMenuItem2.Name = "tablasToolStripMenuItem2";
            this.tablasToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.tablasToolStripMenuItem2.Text = "Tablas";
            this.tablasToolStripMenuItem2.Click += new System.EventHandler(this.tablasToolStripMenuItem2_Click);
            // 
            // gráficosToolStripMenuItem2
            // 
            this.gráficosToolStripMenuItem2.AccessibleDescription = "Boton para ir la pantalla de graficos de productos";
            this.gráficosToolStripMenuItem2.AccessibleName = "BotonGraficosProductos";
            this.gráficosToolStripMenuItem2.Name = "gráficosToolStripMenuItem2";
            this.gráficosToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.gráficosToolStripMenuItem2.Text = "Gráficos";
            this.gráficosToolStripMenuItem2.Click += new System.EventHandler(this.gráficosToolStripMenuItem2_Click);
            // 
            // cochesToolStripMenuItem
            // 
            this.cochesToolStripMenuItem.AccessibleDescription = "Boton para desplegar menu informes de coches";
            this.cochesToolStripMenuItem.AccessibleName = "BontonMenuInformesCoches";
            this.cochesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem3,
            this.graficosToolStripMenuItem});
            this.cochesToolStripMenuItem.Name = "cochesToolStripMenuItem";
            this.cochesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cochesToolStripMenuItem.Text = "Coches";
            // 
            // tablasToolStripMenuItem3
            // 
            this.tablasToolStripMenuItem3.AccessibleDescription = "Boton para ir la pantalla de tablas de coches";
            this.tablasToolStripMenuItem3.AccessibleName = "BotonTablaCoche";
            this.tablasToolStripMenuItem3.Name = "tablasToolStripMenuItem3";
            this.tablasToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.tablasToolStripMenuItem3.Text = "Tablas";
            this.tablasToolStripMenuItem3.Click += new System.EventHandler(this.tablasToolStripMenuItem3_Click);
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.AccessibleDescription = "Boton para ir la pantalla de graficos de coches";
            this.graficosToolStripMenuItem.AccessibleName = "BotonGraficosCoches";
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.graficosToolStripMenuItem.Text = "Gráficos";
            this.graficosToolStripMenuItem.Click += new System.EventHandler(this.graficosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.AccessibleDescription = "Boton para desplegar menu de ayuda";
            this.ayudaToolStripMenuItem.AccessibleName = "BontonMenuAyuda";
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaDeUsuarioToolStripMenuItem,
            this.preguntasFrecuentesFAQToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaDeUsuarioToolStripMenuItem
            // 
            this.ayudaDeUsuarioToolStripMenuItem.AccessibleDescription = "Boton para ir la pantalla de ayuda al usuario";
            this.ayudaDeUsuarioToolStripMenuItem.AccessibleName = "BontonAyudaUsuarios";
            this.ayudaDeUsuarioToolStripMenuItem.Name = "ayudaDeUsuarioToolStripMenuItem";
            this.ayudaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ayudaDeUsuarioToolStripMenuItem.Text = "Ayuda de Usuario";
            this.ayudaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ayudaDeUsuarioToolStripMenuItem_Click);
            // 
            // preguntasFrecuentesFAQToolStripMenuItem
            // 
            this.preguntasFrecuentesFAQToolStripMenuItem.AccessibleDescription = "Boton para ir la pantalla de preguntas frecuentes";
            this.preguntasFrecuentesFAQToolStripMenuItem.AccessibleName = "BotonAyudaPreguntas";
            this.preguntasFrecuentesFAQToolStripMenuItem.Name = "preguntasFrecuentesFAQToolStripMenuItem";
            this.preguntasFrecuentesFAQToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.preguntasFrecuentesFAQToolStripMenuItem.Text = "Preguntas frecuentes (FAQ)";
            this.preguntasFrecuentesFAQToolStripMenuItem.Click += new System.EventHandler(this.preguntasFrecuentesFAQToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.AccessibleDescription = "Boton para ir la pantalla de acerca de...";
            this.acercaDeToolStripMenuItem.AccessibleName = "BotonAceraDe";
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AccessibleDescription = "Boton para delplegar el menu superior";
            this.AccessibleName = "Boton Menu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 502);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cochesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem graficosToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem ayudaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preguntasFrecuentesFAQToolStripMenuItem;
    }
}

