namespace MD.GA.GUI.GA.Almacen.Est_Egreso
{
    partial class RptEstadEgreso
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
            this.rptEstEgre = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gpbEstEgre = new System.Windows.Forms.GroupBox();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArtNom = new System.Windows.Forms.Label();
            this.btnEstEgreGen = new System.Windows.Forms.Button();
            this.dtpFechaEstEgreF = new System.Windows.Forms.DateTimePicker();
            this.lblEstEgreFf = new System.Windows.Forms.Label();
            this.dtpFechaEstEgreI = new System.Windows.Forms.DateTimePicker();
            this.lblEstEgreFi = new System.Windows.Forms.Label();
            this.gpbEstEgre.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptEstEgre
            // 
            this.rptEstEgre.LocalReport.ReportEmbeddedResource = "MD.GA.GUI.GA.Almacen.Est_Egreso.rptEstEgreso.rdlc";
            this.rptEstEgre.Location = new System.Drawing.Point(12, 155);
            this.rptEstEgre.Name = "rptEstEgre";
            this.rptEstEgre.Size = new System.Drawing.Size(816, 438);
            this.rptEstEgre.TabIndex = 3;
            // 
            // gpbEstEgre
            // 
            this.gpbEstEgre.Controls.Add(this.cboArticulo);
            this.gpbEstEgre.Controls.Add(this.cboSede);
            this.gpbEstEgre.Controls.Add(this.label2);
            this.gpbEstEgre.Controls.Add(this.label1);
            this.gpbEstEgre.Controls.Add(this.cboArea);
            this.gpbEstEgre.Controls.Add(this.lblArtNom);
            this.gpbEstEgre.Controls.Add(this.btnEstEgreGen);
            this.gpbEstEgre.Controls.Add(this.dtpFechaEstEgreF);
            this.gpbEstEgre.Controls.Add(this.lblEstEgreFf);
            this.gpbEstEgre.Controls.Add(this.dtpFechaEstEgreI);
            this.gpbEstEgre.Controls.Add(this.lblEstEgreFi);
            this.gpbEstEgre.Location = new System.Drawing.Point(12, 12);
            this.gpbEstEgre.Name = "gpbEstEgre";
            this.gpbEstEgre.Size = new System.Drawing.Size(816, 137);
            this.gpbEstEgre.TabIndex = 2;
            this.gpbEstEgre.TabStop = false;
            this.gpbEstEgre.Text = "Filtros";
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(94, 81);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(230, 21);
            this.cboArticulo.TabIndex = 25;
            this.cboArticulo.Leave += new System.EventHandler(this.cboArticulo_Leave);
            // 
            // cboSede
            // 
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(665, 78);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(126, 21);
            this.cboSede.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sede:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Articulo:";
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(417, 80);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(130, 21);
            this.cboArea.TabIndex = 20;
            this.cboArea.Leave += new System.EventHandler(this.cboArea_Leave);
            // 
            // lblArtNom
            // 
            this.lblArtNom.AutoSize = true;
            this.lblArtNom.Location = new System.Drawing.Point(365, 86);
            this.lblArtNom.Name = "lblArtNom";
            this.lblArtNom.Size = new System.Drawing.Size(32, 13);
            this.lblArtNom.TabIndex = 19;
            this.lblArtNom.Text = "Área:";
            // 
            // btnEstEgreGen
            // 
            this.btnEstEgreGen.Location = new System.Drawing.Point(627, 24);
            this.btnEstEgreGen.Name = "btnEstEgreGen";
            this.btnEstEgreGen.Size = new System.Drawing.Size(164, 48);
            this.btnEstEgreGen.TabIndex = 18;
            this.btnEstEgreGen.Text = "Generar";
            this.btnEstEgreGen.UseVisualStyleBackColor = true;
            this.btnEstEgreGen.Click += new System.EventHandler(this.btnEstEgreGen_Click);
            // 
            // dtpFechaEstEgreF
            // 
            this.dtpFechaEstEgreF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstEgreF.Location = new System.Drawing.Point(395, 30);
            this.dtpFechaEstEgreF.Name = "dtpFechaEstEgreF";
            this.dtpFechaEstEgreF.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaEstEgreF.TabIndex = 17;
            // 
            // lblEstEgreFf
            // 
            this.lblEstEgreFf.AutoSize = true;
            this.lblEstEgreFf.Location = new System.Drawing.Point(298, 36);
            this.lblEstEgreFf.Name = "lblEstEgreFf";
            this.lblEstEgreFf.Size = new System.Drawing.Size(57, 13);
            this.lblEstEgreFf.TabIndex = 16;
            this.lblEstEgreFf.Text = "Fecha Fin:";
            // 
            // dtpFechaEstEgreI
            // 
            this.dtpFechaEstEgreI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstEgreI.Location = new System.Drawing.Point(129, 30);
            this.dtpFechaEstEgreI.Name = "dtpFechaEstEgreI";
            this.dtpFechaEstEgreI.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaEstEgreI.TabIndex = 15;
            // 
            // lblEstEgreFi
            // 
            this.lblEstEgreFi.AutoSize = true;
            this.lblEstEgreFi.Location = new System.Drawing.Point(32, 36);
            this.lblEstEgreFi.Name = "lblEstEgreFi";
            this.lblEstEgreFi.Size = new System.Drawing.Size(68, 13);
            this.lblEstEgreFi.TabIndex = 0;
            this.lblEstEgreFi.Text = "Fecha Inicio:";
            // 
            // RptEstadEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 605);
            this.Controls.Add(this.rptEstEgre);
            this.Controls.Add(this.gpbEstEgre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RptEstadEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de Salida";
            this.Load += new System.EventHandler(this.RptEstadEgreso_Load);
            this.gpbEstEgre.ResumeLayout(false);
            this.gpbEstEgre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEstEgre;
        private System.Windows.Forms.GroupBox gpbEstEgre;
        private System.Windows.Forms.Button btnEstEgreGen;
        private System.Windows.Forms.DateTimePicker dtpFechaEstEgreF;
        private System.Windows.Forms.Label lblEstEgreFf;
        private System.Windows.Forms.DateTimePicker dtpFechaEstEgreI;
        private System.Windows.Forms.Label lblEstEgreFi;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboArticulo;
    }
}