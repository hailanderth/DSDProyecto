namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.UniMedida
{
    partial class EditarUniMedida
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
            this.btnEdiUMed2 = new System.Windows.Forms.Button();
            this.btnEdiUMed1 = new System.Windows.Forms.Button();
            this.gBoxEdiUMed1 = new System.Windows.Forms.GroupBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.LblEdiUMed1 = new System.Windows.Forms.Label();
            this.gBoxEdiUMed1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdiUMed2
            // 
            this.btnEdiUMed2.Location = new System.Drawing.Point(489, 326);
            this.btnEdiUMed2.Name = "btnEdiUMed2";
            this.btnEdiUMed2.Size = new System.Drawing.Size(89, 36);
            this.btnEdiUMed2.TabIndex = 1;
            this.btnEdiUMed2.Text = "Atrás";
            this.btnEdiUMed2.UseVisualStyleBackColor = true;
            this.btnEdiUMed2.Click += new System.EventHandler(this.btnEdiUMed2_Click);
            // 
            // btnEdiUMed1
            // 
            this.btnEdiUMed1.Location = new System.Drawing.Point(391, 326);
            this.btnEdiUMed1.Name = "btnEdiUMed1";
            this.btnEdiUMed1.Size = new System.Drawing.Size(89, 36);
            this.btnEdiUMed1.TabIndex = 0;
            this.btnEdiUMed1.Text = "Grabar";
            this.btnEdiUMed1.UseVisualStyleBackColor = true;
            this.btnEdiUMed1.Click += new System.EventHandler(this.btnEdiUMed1_Click);
            // 
            // gBoxEdiUMed1
            // 
            this.gBoxEdiUMed1.Controls.Add(this.txtUnidadMedida);
            this.gBoxEdiUMed1.Controls.Add(this.LblEdiUMed1);
            this.gBoxEdiUMed1.Location = new System.Drawing.Point(13, 12);
            this.gBoxEdiUMed1.Name = "gBoxEdiUMed1";
            this.gBoxEdiUMed1.Size = new System.Drawing.Size(575, 290);
            this.gBoxEdiUMed1.TabIndex = 28;
            this.gBoxEdiUMed1.TabStop = false;
            this.gBoxEdiUMed1.Text = "Datos";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(168, 82);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(184, 20);
            this.txtUnidadMedida.TabIndex = 0;
            // 
            // LblEdiUMed1
            // 
            this.LblEdiUMed1.AutoSize = true;
            this.LblEdiUMed1.Location = new System.Drawing.Point(23, 82);
            this.LblEdiUMed1.Name = "LblEdiUMed1";
            this.LblEdiUMed1.Size = new System.Drawing.Size(73, 13);
            this.LblEdiUMed1.TabIndex = 18;
            this.LblEdiUMed1.Text = "Unid. Medida:";
            // 
            // EditarUniMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnEdiUMed2);
            this.Controls.Add(this.btnEdiUMed1);
            this.Controls.Add(this.gBoxEdiUMed1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarUniMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar unidad de medida";
            this.Load += new System.EventHandler(this.EditarUniMedida_Load);
            this.gBoxEdiUMed1.ResumeLayout(false);
            this.gBoxEdiUMed1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdiUMed2;
        private System.Windows.Forms.Button btnEdiUMed1;
        private System.Windows.Forms.GroupBox gBoxEdiUMed1;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label LblEdiUMed1;
    }
}