namespace WindowsFormsApp2
{
    partial class ReporteAlumno
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Cmbxalum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btngenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1306, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // Cmbxalum
            // 
            this.Cmbxalum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbxalum.FormattingEnabled = true;
            this.Cmbxalum.Location = new System.Drawing.Point(114, 40);
            this.Cmbxalum.Name = "Cmbxalum";
            this.Cmbxalum.Size = new System.Drawing.Size(121, 24);
            this.Cmbxalum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alumnos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btngenerar
            // 
            this.Btngenerar.Location = new System.Drawing.Point(114, 78);
            this.Btngenerar.Name = "Btngenerar";
            this.Btngenerar.Size = new System.Drawing.Size(121, 23);
            this.Btngenerar.TabIndex = 3;
            this.Btngenerar.Text = "Generar reporte";
            this.Btngenerar.UseVisualStyleBackColor = true;
            this.Btngenerar.Click += new System.EventHandler(this.Btngenerar_Click);
            // 
            // ReporteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 696);
            this.Controls.Add(this.Btngenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmbxalum);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAlumno";
            this.Text = "ReporteAlumno";
            this.Load += new System.EventHandler(this.ReporteAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox Cmbxalum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btngenerar;
    }
}