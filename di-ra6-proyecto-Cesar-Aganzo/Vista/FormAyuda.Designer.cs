namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.buttonFAQ = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFAQ
            // 
            this.buttonFAQ.AccessibleDescription = "Boton a preguntas frecuentes";
            this.buttonFAQ.AccessibleName = "BotonFAQ";
            this.buttonFAQ.Location = new System.Drawing.Point(407, 23);
            this.buttonFAQ.Name = "buttonFAQ";
            this.buttonFAQ.Size = new System.Drawing.Size(148, 26);
            this.buttonFAQ.TabIndex = 4;
            this.buttonFAQ.Text = "FAQ";
            this.buttonFAQ.UseVisualStyleBackColor = true;
            this.buttonFAQ.Click += new System.EventHandler(this.buttonFAQ_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1711, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AccessibleDescription = "Boton para delplegar el menu superior";
            this.menuToolStripMenuItem.AccessibleName = "BotonMenu";
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAtrasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // volverAtrasToolStripMenuItem
            // 
            this.volverAtrasToolStripMenuItem.AccessibleDescription = "Boton para regresar a la pantalla de inicio";
            this.volverAtrasToolStripMenuItem.AccessibleName = "BontonAtras";
            this.volverAtrasToolStripMenuItem.Image = global::di_ra5_proyecto_Cesar_Aganzo.Properties.Resources.undo_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.volverAtrasToolStripMenuItem.Name = "volverAtrasToolStripMenuItem";
            this.volverAtrasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.volverAtrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volverAtrasToolStripMenuItem.Text = "Volver atras";
            this.volverAtrasToolStripMenuItem.Click += new System.EventHandler(this.volverAtrasToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox3);
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFAQ);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Size = new System.Drawing.Size(1711, 716);
            this.splitContainer1.SplitterDistance = 570;
            this.splitContainer1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleDescription = "Descripcion de los pasos a seguir";
            this.richTextBox1.AccessibleName = "RichTextBoxDescripcion";
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 302);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 337);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // listBox3
            // 
            this.listBox3.AccessibleDescription = "Marcador para ver indicaciones de como  importar y exportar Objetos";
            this.listBox3.AccessibleName = "MarcadorImportExport";
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "Importar y Exportar Objeto"});
            this.listBox3.Location = new System.Drawing.Point(16, 213);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(539, 24);
            this.listBox3.TabIndex = 11;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.AccessibleDescription = "Marcador para ver indicaciones de como consultar , modificar o eliminar un Objeto" +
    "";
            this.listBox2.AccessibleName = "MarcadorCMEObjeto";
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Consultar, Modificar o Eliminar Objeto"});
            this.listBox2.Location = new System.Drawing.Point(16, 146);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(539, 24);
            this.listBox2.TabIndex = 10;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.AccessibleDescription = "Marcador para ver indicaciones de como insertar un Objeto";
            this.listBox1.AccessibleName = "MarcadorInsertar";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Inserta un Objeto"});
            this.listBox1.Location = new System.Drawing.Point(16, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 24);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleDescription = "Reproductor de guia";
            this.axWindowsMediaPlayer1.AccessibleName = "ReproductorGuia";
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(17, 14);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1108, 625);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 740);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAyuda";
            this.Text = "FormAyuda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAyuda_FormClosing);
            this.Load += new System.EventHandler(this.FormAyuda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFAQ;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAtrasToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}