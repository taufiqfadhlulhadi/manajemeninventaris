namespace manajemen_inventaris
{
    partial class daftarFrm
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
            this.noTxtbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.daftarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noTxtbox
            // 
            this.noTxtbox.Location = new System.Drawing.Point(16, 81);
            this.noTxtbox.Name = "noTxtbox";
            this.noTxtbox.Size = new System.Drawing.Size(271, 26);
            this.noTxtbox.TabIndex = 0;
            this.noTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noTxtbox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.daftarBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passTxtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.noTxtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Pelanggan";
            // 
            // daftarBtn
            // 
            this.daftarBtn.Location = new System.Drawing.Point(20, 216);
            this.daftarBtn.Name = "daftarBtn";
            this.daftarBtn.Size = new System.Drawing.Size(75, 28);
            this.daftarBtn.TabIndex = 5;
            this.daftarBtn.Text = "Daftar";
            this.daftarBtn.UseVisualStyleBackColor = true;
            this.daftarBtn.Click += new System.EventHandler(this.daftarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // passTxtbox
            // 
            this.passTxtbox.Location = new System.Drawing.Point(16, 154);
            this.passTxtbox.Name = "passTxtbox";
            this.passTxtbox.Size = new System.Drawing.Size(271, 26);
            this.passTxtbox.TabIndex = 2;
            this.passTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTxtbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "No HP";
            // 
            // daftarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "daftarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox noTxtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button daftarBtn;
    }
}