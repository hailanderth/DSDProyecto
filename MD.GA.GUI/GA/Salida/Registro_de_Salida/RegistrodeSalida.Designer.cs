namespace MD.GA.GUI.GA.Salida.Registro_de_Salida
{
    partial class RegistrodeSalida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegdSal1 = new System.Windows.Forms.Label();
            this.lblRegdSal2 = new System.Windows.Forms.Label();
            this.lblRegdSal3 = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.dtpFechaEstIngI = new System.Windows.Forms.DateTimePicker();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.lblRegdSal6 = new System.Windows.Forms.Label();
            this.lblRegdSal7 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CodArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegdSal1
            // 
            this.lblRegdSal1.AutoSize = true;
            this.lblRegdSal1.Location = new System.Drawing.Point(12, 12);
            this.lblRegdSal1.Name = "lblRegdSal1";
            this.lblRegdSal1.Size = new System.Drawing.Size(84, 13);
            this.lblRegdSal1.TabIndex = 0;
            this.lblRegdSal1.Text = "Sede destinada:";
            // 
            // lblRegdSal2
            // 
            this.lblRegdSal2.AutoSize = true;
            this.lblRegdSal2.Location = new System.Drawing.Point(12, 48);
            this.lblRegdSal2.Name = "lblRegdSal2";
            this.lblRegdSal2.Size = new System.Drawing.Size(67, 13);
            this.lblRegdSal2.TabIndex = 1;
            this.lblRegdSal2.Text = "Nº de salida:";
            // 
            // lblRegdSal3
            // 
            this.lblRegdSal3.AutoSize = true;
            this.lblRegdSal3.Location = new System.Drawing.Point(12, 78);
            this.lblRegdSal3.Name = "lblRegdSal3";
            this.lblRegdSal3.Size = new System.Drawing.Size(116, 13);
            this.lblRegdSal3.TabIndex = 2;
            this.lblRegdSal3.Text = "Encargado de entrega:";
            // 
            // cboSede
            // 
            this.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(144, 9);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(121, 21);
            this.cboSede.TabIndex = 4;
            // 
            // dtpFechaEstIngI
            // 
            this.dtpFechaEstIngI.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaEstIngI.Enabled = false;
            this.dtpFechaEstIngI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEstIngI.Location = new System.Drawing.Point(486, 12);
            this.dtpFechaEstIngI.Name = "dtpFechaEstIngI";
            this.dtpFechaEstIngI.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaEstIngI.TabIndex = 17;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(419, 372);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(101, 36);
            this.btnGrabar.TabIndex = 31;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnRegdSal1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(526, 372);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 36);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnRegdSal2_Click);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(141, 48);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroDocumento.TabIndex = 32;
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.Location = new System.Drawing.Point(141, 78);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioActual.TabIndex = 33;
            // 
            // lblRegdSal6
            // 
            this.lblRegdSal6.AutoSize = true;
            this.lblRegdSal6.Location = new System.Drawing.Point(407, 12);
            this.lblRegdSal6.Name = "lblRegdSal6";
            this.lblRegdSal6.Size = new System.Drawing.Size(40, 13);
            this.lblRegdSal6.TabIndex = 34;
            this.lblRegdSal6.Text = "Fecha:";
            // 
            // lblRegdSal7
            // 
            this.lblRegdSal7.AutoSize = true;
            this.lblRegdSal7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegdSal7.Location = new System.Drawing.Point(12, 328);
            this.lblRegdSal7.Name = "lblRegdSal7";
            this.lblRegdSal7.Size = new System.Drawing.Size(48, 18);
            this.lblRegdSal7.TabIndex = 35;
            this.lblRegdSal7.Text = "Items:";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(81, 328);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(17, 18);
            this.lblTotalItems.TabIndex = 36;
            this.lblTotalItems.Text = "0";
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToAddRows = false;
            this.dgvSalida.AllowUserToDeleteRows = false;
            this.dgvSalida.AllowUserToResizeRows = false;
            this.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalida.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodArea,
            this.Descripcion,
            this.UnidadMedida,
            this.Cantidad});
            this.dgvSalida.Location = new System.Drawing.Point(12, 106);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.RowHeadersVisible = false;
            this.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalida.Size = new System.Drawing.Size(612, 211);
            this.dgvSalida.TabIndex = 38;
            this.dgvSalida.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSalida_DataError);
            this.dgvSalida.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MD.GA.GUI.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(640, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MD.GA.GUI.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(640, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CodArea
            // 
            this.CodArea.HeaderText = "CodArea";
            this.CodArea.Name = "CodArea";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // UnidadMedida
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.UnidadMedida.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnidadMedida.HeaderText = "UnidadMedida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 8;
            this.Cantidad.Name = "Cantidad";
            // 
            // RegistrodeSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 424);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.lblRegdSal7);
            this.Controls.Add(this.lblRegdSal6);
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpFechaEstIngI);
            this.Controls.Add(this.cboSede);
            this.Controls.Add(this.lblRegdSal3);
            this.Controls.Add(this.lblRegdSal2);
            this.Controls.Add(this.lblRegdSal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrodeSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrodeSalida";
            this.Load += new System.EventHandler(this.RegistrodeSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegdSal1;
        private System.Windows.Forms.Label lblRegdSal2;
        private System.Windows.Forms.Label lblRegdSal3;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.DateTimePicker dtpFechaEstIngI;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.Label lblRegdSal6;
        private System.Windows.Forms.Label lblRegdSal7;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn CodArea;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}