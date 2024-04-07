namespace LAB03_bmcsdl
{
    partial class ĐangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txb_MaNV = new System.Windows.Forms.TextBox();
            this.txb_MK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_DN
            // 
            this.btn_DN.Location = new System.Drawing.Point(288, 285);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(119, 36);
            this.btn_DN.TabIndex = 2;
            this.btn_DN.Text = "Đăng Nhập ";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(439, 285);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(88, 36);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txb_MaNV
            // 
            this.txb_MaNV.Location = new System.Drawing.Point(288, 102);
            this.txb_MaNV.Name = "txb_MaNV";
            this.txb_MaNV.Size = new System.Drawing.Size(239, 26);
            this.txb_MaNV.TabIndex = 4;
            // 
            // txb_MK
            // 
            this.txb_MK.Location = new System.Drawing.Point(288, 189);
            this.txb_MK.Name = "txb_MK";
            this.txb_MK.Size = new System.Drawing.Size(239, 26);
            this.txb_MK.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 393);
            this.Controls.Add(this.txb_MK);
            this.Controls.Add(this.txb_MaNV);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.loginButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txb_MaNV;
        private System.Windows.Forms.TextBox txb_MK;
    }
}

