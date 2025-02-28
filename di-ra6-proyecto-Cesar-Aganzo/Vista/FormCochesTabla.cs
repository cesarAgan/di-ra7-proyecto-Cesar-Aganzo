using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using di_ra5_proyecto_Cesar_Aganzo.Vista;
using di_ra5_proyecto_Cesar_Aganzo;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace di_ra5_proyecto_Cesar_Aganzo.Vista
{    /// <summary>
     /// Formulario para tablas de prueba Coches.
     /// </summary>
    public partial class FormCochesTabla : Form
    {
        /// <summary>
        /// Lista estática que contiene los datos de los coches.
        /// </summary>
        List<Coche> cochesList = new List<Coche>();
        /// <summary>
        /// Variable para almacenar una referencia al formulario principal.
        /// </summary>
        Form formPrincipal;
        /// <summary>
        /// Constructor del formulario que inicializa los componentes y carga los datos de coches desde un archivo XML.
        /// </summary>
        public FormCochesTabla()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Controlador.Dao.CochesDaoXml.leerXml2(cochesList);
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga.
        /// Aquí se configura el reportViewer para mostrar un informe con los datos de los coches.
        /// </summary>
        private void FormCochesTabla_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportCochesTabla.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet1", cochesList);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        /// <summary>
        /// Evento que ocurre cuando el formulario se está cerrando.
        /// Aquí se verifica si el formulario principal está abierto y se lo muestra de nuevo.
        /// </summary>
        private void FormCochesTabla_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is FormPrincipal)
                {
                    formPrincipal = (FormPrincipal)item;
                }
            }
            formPrincipal.Show();
        }
    }
}
