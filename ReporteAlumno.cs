using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ReporteAlumno : Form
    {
        public ReporteAlumno()
        {
            InitializeComponent();
        }

        private void ReporteAlumno_Load(object sender, EventArgs e)
        {
            using (var cn = Conexion.GetConnection())
            using (var cmd = new SqlCommand("SELECT Id, Nombre FROM Alumnos ORDER BY Nombre", cn))
            {
                cn.Open();
                var dr = cmd.ExecuteReader();

                var datos = new List<dynamic>();

                while (dr.Read())
                {
                    datos.Add(new
                    {
                        Id = dr.GetInt32(0),
                        Nombre = dr.GetString(1)
                    });
                }

                Cmbxalum.DataSource = datos;
                Cmbxalum.DisplayMember = "Nombre";
                Cmbxalum.ValueMember = "Id";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btngenerar_Click(object sender, EventArgs e)
        {
            if (Cmbxalum.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un alumno.");
                return;
            }

            int idAlumno = (int)Cmbxalum.SelectedValue;

            DSAlumnos ds = new DSAlumnos();
            var ta = new DSAlumnosTableAdapters.AlumnosTableAdapter();

            // Cargar solo el alumno seleccionado
            ta.FillById(ds.Alumnos, idAlumno);

            // Configurar reporte
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "WindowsFormsApp2.ReporteAlumno.rdlc"; 

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DSAlumnos", ds.Tables["Alumnos"])
            );

            reportViewer1.RefreshReport();
        }
    }
}
