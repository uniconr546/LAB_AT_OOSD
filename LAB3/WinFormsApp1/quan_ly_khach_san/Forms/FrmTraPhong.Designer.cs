namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            btnLapphieudenbu = new Button();
            dgvDanhmuc = new DataGridView();
            tbxSotien = new TextBox();
            tbxMucdo = new TextBox();
            tbxPhieudango = new TextBox();
            lblSotien = new Label();
            lblSophieudenbu = new Label();
            lblPhieudango = new Label();
            lblHinhthuc = new Label();
            labelsotien = new Label();
            txbHinhthuc = new TextBox();
            txbSotien = new TextBox();
            btnthanhtoan = new Button();
            lblSohoadon = new Label();
            label5 = new Label();
            txbSohoadon = new TextBox();
            txbSongaytinhtien = new TextBox();
            btnLaphoadon = new Button();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colDongiaNgay = new DataGridViewTextBoxColumn();
            colTiennghi = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colTinhtrang = new DataGridViewTextBoxColumn();
            colTiennghidenbu = new DataGridViewTextBoxColumn();
            colMucdo = new DataGridViewTextBoxColumn();
            colSotien = new DataGridViewTextBoxColumn();
            colHoadon = new DataGridViewTextBoxColumn();
            colPhieudat = new DataGridViewTextBoxColumn();
            colTenphong = new DataGridViewTextBoxColumn();
            colTendichvu = new DataGridViewTextBoxColumn();
            colTongtien = new DataGridViewTextBoxColumn();
            colTrangthai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.SteelBlue;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colHoadon, colPhieudat, colTenphong, colTendichvu, colTongtien, colTrangthai });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.Location = new Point(35, 399);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(819, 162);
            dataGridView2.TabIndex = 53;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.SteelBlue;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, colDongiaNgay });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.Location = new Point(35, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(200, 218);
            dataGridView1.TabIndex = 52;
            // 
            // btnLapphieudenbu
            // 
            btnLapphieudenbu.BackColor = SystemColors.ControlLight;
            btnLapphieudenbu.Location = new Point(703, 287);
            btnLapphieudenbu.Name = "btnLapphieudenbu";
            btnLapphieudenbu.Size = new Size(141, 29);
            btnLapphieudenbu.TabIndex = 51;
            btnLapphieudenbu.Text = "Lập phiếu đền bù";
            btnLapphieudenbu.UseVisualStyleBackColor = false;
            // 
            // dgvDanhmuc
            // 
            dgvDanhmuc.AllowUserToAddRows = false;
            dgvDanhmuc.AllowUserToDeleteRows = false;
            dgvDanhmuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhmuc.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.SteelBlue;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvDanhmuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvDanhmuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhmuc.Columns.AddRange(new DataGridViewColumn[] { colTiennghi, colLoai, colTinhtrang });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvDanhmuc.DefaultCellStyle = dataGridViewCellStyle14;
            dgvDanhmuc.Location = new Point(254, 51);
            dgvDanhmuc.Name = "dgvDanhmuc";
            dgvDanhmuc.ReadOnly = true;
            dgvDanhmuc.RowHeadersVisible = false;
            dgvDanhmuc.RowHeadersWidth = 51;
            dgvDanhmuc.Size = new Size(289, 218);
            dgvDanhmuc.TabIndex = 50;
            // 
            // tbxSotien
            // 
            tbxSotien.Location = new Point(565, 288);
            tbxSotien.Name = "tbxSotien";
            tbxSotien.Size = new Size(123, 27);
            tbxSotien.TabIndex = 41;
            tbxSotien.Text = "500000";
            // 
            // tbxMucdo
            // 
            tbxMucdo.Location = new Point(370, 287);
            tbxMucdo.Name = "tbxMucdo";
            tbxMucdo.Size = new Size(112, 27);
            tbxMucdo.TabIndex = 42;
            tbxMucdo.Text = "Hư hỏng nhẹ";
            // 
            // tbxSophieudenbu
            // 
            // tbxPhieudango
            // 
            tbxPhieudango.Location = new Point(152, 12);
            tbxPhieudango.Name = "tbxPhieudango";
            tbxPhieudango.Size = new Size(106, 27);
            tbxPhieudango.TabIndex = 44;
            tbxPhieudango.Text = "DP001";
            // 
            // lblSotien
            // 
            lblSotien.AutoSize = true;
            lblSotien.Location = new Point(501, 290);
            lblSotien.Name = "lblSotien";
            lblSotien.Size = new Size(58, 20);
            lblSotien.TabIndex = 46;
            lblSotien.Text = "Số tiền:";
            // 
            // lblMucdo
            // 
            // 
            // lblSophieudenbu
            // 
            lblSophieudenbu.AutoSize = true;
            lblSophieudenbu.Location = new Point(45, 291);
            lblSophieudenbu.Name = "lblSophieudenbu";
            lblSophieudenbu.Size = new Size(120, 20);
            lblSophieudenbu.TabIndex = 47;
            lblSophieudenbu.Text = "Số phiếu đền bù:";
            // 
            // lblPhieudango
            // 
            lblPhieudango.AutoSize = true;
            lblPhieudango.Location = new Point(28, 15);
            lblPhieudango.Name = "lblPhieudango";
            lblPhieudango.Size = new Size(99, 20);
            lblPhieudango.TabIndex = 48;
            lblPhieudango.Text = "Phiếu đang ở:";
            // 
            // lblHinhthuc
            // 
            lblHinhthuc.AutoSize = true;
            lblHinhthuc.Location = new Point(45, 570);
            lblHinhthuc.Name = "lblHinhthuc";
            lblHinhthuc.Size = new Size(76, 20);
            lblHinhthuc.TabIndex = 47;
            lblHinhthuc.Text = "Hình thức:";
            // 
            // labelsotien
            // 
            labelsotien.AutoSize = true;
            labelsotien.Location = new Point(279, 570);
            labelsotien.Name = "labelsotien";
            labelsotien.Size = new Size(58, 20);
            labelsotien.TabIndex = 45;
            labelsotien.Text = "Số tiền:";
            // 
            // txbHinhthuc
            // 
            txbHinhthuc.Location = new Point(127, 567);
            txbHinhthuc.Name = "txbHinhthuc";
            txbHinhthuc.Size = new Size(131, 27);
            txbHinhthuc.TabIndex = 43;
            txbHinhthuc.Text = "Thẻ";
            // 
            // txbSotien
            // 
            txbSotien.Location = new Point(357, 567);
            txbSotien.Name = "txbSotien";
            txbSotien.Size = new Size(92, 27);
            txbSotien.TabIndex = 42;
            txbSotien.Text = "1200000";
            // 
            // btnthanhtoan
            // 
            btnthanhtoan.BackColor = SystemColors.ControlLight;
            btnthanhtoan.Location = new Point(471, 566);
            btnthanhtoan.Name = "btnthanhtoan";
            btnthanhtoan.Size = new Size(163, 29);
            btnthanhtoan.TabIndex = 51;
            btnthanhtoan.Text = "Thanh toán";
            btnthanhtoan.UseVisualStyleBackColor = false;
            // 
            // lblSohoadon
            // 
            lblSohoadon.AutoSize = true;
            lblSohoadon.Location = new Point(45, 340);
            lblSohoadon.Name = "lblSohoadon";
            lblSohoadon.Size = new Size(88, 20);
            lblSohoadon.TabIndex = 47;
            lblSohoadon.Text = "Số hóa đơn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 340);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 45;
            label5.Text = "Số ngày tính tiền:";
            // 
            // txbSohoadon
            // 
            txbSohoadon.Location = new Point(141, 337);
            txbSohoadon.Name = "txbSohoadon";
            txbSohoadon.Size = new Size(134, 27);
            txbSohoadon.TabIndex = 43;
            txbSohoadon.Text = "HD001";
            // 
            // txbSongaytinhtien
            // 
            txbSongaytinhtien.Location = new Point(418, 337);
            txbSongaytinhtien.Name = "txbSongaytinhtien";
            txbSongaytinhtien.Size = new Size(92, 27);
            txbSongaytinhtien.TabIndex = 42;
            txbSongaytinhtien.Text = "2";
            // 
            // btnLaphoadon
            // 
            btnLaphoadon.BackColor = SystemColors.ControlLight;
            btnLaphoadon.Location = new Point(528, 340);
            btnLaphoadon.Name = "btnLaphoadon";
            btnLaphoadon.Size = new Size(135, 29);
            btnLaphoadon.TabIndex = 51;
            btnLaphoadon.Text = "Lập hóa đơn";
            btnLaphoadon.UseVisualStyleBackColor = false;
            btnLaphoadon.Click += button2_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.SteelBlue;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { colTiennghidenbu, colMucdo, colSotien });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridView3.Location = new Point(565, 51);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(289, 218);
            dataGridView3.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Phòng";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colDongiaNgay
            // 
            colDongiaNgay.HeaderText = "Đơn giá/ngày";
            colDongiaNgay.MinimumWidth = 6;
            colDongiaNgay.Name = "colDongiaNgay";
            colDongiaNgay.ReadOnly = true;
            // 
            // colTiennghi
            // 
            colTiennghi.HeaderText = "Tiện nghi";
            colTiennghi.MinimumWidth = 6;
            colTiennghi.Name = "colTiennghi";
            colTiennghi.ReadOnly = true;
            // 
            // colLoai
            // 
            colLoai.HeaderText = "Loại";
            colLoai.MinimumWidth = 6;
            colLoai.Name = "colLoai";
            colLoai.ReadOnly = true;
            // 
            // colTinhtrang
            // 
            colTinhtrang.HeaderText = "Tình trạng";
            colTinhtrang.MinimumWidth = 6;
            colTinhtrang.Name = "colTinhtrang";
            colTinhtrang.ReadOnly = true;
            // 
            // colTiennghidenbu
            // 
            colTiennghidenbu.HeaderText = "Tiện nghi đền bù";
            colTiennghidenbu.MinimumWidth = 6;
            colTiennghidenbu.Name = "colTiennghidenbu";
            colTiennghidenbu.ReadOnly = true;
            // 
            // colMucdo
            // 
            colMucdo.HeaderText = "Mức độ";
            colMucdo.MinimumWidth = 6;
            colMucdo.Name = "colMucdo";
            colMucdo.ReadOnly = true;
            // 
            // colSotien
            // 
            colSotien.HeaderText = "Số tiền";
            colSotien.MinimumWidth = 6;
            colSotien.Name = "colSotien";
            colSotien.ReadOnly = true;
            // 
            // colHoadon
            // 
            colHoadon.HeaderText = "Hóa đơn";
            colHoadon.MinimumWidth = 6;
            colHoadon.Name = "colHoadon";
            colHoadon.ReadOnly = true;
            // 
            // colPhieudat
            // 
            colPhieudat.HeaderText = "Phiếu đặt";
            colPhieudat.MinimumWidth = 6;
            colPhieudat.Name = "colPhieudat";
            colPhieudat.ReadOnly = true;
            // 
            // colTenphong
            // 
            colTenphong.HeaderText = "Tên phòng";
            colTenphong.MinimumWidth = 6;
            colTenphong.Name = "colTenphong";
            colTenphong.ReadOnly = true;
            // 
            // colTendichvu
            // 
            colTendichvu.HeaderText = "Tên dịch vụ";
            colTendichvu.MinimumWidth = 6;
            colTendichvu.Name = "colTendichvu";
            colTendichvu.ReadOnly = true;
            // 
            // colTongtien
            // 
            colTongtien.HeaderText = "Tổng tiền";
            colTongtien.MinimumWidth = 6;
            colTongtien.Name = "colTongtien";
            colTongtien.ReadOnly = true;
            // 
            // colTrangthai
            // 
            colTrangthai.HeaderText = "Trạng thái";
            colTrangthai.MinimumWidth = 6;
            colTrangthai.Name = "colTrangthai";
            colTrangthai.ReadOnly = true;
            // 
            // button1
            // 
            // 
            // FrmTraPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 625);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnthanhtoan);
            Controls.Add(btnLaphoadon);
            Controls.Add(btnLapphieudenbu);
            Controls.Add(dgvDanhmuc);
            Controls.Add(tbxSotien);
            Controls.Add(txbSongaytinhtien);
            Controls.Add(txbSotien);
            Controls.Add(tbxMucdo);
            Controls.Add(txbSohoadon);
            Controls.Add(txbHinhthuc);
            Controls.Add(tbxPhieudango);
            Controls.Add(labelsotien);
            Controls.Add(lblSotien);
            Controls.Add(label5);
            Controls.Add(lblHinhthuc);
            Controls.Add(lblSohoadon);
            Controls.Add(lblSophieudenbu);
            Controls.Add(lblPhieudango);
            Name = "FrmTraPhong";
            Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            Load += FrmTraPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button btnLapphieudenbu;
        private DataGridView dgvDanhmuc;
        private DataGridViewTextBoxColumn colPhongChon;
        private DataGridViewTextBoxColumn colSonguoi;
        private DataGridViewTextBoxColumn colDongiatrenngay;
        private TextBox tbxSotien;
        private TextBox tbxMucdo;
        private TextBox tbxkhach;
        private TextBox tbxPhieudango;
        private Label lblSotien;
        private Label lblKenhdat;
        private Label lblSophieudenbu;
        private Label lblPhieudango;
        private Label lblHinhthuc;
        private Label labelsotien;
        private Label label3;
        private TextBox txbHinhthuc;
        private TextBox txbSotien;
        private TextBox textBox3;
        private Button btnthanhtoan;
        private Label lblSohoadon;
        private Label label5;
        private TextBox txbSohoadon;
        private TextBox txbSongaytinhtien;
        private Button btnLaphoadon;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colDongiaNgay;
        private DataGridViewTextBoxColumn colTiennghi;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colTinhtrang;
        private DataGridViewTextBoxColumn colTiennghidenbu;
        private DataGridViewTextBoxColumn colMucdo;
        private DataGridViewTextBoxColumn colSotien;
        private DataGridViewTextBoxColumn colHoadon;
        private DataGridViewTextBoxColumn colPhieudat;
        private DataGridViewTextBoxColumn colTenphong;
        private DataGridViewTextBoxColumn colTendichvu;
        private DataGridViewTextBoxColumn colTongtien;
        private DataGridViewTextBoxColumn colTrangthai;
    }
}