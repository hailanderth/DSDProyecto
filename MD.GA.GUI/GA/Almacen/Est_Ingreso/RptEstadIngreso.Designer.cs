namespace MD.GA.GUI.GA.Almacen.Est_Ingreso
{
    partial class RptEstadIngreso
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
            this.gpbEstIng = new System.Windows.Forms.GroupBox();
            this.btnEstIngGen = new System.Windows.Forms.Button();
            this.dtpFechaEstIngF = new System.Windows.Forms.DateTimePicker();
            this.lblEstIngFf = new System.Windows.Forms.Label();
            this.dtpFechaEstIngI = new System.Windows.Forms.DateTimePicker();
            this.lblEstIngFi = new System.Windows.Forms.Label();
            this.rptEstIng = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArtNom = new System.Windows.Forms.Label();
            this.gpbEstIng.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEstIng
            // 
            this.gpbEstIng.Controls.Add(this.cboArticulo);
            this.gpbEstIng.Controls.Add(this.label1);
            this.gpbEstIng.Controls.Add(this.cboArea);
            this.gpbEstIng.Controls.Add(this.lblArtNom);
            this.gpbEstIng.Controls.Add(this.btnEstIngGen);
            this.gpbEstIng.Controls.Add(this.dtpFechaEstIngF);
            this.gpbEstIng.Controls.Add(this.lblEstIngFf);
            this.gpbEstIng.Controls.Add(this.dtpFechaEstIngI);
            this.gpbEstIng.Controls.Add(this.lblEstIngFi);
            this.gpbEstIng.Location = new System.Drawing.Point(12, 12);
            this.gpbEstIng.Name = "gpbEstIng";
            this.gpbEstIng.Size = new System.Drawing.Size(816, 137);
            this.gpbEstIng.TabIndex = 0;
            this.gpbEstIng.TabStop = false;
            this.gpbEstIng.Text = "Filtros";
            // 
            // btnEstIngGen
            // 
            this.btnEstIngGen.Location = new System.Drawing.Point(625, 36);
            this.btnEstIngGen.Name = "btnEstIngGen";
            this.btnEstIngGen.Size = new System.Drawing.Size(164, 55);
            this.btnEstIngGen.TabIndex = 18;
            this.btnEstIngGen.Text = "Generar";
            this.btnEstIngGen.UseVisualStyleBackColor = true;
            this.btnEstIngGen.Click += new System.EventHandler(this.btnEstIngGen_Click);
            // 
            // dtpFechaEstIngF
            // 
            this.dtpFechaEstIngF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstIngF.Location = new System.Drawing.Point(412, 29);
            this.dtpFechaEstIngF.Name = "dtpFechaEstIngF";
            this.dtpFechaEstIngF.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaEstIngF.TabIndex = 17;
            // 
            // lblEstIngFf
            // 
            this.lblEstIngFf.AutoSize = true;
            this.lblEstIngFf.Location = new System.Drawing.Point(315, 35);
            this.lblEstIngFf.Name = "lblEstIngFf";
            this.lblEstIngFf.Size = new System.Drawing.Size(57, 13);
            this.lblEstIngFf.TabIndex = 16;
            this.lblEstIngFf.Text = "Fecha Fin:";
            // 
            // dtpFechaEstIngI
            // 
            this.dtpFechaEstIngI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstIngI.Location = new System.Drawing.Point(119, 30);
            this.dtpFechaEstIngI.Name = "dtpFechaEstIngI";
            this.dtpFechaEstIngI.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaEstIngI.TabIndex = 15;
            // 
            // lblEstIngFi
            // 
            this.lblEstIngFi.AutoSize = true;
            this.lblEstIngFi.Location = new System.Drawing.Point(22, 36);
            this.lblEstIngFi.Name = "lblEstIngFi";
            this.lblEstIngFi.Size = new System.Drawing.Size(68, 13);
            this.lblEstIngFi.TabIndex = 0;
            this.lblEstIngFi.Text = "Fecha Inicio:";
            // 
            // rptEstIng
            // 
            this.rptEstIng.LocalReport.ReportEmbeddedResource = "MD.GA.GUI.GA.Almacen.Est_Ingreso.rptEstIngreso.rdlc";
            this.rptEstIng.Location = new System.Drawing.Point(12, 155);
            this.rptEstIng.Name = "rptEstIng";
            this.rptEstIng.Size = new System.Drawing.Size(816, 438);
            this.rptEstIng.TabIndex = 1;
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(89, 83);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(230, 21);
            this.cboArticulo.TabIndex = 29;
            this.cboArticulo.Leave += new System.EventHandler(this.cboArticulo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Articulo:";
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(412, 82);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(130, 21);
            this.cboArea.TabIndex = 27;
            this.cboArea.Leave += new System.EventHandler(this.cboArea_Leave);
            // 
            // lblArtNom
            // 
            this.lblArtNom.AutoSize = true;
            this.lblArtNom.Location = new System.Drawing.Point(360, 88);
            this.lblArtNom.Name = "lblArtNom";
            this.lblArtNom.Size = new System.Drawing.Size(32, 13);
            this.lblArtNom.TabIndex = 26;
            this.lblArtNom.Text = "Área:";
            // 
            // RptEstadIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 605);
            this.Controls.Add(this.rptEstIng);
            this.Controls.Add(this.gpbEstIng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RptEstadIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de Ingreso";
            this.Load += new System.EventHandler(this.RptEstadIngreso_Load);
            this.gpbEstIng.ResumeLayout(false);
            this.gpbEstIng.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEstIng;
        private System.Windows.Forms.Button btnEstIngGen;
        private System.Windows.Forms.DateTimePicker dtpFechaEstIngF;
        private System.Windows.Forms.Label lblEstIngFf;
        private System.Windows.Forms.DateTimePicker dtpFechaEstIngI;
        private System.Windows.Forms.Label lblEstIngFi;
        private Microsoft.Reporting.WinForms.ReportViewer rptEstIng;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArtNom;
    }
}