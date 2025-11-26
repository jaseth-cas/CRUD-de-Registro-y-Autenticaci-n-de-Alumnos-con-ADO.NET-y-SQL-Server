using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ReporteJornada : Form
    {
        

        public ReporteJornada()
        {
            InitializeComponent();
            
        }

        private void ReporteJornada_Load(object sender, EventArgs e)
        {
            DSAlumnos ds = new DSAlumnos();
            var ta = new DSAlumnosTableAdapters.AlumnosTableAdapter();

            ta.Fill(ds.Alumnos); 

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "WindowsFormsApp2.ReportJornada.rdlc";

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DSAlumnos", ds.Tables["Alumnos"])
            );

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
