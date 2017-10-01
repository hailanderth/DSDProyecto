namespace MD.GA.GUI.GA.Configuracion.Usuarios
{
    partial class Usuarios
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
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomUsus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(728, 543);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 36);
            this.button14.TabIndex = 34;
            this.button14.Text = "Salir";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(621, 543);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(101, 36);
            this.button15.TabIndex = 33;
            this.button15.Text = "Nuevo";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Usuario,
            this.dataGridViewImageColumn9,
            this.dataGridViewImageColumn10,
            this.nomUsus,
            this.apeUsu,
            this.nomUsu,
            this.puesUsu,
            this.Puesto,
            this.EstadoEntidad,
            this.Estado});
            this.dgvUsuario.Location = new System.Drawing.Point(12, 130);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(813, 407);
            this.dgvUsuario.TabIndex = 32;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.DataPropertyName = "Id_Usuario";
            this.Id_Usuario.HeaderText = "Column1";
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            this.Id_Usuario.Visible = false;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.HeaderText = "Editar";
            this.dataGridViewImageColumn9.Image = global::MD.GA.GUI.Properties.Resources.ic_menu_edit;
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.ReadOnly = true;
            // 
            // dataGridViewImageColumn10
            // 
            this.dataGridViewImageColumn10.HeaderText = "Eliminar";
            this.dataGridViewImageColumn10.Image = global::MD.GA.GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn10.Name = "dataGridViewImageColumn10";
            this.dataGridViewImageColumn10.ReadOnly = true;
            // 
            // nomUsus
            // 
            this.nomUsus.DataPropertyName = "Nombres";
            this.nomUsus.HeaderText = "Nombre";
            this.nomUsus.Name = "nomUsus";
            this.nomUsus.ReadOnly = true;
            // 
            // apeUsu
            // 
            this.apeUsu.DataPropertyName = "Apellidos";
            this.apeUsu.HeaderText = "Apellidos";
            this.apeUsu.Name = "apeUsu";
            this.apeUsu.ReadOnly = true;
            // 
            // nomUsu
            // 
            this.nomUsu.DataPropertyName = "Usuario1";
            this.nomUsu.HeaderText = "Usuario";
            this.nomUsu.Name = "nomUsu";
            this.nomUsu.ReadOnly = true;
            // 
            // puesUsu
            // 
            this.puesUsu.DataPropertyName = "Id_Puesto";
            this.puesUsu.HeaderText = "Puesto";
            this.puesUsu.Name = "puesUsu";
            this.puesUsu.ReadOnly = true;
            this.puesUsu.Visible = false;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // EstadoEntidad
            // 
            this.EstadoEntidad.DataPropertyName = "Estado";
            this.EstadoEntidad.HeaderText = "Estado";
            this.EstadoEntidad.Name = "EstadoEntidad";
            this.EstadoEntidad.ReadOnly = true;
            this.EstadoEntidad.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBuscar);
            this.groupBox6.Controls.Add(this.cboUsuario);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(813, 112);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(164, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(192, 47);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(279, 21);
            this.cboUsuario.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuarios:";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos de usuario";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsus;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}