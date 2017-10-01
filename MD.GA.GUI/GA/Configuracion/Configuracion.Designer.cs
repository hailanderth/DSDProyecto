namespace MD.GA.GUI.GA.Configuracion
{
    partial class Configuracion
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
            this.BtnConfi2 = new System.Windows.Forms.Button();
            this.BtnConfi1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConfi2
            // 
            this.BtnConfi2.Location = new System.Drawing.Point(44, 169);
            this.BtnConfi2.Name = "BtnConfi2";
            this.BtnConfi2.Size = new System.Drawing.Size(197, 42);
            this.BtnConfi2.TabIndex = 3;
            this.BtnConfi2.Text = "Usuarios";
            this.BtnConfi2.UseVisualStyleBackColor = true;
            this.BtnConfi2.Click += new System.EventHandler(this.BtnConfi2_Click);
            // 
            // BtnConfi1
            // 
            this.BtnConfi1.Location = new System.Drawing.Point(44, 118);
            this.BtnConfi1.Name = "BtnConfi1";
            this.BtnConfi1.Size = new System.Drawing.Size(197, 45);
            this.BtnConfi1.TabIndex = 2;
            this.BtnConfi1.Text = "Registro de información";
            this.BtnConfi1.UseVisualStyleBackColor = true;
            this.BtnConfi1.Click += new System.EventHandler(this.BtnConfi1_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 328);
            this.Controls.Add(this.BtnConfi2);
            this.Controls.Add(this.BtnConfi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConfi2;
        private System.Windows.Forms.Button BtnConfi1;
    }
}