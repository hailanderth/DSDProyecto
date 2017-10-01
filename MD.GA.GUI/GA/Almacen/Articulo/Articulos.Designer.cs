namespace MD.GA.GUI.GA.Almacen
{
    partial class Articulos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chSinStock = new System.Windows.Forms.CheckBox();
            this.chkBajo = new System.Windows.Forms.CheckBox();
            this.chkConsiderar = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArtBuscar = new System.Windows.Forms.Button();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArtNom = new System.Windows.Forms.Label();
            this.BtnArtSal = new System.Windows.Forms.Button();
            this.BtnArtNue = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.LblArt1 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódÁrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripArtículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chSinStock);
            this.groupBox1.Controls.Add(this.chkBajo);
            this.groupBox1.Controls.Add(this.chkConsiderar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnArtBuscar);
            this.groupBox1.Controls.Add(this.cboArea);
            this.groupBox1.Controls.Add(this.lblArtNom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chSinStock
            // 
            this.chSinStock.AutoSize = true;
            this.chSinStock.Checked = true;
            this.chSinStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chSinStock.Location = new System.Drawing.Point(463, 90);
            this.chSinStock.Name = "chSinStock";
            this.chSinStock.Size = new System.Drawing.Size(70, 17);
            this.chSinStock.TabIndex = 5;
            this.chSinStock.Text = "Sin stock";
            this.chSinStock.UseVisualStyleBackColor = true;
            this.chSinStock.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkBajo
            // 
            this.chkBajo.AutoSize = true;
            this.chkBajo.Checked = true;
            this.chkBajo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBajo.Location = new System.Drawing.Point(242, 90);
            this.chkBajo.Name = "chkBajo";
            this.chkBajo.Size = new System.Drawing.Size(97, 17);
            this.chkBajo.TabIndex = 4;
            this.chkBajo.Text = "Con bajo stock";
            this.chkBajo.UseVisualStyleBackColor = true;
            // 
            // chkConsiderar
            // 
            this.chkConsiderar.AutoSize = true;
            this.chkConsiderar.Checked = true;
            this.chkConsiderar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsiderar.Location = new System.Drawing.Point(31, 90);
            this.chkConsiderar.Name = "chkConsiderar";
            this.chkConsiderar.Size = new System.Drawing.Size(88, 17);
            this.chkConsiderar.TabIndex = 3;
            this.chkConsiderar.Text = "A considerar ";
            this.chkConsiderar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(327, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Articulo:";
            // 
            // btnArtBuscar
            // 
            this.btnArtBuscar.Location = new System.Drawing.Point(709, 21);
            this.btnArtBuscar.Name = "btnArtBuscar";
            this.btnArtBuscar.Size = new System.Drawing.Size(149, 37);
            this.btnArtBuscar.TabIndex = 6;
            this.btnArtBuscar.Text = "Buscar";
            this.btnArtBuscar.UseVisualStyleBackColor = true;
            this.btnArtBuscar.Click += new System.EventHandler(this.btnArtBuscar_Click);
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(66, 30);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(165, 21);
            this.cboArea.TabIndex = 1;
            // 
            // lblArtNom
            // 
            this.lblArtNom.AutoSize = true;
            this.lblArtNom.Location = new System.Drawing.Point(28, 33);
            this.lblArtNom.Name = "lblArtNom";
            this.lblArtNom.Size = new System.Drawing.Size(32, 13);
            this.lblArtNom.TabIndex = 0;
            this.lblArtNom.Text = "Área:";
            // 
            // BtnArtSal
            // 
            this.BtnArtSal.Location = new System.Drawing.Point(775, 645);
            this.BtnArtSal.Name = "BtnArtSal";
            this.BtnArtSal.Size = new System.Drawing.Size(101, 36);
            this.BtnArtSal.TabIndex = 2;
            this.BtnArtSal.Text = "Atrás";
            this.BtnArtSal.UseVisualStyleBackColor = true;
            this.BtnArtSal.Click += new System.EventHandler(this.BtnArtbutton6_Click);
            // 
            // BtnArtNue
            // 
            this.BtnArtNue.Location = new System.Drawing.Point(668, 645);
            this.BtnArtNue.Name = "BtnArtNue";
            this.BtnArtNue.Size = new System.Drawing.Size(101, 36);
            this.BtnArtNue.TabIndex = 1;
            this.BtnArtNue.Text = "Nuevo Producto";
            this.BtnArtNue.UseVisualStyleBackColor = true;
            this.BtnArtNue.Click += new System.EventHandler(this.BtnArtbutton1_Click_1);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(64, 625);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 20;
            // 
            // LblArt1
            // 
            this.LblArt1.AutoSize = true;
            this.LblArt1.Location = new System.Drawing.Point(12, 625);
            this.LblArt1.Name = "LblArt1";
            this.LblArt1.Size = new System.Drawing.Size(35, 13);
            this.LblArt1.TabIndex = 19;
            this.LblArt1.Text = "Items:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.IdArticulo,
            this.IdArea,
            this.IdUnidadMedida,
            this.CódÁrea,
            this.Marca,
            this.DescripArtículo,
            this.UnidMedida,
            this.Stock,
            this.moneda,
            this.MonedaMod,
            this.CostoUnid,
            this.CantidadMinima,
            this.Estado,
            this.ModEstado});
            this.dgvArticulos.Location = new System.Drawing.Point(15, 141);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(861, 481);
            this.dgvArticulos.TabIndex = 18;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArticulos_CellFormatting);
            this.dgvArticulos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvArticulos_DataBindingComplete);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::MD.GA.GUI.Properties.Resources.ic_menu_edit;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::MD.GA.GUI.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "Id_Articulo";
            this.IdArticulo.HeaderText = "IdArticulo";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Visible = false;
            // 
            // IdArea
            // 
            this.IdArea.DataPropertyName = "Id_Area";
            this.IdArea.HeaderText = "IdArea";
            this.IdArea.Name = "IdArea";
            this.IdArea.ReadOnly = true;
            this.IdArea.Visible = false;
            // 
            // IdUnidadMedida
            // 
            this.IdUnidadMedida.DataPropertyName = "Id_UnidadMedida";
            this.IdUnidadMedida.HeaderText = "IdUnidadMedida";
            this.IdUnidadMedida.Name = "IdUnidadMedida";
            this.IdUnidadMedida.ReadOnly = true;
            this.IdUnidadMedida.Visible = false;
            // 
            // CódÁrea
            // 
            this.CódÁrea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CódÁrea.DataPropertyName = "CodArea";
            this.CódÁrea.HeaderText = "Cód. área";
            this.CódÁrea.Name = "CódÁrea";
            this.CódÁrea.ReadOnly = true;
            this.CódÁrea.Width = 101;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // DescripArtículo
            // 
            this.DescripArtículo.DataPropertyName = "Descripcion";
            this.DescripArtículo.HeaderText = "Descripción del artículo";
            this.DescripArtículo.Name = "DescripArtículo";
            this.DescripArtículo.ReadOnly = true;
            // 
            // UnidMedida
            // 
            this.UnidMedida.DataPropertyName = "DesUnidadMedida";
            this.UnidMedida.HeaderText = "Unid. Medida";
            this.UnidMedida.Name = "UnidMedida";
            this.UnidMedida.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "Moneda";
            this.moneda.HeaderText = "Moneda";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Visible = false;
            // 
            // MonedaMod
            // 
            this.MonedaMod.HeaderText = "Moneda";
            this.MonedaMod.Name = "MonedaMod";
            this.MonedaMod.ReadOnly = true;
            // 
            // CostoUnid
            // 
            this.CostoUnid.DataPropertyName = "Costo";
            this.CostoUnid.HeaderText = "Costo";
            this.CostoUnid.Name = "CostoUnid";
            this.CostoUnid.ReadOnly = true;
            // 
            // CantidadMinima
            // 
            this.CantidadMinima.DataPropertyName = "CantidadMinima";
            this.CantidadMinima.HeaderText = "Cantidad Minima";
            this.CantidadMinima.Name = "CantidadMinima";
            this.CantidadMinima.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "DataEstado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // ModEstado
            // 
            this.ModEstado.HeaderText = "Estado";
            this.ModEstado.Name = "ModEstado";
            this.ModEstado.ReadOnly = true;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(888, 693);
            this.Controls.Add(this.BtnArtSal);
            this.Controls.Add(this.BtnArtNue);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.LblArt1);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de artículos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArtBuscar;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArtNom;
        private System.Windows.Forms.Button BtnArtSal;
        private System.Windows.Forms.Button BtnArtNue;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label LblArt1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.CheckBox chSinStock;
        private System.Windows.Forms.CheckBox chkBajo;
        private System.Windows.Forms.CheckBox chkConsiderar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódÁrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripArtículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModEstado;
    }
}