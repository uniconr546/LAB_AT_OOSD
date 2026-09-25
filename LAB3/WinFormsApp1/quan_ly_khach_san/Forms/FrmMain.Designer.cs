namespace WinFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnDanhMuc = new Button();
            btnPhongTiennghi = new Button();
            btnDatNhanphong = new Button();
            btnSudungdichvu = new Button();
            btnTraphongThanhtoan = new Button();
            btnThongke = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(132, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(519, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Location = new Point(12, 92);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(226, 61);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += button1_Click;
            // 
            // btnPhongTiennghi
            // 
            btnPhongTiennghi.Location = new Point(281, 92);
            btnPhongTiennghi.Name = "btnPhongTiennghi";
            btnPhongTiennghi.Size = new Size(226, 61);
            btnPhongTiennghi.TabIndex = 1;
            btnPhongTiennghi.Text = "Phòng-Tiện nghi";
            btnPhongTiennghi.UseVisualStyleBackColor = true;
            btnPhongTiennghi.Click += button1_Click;
            // 
            // btnDatNhanphong
            // 
            btnDatNhanphong.Location = new Point(544, 92);
            btnDatNhanphong.Name = "btnDatNhanphong";
            btnDatNhanphong.Size = new Size(226, 61);
            btnDatNhanphong.TabIndex = 1;
            btnDatNhanphong.Text = "Đặt/Nhận phòng";
            btnDatNhanphong.UseVisualStyleBackColor = true;
            btnDatNhanphong.Click += button1_Click;
            // 
            // btnSudungdichvu
            // 
            btnSudungdichvu.Location = new Point(12, 193);
            btnSudungdichvu.Name = "btnSudungdichvu";
            btnSudungdichvu.Size = new Size(226, 61);
            btnSudungdichvu.TabIndex = 1;
            btnSudungdichvu.Text = "Sử dụng dịch vụ";
            btnSudungdichvu.UseVisualStyleBackColor = true;
            btnSudungdichvu.Click += button1_Click;
            // 
            // btnTraphongThanhtoan
            // 
            btnTraphongThanhtoan.Location = new Point(281, 193);
            btnTraphongThanhtoan.Name = "btnTraphongThanhtoan";
            btnTraphongThanhtoan.Size = new Size(226, 61);
            btnTraphongThanhtoan.TabIndex = 1;
            btnTraphongThanhtoan.Text = "Trả phòng-Thanh toán";
            btnTraphongThanhtoan.UseVisualStyleBackColor = true;
            btnTraphongThanhtoan.Click += button1_Click;
            // 
            // btnThongke
            // 
            btnThongke.Location = new Point(544, 193);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(226, 61);
            btnThongke.TabIndex = 1;
            btnThongke.Text = "Thống kê";
            btnThongke.UseVisualStyleBackColor = true;
            btnThongke.Click += button1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(281, 294);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(226, 61);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnThongke);
            Controls.Add(btnThoat);
            Controls.Add(btnTraphongThanhtoan);
            Controls.Add(btnDatNhanphong);
            Controls.Add(btnSudungdichvu);
            Controls.Add(btnPhongTiennghi);
            Controls.Add(btnDanhMuc);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN ";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnDanhMuc;
        private Button btnPhongTiennghi;
        private Button btnDatNhanphong;
        private Button btnSudungdichvu;
        private Button btnTraphongThanhtoan;
        private Button btnThongke;
        private Button btnThoat;
    }
}
