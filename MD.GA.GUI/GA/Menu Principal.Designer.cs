namespace MD.GA.GUI.GA
{
    partial class Menu_Principal
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
            this.BtnMpAlm = new System.Windows.Forms.Button();
            this.BtnMpCom = new System.Windows.Forms.Button();
            this.BtnMpSal = new System.Windows.Forms.Button();
            this.BtnMpConfi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMpAlm
            // 
            this.BtnMpAlm.Location = new System.Drawing.Point(40, 59);
            this.BtnMpAlm.Name = "BtnMpAlm";
            this.BtnMpAlm.Size = new System.Drawing.Size(197, 45);
            this.BtnMpAlm.TabIndex = 0;
            this.BtnMpAlm.Text = "Almacén";
            this.BtnMpAlm.UseVisualStyleBackColor = true;
            this.BtnMpAlm.Click += new System.EventHandler(this.BtnMpButton1_Click);
            // 
            // BtnMpCom
            // 
            this.BtnMpCom.Location = new System.Drawing.Point(40, 110);
            this.BtnMpCom.Name = "BtnMpCom";
            this.BtnMpCom.Size = new System.Drawing.Size(197, 42);
            this.BtnMpCom.TabIndex = 1;
            this.BtnMpCom.Text = "Compras";
            this.BtnMpCom.UseVisualStyleBackColor = true;
            this.BtnMpCom.Click += new System.EventHandler(this.BtnMpButton2_Click);
            // 
            // BtnMpSal
            // 
            this.BtnMpSal.Location = new System.Drawing.Point(40, 158);
            this.BtnMpSal.Name = "BtnMpSal";
            this.BtnMpSal.Size = new System.Drawing.Size(197, 43);
            this.BtnMpSal.TabIndex = 2;
            this.BtnMpSal.Text = "Salida";
            this.BtnMpSal.UseVisualStyleBackColor = true;
            this.BtnMpSal.Click += new System.EventHandler(this.BtnMpbutton3_Click);
            // 
            // BtnMpConfi
            // 
            this.BtnMpConfi.Location = new System.Drawing.Point(40, 256);
            this.BtnMpConfi.Name = "BtnMpConfi";
            this.BtnMpConfi.Size = new System.Drawing.Size(197, 41);
            this.BtnMpConfi.TabIndex = 3;
            this.BtnMpConfi.Text = "Configuración";
            this.BtnMpConfi.UseVisualStyleBackColor = true;
            this.BtnMpConfi.Click += new System.EventHandler(this.BtnMpButton4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(285, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnMpConfi);
            this.Controls.Add(this.BtnMpSal);
            this.Controls.Add(this.BtnMpCom);
            this.Controls.Add(this.BtnMpAlm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMpAlm;
        private System.Windows.Forms.Button BtnMpCom;
        private System.Windows.Forms.Button BtnMpSal;
        private System.Windows.Forms.Button BtnMpConfi;
        private System.Windows.Forms.Button button1;
    }
}