namespace MD.GA.GUI.GA.Configuracion.Usuarios
{
    partial class CrearUsuario
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.gBoxCreUsu1 = new System.Windows.Forms.GroupBox();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.lblCreUsu5 = new System.Windows.Forms.Label();
            this.lblCreUsu4 = new System.Windows.Forms.Label();
            this.lblCreUsu3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCreUsu2 = new System.Windows.Forms.Label();
            this.LblCreUsu1 = new System.Windows.Forms.Label();
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.gBoxCreUsu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(489, 326);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(89, 36);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnCreUsu2_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(391, 326);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 36);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // gBoxCreUsu1
            // 
            this.gBoxCreUsu1.Controls.Add(this.btnMostrarPass);
            this.gBoxCreUsu1.Controls.Add(this.txtContraseña2);
            this.gBoxCreUsu1.Controls.Add(this.label1);
            this.gBoxCreUsu1.Controls.Add(this.cboPuesto);
            this.gBoxCreUsu1.Controls.Add(this.lblCreUsu5);
            this.gBoxCreUsu1.Controls.Add(this.lblCreUsu4);
            this.gBoxCreUsu1.Controls.Add(this.lblCreUsu3);
            this.gBoxCreUsu1.Controls.Add(this.txtContraseña);
            this.gBoxCreUsu1.Controls.Add(this.txtUsuario);
            this.gBoxCreUsu1.Controls.Add(this.txtApellidos);
            this.gBoxCreUsu1.Controls.Add(this.txtNombre);
            this.gBoxCreUsu1.Controls.Add(this.lblCreUsu2);
            this.gBoxCreUsu1.Controls.Add(this.LblCreUsu1);
            this.gBoxCreUsu1.Location = new System.Drawing.Point(13, 12);
            this.gBoxCreUsu1.Name = "gBoxCreUsu1";
            this.gBoxCreUsu1.Size = new System.Drawing.Size(575, 290);
            this.gBoxCreUsu1.TabIndex = 0;
            this.gBoxCreUsu1.TabStop = false;
            this.gBoxCreUsu1.Text = "Datos";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(168, 258);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(184, 20);
            this.txtContraseña2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Repetir contraseña:";
            // 
            // cboPuesto
            // 
            this.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(168, 55);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(184, 21);
            this.cboPuesto.TabIndex = 0;
            // 
            // lblCreUsu5
            // 
            this.lblCreUsu5.AutoSize = true;
            this.lblCreUsu5.Location = new System.Drawing.Point(26, 217);
            this.lblCreUsu5.Name = "lblCreUsu5";
            this.lblCreUsu5.Size = new System.Drawing.Size(64, 13);
            this.lblCreUsu5.TabIndex = 27;
            this.lblCreUsu5.Text = "Contraseña:";
            // 
            // lblCreUsu4
            // 
            this.lblCreUsu4.AutoSize = true;
            this.lblCreUsu4.Location = new System.Drawing.Point(26, 180);
            this.lblCreUsu4.Name = "lblCreUsu4";
            this.lblCreUsu4.Size = new System.Drawing.Size(46, 13);
            this.lblCreUsu4.TabIndex = 26;
            this.lblCreUsu4.Text = "Usuario:";
            // 
            // lblCreUsu3
            // 
            this.lblCreUsu3.AutoSize = true;
            this.lblCreUsu3.Location = new System.Drawing.Point(26, 138);
            this.lblCreUsu3.Name = "lblCreUsu3";
            this.lblCreUsu3.Size = new System.Drawing.Size(52, 13);
            this.lblCreUsu3.TabIndex = 25;
            this.lblCreUsu3.Text = "Apellidos:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(168, 217);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(184, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(168, 180);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(168, 138);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(184, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCreUsu2
            // 
            this.lblCreUsu2.AutoSize = true;
            this.lblCreUsu2.Location = new System.Drawing.Point(23, 98);
            this.lblCreUsu2.Name = "lblCreUsu2";
            this.lblCreUsu2.Size = new System.Drawing.Size(52, 13);
            this.lblCreUsu2.TabIndex = 20;
            this.lblCreUsu2.Text = "Nombres:";
            // 
            // LblCreUsu1
            // 
            this.LblCreUsu1.AutoSize = true;
            this.LblCreUsu1.Location = new System.Drawing.Point(23, 58);
            this.LblCreUsu1.Name = "LblCreUsu1";
            this.LblCreUsu1.Size = new System.Drawing.Size(43, 13);
            this.LblCreUsu1.TabIndex = 18;
            this.LblCreUsu1.Text = "Puesto:";
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.Location = new System.Drawing.Point(459, 217);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(93, 38);
            this.btnMostrarPass.TabIndex = 30;
            this.btnMostrarPass.Text = "Motrar Caracteres";
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gBoxCreUsu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.gBoxCreUsu1.ResumeLayout(false);
            this.gBoxCreUsu1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox gBoxCreUsu1;
        private System.Windows.Forms.Label lblCreUsu5;
        private System.Windows.Forms.Label lblCreUsu4;
        private System.Windows.Forms.Label lblCreUsu3;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCreUsu2;
        private System.Windows.Forms.Label LblCreUsu1;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarPass;
    }
}