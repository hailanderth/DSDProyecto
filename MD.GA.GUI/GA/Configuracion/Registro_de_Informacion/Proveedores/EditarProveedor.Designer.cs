namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Proveedores
{
    partial class EditarProveedor
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gBoxEdiPro1 = new System.Windows.Forms.GroupBox();
            this.lblEdiPro5 = new System.Windows.Forms.Label();
            this.lblEdiPro4 = new System.Windows.Forms.Label();
            this.lblEdiPro3 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lblEdiPro2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblEdiPro1 = new System.Windows.Forms.Label();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxEdiPro1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(499, 391);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(89, 36);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(401, 391);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 36);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.txtEditar_Click);
            // 
            // gBoxEdiPro1
            // 
            this.gBoxEdiPro1.Controls.Add(this.cboTipoCuenta);
            this.gBoxEdiPro1.Controls.Add(this.cboBanco);
            this.gBoxEdiPro1.Controls.Add(this.label3);
            this.gBoxEdiPro1.Controls.Add(this.txtNumeroCuenta);
            this.gBoxEdiPro1.Controls.Add(this.label1);
            this.gBoxEdiPro1.Controls.Add(this.label2);
            this.gBoxEdiPro1.Controls.Add(this.lblEdiPro5);
            this.gBoxEdiPro1.Controls.Add(this.lblEdiPro4);
            this.gBoxEdiPro1.Controls.Add(this.lblEdiPro3);
            this.gBoxEdiPro1.Controls.Add(this.txtContacto);
            this.gBoxEdiPro1.Controls.Add(this.txtTelefono);
            this.gBoxEdiPro1.Controls.Add(this.txtDireccion);
            this.gBoxEdiPro1.Controls.Add(this.txtRuc);
            this.gBoxEdiPro1.Controls.Add(this.lblEdiPro2);
            this.gBoxEdiPro1.Controls.Add(this.txtRazonSocial);
            this.gBoxEdiPro1.Controls.Add(this.LblEdiPro1);
            this.gBoxEdiPro1.Location = new System.Drawing.Point(13, 12);
            this.gBoxEdiPro1.Name = "gBoxEdiPro1";
            this.gBoxEdiPro1.Size = new System.Drawing.Size(575, 373);
            this.gBoxEdiPro1.TabIndex = 0;
            this.gBoxEdiPro1.TabStop = false;
            this.gBoxEdiPro1.Text = "Datos";
            // 
            // lblEdiPro5
            // 
            this.lblEdiPro5.AutoSize = true;
            this.lblEdiPro5.Location = new System.Drawing.Point(23, 215);
            this.lblEdiPro5.Name = "lblEdiPro5";
            this.lblEdiPro5.Size = new System.Drawing.Size(53, 13);
            this.lblEdiPro5.TabIndex = 27;
            this.lblEdiPro5.Text = "Contacto:";
            // 
            // lblEdiPro4
            // 
            this.lblEdiPro4.AutoSize = true;
            this.lblEdiPro4.Location = new System.Drawing.Point(23, 179);
            this.lblEdiPro4.Name = "lblEdiPro4";
            this.lblEdiPro4.Size = new System.Drawing.Size(52, 13);
            this.lblEdiPro4.TabIndex = 26;
            this.lblEdiPro4.Text = "Teléfono:";
            // 
            // lblEdiPro3
            // 
            this.lblEdiPro3.AutoSize = true;
            this.lblEdiPro3.Location = new System.Drawing.Point(23, 142);
            this.lblEdiPro3.Name = "lblEdiPro3";
            this.lblEdiPro3.Size = new System.Drawing.Size(55, 13);
            this.lblEdiPro3.TabIndex = 25;
            this.lblEdiPro3.Text = "Dirección:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(168, 215);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(184, 20);
            this.txtContacto.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(168, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(168, 142);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(184, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(168, 105);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(184, 20);
            this.txtRuc.TabIndex = 2;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            // 
            // lblEdiPro2
            // 
            this.lblEdiPro2.AutoSize = true;
            this.lblEdiPro2.Location = new System.Drawing.Point(23, 105);
            this.lblEdiPro2.Name = "lblEdiPro2";
            this.lblEdiPro2.Size = new System.Drawing.Size(33, 13);
            this.lblEdiPro2.TabIndex = 20;
            this.lblEdiPro2.Text = "RUC:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(168, 68);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(184, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // LblEdiPro1
            // 
            this.LblEdiPro1.AutoSize = true;
            this.LblEdiPro1.Location = new System.Drawing.Point(23, 68);
            this.LblEdiPro1.Name = "LblEdiPro1";
            this.LblEdiPro1.Size = new System.Drawing.Size(73, 13);
            this.LblEdiPro1.TabIndex = 18;
            this.LblEdiPro1.Text = "Razón Social:";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Items.AddRange(new object[] {
            "[--Seleccione--]",
            "Soles",
            "Dolares"});
            this.cboTipoCuenta.Location = new System.Drawing.Point(168, 283);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(184, 21);
            this.cboTipoCuenta.TabIndex = 41;
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(168, 250);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(184, 21);
            this.cboBanco.TabIndex = 40;
            this.cboBanco.SelectionChangeCommitted += new System.EventHandler(this.cboBanco_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Numero cuenta:";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(168, 322);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(184, 20);
            this.txtNumeroCuenta.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Banco:";
            // 
            // EditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 444);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gBoxEdiPro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar proveedor";
            this.Load += new System.EventHandler(this.EditarProveedor_Load);
            this.gBoxEdiPro1.ResumeLayout(false);
            this.gBoxEdiPro1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gBoxEdiPro1;
        private System.Windows.Forms.Label lblEdiPro5;
        private System.Windows.Forms.Label lblEdiPro4;
        private System.Windows.Forms.Label lblEdiPro3;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lblEdiPro2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label LblEdiPro1;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}