namespace MD.GA.GUI.GA
{
    partial class login
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
            this.txtlogin1 = new System.Windows.Forms.TextBox();
            this.txtlogin2 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnlogAcep = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBxlogin2 = new System.Windows.Forms.PictureBox();
            this.pBxlogin1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxlogin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxlogin1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlogin1
            // 
            this.txtlogin1.Location = new System.Drawing.Point(98, 178);
            this.txtlogin1.Name = "txtlogin1";
            this.txtlogin1.Size = new System.Drawing.Size(175, 20);
            this.txtlogin1.TabIndex = 2;
            // 
            // txtlogin2
            // 
            this.txtlogin2.Location = new System.Drawing.Point(98, 241);
            this.txtlogin2.Name = "txtlogin2";
            this.txtlogin2.PasswordChar = '*';
            this.txtlogin2.Size = new System.Drawing.Size(175, 20);
            this.txtlogin2.TabIndex = 3;
            this.txtlogin2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlogin2_KeyPress);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnlogAcep
            // 
            this.btnlogAcep.Location = new System.Drawing.Point(111, 306);
            this.btnlogAcep.Name = "btnlogAcep";
            this.btnlogAcep.Size = new System.Drawing.Size(148, 40);
            this.btnlogAcep.TabIndex = 4;
            this.btnlogAcep.Text = "Aceptar";
            this.btnlogAcep.UseVisualStyleBackColor = true;
            this.btnlogAcep.Click += new System.EventHandler(this.btnlogin1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MD.GA.GUI.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(246, 395);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MD.GA.GUI.Properties.Resources.logo_diagnosticos;
            this.pictureBox1.Location = new System.Drawing.Point(41, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pBxlogin2
            // 
            this.pBxlogin2.Image = global::MD.GA.GUI.Properties.Resources.padlock;
            this.pBxlogin2.Location = new System.Drawing.Point(54, 239);
            this.pBxlogin2.Name = "pBxlogin2";
            this.pBxlogin2.Size = new System.Drawing.Size(24, 22);
            this.pBxlogin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxlogin2.TabIndex = 1;
            this.pBxlogin2.TabStop = false;
            // 
            // pBxlogin1
            // 
            this.pBxlogin1.Image = global::MD.GA.GUI.Properties.Resources.user;
            this.pBxlogin1.Location = new System.Drawing.Point(54, 176);
            this.pBxlogin1.Name = "pBxlogin1";
            this.pBxlogin1.Size = new System.Drawing.Size(24, 22);
            this.pBxlogin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxlogin1.TabIndex = 0;
            this.pBxlogin1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(158, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Powered by";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(329, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogAcep);
            this.Controls.Add(this.txtlogin2);
            this.Controls.Add(this.txtlogin1);
            this.Controls.Add(this.pBxlogin2);
            this.Controls.Add(this.pBxlogin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxlogin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxlogin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBxlogin1;
        private System.Windows.Forms.PictureBox pBxlogin2;
        private System.Windows.Forms.TextBox txtlogin1;
        private System.Windows.Forms.TextBox txtlogin2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnlogAcep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}