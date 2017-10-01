namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.ManArea
{
    partial class CrearArea
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
            this.btnCreArea2 = new System.Windows.Forms.Button();
            this.btnCreArea1 = new System.Windows.Forms.Button();
            this.gBoxCreArea1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCreArea2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.LblCreArea1 = new System.Windows.Forms.Label();
            this.gBoxCreArea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreArea2
            // 
            this.btnCreArea2.Location = new System.Drawing.Point(489, 326);
            this.btnCreArea2.Name = "btnCreArea2";
            this.btnCreArea2.Size = new System.Drawing.Size(89, 36);
            this.btnCreArea2.TabIndex = 1;
            this.btnCreArea2.Text = "Atrás";
            this.btnCreArea2.UseVisualStyleBackColor = true;
            this.btnCreArea2.Click += new System.EventHandler(this.btnCreArea2_Click);
            // 
            // btnCreArea1
            // 
            this.btnCreArea1.Location = new System.Drawing.Point(391, 326);
            this.btnCreArea1.Name = "btnCreArea1";
            this.btnCreArea1.Size = new System.Drawing.Size(89, 36);
            this.btnCreArea1.TabIndex = 0;
            this.btnCreArea1.Text = "Grabar";
            this.btnCreArea1.UseVisualStyleBackColor = true;
            this.btnCreArea1.Click += new System.EventHandler(this.btnCreArea1_Click);
            // 
            // gBoxCreArea1
            // 
            this.gBoxCreArea1.Controls.Add(this.txtNombre);
            this.gBoxCreArea1.Controls.Add(this.lblCreArea2);
            this.gBoxCreArea1.Controls.Add(this.txtCod);
            this.gBoxCreArea1.Controls.Add(this.LblCreArea1);
            this.gBoxCreArea1.Location = new System.Drawing.Point(13, 12);
            this.gBoxCreArea1.Name = "gBoxCreArea1";
            this.gBoxCreArea1.Size = new System.Drawing.Size(575, 290);
            this.gBoxCreArea1.TabIndex = 22;
            this.gBoxCreArea1.TabStop = false;
            this.gBoxCreArea1.Text = "Datos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCreArea2
            // 
            this.lblCreArea2.AutoSize = true;
            this.lblCreArea2.Location = new System.Drawing.Point(23, 129);
            this.lblCreArea2.Name = "lblCreArea2";
            this.lblCreArea2.Size = new System.Drawing.Size(32, 13);
            this.lblCreArea2.TabIndex = 20;
            this.lblCreArea2.Text = "Área:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(168, 82);
            this.txtCod.MaxLength = 10;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(184, 20);
            this.txtCod.TabIndex = 0;
            // 
            // LblCreArea1
            // 
            this.LblCreArea1.AutoSize = true;
            this.LblCreArea1.Location = new System.Drawing.Point(23, 82);
            this.LblCreArea1.Name = "LblCreArea1";
            this.LblCreArea1.Size = new System.Drawing.Size(56, 13);
            this.LblCreArea1.TabIndex = 18;
            this.LblCreArea1.Text = "Cód. área:";
            // 
            // CrearArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnCreArea2);
            this.Controls.Add(this.btnCreArea1);
            this.Controls.Add(this.gBoxCreArea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrearArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear área";
            this.Load += new System.EventHandler(this.CrearArea_Load);
            this.gBoxCreArea1.ResumeLayout(false);
            this.gBoxCreArea1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreArea2;
        private System.Windows.Forms.Button btnCreArea1;
        private System.Windows.Forms.GroupBox gBoxCreArea1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCreArea2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label LblCreArea1;
    }
}