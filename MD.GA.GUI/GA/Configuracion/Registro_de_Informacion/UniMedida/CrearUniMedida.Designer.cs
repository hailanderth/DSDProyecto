namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.UniMedida
{
    partial class CrearUniMedida
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
            this.btnCreUMed2 = new System.Windows.Forms.Button();
            this.btnCreUMed1 = new System.Windows.Forms.Button();
            this.gBoxCreUMed1 = new System.Windows.Forms.GroupBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.LblCreUMed1 = new System.Windows.Forms.Label();
            this.gBoxCreUMed1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreUMed2
            // 
            this.btnCreUMed2.Location = new System.Drawing.Point(489, 326);
            this.btnCreUMed2.Name = "btnCreUMed2";
            this.btnCreUMed2.Size = new System.Drawing.Size(89, 36);
            this.btnCreUMed2.TabIndex = 2;
            this.btnCreUMed2.Text = "Atrás";
            this.btnCreUMed2.UseVisualStyleBackColor = true;
            this.btnCreUMed2.Click += new System.EventHandler(this.btnCreUMed2_Click);
            // 
            // btnCreUMed1
            // 
            this.btnCreUMed1.Location = new System.Drawing.Point(391, 326);
            this.btnCreUMed1.Name = "btnCreUMed1";
            this.btnCreUMed1.Size = new System.Drawing.Size(89, 36);
            this.btnCreUMed1.TabIndex = 1;
            this.btnCreUMed1.Text = "Grabar";
            this.btnCreUMed1.UseVisualStyleBackColor = true;
            this.btnCreUMed1.Click += new System.EventHandler(this.btnCreUMed1_Click);
            // 
            // gBoxCreUMed1
            // 
            this.gBoxCreUMed1.Controls.Add(this.txtUnidadMedida);
            this.gBoxCreUMed1.Controls.Add(this.LblCreUMed1);
            this.gBoxCreUMed1.Location = new System.Drawing.Point(13, 12);
            this.gBoxCreUMed1.Name = "gBoxCreUMed1";
            this.gBoxCreUMed1.Size = new System.Drawing.Size(575, 290);
            this.gBoxCreUMed1.TabIndex = 0;
            this.gBoxCreUMed1.TabStop = false;
            this.gBoxCreUMed1.Text = "Datos";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(168, 82);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(184, 20);
            this.txtUnidadMedida.TabIndex = 0;
            // 
            // LblCreUMed1
            // 
            this.LblCreUMed1.AutoSize = true;
            this.LblCreUMed1.Location = new System.Drawing.Point(23, 82);
            this.LblCreUMed1.Name = "LblCreUMed1";
            this.LblCreUMed1.Size = new System.Drawing.Size(73, 13);
            this.LblCreUMed1.TabIndex = 18;
            this.LblCreUMed1.Text = "Unid. Medida:";
            // 
            // CrearUniMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnCreUMed2);
            this.Controls.Add(this.btnCreUMed1);
            this.Controls.Add(this.gBoxCreUMed1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrearUniMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear unidad de medida";
            this.Load += new System.EventHandler(this.CrearUniMedida_Load);
            this.gBoxCreUMed1.ResumeLayout(false);
            this.gBoxCreUMed1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreUMed2;
        private System.Windows.Forms.Button btnCreUMed1;
        private System.Windows.Forms.GroupBox gBoxCreUMed1;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label LblCreUMed1;
    }
}