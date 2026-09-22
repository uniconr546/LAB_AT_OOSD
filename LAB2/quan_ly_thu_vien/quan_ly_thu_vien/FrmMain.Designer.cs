namespace quan_ly_thu_vien
{
    partial class FrmMain
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
            pnlHeader = new Panel();
            lblTiltle = new Label();
            pnlMenu = new Panel();
            pnlContent = new Panel();
            lblDanhMuc = new Label();
            btnDocGia = new Button();
            btnTheThuVien = new Button();
            btnTheLoai = new Button();
            btnDauSach = new Button();
            btnNhaXuatBan = new Button();
            lblNghiepVu = new Label();
            btnMuonSach = new Button();
            btnTraSach = new Button();
            btnPhieuPhat = new Button();
            lblThongKe = new Label();
            btnThongKe = new Button();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Control;
            pnlHeader.Controls.Add(lblTiltle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1182, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTiltle
            // 
            lblTiltle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiltle.Location = new Point(0, 0);
            lblTiltle.Name = "lblTiltle";
            lblTiltle.Size = new Size(1182, 70);
            lblTiltle.TabIndex = 0;
            lblTiltle.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN\r\n";
            lblTiltle.TextAlign = ContentAlignment.MiddleCenter;
            lblTiltle.Click += lblTiltle_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnNhaXuatBan);
            pnlMenu.Controls.Add(btnDauSach);
            pnlMenu.Controls.Add(btnTheLoai);
            pnlMenu.Controls.Add(btnTheThuVien);
            pnlMenu.Controls.Add(btnThongKe);
            pnlMenu.Controls.Add(btnPhieuPhat);
            pnlMenu.Controls.Add(btnTraSach);
            pnlMenu.Controls.Add(btnMuonSach);
            pnlMenu.Controls.Add(btnDocGia);
            pnlMenu.Controls.Add(lblThongKe);
            pnlMenu.Controls.Add(lblNghiepVu);
            pnlMenu.Controls.Add(lblDanhMuc);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 653);
            pnlMenu.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1182, 653);
            pnlContent.TabIndex = 2;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDanhMuc.Location = new Point(12, 70);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(114, 22);
            lblDanhMuc.TabIndex = 0;
            lblDanhMuc.Text = "DANH MỤC";
            lblDanhMuc.Click += lblDanhMuc_Click;
            // 
            // btnDocGia
            // 
            btnDocGia.Location = new Point(12, 95);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Size = new Size(200, 29);
            btnDocGia.TabIndex = 1;
            btnDocGia.Text = "Độc Giả";
            btnDocGia.UseVisualStyleBackColor = true;
            // 
            // btnTheThuVien
            // 
            btnTheThuVien.Location = new Point(13, 130);
            btnTheThuVien.Name = "btnTheThuVien";
            btnTheThuVien.Size = new Size(199, 29);
            btnTheThuVien.TabIndex = 1;
            btnTheThuVien.Text = "Thẻ Thư Viện";
            btnTheThuVien.UseVisualStyleBackColor = true;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Location = new Point(13, 165);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(199, 29);
            btnTheLoai.TabIndex = 1;
            btnTheLoai.Text = "Thể Loại";
            btnTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnDauSach
            // 
            btnDauSach.Location = new Point(13, 200);
            btnDauSach.Name = "btnDauSach";
            btnDauSach.Size = new Size(199, 29);
            btnDauSach.TabIndex = 1;
            btnDauSach.Text = "Đầu Sách ";
            btnDauSach.UseVisualStyleBackColor = true;
            // 
            // btnNhaXuatBan
            // 
            btnNhaXuatBan.Location = new Point(12, 235);
            btnNhaXuatBan.Name = "btnNhaXuatBan";
            btnNhaXuatBan.Size = new Size(199, 29);
            btnNhaXuatBan.TabIndex = 1;
            btnNhaXuatBan.Text = "Nhà Xuất Bản";
            btnNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // lblNghiepVu
            // 
            lblNghiepVu.AutoSize = true;
            lblNghiepVu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNghiepVu.Location = new Point(12, 294);
            lblNghiepVu.Name = "lblNghiepVu";
            lblNghiepVu.Size = new Size(111, 22);
            lblNghiepVu.TabIndex = 0;
            lblNghiepVu.Text = "NGHIỆP VỤ";
            lblNghiepVu.Click += lblDanhMuc_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Location = new Point(12, 319);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(199, 29);
            btnMuonSach.TabIndex = 1;
            btnMuonSach.Text = "Mượn Sách ";
            btnMuonSach.UseVisualStyleBackColor = true;
            btnMuonSach.Click += button1_Click;
            // 
            // btnTraSach
            // 
            btnTraSach.Location = new Point(13, 354);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(199, 29);
            btnTraSach.TabIndex = 1;
            btnTraSach.Text = "Trả Sách ";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Click += button1_Click;
            // 
            // btnPhieuPhat
            // 
            btnPhieuPhat.Location = new Point(12, 389);
            btnPhieuPhat.Name = "btnPhieuPhat";
            btnPhieuPhat.Size = new Size(199, 29);
            btnPhieuPhat.TabIndex = 1;
            btnPhieuPhat.Text = "Phiếu Phạt";
            btnPhieuPhat.UseVisualStyleBackColor = true;
            btnPhieuPhat.Click += button1_Click;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThongKe.Location = new Point(12, 445);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(109, 22);
            lblThongKe.TabIndex = 0;
            lblThongKe.Text = "THỐNG KÊ";
            lblThongKe.Click += lblDanhMuc_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(12, 470);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(199, 29);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Controls.Add(pnlContent);
            MinimumSize = new Size(1200, 700);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            pnlHeader.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTiltle;
        private Panel pnlMenu;
        private Panel pnlContent;
        private Label lblDanhMuc;
        private Button btnDocGia;
        private Button btnNhaXuatBan;
        private Button btnDauSach;
        private Button btnTheLoai;
        private Button btnTheThuVien;
        private Button btnMuonSach;
        private Label lblNghiepVu;
        private Button btnPhieuPhat;
        private Button btnTraSach;
        private Label lblThongKe;
        private Button btnThongKe;
    }
}