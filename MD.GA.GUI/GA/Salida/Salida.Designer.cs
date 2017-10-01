namespace MD.GA.GUI.GA.Salida
{
    partial class Salida
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
            this.btnSalida1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalida1
            // 
            this.btnSalida1.Location = new System.Drawing.Point(45, 59);
            this.btnSalida1.Name = "btnSalida1";
            this.btnSalida1.Size = new System.Drawing.Size(197, 45);
            this.btnSalida1.TabIndex = 0;
            this.btnSalida1.Text = "Registro de salidas";
            this.btnSalida1.UseVisualStyleBackColor = true;
            this.btnSalida1.Click += new System.EventHandler(this.btnSalida1_Click);
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 154);
            this.Controls.Add(this.btnSalida1);
            this.Name = "Salida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalida1;
    }
}