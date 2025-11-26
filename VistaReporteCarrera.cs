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

namespace WindowsFormsApp2
{
    public partial class VistaReporteCarrera : Form
    {
        
        public VistaReporteCarrera()
        {
            InitializeComponent();
            
            Cmboxcarre.Items.AddRange(new string[] {
                "Ingeniería",
                "Medicina",
                "Derecho"
            });
        }

        private void VistaReporteCarrera_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (Cmboxcarre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una carrera.");
                return;
            }

            string carrera = Cmboxcarre.SelectedItem.ToString();

            DSAlumnos ds = new DSAlumnos();
            var ta = new DSAlumnosTableAdapters.AlumnosTableAdapter();

            ta.FillByCarrera(ds.Alumnos, carrera);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "WindowsFormsApp2.ReporteCarrera.rdlc";

            ReportParameter p = new ReportParameter("CarreraParam", carrera);
            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DSAlumnos", ds.Tables["Alumnos"])
            );

            reportViewer1.RefreshReport();
        }

    }
}
