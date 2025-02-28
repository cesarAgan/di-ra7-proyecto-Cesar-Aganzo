using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using Microsoft.Reporting.WinForms;
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
{    /// <summary>
     /// Formulario para graficos de prueba Clientes.
     /// </summary>
    public partial class FormClientesGrf : Form
    {
        /// <summary>
        /// Variable para almacenar una referencia al formulario principal.
        /// </summary>
        private FormPrincipal formPrincipal;
        /// <summary>
        /// Lista estática que contiene los datos de los clientes.
        /// </summary>
        public static List<Cliente> clienteList = new List<Cliente>();
        /// <summary>
        /// Constructor del formulario que inicializa los componentes y carga los datos de clientes desde un archivo XML.
        /// </summary>
        public FormClientesGrf()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Controlador.Dao.ClienteDaoXml.leerXml2(clienteList);
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga.
        /// Aquí se configura el reportViewer para mostrar un informe con los datos de los clientes.
        /// </summary>
        private void FormClientesInformeGrf_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.reportViewer1.LocalReport.ReportPath = "ReportClienteGrf.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet1", clienteList);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        /// <summary>
        /// Evento que ocurre cuando el formulario se está cerrando.
        /// Aquí se verifica si el formulario principal está abierto y se lo muestra de nuevo.
        /// </summary>

        private void FormClientesInformeGrf_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is FormPrincipal)
                {
                    formPrincipal = (FormPrincipal)item;
                }
            }
            if (formPrincipal != null)
            {
                this.WindowState = FormWindowState.Normal;
                formPrincipal.Show();

            }
        }
    }
}
