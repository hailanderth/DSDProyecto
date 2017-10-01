namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.ManArea
{
    partial class EditarArea
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
            this.gBoxEdiArea1 = new System.Windows.Forms.GroupBox();
            this.txtNombreArea = new System.Windows.Forms.TextBox();
            this.lblEdiArea2 = new System.Windows.Forms.Label();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.LblEdiArea1 = new System.Windows.Forms.Label();
            this.gBoxEdiArea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(489, 326);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(89, 36);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(391, 326);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 36);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // gBoxEdiArea1
            // 
            this.gBoxEdiArea1.Controls.Add(this.txtNombreArea);
            this.gBoxEdiArea1.Controls.Add(this.lblEdiArea2);
            this.gBoxEdiArea1.Controls.Add(this.txtCodArea);
            this.gBoxEdiArea1.Controls.Add(this.LblEdiArea1);
            this.gBoxEdiArea1.Location = new System.Drawing.Point(13, 12);
            this.gBoxEdiArea1.Name = "gBoxEdiArea1";
            this.gBoxEdiArea1.Size = new System.Drawing.Size(575, 290);
            this.gBoxEdiArea1.TabIndex = 25;
            this.gBoxEdiArea1.TabStop = false;
            this.gBoxEdiArea1.Text = "Datos";
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Location = new System.Drawing.Point(168, 129);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(184, 20);
            this.txtNombreArea.TabIndex = 1;
            // 
            // lblEdiArea2
            // 
            this.lblEdiArea2.AutoSize = true;
            this.lblEdiArea2.Location = new System.Drawing.Point(23, 129);
            this.lblEdiArea2.Name = "lblEdiArea2";
            this.lblEdiArea2.Size = new System.Drawing.Size(32, 13);
            this.lblEdiArea2.TabIndex = 20;
            this.lblEdiArea2.Text = "Área:";
            // 
            // txtCodArea
            // 
            this.txtCodArea.Location = new System.Drawing.Point(168, 82);
            this.txtCodArea.MaxLength = 10;
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.Size = new System.Drawing.Size(184, 20);
            this.txtCodArea.TabIndex = 0;
            // 
            // LblEdiArea1
            // 
            this.LblEdiArea1.AutoSize = true;
            this.LblEdiArea1.Location = new System.Drawing.Point(23, 89);
            this.LblEdiArea1.Name = "LblEdiArea1";
            this.LblEdiArea1.Size = new System.Drawing.Size(56, 13);
            this.LblEdiArea1.TabIndex = 18;
            this.LblEdiArea1.Text = "Cód. área:";
            // 
            // EditarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gBoxEdiArea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar área";
            this.Load += new System.EventHandler(this.EditarArea_Load);
            this.gBoxEdiArea1.ResumeLayout(false);
            this.gBoxEdiArea1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox gBoxEdiArea1;
        private System.Windows.Forms.TextBox txtNombreArea;
        private System.Windows.Forms.Label lblEdiArea2;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.Label LblEdiArea1;
    }
}