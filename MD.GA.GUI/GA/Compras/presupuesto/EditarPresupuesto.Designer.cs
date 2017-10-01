namespace MD.GA.GUI.GA.Compras.presupuesto
{
    partial class EditarPresupuesto
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
            this.lblMonto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDolares = new System.Windows.Forms.RadioButton();
            this.rbSoles = new System.Windows.Forms.RadioButton();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEstIngI = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.RazonSocial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CodArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(799, 552);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(17, 18);
            this.lblMonto.TabIndex = 85;
            this.lblMonto.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Monto Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Moneda:";
            // 
            // rbDolares
            // 
            this.rbDolares.AutoSize = true;
            this.rbDolares.Location = new System.Drawing.Point(229, 91);
            this.rbDolares.Name = "rbDolares";
            this.rbDolares.Size = new System.Drawing.Size(61, 17);
            this.rbDolares.TabIndex = 80;
            this.rbDolares.Text = "Dólares";
            this.rbDolares.UseVisualStyleBackColor = true;
            this.rbDolares.CheckedChanged += new System.EventHandler(this.rbDolares_CheckedChanged);
            this.rbDolares.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbDolares_MouseClick);
            // 
            // rbSoles
            // 
            this.rbSoles.AutoSize = true;
            this.rbSoles.Checked = true;
            this.rbSoles.Location = new System.Drawing.Point(91, 91);
            this.rbSoles.Name = "rbSoles";
            this.rbSoles.Size = new System.Drawing.Size(51, 17);
            this.rbSoles.TabIndex = 79;
            this.rbSoles.TabStop = true;
            this.rbSoles.Text = "Soles";
            this.rbSoles.UseVisualStyleBackColor = true;
            this.rbSoles.CheckedChanged += new System.EventHandler(this.rbSoles_CheckedChanged);
            this.rbSoles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSoles_MouseClick);
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Location = new System.Drawing.Point(118, 24);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(0, 13);
            this.lblPresupuesto.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nro Presupuesto:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonSocial,
            this.CodArea,
            this.Descripcion,
            this.Proveedor,
            this.Banco,
            this.NumCuenta,
            this.UnidadMedida,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.dgvArticulos.Location = new System.Drawing.Point(11, 158);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(837, 390);
            this.dgvArticulos.TabIndex = 76;
            this.dgvArticulos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvArticulos_DataError);
            this.dgvArticulos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvArticulos_EditingControlShowing);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha y Hora:";
            // 
            // dtpFechaEstIngI
            // 
            this.dtpFechaEstIngI.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaEstIngI.Enabled = false;
            this.dtpFechaEstIngI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEstIngI.Location = new System.Drawing.Point(707, 18);
            this.dtpFechaEstIngI.Name = "dtpFechaEstIngI";
            this.dtpFechaEstIngI.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaEstIngI.TabIndex = 74;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MD.GA.GUI.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(895, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MD.GA.GUI.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(895, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(91, 578);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(17, 18);
            this.lblItems.TabIndex = 87;
            this.lblItems.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 86;
            this.label5.Text = "Items:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(747, 606);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(101, 36);
            this.btnGrabar.TabIndex = 89;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(854, 606);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 36);
            this.btnSalir.TabIndex = 88;
            this.btnSalir.Text = "Atrás";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(758, 552);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(0, 18);
            this.lblMoneda.TabIndex = 90;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial";
            this.RazonSocial.HeaderText = "R. Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RazonSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CodArea
            // 
            this.CodArea.DataPropertyName = "CodArea";
            this.CodArea.HeaderText = "Cód. área";
            this.CodArea.Name = "CodArea";
            this.CodArea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DescripcionArticulo";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // NumCuenta
            // 
            this.NumCuenta.HeaderText = "NumCuenta";
            this.NumCuenta.Name = "NumCuenta";
            this.NumCuenta.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "Unid. Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioUnitario";
            this.Precio.HeaderText = "P. Unitario";
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // EditarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(968, 654);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbDolares);
            this.Controls.Add(this.rbSoles);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaEstIngI);
            this.MaximizeBox = false;
            this.Name = "EditarPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPresupuesto";
            this.Load += new System.EventHandler(this.EditarPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDolares;
        private System.Windows.Forms.RadioButton rbSoles;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaEstIngI;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.DataGridViewComboBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewComboBoxColumn CodArea;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}