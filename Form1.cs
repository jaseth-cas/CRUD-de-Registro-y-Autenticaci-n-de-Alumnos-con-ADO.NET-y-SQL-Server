using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            // Atajos
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            // Eventos
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtCedula.KeyPress += txtCedula_KeyPress;
            txtCedula.Validating += txtCedula_Validating;
            txtId.Text = ObtenerSiguienteId().ToString();

            // Menú
            btnnuv.Click += nuevoToolStripMenuItem_Click;
            btnguar.Click += guardarToolStripMenuItem_Click;
            btnslr.Click += salirToolStripMenuItem_Click;
            btnacercade.Click += acercaDeToolStripMenuItem_Click;
            lstAlumnos.HorizontalScrollbar = true;
            lstAlumnos.ScrollAlwaysVisible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReportes.Items.Clear();
            cmbReportes.Items.Add("Reporte general");
            cmbReportes.Items.Add("Reporte por carrera");
            cmbReportes.Items.Add("Reporte por jornada");
            cmbReportes.Items.Add("Reporte por rango de fechas");
            cmbReportes.Items.Add("Perfil del alumno");
            cmbReportes.SelectedIndex = 0;
            // Llenar combos
            cmbCarrera.Items.AddRange(new string[] {
        "Ingeniería",
        "Medicina",
        "Derecho"
    });

            cmbSemestre.Items.AddRange(new string[] {
        "1er Semestre",
        "2do Semestre",
        "3er Semestre",
        "4to Semestre"
    });

            // Contraseñas
            txtContraseña.PasswordChar = '*';
            txtConfirmar.PasswordChar = '*';
            txtContraseña.MaxLength = 12;

            txtUsuario.ReadOnly = true;

            // Cargar alumnos desde SQL Server
            CargarAlumnos();

            txtNombre.Focus();
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            GenerarUsuario();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria.", "Advertencia");
                e.Cancel = true;
            }
            else
                GenerarUsuario();
        }

       

        private void GenerarUsuario()
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();

            if (nombre.Length > 0 && cedula.Length > 0)
            {
                txtUsuario.Text = nombre.Substring(0, 1).ToLower() + cedula;
            }
            else
            {
                txtUsuario.Text = "";
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Nombre y cédula son obligatorios.");
                return false;
            }

          
            if (cmbCarrera.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbCarrera.Text))
            {
                MessageBox.Show("Debe seleccionar una carrera.");
                return false;
            }

          
            if (cmbSemestre.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbSemestre.Text))
            {
                MessageBox.Show("Debe seleccionar un semestre.");
                return false;
            }

            if (!rbMatutina.Checked && !rbVespertina.Checked)
            {
                MessageBox.Show("Debe seleccionar una jornada.");
                return false;
            }

            if (!chkTerminos.Checked)
            {
                MessageBox.Show("Debe aceptar los términos.");
                return false;
            }

            if (txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            if (txtContraseña.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.");
                return false;
            }

            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("No se pudo generar el usuario.");
                return false;
            }

            return true;
        }


        private void GuardarAlumno()
        {
            if (!ValidarCampos()) return;

            string jornada = rbMatutina.Checked ? "Matutina" : "Vespertina";

            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Alumnos 
                 (Nombre, Cedula, Carrera, Semestre, Jornada, Usuario, Contrasena, RecibirNotificaciones)
                 VALUES (@Nombre, @Cedula, @Carrera, @Semestre, @Jornada, @Usuario, @Contrasena, @Noti)", cn))
            {
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text.Trim());
                cmd.Parameters.AddWithValue("@Carrera", cmbCarrera.Text);
                cmd.Parameters.AddWithValue("@Semestre", cmbSemestre.Text);
                cmd.Parameters.AddWithValue("@Jornada", jornada);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@Noti", chkNotificaciones.Checked);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alumno guardado correctamente.", "Éxito");

            LimpiarCampos();
            CargarAlumnos();
            txtId.Text = ObtenerSiguienteId().ToString();
        }


        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtConfirmar.Clear();
            cmbCarrera.SelectedIndex = -1;
            cmbSemestre.SelectedIndex = -1;
            rbMatutina.Checked = false;
            rbVespertina.Checked = false;
            chkTerminos.Checked = false;
            chkNotificaciones.Checked = false;
            txtNombre.Focus();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Guardar
            if (e.Control && e.KeyCode == Keys.S)
            {
                GuardarAlumno();
                e.SuppressKeyPress = true;
            }

            // Editar
            if (e.Control && e.KeyCode == Keys.E)
            {
                EditarAlumno();   
                e.SuppressKeyPress = true;
            }

            // Eliminar
            if (e.Control && e.KeyCode == Keys.D)
            {
                EliminarAlumno(); 
                e.SuppressKeyPress = true;
            }

            // Nuevo
            if (e.KeyCode == Keys.Escape)
            {
                LimpiarCampos();
                e.SuppressKeyPress = true;
            }

            // Reportes
            if (e.Control && e.KeyCode == Keys.R)
            {
                BtnReporte.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void CargarAlumnos()
        {
            lstAlumnos.Items.Clear();

            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT Id, Nombre, Carrera, Jornada FROM Alumnos ORDER BY FechaRegistro DESC", cn))
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nombre = dr.GetString(1);
                    string carrera = dr.GetString(2);
                    string jornada = dr.GetString(3);

                    lstAlumnos.Items.Add($"{id} — {nombre} — {carrera} — {jornada}");
                }
            }
        }
        private void CargarAlumnoPorId(int id)
        {
            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos WHERE Id = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtId.Text = dr["Id"].ToString();
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtCedula.Text = dr["Cedula"].ToString();
                    cmbCarrera.Text = dr["Carrera"].ToString();
                    cmbSemestre.Text = dr["Semestre"].ToString();

                    string jornada = dr["Jornada"].ToString();
                    rbMatutina.Checked = jornada == "Matutina";
                    rbVespertina.Checked = jornada == "Vespertina";

                    txtUsuario.Text = dr["Usuario"].ToString();
                    txtContraseña.Text = dr["Contrasena"].ToString();
                    txtConfirmar.Text = dr["Contrasena"].ToString();
                    chkNotificaciones.Checked = (bool)dr["RecibirNotificaciones"];
                }
            }
        }

        private int ObtenerSiguienteId()
        {
            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(Id), 0) + 1 FROM Alumnos", cn))
            {
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void EditarAlumno()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un alumno de la lista para editar.", "Advertencia");
                return;
            }

            if (!ValidarCampos()) return;

            string jornada = rbMatutina.Checked ? "Matutina" : "Vespertina";

            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE Alumnos SET
            Nombre = @Nombre,
            Cedula = @Cedula,
            Carrera = @Carrera,
            Semestre = @Semestre,
            Jornada = @Jornada,
            Usuario = @Usuario,
            Contrasena = @Contrasena,
            RecibirNotificaciones = @Noti
            WHERE Id = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text.Trim());
                cmd.Parameters.AddWithValue("@Carrera", cmbCarrera.Text);
                cmd.Parameters.AddWithValue("@Semestre", cmbSemestre.Text);
                cmd.Parameters.AddWithValue("@Jornada", jornada);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@Noti", chkNotificaciones.Checked);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alumno actualizado correctamente.", "Información");
            CargarAlumnos();
        }

        private void EliminarAlumno()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un alumno de la lista para eliminar.", "Advertencia");
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Está seguro que desea eliminar este alumno?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes)
                return;

            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Alumnos WHERE Id = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alumno eliminado correctamente.", "Información");

            LimpiarCampos();
            CargarAlumnos();
            LimpiarCampos();
        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedItem == null) return;

            string item = lstAlumnos.SelectedItem.ToString();

            // El formato es: "Id — Nombre — Carrera — Jornada"
            string idTexto = item.Split('—')[0].Trim();

            if (int.TryParse(idTexto, out int id))
            {
                CargarAlumnoPorId(id);
            }
        }
        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbusc.Text))
            {
                MessageBox.Show("Ingrese una cédula para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = Conexion.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos WHERE Cedula = @Cedula", cn))
            {
                cmd.Parameters.AddWithValue("@Cedula", txtbusc.Text.Trim());

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Llenar los campos
                    txtId.Text = dr["Id"].ToString();
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtCedula.Text = dr["Cedula"].ToString();
                    cmbCarrera.Text = dr["Carrera"].ToString();
                    cmbSemestre.Text = dr["Semestre"].ToString();
                    txtUsuario.Text = dr["Usuario"].ToString();
                    txtContraseña.Text = dr["Contrasena"].ToString();
                    chkNotificaciones.Checked = Convert.ToBoolean(dr["RecibirNotificaciones"]);

                    string jornada = dr["Jornada"].ToString();
                    rbMatutina.Checked = jornada == "Matutina";
                    rbVespertina.Checked = jornada == "Vespertina";

                    MessageBox.Show("Alumno encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún alumno con esa cédula.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {

        }



        private void Btnedit_Click(object sender, EventArgs e)
        {
            EditarAlumno();
        }

        private void BtnElim_Click(object sender, EventArgs e)
        {
            EliminarAlumno();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarAlumno();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Alexandra De Gracia y Jaseth Castillo\nVersión: 1.0", "Acerca de");
        }

        private void btnslr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void Lblnomb_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblced_Click(object sender, EventArgs e)
        {

        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lblcarre_Click(object sender, EventArgs e)
        {

        }

        private void Lblsemes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GpbxAlum_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {

        }


        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnnuv_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtId.Text = ObtenerSiguienteId().ToString(); // ← aquí
        }

        private void btnguar_Click(object sender, EventArgs e)
        {

        }

        private void BtnVist_Click(object sender, EventArgs e)
        {
            VistaReporte vr = new VistaReporte();
            vr.ShowDialog();
        }

        private void txtbusc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            string opcion = cmbReportes.SelectedItem as string;

            if (string.IsNullOrEmpty(opcion))
            {
                MessageBox.Show("Seleccione un tipo de reporte.");
                return;
            }

            switch (opcion)
            {
                case "Reporte general":
                    new VistaReporte().ShowDialog();
                    break;

                case "Reporte por carrera":
                    new VistaReporteCarrera().ShowDialog();
                    break;

                case "Reporte por jornada":
                    new ReporteJornada().ShowDialog();
                    break;

                case "Reporte por rango de fechas":
                    new ReporteRango().ShowDialog();
                    break;

                case "Perfil del alumno":
                    new ReporteAlumno().ShowDialog();
                    break;
            }
        }
    }
}


