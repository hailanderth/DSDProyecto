namespace MD.GA.GUI.GA.Compras.Consulta_Compra
{
    partial class ConsulCompra
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Documento_ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBConCom1 = new System.Windows.Forms.GroupBox();
            this.btnCloseReport = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.txtNumd = new System.Windows.Forms.TextBox();
            this.cboTipoPre = new System.Windows.Forms.ComboBox();
            this.txtTipodoc = new System.Windows.Forms.TextBox();
            this.btnCondSal2 = new System.Windows.Forms.Button();
            this.btnConCom1 = new System.Windows.Forms.Button();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblConCom2 = new System.Windows.Forms.Label();
            this.lblConCom1 = new System.Windows.Forms.Label();
            this.rptPresupuesto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptOdenCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptConsultaSalida = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAnulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAnulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Documento_ArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentoBindingSource)).BeginInit();
            this.gBConCom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Documento_ArticuloBindingSource
            // 
            this.Documento_ArticuloBindingSource.DataSource = typeof(MD.GA.BE.Entidades.Documento_Articulo);
            // 
            // DocumentoBindingSource
            // 
            this.DocumentoBindingSource.DataSource = typeof(MD.GA.BE.Entidades.Documento);
            // 
            // gBConCom1
            // 
            this.gBConCom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBConCom1.Controls.Add(this.cboEstado);
            this.gBConCom1.Controls.Add(this.label3);
            this.gBConCom1.Controls.Add(this.label2);
            this.gBConCom1.Controls.Add(this.label1);
            this.gBConCom1.Controls.Add(this.dtpFechaFin);
            this.gBConCom1.Controls.Add(this.dtpFechaInicio);
            this.gBConCom1.Controls.Add(this.cboSede);
            this.gBConCom1.Controls.Add(this.txtNumd);
            this.gBConCom1.Controls.Add(this.cboTipoPre);
            this.gBConCom1.Controls.Add(this.txtTipodoc);
            this.gBConCom1.Controls.Add(this.btnCondSal2);
            this.gBConCom1.Controls.Add(this.btnConCom1);
            this.gBConCom1.Controls.Add(this.cboTipoDoc);
            this.gBConCom1.Controls.Add(this.lblConCom2);
            this.gBConCom1.Controls.Add(this.lblConCom1);
            this.gBConCom1.Location = new System.Drawing.Point(6, 2);
            this.gBConCom1.Name = "gBConCom1";
            this.gBConCom1.Size = new System.Drawing.Size(1091, 218);
            this.gBConCom1.TabIndex = 0;
            this.gBConCom1.TabStop = false;
            this.gBConCom1.Text = "Filtros";
            // 
            // btnCloseReport
            // 
            this.btnCloseReport.Location = new System.Drawing.Point(1069, 2);
            this.btnCloseReport.Name = "btnCloseReport";
            this.btnCloseReport.Size = new System.Drawing.Size(24, 25);
            this.btnCloseReport.TabIndex = 8;
            this.btnCloseReport.Text = "X";
            this.btnCloseReport.UseVisualStyleBackColor = true;
            this.btnCloseReport.Visible = false;
            this.btnCloseReport.Click += new System.EventHandler(this.btnCloseReport_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "[--TODOS--]",
            "ACTIVO",
            "ANULADO"});
            this.cboEstado.Location = new System.Drawing.Point(147, 160);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(186, 21);
            this.cboEstado.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(147, 131);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(188, 20);
            this.dtpFechaFin.TabIndex = 34;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(147, 99);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(188, 20);
            this.dtpFechaInicio.TabIndex = 33;
            // 
            // cboSede
            // 
            this.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(147, 67);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(81, 21);
            this.cboSede.TabIndex = 32;
            this.cboSede.Visible = false;
            // 
            // txtNumd
            // 
            this.txtNumd.Location = new System.Drawing.Point(228, 67);
            this.txtNumd.Name = "txtNumd";
            this.txtNumd.Size = new System.Drawing.Size(107, 20);
            this.txtNumd.TabIndex = 31;
            this.txtNumd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumd_KeyPress);
            // 
            // cboTipoPre
            // 
            this.cboTipoPre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPre.FormattingEnabled = true;
            this.cboTipoPre.Items.AddRange(new object[] {
            "[--TODOS--]",
            "VAR",
            "PLA",
            "LAB"});
            this.cboTipoPre.Location = new System.Drawing.Point(147, 67);
            this.cboTipoPre.Name = "cboTipoPre";
            this.cboTipoPre.Size = new System.Drawing.Size(81, 21);
            this.cboTipoPre.TabIndex = 29;
            // 
            // txtTipodoc
            // 
            this.txtTipodoc.Location = new System.Drawing.Point(147, 67);
            this.txtTipodoc.Name = "txtTipodoc";
            this.txtTipodoc.ReadOnly = true;
            this.txtTipodoc.Size = new System.Drawing.Size(81, 20);
            this.txtTipodoc.TabIndex = 28;
            // 
            // btnCondSal2
            // 
            this.btnCondSal2.Location = new System.Drawing.Point(613, 85);
            this.btnCondSal2.Name = "btnCondSal2";
            this.btnCondSal2.Size = new System.Drawing.Size(197, 45);
            this.btnCondSal2.TabIndex = 26;
            this.btnCondSal2.Text = "Anular Documento";
            this.btnCondSal2.UseVisualStyleBackColor = true;
            this.btnCondSal2.Click += new System.EventHandler(this.btnCondSal2_Click);
            // 
            // btnConCom1
            // 
            this.btnConCom1.Location = new System.Drawing.Point(613, 34);
            this.btnConCom1.Name = "btnConCom1";
            this.btnConCom1.Size = new System.Drawing.Size(197, 45);
            this.btnConCom1.TabIndex = 18;
            this.btnConCom1.Text = "Generar";
            this.btnConCom1.UseVisualStyleBackColor = true;
            this.btnConCom1.Click += new System.EventHandler(this.btnConsulCom1_Click);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "[--TODOS--]",
            "PRESUPUESTO",
            "ORDEN DE COMPRA",
            "REGISTRO DE SALIDA"});
            this.cboTipoDoc.Location = new System.Drawing.Point(149, 31);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(186, 21);
            this.cboTipoDoc.TabIndex = 2;
            this.cboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cbBConCom1_SelectedIndexChanged);
            // 
            // lblConCom2
            // 
            this.lblConCom2.AutoSize = true;
            this.lblConCom2.Location = new System.Drawing.Point(22, 70);
            this.lblConCom2.Name = "lblConCom2";
            this.lblConCom2.Size = new System.Drawing.Size(93, 13);
            this.lblConCom2.TabIndex = 1;
            this.lblConCom2.Text = "Nº de documento:";
            // 
            // lblConCom1
            // 
            this.lblConCom1.AutoSize = true;
            this.lblConCom1.Location = new System.Drawing.Point(22, 34);
            this.lblConCom1.Name = "lblConCom1";
            this.lblConCom1.Size = new System.Drawing.Size(102, 13);
            this.lblConCom1.TabIndex = 0;
            this.lblConCom1.Text = "Tipo de documento:";
            // 
            // rptPresupuesto
            // 
            reportDataSource13.Name = "DataSet1";
            reportDataSource13.Value = this.Documento_ArticuloBindingSource;
            reportDataSource14.Name = "DataSet2";
            reportDataSource14.Value = this.DocumentoBindingSource;
            this.rptPresupuesto.LocalReport.DataSources.Add(reportDataSource13);
            this.rptPresupuesto.LocalReport.DataSources.Add(reportDataSource14);
            this.rptPresupuesto.LocalReport.ReportEmbeddedResource = "MD.GA.GUI.GA.Compras.Consulta_Compra.RptPresupuesto.rdlc";
            this.rptPresupuesto.Location = new System.Drawing.Point(4, 2);
            this.rptPresupuesto.Name = "rptPresupuesto";
            this.rptPresupuesto.Size = new System.Drawing.Size(1097, 731);
            this.rptPresupuesto.TabIndex = 4;
            // 
            // rptOdenCompra
            // 
            reportDataSource15.Name = "DataSet1";
            reportDataSource15.Value = this.Documento_ArticuloBindingSource;
            this.rptOdenCompra.LocalReport.DataSources.Add(reportDataSource15);
            this.rptOdenCompra.LocalReport.ReportEmbeddedResource = "MD.GA.GUI.GA.Compras.Consulta_Compra.ReporteOrdenCompra.rdlc";
            this.rptOdenCompra.Location = new System.Drawing.Point(6, 2);
            this.rptOdenCompra.Name = "rptOdenCompra";
            this.rptOdenCompra.Size = new System.Drawing.Size(1095, 731);
            this.rptOdenCompra.TabIndex = 5;
            // 
            // rptConsultaSalida
            // 
            reportDataSource16.Name = "DataSet1";
            reportDataSource16.Value = this.Documento_ArticuloBindingSource;
            this.rptConsultaSalida.LocalReport.DataSources.Add(reportDataSource16);
            this.rptConsultaSalida.LocalReport.ReportEmbeddedResource = "MD.GA.GUI.GA.Salida.Consulta_de_Salida.ConsultaSalida.rdlc";
            this.rptConsultaSalida.Location = new System.Drawing.Point(6, 2);
            this.rptConsultaSalida.Name = "rptConsultaSalida";
            this.rptConsultaSalida.ShowRefreshButton = false;
            this.rptConsultaSalida.ShowStopButton = false;
            this.rptConsultaSalida.Size = new System.Drawing.Size(1095, 731);
            this.rptConsultaSalida.TabIndex = 6;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.AllowUserToResizeRows = false;
            this.dgvDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NumeroDocumento,
            this.TipoPresupuesto,
            this.Sede,
            this.UsuarioCreacion,
            this.FechaCreacion,
            this.EstadoDocumento,
            this.EstadoBD,
            this.UsuarioAnulacion,
            this.FechaAnulacion});
            this.dgvDocumentos.Location = new System.Drawing.Point(6, 226);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowHeadersVisible = false;
            this.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentos.Size = new System.Drawing.Size(1095, 507);
            this.dgvDocumentos.TabIndex = 7;
            this.dgvDocumentos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDocumentos_DataBindingComplete);
            this.dgvDocumentos.DoubleClick += new System.EventHandler(this.dgvDocumentos_DoubleClick);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "TipoDocumento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NroDocumento";
            this.NumeroDocumento.HeaderText = "Numero";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // TipoPresupuesto
            // 
            this.TipoPresupuesto.DataPropertyName = "Detalle2";
            this.TipoPresupuesto.HeaderText = "TipoPresupuesto";
            this.TipoPresupuesto.Name = "TipoPresupuesto";
            this.TipoPresupuesto.ReadOnly = true;
            // 
            // Sede
            // 
            this.Sede.DataPropertyName = "Detalle";
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            this.Sede.ReadOnly = true;
            // 
            // UsuarioCreacion
            // 
            this.UsuarioCreacion.DataPropertyName = "UsuarioCreacion";
            this.UsuarioCreacion.HeaderText = "Usuario Creador";
            this.UsuarioCreacion.Name = "UsuarioCreacion";
            this.UsuarioCreacion.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "Fecha Creación";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // EstadoDocumento
            // 
            this.EstadoDocumento.DataPropertyName = "EstadoDocumento";
            this.EstadoDocumento.HeaderText = "Estado";
            this.EstadoDocumento.Name = "EstadoDocumento";
            this.EstadoDocumento.ReadOnly = true;
            // 
            // EstadoBD
            // 
            this.EstadoBD.DataPropertyName = "Estado";
            this.EstadoBD.HeaderText = "EstadoBD";
            this.EstadoBD.Name = "EstadoBD";
            this.EstadoBD.ReadOnly = true;
            this.EstadoBD.Visible = false;
            // 
            // UsuarioAnulacion
            // 
            this.UsuarioAnulacion.DataPropertyName = "UsuarioModificacion";
            this.UsuarioAnulacion.HeaderText = "UsuarioAnulación";
            this.UsuarioAnulacion.Name = "UsuarioAnulacion";
            this.UsuarioAnulacion.ReadOnly = true;
            // 
            // FechaAnulacion
            // 
            this.FechaAnulacion.DataPropertyName = "FechaModificacion";
            this.FechaAnulacion.HeaderText = "FechaAnulación";
            this.FechaAnulacion.Name = "FechaAnulacion";
            this.FechaAnulacion.ReadOnly = true;
            // 
            // ConsulCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1107, 745);
            this.Controls.Add(this.btnCloseReport);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.gBConCom1);
            this.Controls.Add(this.rptConsultaSalida);
            this.Controls.Add(this.rptOdenCompra);
            this.Controls.Add(this.rptPresupuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsulCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Documentos";
            this.Load += new System.EventHandler(this.ConsulCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Documento_ArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentoBindingSource)).EndInit();
            this.gBConCom1.ResumeLayout(false);
            this.gBConCom1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBConCom1;
        private System.Windows.Forms.Label lblConCom2;
        private System.Windows.Forms.Label lblConCom1;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Button btnConCom1;
        private System.Windows.Forms.Button btnCondSal2;
        private Microsoft.Reporting.WinForms.ReportViewer rptPresupuesto;
        private Microsoft.Reporting.WinForms.ReportViewer rptOdenCompra;
        private System.Windows.Forms.TextBox txtTipodoc;
        private System.Windows.Forms.BindingSource Documento_ArticuloBindingSource;
        private System.Windows.Forms.ComboBox cboTipoPre;
        private System.Windows.Forms.TextBox txtNumd;
        private Microsoft.Reporting.WinForms.ReportViewer rptConsultaSalida;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.Button btnCloseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAnulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAnulacion;
        private System.Windows.Forms.BindingSource DocumentoBindingSource;
    }
}