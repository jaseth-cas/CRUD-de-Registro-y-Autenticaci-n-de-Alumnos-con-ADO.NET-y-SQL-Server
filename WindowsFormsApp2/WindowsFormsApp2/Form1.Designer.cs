using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Lblusu = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Lblcontr = new System.Windows.Forms.Label();
            this.GpBxCrede = new System.Windows.Forms.GroupBox();
            this.Lblconf = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lblnomb = new System.Windows.Forms.Label();
            this.Lblced = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.Lblcarre = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.Lblsemes = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.rbMatutina = new System.Windows.Forms.RadioButton();
            this.rbVespertina = new System.Windows.Forms.RadioButton();
            this.chkTerminos = new System.Windows.Forms.CheckBox();
            this.chkNotificaciones = new System.Windows.Forms.CheckBox();
            this.GpbxAlum = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnnuv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnguar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnslr = new System.Windows.Forms.ToolStripMenuItem();
            this.btnacercade = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnuopcion = new System.Windows.Forms.MenuStrip();
            this.GpBxalumnos = new System.Windows.Forms.GroupBox();
            this.Btnedit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnElim = new System.Windows.Forms.ToolStripMenuItem();
            this.LblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Lblbusc = new System.Windows.Forms.Label();
            this.txtbusc = new System.Windows.Forms.TextBox();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GpBxCrede.SuspendLayout();
            this.GpbxAlum.SuspendLayout();
            this.Mnuopcion.SuspendLayout();
            this.GpBxalumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(136, 87);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // Lblusu
            // 
            this.Lblusu.AutoSize = true;
            this.Lblusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblusu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblusu.Location = new System.Drawing.Point(50, 43);
            this.Lblusu.Name = "Lblusu";
            this.Lblusu.Size = new System.Drawing.Size(60, 18);
            this.Lblusu.TabIndex = 6;
            this.Lblusu.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(136, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // Lblcontr
            // 
            this.Lblcontr.AutoSize = true;
            this.Lblcontr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcontr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblcontr.Location = new System.Drawing.Point(25, 91);
            this.Lblcontr.Name = "Lblcontr";
            this.Lblcontr.Size = new System.Drawing.Size(85, 18);
            this.Lblcontr.TabIndex = 7;
            this.Lblcontr.Text = "Contraseña";
            // 
            // GpBxCrede
            // 
            this.GpBxCrede.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GpBxCrede.Controls.Add(this.Lblconf);
            this.GpBxCrede.Controls.Add(this.Lblcontr);
            this.GpBxCrede.Controls.Add(this.Lblusu);
            this.GpBxCrede.Controls.Add(this.txtConfirmar);
            this.GpBxCrede.Controls.Add(this.label7);
            this.GpBxCrede.Controls.Add(this.txtContraseña);
            this.GpBxCrede.Controls.Add(this.label6);
            this.GpBxCrede.Controls.Add(this.txtUsuario);
            this.GpBxCrede.Controls.Add(this.label5);
            this.GpBxCrede.Location = new System.Drawing.Point(12, 343);
            this.GpBxCrede.Name = "GpBxCrede";
            this.GpBxCrede.Size = new System.Drawing.Size(300, 200);
            this.GpBxCrede.TabIndex = 1;
            this.GpBxCrede.TabStop = false;
            this.GpBxCrede.Text = "Credenciales";
            // 
            // Lblconf
            // 
            this.Lblconf.AutoSize = true;
            this.Lblconf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblconf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblconf.Location = new System.Drawing.Point(36, 141);
            this.Lblconf.Name = "Lblconf";
            this.Lblconf.Size = new System.Drawing.Size(74, 18);
            this.Lblconf.TabIndex = 8;
            this.Lblconf.Text = "Confirmar";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(136, 137);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmar.TabIndex = 0;
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Confirmar:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuario:";
            // 
            // Lblnomb
            // 
            this.Lblnomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnomb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblnomb.Location = new System.Drawing.Point(10, 66);
            this.Lblnomb.Name = "Lblnomb";
            this.Lblnomb.Size = new System.Drawing.Size(100, 23);
            this.Lblnomb.TabIndex = 12;
            this.Lblnomb.Text = "Nombre:";
            this.Lblnomb.Click += new System.EventHandler(this.Lblnomb_Click);
            // 
            // Lblced
            // 
            this.Lblced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblced.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblced.Location = new System.Drawing.Point(10, 106);
            this.Lblced.Name = "Lblced";
            this.Lblced.Size = new System.Drawing.Size(100, 23);
            this.Lblced.TabIndex = 10;
            this.Lblced.Text = "Cédula:";
            this.Lblced.Click += new System.EventHandler(this.Lblced_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(116, 105);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(144, 22);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // Lblcarre
            // 
            this.Lblcarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcarre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblcarre.Location = new System.Drawing.Point(10, 146);
            this.Lblcarre.Name = "Lblcarre";
            this.Lblcarre.Size = new System.Drawing.Size(100, 23);
            this.Lblcarre.TabIndex = 8;
            this.Lblcarre.Text = "Carrera:";
            this.Lblcarre.Click += new System.EventHandler(this.Lblcarre_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.Location = new System.Drawing.Point(116, 145);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(144, 24);
            this.cmbCarrera.TabIndex = 7;
            this.cmbCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCarrera_SelectedIndexChanged);
            // 
            // Lblsemes
            // 
            this.Lblsemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsemes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblsemes.Location = new System.Drawing.Point(10, 186);
            this.Lblsemes.Name = "Lblsemes";
            this.Lblsemes.Size = new System.Drawing.Size(100, 23);
            this.Lblsemes.TabIndex = 6;
            this.Lblsemes.Text = "Semestre:";
            this.Lblsemes.Click += new System.EventHandler(this.Lblsemes_Click);
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestre.Location = new System.Drawing.Point(116, 186);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(144, 24);
            this.cmbSemestre.TabIndex = 5;
            this.cmbSemestre.SelectedIndexChanged += new System.EventHandler(this.cmbSemestre_SelectedIndexChanged);
            // 
            // rbMatutina
            // 
            this.rbMatutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMatutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMatutina.Location = new System.Drawing.Point(120, 226);
            this.rbMatutina.Name = "rbMatutina";
            this.rbMatutina.Size = new System.Drawing.Size(104, 24);
            this.rbMatutina.TabIndex = 4;
            this.rbMatutina.Text = "Matutina";
            // 
            // rbVespertina
            // 
            this.rbVespertina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVespertina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbVespertina.Location = new System.Drawing.Point(10, 226);
            this.rbVespertina.Name = "rbVespertina";
            this.rbVespertina.Size = new System.Drawing.Size(104, 24);
            this.rbVespertina.TabIndex = 3;
            this.rbVespertina.Text = "Vespertina";
            // 
            // chkTerminos
            // 
            this.chkTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTerminos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkTerminos.Location = new System.Drawing.Point(10, 271);
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.Size = new System.Drawing.Size(150, 24);
            this.chkTerminos.TabIndex = 2;
            this.chkTerminos.Text = "Acepto términos";
            // 
            // chkNotificaciones
            // 
            this.chkNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotificaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkNotificaciones.Location = new System.Drawing.Point(150, 271);
            this.chkNotificaciones.Name = "chkNotificaciones";
            this.chkNotificaciones.Size = new System.Drawing.Size(134, 24);
            this.chkNotificaciones.TabIndex = 1;
            this.chkNotificaciones.Text = "Notificaciones";
            // 
            // GpbxAlum
            // 
            this.GpbxAlum.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GpbxAlum.Controls.Add(this.txtId);
            this.GpbxAlum.Controls.Add(this.LblId);
            this.GpbxAlum.Controls.Add(this.chkNotificaciones);
            this.GpbxAlum.Controls.Add(this.chkTerminos);
            this.GpbxAlum.Controls.Add(this.rbVespertina);
            this.GpbxAlum.Controls.Add(this.rbMatutina);
            this.GpbxAlum.Controls.Add(this.cmbSemestre);
            this.GpbxAlum.Controls.Add(this.Lblsemes);
            this.GpbxAlum.Controls.Add(this.cmbCarrera);
            this.GpbxAlum.Controls.Add(this.Lblcarre);
            this.GpbxAlum.Controls.Add(this.txtCedula);
            this.GpbxAlum.Controls.Add(this.Lblced);
            this.GpbxAlum.Controls.Add(this.txtNombre);
            this.GpbxAlum.Controls.Add(this.Lblnomb);
            this.GpbxAlum.ForeColor = System.Drawing.SystemColors.Control;
            this.GpbxAlum.Location = new System.Drawing.Point(12, 31);
            this.GpbxAlum.Name = "GpbxAlum";
            this.GpbxAlum.Size = new System.Drawing.Size(300, 302);
            this.GpbxAlum.TabIndex = 0;
            this.GpbxAlum.TabStop = false;
            this.GpbxAlum.Text = "Datos del Alumno";
            this.GpbxAlum.Enter += new System.EventHandler(this.GpbxAlum_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.ItemHeight = 16;
            this.lstAlumnos.Location = new System.Drawing.Point(6, 78);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(288, 420);
            this.lstAlumnos.TabIndex = 0;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
            // 
            // btnnuv
            // 
            this.btnnuv.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnuv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnnuv.Name = "btnnuv";
            this.btnnuv.Size = new System.Drawing.Size(66, 24);
            this.btnnuv.Text = "Nuevo";
            this.btnnuv.Click += new System.EventHandler(this.btnnuv_Click);
            // 
            // btnguar
            // 
            this.btnguar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnguar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnguar.Name = "btnguar";
            this.btnguar.Size = new System.Drawing.Size(76, 24);
            this.btnguar.Text = "Guardar";
            this.btnguar.Click += new System.EventHandler(this.btnguar_Click);
            // 
            // btnslr
            // 
            this.btnslr.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnslr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnslr.Name = "btnslr";
            this.btnslr.Size = new System.Drawing.Size(52, 24);
            this.btnslr.Text = "Salir";
            this.btnslr.Click += new System.EventHandler(this.btnslr_Click);
            // 
            // btnacercade
            // 
            this.btnacercade.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnacercade.ForeColor = System.Drawing.SystemColors.Control;
            this.btnacercade.Name = "btnacercade";
            this.btnacercade.Size = new System.Drawing.Size(89, 24);
            this.btnacercade.Text = "Acerca de";
            this.btnacercade.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // Mnuopcion
            // 
            this.Mnuopcion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mnuopcion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuv,
            this.btnguar,
            this.Btnedit,
            this.BtnElim,
            this.buscaToolStripMenuItem,
            this.btnslr,
            this.btnacercade});
            this.Mnuopcion.Location = new System.Drawing.Point(0, 0);
            this.Mnuopcion.Name = "Mnuopcion";
            this.Mnuopcion.Size = new System.Drawing.Size(697, 28);
            this.Mnuopcion.TabIndex = 2;
            // 
            // GpBxalumnos
            // 
            this.GpBxalumnos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GpBxalumnos.Controls.Add(this.txtbusc);
            this.GpBxalumnos.Controls.Add(this.Lblbusc);
            this.GpBxalumnos.Controls.Add(this.lstAlumnos);
            this.GpBxalumnos.ForeColor = System.Drawing.SystemColors.Control;
            this.GpBxalumnos.Location = new System.Drawing.Point(318, 35);
            this.GpBxalumnos.Name = "GpBxalumnos";
            this.GpBxalumnos.Size = new System.Drawing.Size(304, 508);
            this.GpBxalumnos.TabIndex = 3;
            this.GpBxalumnos.TabStop = false;
            this.GpBxalumnos.Text = "Lista de Alumnos";
            // 
            // Btnedit
            // 
            this.Btnedit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btnedit.ForeColor = System.Drawing.SystemColors.Control;
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(62, 24);
            this.Btnedit.Text = "Editar";
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // BtnElim
            // 
            this.BtnElim.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnElim.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnElim.Name = "BtnElim";
            this.BtnElim.Size = new System.Drawing.Size(77, 24);
            this.BtnElim.Text = "Eliminar";
            this.BtnElim.Click += new System.EventHandler(this.BtnElim_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(10, 34);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(19, 18);
            this.LblId.TabIndex = 13;
            this.LblId.Text = "Id";
            this.LblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(116, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 22);
            this.txtId.TabIndex = 14;
            // 
            // Lblbusc
            // 
            this.Lblbusc.AutoSize = true;
            this.Lblbusc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbusc.Location = new System.Drawing.Point(6, 40);
            this.Lblbusc.Name = "Lblbusc";
            this.Lblbusc.Size = new System.Drawing.Size(128, 18);
            this.Lblbusc.TabIndex = 15;
            this.Lblbusc.Text = "Buscar por cédula";
            // 
            // txtbusc
            // 
            this.txtbusc.Location = new System.Drawing.Point(150, 39);
            this.txtbusc.Name = "txtbusc";
            this.txtbusc.Size = new System.Drawing.Size(144, 22);
            this.txtbusc.TabIndex = 15;
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buscaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.buscaToolStripMenuItem.Text = "Buscar";
            this.buscaToolStripMenuItem.Click += new System.EventHandler(this.buscaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(697, 565);
            this.Controls.Add(this.GpBxalumnos);
            this.Controls.Add(this.GpbxAlum);
            this.Controls.Add(this.GpBxCrede);
            this.Controls.Add(this.Mnuopcion);
            this.MainMenuStrip = this.Mnuopcion;
            this.Name = "Form1";
            this.Text = "Registro de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GpBxCrede.ResumeLayout(false);
            this.GpBxCrede.PerformLayout();
            this.GpbxAlum.ResumeLayout(false);
            this.GpbxAlum.PerformLayout();
            this.Mnuopcion.ResumeLayout(false);
            this.Mnuopcion.PerformLayout();
            this.GpBxalumnos.ResumeLayout(false);
            this.GpBxalumnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtContraseña;
        private Label Lblusu;
        private TextBox txtUsuario;
        private Label Lblcontr;
        private GroupBox GpBxCrede;
        private Label Lblconf;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox txtConfirmar;
        private Label Lblnomb;
        private Label Lblced;
        private TextBox txtCedula;
        private Label Lblcarre;
        private ComboBox cmbCarrera;
        private Label Lblsemes;
        private ComboBox cmbSemestre;
        private RadioButton rbMatutina;
        private RadioButton rbVespertina;
        private CheckBox chkTerminos;
        private CheckBox chkNotificaciones;
        private GroupBox GpbxAlum;
        private ListBox lstAlumnos;
        private TextBox txtNombre;
        private ToolStripMenuItem btnnuv;
        private ToolStripMenuItem btnguar;
        private ToolStripMenuItem btnslr;
        private ToolStripMenuItem btnacercade;
        private MenuStrip Mnuopcion;
        private GroupBox GpBxalumnos;
        private ToolStripMenuItem Btnedit;
        private ToolStripMenuItem BtnElim;
        private Label LblId;
        private TextBox txtId;
        private TextBox txtbusc;
        private Label Lblbusc;
        private ToolStripMenuItem buscaToolStripMenuItem;
    }
}


