using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
   

    public partial class ReporteRango : Form
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public ReporteRango()
        {
            InitializeComponent();
        }

        private void ReporteRango_Load(object sender, EventArgs e)
        {

          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DSAlumnos ds = new DSAlumnos();
                var ta = new DSAlumnosTableAdapters.AlumnosTableAdapter();

                // FILTRAR ENTRE FECHAS
                ta.FillByRangoFechas(ds.Alumnos, dtpDesde.Value.Date, dtpHasta.Value.Date);

                // CONFIGURAR EL REPORTE
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "WindowsFormsApp2.ReporteRango.rdlc";  

                // ENVIAR PARÁMETROS AL RDLC
                ReportParameter[] parametros =
                {
                    new ReportParameter("DesdeParam", dtpDesde.Value.ToShortDateString()),
                    new ReportParameter("HastaParam", dtpHasta.Value.ToShortDateString())
                };

                reportViewer1.LocalReport.SetParameters(parametros);

                // ENVIAR DATOS AL REPORTE
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DSAlumnos", ds.Tables["Alumnos"])
                );

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
