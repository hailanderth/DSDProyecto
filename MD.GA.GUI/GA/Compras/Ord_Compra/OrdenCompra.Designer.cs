namespace MD.GA.GUI.GA.Compras.Ord_Compra
{
    partial class OrdenCompra
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEstIngI = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblOrdenCompra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbContado = new System.Windows.Forms.RadioButton();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoDisponible = new System.Windows.Forms.TextBox();
            this.RazonSocial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CodArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Proveedor,
            this.Banco,
            this.Cuenta,
            this.Descripcion,
            this.UnidadMedida,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.dgvArticulos.Location = new System.Drawing.Point(12, 161);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(931, 390);
            this.dgvArticulos.TabIndex = 29;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvArticulos_DataError);
            this.dgvArticulos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvArticulos_EditingControlShowing);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha y Hora:";
            // 
            // dtpFechaEstIngI
            // 
            this.dtpFechaEstIngI.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaEstIngI.Enabled = false;
            this.dtpFechaEstIngI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEstIngI.Location = new System.Drawing.Point(800, 18);
            this.dtpFechaEstIngI.Name = "dtpFechaEstIngI";
            this.dtpFechaEstIngI.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaEstIngI.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(883, 632);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 36);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(776, 632);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(101, 36);
            this.btnGrabar.TabIndex = 35;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.AutoSize = true;
            this.lblOrdenCompra.Location = new System.Drawing.Point(119, 18);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(0, 13);
            this.lblOrdenCompra.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Nro Orden:";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Location = new System.Drawing.Point(119, 60);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(0, 13);
            this.lblPresupuesto.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nro Presupuesto:";
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(260, 94);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(58, 17);
            this.rbCredito.TabIndex = 42;
            this.rbCredito.Text = "Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Checked = true;
            this.rbContado.Location = new System.Drawing.Point(122, 94);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(65, 17);
            this.rbContado.TabIndex = 41;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "Contado";
            this.rbContado.UseVisualStyleBackColor = true;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(119, 131);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(0, 13);
            this.lblMoneda.TabIndex = 43;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MD.GA.GUI.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(949, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MD.GA.GUI.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(949, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(785, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Monto Total:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(924, 564);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(17, 18);
            this.lblMonto.TabIndex = 49;
            this.lblMonto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Items:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(85, 564);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(17, 18);
            this.lblItems.TabIndex = 51;
            this.lblItems.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Forma de pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Moneda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Monto disponible";
            // 
            // txtMontoDisponible
            // 
            this.txtMontoDisponible.Location = new System.Drawing.Point(800, 88);
            this.txtMontoDisponible.Name = "txtMontoDisponible";
            this.txtMontoDisponible.Size = new System.Drawing.Size(141, 20);
            this.txtMontoDisponible.TabIndex = 57;
            this.txtMontoDisponible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoDisponible_KeyPress);
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
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "RazonSocialProveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DescripcionArticulo";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(996, 680);
            this.Controls.Add(this.txtMontoDisponible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.rbContado);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrdenCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaEstIngI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenCompra";
            this.Load += new System.EventHandler(this.OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaEstIngI;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblOrdenCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbContado;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoDisponible;
        private System.Windows.Forms.DataGridViewComboBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewComboBoxColumn CodArea;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}