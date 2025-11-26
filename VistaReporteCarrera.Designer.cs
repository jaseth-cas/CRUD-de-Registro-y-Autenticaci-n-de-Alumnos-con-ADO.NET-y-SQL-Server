namespace WindowsFormsApp2
{
    partial class VistaReporteCarrera
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
            this.Cmboxcarre = new System.Windows.Forms.ComboBox();
            this.BtnRpor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(13, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1115, 555);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Cmboxcarre
            // 
            this.Cmboxcarre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmboxcarre.FormattingEnabled = true;
            this.Cmboxcarre.Location = new System.Drawing.Point(12, 33);
            this.Cmboxcarre.Name = "Cmboxcarre";
            this.Cmboxcarre.Size = new System.Drawing.Size(121, 24);
            this.Cmboxcarre.TabIndex = 1;
            // 
            // BtnRpor
            // 
            this.BtnRpor.Location = new System.Drawing.Point(238, 33);
            this.BtnRpor.Name = "BtnRpor";
            this.BtnRpor.Size = new System.Drawing.Size(140, 23);
            this.BtnRpor.TabIndex = 2;
            this.BtnRpor.Text = "Generar Reporte";
            this.BtnRpor.UseVisualStyleBackColor = true;
            this.BtnRpor.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // VistaReporteCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.BtnRpor);
            this.Controls.Add(this.Cmboxcarre);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VistaReporteCarrera";
            this.Text = "VistaReporteCarrera";
            this.Load += new System.EventHandler(this.VistaReporteCarrera_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox Cmboxcarre;
        private System.Windows.Forms.Button BtnRpor;
    }
}