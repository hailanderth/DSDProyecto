namespace MD.GA.GUI.GA.Compras
{
    partial class Compras
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
            this.BtnAlmbutton2 = new System.Windows.Forms.Button();
            this.BtnAlmbutton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAlmbutton2
            // 
            this.BtnAlmbutton2.Location = new System.Drawing.Point(44, 223);
            this.BtnAlmbutton2.Name = "BtnAlmbutton2";
            this.BtnAlmbutton2.Size = new System.Drawing.Size(197, 45);
            this.BtnAlmbutton2.TabIndex = 7;
            this.BtnAlmbutton2.Text = "Orden de Compra";
            this.BtnAlmbutton2.UseVisualStyleBackColor = true;
            this.BtnAlmbutton2.Click += new System.EventHandler(this.BtnAlmbutton2_Click);
            // 
            // BtnAlmbutton1
            // 
            this.BtnAlmbutton1.Location = new System.Drawing.Point(44, 116);
            this.BtnAlmbutton1.Name = "BtnAlmbutton1";
            this.BtnAlmbutton1.Size = new System.Drawing.Size(197, 45);
            this.BtnAlmbutton1.TabIndex = 6;
            this.BtnAlmbutton1.Text = "Presupuesto";
            this.BtnAlmbutton1.UseVisualStyleBackColor = true;
            this.BtnAlmbutton1.Click += new System.EventHandler(this.BtnAlmbutton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar Presupuesto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(285, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAlmbutton2);
            this.Controls.Add(this.BtnAlmbutton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAlmbutton2;
        private System.Windows.Forms.Button BtnAlmbutton1;
        private System.Windows.Forms.Button button1;
    }
}