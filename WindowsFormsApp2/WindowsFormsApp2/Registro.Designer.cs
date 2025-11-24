namespace WindowsFormsApp2
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAcceso = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.Lblacc = new System.Windows.Forms.Label();
            this.btnIng = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Cmbxrol = new System.Windows.Forms.ComboBox();
            this.TxtbxContra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAcceso
            // 
            this.LblAcceso.AutoSize = true;
            this.LblAcceso.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LblAcceso.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcceso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAcceso.Location = new System.Drawing.Point(65, 45);
            this.LblAcceso.Name = "LblAcceso";
            this.LblAcceso.Size = new System.Drawing.Size(278, 38);
            this.LblAcceso.TabIndex = 0;
            this.LblAcceso.Text = "Acceso al sistema";
            this.LblAcceso.Click += new System.EventHandler(this.LblAcceso_Click);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LblTipo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTipo.Location = new System.Drawing.Point(47, 141);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(117, 20);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo de usuario";
            this.LblTipo.Click += new System.EventHandler(this.LblTipo_Click);
            // 
            // Lblacc
            // 
            this.Lblacc.AutoSize = true;
            this.Lblacc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Lblacc.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblacc.ForeColor = System.Drawing.SystemColors.Control;
            this.Lblacc.Location = new System.Drawing.Point(47, 189);
            this.Lblacc.Name = "Lblacc";
            this.Lblacc.Size = new System.Drawing.Size(122, 20);
            this.Lblacc.TabIndex = 2;
            this.Lblacc.Text = "Código de acceso";
            this.Lblacc.Click += new System.EventHandler(this.Lblacc_Click);
            // 
            // btnIng
            // 
            this.btnIng.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIng.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIng.Location = new System.Drawing.Point(51, 268);
            this.btnIng.Name = "btnIng";
            this.btnIng.Size = new System.Drawing.Size(97, 34);
            this.btnIng.TabIndex = 3;
            this.btnIng.Text = "Ingresar";
            this.btnIng.UseVisualStyleBackColor = false;
            this.btnIng.Click += new System.EventHandler(this.btnIng_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.Crimson;
            this.Btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnsalir.Location = new System.Drawing.Point(251, 268);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(92, 34);
            this.Btnsalir.TabIndex = 4;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Cmbxrol
            // 
            this.Cmbxrol.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Cmbxrol.ForeColor = System.Drawing.SystemColors.Window;
            this.Cmbxrol.FormattingEnabled = true;
            this.Cmbxrol.Items.AddRange(new object[] {
            "Administrador",
            "Profesor"});
            this.Cmbxrol.Location = new System.Drawing.Point(237, 141);
            this.Cmbxrol.Name = "Cmbxrol";
            this.Cmbxrol.Size = new System.Drawing.Size(128, 24);
            this.Cmbxrol.TabIndex = 5;
            this.Cmbxrol.Text = "Administrador";
            this.Cmbxrol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtbxContra
            // 
            this.TxtbxContra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TxtbxContra.Location = new System.Drawing.Point(237, 187);
            this.TxtbxContra.Name = "TxtbxContra";
            this.TxtbxContra.Size = new System.Drawing.Size(128, 22);
            this.TxtbxContra.TabIndex = 6;
            this.TxtbxContra.TextChanged += new System.EventHandler(this.TxtbxContra_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.LblAcceso);
            this.groupBox1.Controls.Add(this.Btnsalir);
            this.groupBox1.Controls.Add(this.TxtbxContra);
            this.groupBox1.Controls.Add(this.btnIng);
            this.groupBox1.Controls.Add(this.Cmbxrol);
            this.groupBox1.Controls.Add(this.LblTipo);
            this.groupBox1.Controls.Add(this.Lblacc);
            this.groupBox1.Location = new System.Drawing.Point(43, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(491, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAcceso;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label Lblacc;
        private System.Windows.Forms.Button btnIng;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.ComboBox Cmbxrol;
        private System.Windows.Forms.TextBox TxtbxContra;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}