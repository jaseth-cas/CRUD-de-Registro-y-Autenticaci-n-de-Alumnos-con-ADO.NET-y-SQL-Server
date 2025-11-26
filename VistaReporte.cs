using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class VistaReporte : Form
    {
        public VistaReporte()
        {
            InitializeComponent();
        }

        private void VistaReporte_Load(object sender, EventArgs e)
        {
            try
            {
                // Limpia fuentes previas
                reportViewer1.LocalReport.DataSources.Clear();

                // IMPORTANTE: Recurso incrustado
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "WindowsFormsApp2.ReporteGeneral.rdlc";
                // Asegúrate que el archivo se llame exactamente ReporteGeneral.rdlc

                // Instancia del DataSet
                DSAlumnos ds = new DSAlumnos();

                // TableAdapter real generado por el .xsd
                DSAlumnosTableAdapters.AlumnosTableAdapter ta =
                    new DSAlumnosTableAdapters.AlumnosTableAdapter();

                // Llenar tabla
                ta.Fill(ds.Alumnos);

                // Nombre EXACTO del DataSet dentro del RDLC (lo que aparece en Datos del Informe)
                ReportDataSource rds =
                      new ReportDataSource("DataSetAlumnos", (DataTable)ds.Tables["Alumnos"]);


                reportViewer1.LocalReport.DataSources.Add(rds);

                // Refrescar visor
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error cargando reporte:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
