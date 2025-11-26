using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            InicializarFormulario();

        }
        private void InicializarFormulario()
        {
           

            TxtbxContra.PasswordChar = '*'; // Ocultar texto
            TxtbxContra.MaxLength = 12;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblAcceso_Click(object sender, EventArgs e)
        {

        }

        private void LblTipo_Click(object sender, EventArgs e)
        {

        }

        private void TxtbxContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            if (Cmbxrol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione su rol (Administrador o Profesor).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtbxContra.Text))
            {
                MessageBox.Show("Debe ingresar el código de acceso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Supongamos que 1234 es el código válido para ambos roles
            if (TxtbxContra.Text == "1234")
            {
                MessageBox.Show("Bienvenido al sistema.", "Acceso autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si quieres abrir Form1:
                Form1 formularioPrincipal = new Form1();
                formularioPrincipal.Show();
                this.Hide();

            
            }
            else
            {
                MessageBox.Show("Código incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtbxContra.Clear();
                TxtbxContra.Focus();
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lblacc_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
