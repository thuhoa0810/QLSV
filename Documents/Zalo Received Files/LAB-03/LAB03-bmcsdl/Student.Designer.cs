namespace LAB03_bmcsdl
{
    partial class SINHVIEN
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
            this.components = new System.ComponentModel.Container();
            this.dtgv_SV = new System.Windows.Forms.DataGridView();
            this.cboMALOP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDIACHI = new System.Windows.Forms.RichTextBox();
            this.txtTENDN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_SV
            // 
            this.dtgv_SV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_SV.Location = new System.Drawing.Point(0, 284);
            this.dtgv_SV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_SV.Name = "dtgv_SV";
            this.dtgv_SV.RowHeadersWidth = 62;
            this.dtgv_SV.RowTemplate.Height = 28;
            this.dtgv_SV.Size = new System.Drawing.Size(1115, 369);
            this.dtgv_SV.TabIndex = 0;
            this.dtgv_SV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_SV_CellContentClick);
            // 
            // cboMALOP
            // 
            this.cboMALOP.FormattingEnabled = true;
            this.cboMALOP.Location = new System.Drawing.Point(83, 22);
            this.cboMALOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMALOP.Name = "cboMALOP";
            this.cboMALOP.Size = new System.Drawing.Size(194, 24);
            this.cboMALOP.TabIndex = 1;
            this.cboMALOP.SelectedIndexChanged += new System.EventHandler(this.cboMALOP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp ";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(83, 59);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(194, 40);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm Sinh viên";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(83, 163);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(194, 40);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Gold;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(83, 110);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(194, 40);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXemDiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.Location = new System.Drawing.Point(83, 216);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(194, 40);
            this.btnXemDiem.TabIndex = 6;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin sinh viên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "MSSV *";
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(548, 89);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(241, 23);
            this.txtMASV.TabIndex = 10;
            this.txtMASV.Validating += new System.ComponentModel.CancelEventHandler(this.txtMASV_Validating);
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(548, 185);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(246, 23);
            this.txtHOTEN.TabIndex = 12;
            this.txtHOTEN.Validating += new System.ComponentModel.CancelEventHandler(this.txtHOTEN_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Họ Tên * ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày sinh";
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.Location = new System.Drawing.Point(548, 248);
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Size = new System.Drawing.Size(246, 23);
            this.dateNGAYSINH.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(818, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa chỉ";
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(822, 200);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(247, 74);
            this.txtDIACHI.TabIndex = 17;
            this.txtDIACHI.Text = "";
            // 
            // txtTENDN
            // 
            this.txtTENDN.Location = new System.Drawing.Point(822, 89);
            this.txtTENDN.Name = "txtTENDN";
            this.txtTENDN.Size = new System.Drawing.Size(247, 23);
            this.txtTENDN.TabIndex = 19;
            this.txtTENDN.Validating += new System.ComponentModel.CancelEventHandler(this.txtTENDN_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(818, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên Đăng nhập *";
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(822, 146);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Size = new System.Drawing.Size(247, 23);
            this.txtMATKHAU.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(818, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mật khẩu *";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(311, 101);
            this.lblWarning.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 16);
            this.lblWarning.TabIndex = 22;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.Location = new System.Drawing.Point(639, 120);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 26);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tim kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(548, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 26);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1115, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTENDN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateNGAYSINH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMASV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMALOP);
            this.Controls.Add(this.dtgv_SV);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SINHVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.SINHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_SV;
        private System.Windows.Forms.ComboBox cboMALOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateNGAYSINH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTENDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnClear;
    }
}