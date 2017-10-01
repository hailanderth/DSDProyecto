namespace MD.GA.GUI.GA.Almacen
{
    partial class Almacen
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
            this.BtnAlmEstdSal = new System.Windows.Forms.Button();
            this.BtnAlmEstdIng = new System.Windows.Forms.Button();
            this.BtnAlmArti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAlmEstdSal
            // 
            this.BtnAlmEstdSal.Location = new System.Drawing.Point(47, 181);
            this.BtnAlmEstdSal.Name = "BtnAlmEstdSal";
            this.BtnAlmEstdSal.Size = new System.Drawing.Size(197, 45);
            this.BtnAlmEstdSal.TabIndex = 5;
            this.BtnAlmEstdSal.Text = "Estadística de Salida";
            this.BtnAlmEstdSal.UseVisualStyleBackColor = true;
            this.BtnAlmEstdSal.Click += new System.EventHandler(this.BtnAlmbutton3_Click);
            // 
            // BtnAlmEstdIng
            // 
            this.BtnAlmEstdIng.Location = new System.Drawing.Point(47, 130);
            this.BtnAlmEstdIng.Name = "BtnAlmEstdIng";
            this.BtnAlmEstdIng.Size = new System.Drawing.Size(197, 45);
            this.BtnAlmEstdIng.TabIndex = 4;
            this.BtnAlmEstdIng.Text = "Estadística de Ingreso ";
            this.BtnAlmEstdIng.UseVisualStyleBackColor = true;
            this.BtnAlmEstdIng.Click += new System.EventHandler(this.BtnAlmbutton2_Click);
            // 
            // BtnAlmArti
            // 
            this.BtnAlmArti.Location = new System.Drawing.Point(47, 79);
            this.BtnAlmArti.Name = "BtnAlmArti";
            this.BtnAlmArti.Size = new System.Drawing.Size(197, 45);
            this.BtnAlmArti.TabIndex = 3;
            this.BtnAlmArti.Text = "Artículos";
            this.BtnAlmArti.UseVisualStyleBackColor = true;
            this.BtnAlmArti.Click += new System.EventHandler(this.BtnAlmbutton1_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(285, 328);
            this.Controls.Add(this.BtnAlmEstdSal);
            this.Controls.Add(this.BtnAlmEstdIng);
            this.Controls.Add(this.BtnAlmArti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacén";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAlmEstdSal;
        private System.Windows.Forms.Button BtnAlmEstdIng;
        private System.Windows.Forms.Button BtnAlmArti;
    }
}