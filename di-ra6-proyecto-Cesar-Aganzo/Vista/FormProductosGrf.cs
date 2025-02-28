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
     /// Formulario para graficos de prueba Productos.
     /// </summary>
    public partial class FormProductosGrf : Form
    {
        /// <summary>
        /// Lista estática que contiene los datos de los productos.
        /// </summary>
        List<Producto> productosList = new List<Producto>();
        /// <summary>
        /// Variable para almacenar una referencia al formulario principal.
        /// </summary>
        Form formPrincipal;
        /// <summary>
        /// Constructor del formulario que inicializa los componentes y carga los datos de prodcutos desde un archivo JSON.
        /// </summary>
        public FormProductosGrf()
        {
            InitializeComponent(); 
            this.WindowState = FormWindowState.Maximized;
            Controlador.Dao.ProductoDaoJson.leerJson(productosList);
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga.
        /// Aquí se configura el reportViewer para mostrar un informe con los datos de los productos.
        /// </summary>
        private void FormProductosGrf_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportProductosGrf.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet1", productosList);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        /// <summary>
        /// Evento que ocurre cuando el formulario se está cerrando.
        /// Aquí se verifica si el formulario principal está abierto y se lo muestra de nuevo.
        /// </summary>
        private void FormProductosGrf_FormClosing(object sender, FormClosingEventArgs e)
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