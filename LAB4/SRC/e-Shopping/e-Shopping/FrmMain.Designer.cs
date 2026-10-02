namespace e_Shopping
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
            pnlHeader = new Panel();
            lblLogo = new Label();
            lblTitle = new Label();
            pnlMenu = new Panel();
            btnTrangChu = new Button();
            btnSanPham = new Button();
            btnGioHang = new Button();
            btnDonHang = new Button();
            btnDangNhap = new Button();
            pnlConTent = new Panel();
            btnXemSanPham = new Button();
            lblWellcome = new Label();
            lblDescription = new Label();
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlConTent.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Location = new Point(-4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1197, 101);
            pnlHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(562, 18);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(94, 20);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "e-SHOPPING";
            lblLogo.Click += label1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(482, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG MUA SẮM TRỰC TUYẾN";
            lblTitle.Click += label1_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnDangNhap);
            pnlMenu.Controls.Add(btnDonHang);
            pnlMenu.Controls.Add(btnGioHang);
            pnlMenu.Controls.Add(btnSanPham);
            pnlMenu.Controls.Add(btnTrangChu);
            pnlMenu.Location = new Point(-4, 110);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1197, 55);
            pnlMenu.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Location = new Point(116, 20);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(94, 29);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // btnSanPham
            // 
            btnSanPham.Location = new Point(350, 20);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(94, 29);
            btnSanPham.TabIndex = 0;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            // 
            // btnGioHang
            // 
            btnGioHang.Location = new Point(572, 20);
            btnGioHang.Name = "btnGioHang";
            btnGioHang.Size = new Size(94, 29);
            btnGioHang.TabIndex = 0;
            btnGioHang.Text = "Giỏ hàng";
            btnGioHang.UseVisualStyleBackColor = true;
            // 
            // btnDonHang
            // 
            btnDonHang.Location = new Point(785, 20);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(94, 29);
            btnDonHang.TabIndex = 0;
            btnDonHang.Text = "Đơn hàng";
            btnDonHang.UseVisualStyleBackColor = true;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(994, 20);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // pnlConTent
            // 
            pnlConTent.Controls.Add(lblDescription);
            pnlConTent.Controls.Add(lblWellcome);
            pnlConTent.Controls.Add(btnXemSanPham);
            pnlConTent.Location = new Point(-4, 171);
            pnlConTent.Name = "pnlConTent";
            pnlConTent.Size = new Size(1197, 424);
            pnlConTent.TabIndex = 0;
            // 
            // btnXemSanPham
            // 
            btnXemSanPham.Location = new Point(477, 344);
            btnXemSanPham.Name = "btnXemSanPham";
            btnXemSanPham.Size = new Size(247, 47);
            btnXemSanPham.TabIndex = 0;
            btnXemSanPham.Text = "Xem sản phẩm";
            btnXemSanPham.UseVisualStyleBackColor = true;
            // 
            // lblWellcome
            // 
            lblWellcome.AutoSize = true;
            lblWellcome.Location = new Point(482, 83);
            lblWellcome.Name = "lblWellcome";
            lblWellcome.Size = new Size(222, 20);
            lblWellcome.TabIndex = 0;
            lblWellcome.Text = "CHÀO MỪNG ĐẾN E-SHOPPING";
            lblWellcome.Click += label1_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(459, 213);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(281, 20);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Mua sắm trực tuyến nhanh chóng, tiện lợi";
            lblDescription.Click += label1_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Location = new Point(-4, 601);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1197, 55);
            pnlFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(526, 16);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(130, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "2026 e-SHOPPING";
            lblFooter.Click += label1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 658);
            Controls.Add(pnlConTent);
            Controls.Add(pnlFooter);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Name = "FrmMain";
            Text = "Giao diện trang chủ";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlConTent.ResumeLayout(false);
            pnlConTent.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblLogo;
        private Label lblTitle;
        private Panel pnlMenu;
        private Button btnDangNhap;
        private Button btnDonHang;
        private Button btnGioHang;
        private Button btnSanPham;
        private Button btnTrangChu;
        private Panel pnlConTent;
        private Label lblWellcome;
        private Button btnXemSanPham;
        private Label lblDescription;
        private Panel pnlFooter;
        private Label lblFooter;
    }
}
