namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.RazSocial
{
    partial class CrearRazSocial
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
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblNueArt3 = new System.Windows.Forms.Label();
            this.BtnNueArt2 = new System.Windows.Forms.Button();
            this.BtnNueArt1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.LblNueArt3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 290);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(168, 120);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(184, 20);
            this.txtRuc.TabIndex = 1;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "RUC:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(168, 85);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(184, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // LblNueArt3
            // 
            this.LblNueArt3.AutoSize = true;
            this.LblNueArt3.Location = new System.Drawing.Point(23, 88);
            this.LblNueArt3.Name = "LblNueArt3";
            this.LblNueArt3.Size = new System.Drawing.Size(73, 13);
            this.LblNueArt3.TabIndex = 18;
            this.LblNueArt3.Text = "Razón Social:";
            // 
            // BtnNueArt2
            // 
            this.BtnNueArt2.Location = new System.Drawing.Point(499, 326);
            this.BtnNueArt2.Name = "BtnNueArt2";
            this.BtnNueArt2.Size = new System.Drawing.Size(89, 36);
            this.BtnNueArt2.TabIndex = 1;
            this.BtnNueArt2.Text = "Atrás";
            this.BtnNueArt2.UseVisualStyleBackColor = true;
            this.BtnNueArt2.Click += new System.EventHandler(this.BtnNueArt2_Click);
            // 
            // BtnNueArt1
            // 
            this.BtnNueArt1.Location = new System.Drawing.Point(401, 326);
            this.BtnNueArt1.Name = "BtnNueArt1";
            this.BtnNueArt1.Size = new System.Drawing.Size(89, 36);
            this.BtnNueArt1.TabIndex = 0;
            this.BtnNueArt1.Text = "Grabar";
            this.BtnNueArt1.UseVisualStyleBackColor = true;
            this.BtnNueArt1.Click += new System.EventHandler(this.BtnNueArt1_Click);
            // 
            // CrearRazSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNueArt2);
            this.Controls.Add(this.BtnNueArt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrearRazSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear empresa";
            this.Load += new System.EventHandler(this.CrearRazSocial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label LblNueArt3;
        private System.Windows.Forms.Button BtnNueArt2;
        private System.Windows.Forms.Button BtnNueArt1;
    }
}