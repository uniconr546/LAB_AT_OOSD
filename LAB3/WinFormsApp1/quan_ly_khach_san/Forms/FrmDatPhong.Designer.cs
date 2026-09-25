namespace QuanLyKhachSan
{
    partial class FrmDatPhong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnLapphieudat = new Button();
            dgvDanhmuc = new DataGridView();
            tbxTiencoc = new TextBox();
            tbxKenhdat = new TextBox();
            tbxkhach = new TextBox();
            tbxSophieudat = new TextBox();
            lblTiencoc = new Label();
            lblKenhdat = new Label();
            lblNhanphongnguoiluutru = new Label();
            lblDatphong = new Label();
            lblkhach = new Label();
            lblSophieudat = new Label();
            lblKhachhang = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            colPhongChon = new DataGridViewTextBoxColumn();
            colSonguoi = new DataGridViewTextBoxColumn();
            colDongiatrenngay = new DataGridViewTextBoxColumn();
            lblPhieudatphong = new Label();
            colSophieu = new DataGridViewTextBoxColumn();
            colKhach = new DataGridViewTextBoxColumn();
            colNgaynhan = new DataGridViewTextBoxColumn();
            colNgaytradukien = new DataGridViewTextBoxColumn();
            colCoc = new DataGridViewTextBoxColumn();
            colKenh = new DataGridViewTextBoxColumn();
            colTrangthai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnLapphieudat
            // 
            btnLapphieudat.BackColor = SystemColors.ControlLight;
            btnLapphieudat.Location = new Point(668, 313);
            btnLapphieudat.Name = "btnLapphieudat";
            btnLapphieudat.Size = new Size(163, 29);
            btnLapphieudat.TabIndex = 38;
            btnLapphieudat.Text = "Lập phiếu đặt";
            btnLapphieudat.UseVisualStyleBackColor = false;
            // 
            // dgvDanhmuc
            // 
            dgvDanhmuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhmuc.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhmuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhmuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhmuc.Columns.AddRange(new DataGridViewColumn[] { colPhongChon, colSonguoi, colDongiatrenngay });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhmuc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhmuc.Location = new Point(428, 89);
            dgvDanhmuc.Name = "dgvDanhmuc";
            dgvDanhmuc.RowHeadersWidth = 51;
            dgvDanhmuc.Size = new Size(403, 218);
            dgvDanhmuc.TabIndex = 37;
            dgvDanhmuc.CellContentClick += dgvDanhmuc_CellContentClick;
            // 
            // tbxTiencoc
            // 
            tbxTiencoc.Location = new Point(701, 41);
            tbxTiencoc.Name = "tbxTiencoc";
            tbxTiencoc.Size = new Size(123, 27);
            tbxTiencoc.TabIndex = 20;
            tbxTiencoc.Text = "500000";
            // 
            // tbxKenhdat
            // 
            tbxKenhdat.Location = new Point(516, 41);
            tbxKenhdat.Name = "tbxKenhdat";
            tbxKenhdat.Size = new Size(92, 27);
            tbxKenhdat.TabIndex = 21;
            tbxKenhdat.Text = "Website";
            // 
            // tbxkhach
            // 
            tbxkhach.Location = new Point(302, 41);
            tbxkhach.Name = "tbxkhach";
            tbxkhach.Size = new Size(109, 27);
            tbxkhach.TabIndex = 22;
            tbxkhach.Text = "Nguyễn Văn A";
            // 
            // tbxSophieudat
            // 
            tbxSophieudat.Location = new Point(114, 41);
            tbxSophieudat.Name = "tbxSophieudat";
            tbxSophieudat.Size = new Size(105, 27);
            tbxSophieudat.TabIndex = 25;
            tbxSophieudat.Text = "DP001";
            // 
            // lblTiencoc
            // 
            lblTiencoc.AutoSize = true;
            lblTiencoc.Location = new Point(628, 44);
            lblTiencoc.Name = "lblTiencoc";
            lblTiencoc.Size = new Size(67, 20);
            lblTiencoc.TabIndex = 27;
            lblTiencoc.Text = "Tiền cọc:";
            // 
            // lblKenhdat
            // 
            lblKenhdat.AutoSize = true;
            lblKenhdat.Location = new Point(428, 44);
            lblKenhdat.Name = "lblKenhdat";
            lblKenhdat.Size = new Size(71, 20);
            lblKenhdat.TabIndex = 26;
            lblKenhdat.Text = "Kênh đặt:";
            // 
            // lblNhanphongnguoiluutru
            // 
            lblNhanphongnguoiluutru.AutoSize = true;
            lblNhanphongnguoiluutru.Location = new Point(244, 6);
            lblNhanphongnguoiluutru.Name = "lblNhanphongnguoiluutru";
            lblNhanphongnguoiluutru.Size = new Size(209, 20);
            lblNhanphongnguoiluutru.TabIndex = 30;
            lblNhanphongnguoiluutru.Text = "[ Nhận phòng /Người lưu trữ ]";
            // 
            // lblDatphong
            // 
            lblDatphong.AutoSize = true;
            lblDatphong.Location = new Point(131, 6);
            lblDatphong.Name = "lblDatphong";
            lblDatphong.Size = new Size(98, 20);
            lblDatphong.TabIndex = 31;
            lblDatphong.Text = "[ Đặt phòng ]";
            lblDatphong.Click += lblTiennghi_Click;
            // 
            // lblkhach
            // 
            lblkhach.AutoSize = true;
            lblkhach.Location = new Point(232, 44);
            lblkhach.Name = "lblkhach";
            lblkhach.Size = new Size(52, 20);
            lblkhach.TabIndex = 32;
            lblkhach.Text = "Khách:";
            // 
            // lblSophieudat
            // 
            lblSophieudat.AutoSize = true;
            lblSophieudat.Location = new Point(12, 44);
            lblSophieudat.Name = "lblSophieudat";
            lblSophieudat.Size = new Size(96, 20);
            lblSophieudat.TabIndex = 34;
            lblSophieudat.Text = "Số phiếu đặt:";
            // 
            // lblKhachhang
            // 
            lblKhachhang.AutoSize = true;
            lblKhachhang.Location = new Point(12, 6);
            lblKhachhang.Name = "lblKhachhang";
            lblKhachhang.Size = new Size(104, 20);
            lblKhachhang.TabIndex = 36;
            lblKhachhang.Text = "[ Khách hàng ]";
            lblKhachhang.Click += lblKhachhang_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(403, 218);
            dataGridView1.TabIndex = 39;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colSophieu, colKhach, colNgaynhan, colNgaytradukien, colCoc, colKenh, colTrangthai });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.Location = new Point(12, 383);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(819, 162);
            dataGridView2.TabIndex = 40;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Phòng";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Khu";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Sửa chửa";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colPhongChon
            // 
            colPhongChon.HeaderText = "Phòng Chọn";
            colPhongChon.MinimumWidth = 6;
            colPhongChon.Name = "colPhongChon";
            // 
            // colSonguoi
            // 
            colSonguoi.HeaderText = "Số người";
            colSonguoi.MinimumWidth = 6;
            colSonguoi.Name = "colSonguoi";
            // 
            // colDongiatrenngay
            // 
            colDongiatrenngay.HeaderText = "Đơn giá/ngày";
            colDongiatrenngay.MinimumWidth = 6;
            colDongiatrenngay.Name = "colDongiatrenngay";
            // 
            // lblPhieudatphong
            // 
            lblPhieudatphong.AutoSize = true;
            lblPhieudatphong.Location = new Point(12, 360);
            lblPhieudatphong.Name = "lblPhieudatphong";
            lblPhieudatphong.Size = new Size(121, 20);
            lblPhieudatphong.TabIndex = 36;
            lblPhieudatphong.Text = "Phiếu đặt phòng:";
            lblPhieudatphong.Click += lblKhachhang_Click;
            // 
            // colSophieu
            // 
            colSophieu.HeaderText = "Số phiếu";
            colSophieu.MinimumWidth = 6;
            colSophieu.Name = "colSophieu";
            // 
            // colKhach
            // 
            colKhach.HeaderText = "Khách ";
            colKhach.MinimumWidth = 6;
            colKhach.Name = "colKhach";
            // 
            // colNgaynhan
            // 
            colNgaynhan.HeaderText = "Ngày nhận";
            colNgaynhan.MinimumWidth = 6;
            colNgaynhan.Name = "colNgaynhan";
            // 
            // colNgaytradukien
            // 
            colNgaytradukien.HeaderText = "Ngày trả dự kiến";
            colNgaytradukien.MinimumWidth = 6;
            colNgaytradukien.Name = "colNgaytradukien";
            // 
            // colCoc
            // 
            colCoc.HeaderText = "Cọc";
            colCoc.MinimumWidth = 6;
            colCoc.Name = "colCoc";
            // 
            // colKenh
            // 
            colKenh.HeaderText = "Kênh";
            colKenh.MinimumWidth = 6;
            colKenh.Name = "colKenh";
            // 
            // colTrangthai
            // 
            colTrangthai.HeaderText = "Trạng thái";
            colTrangthai.MinimumWidth = 6;
            colTrangthai.Name = "colTrangthai";
            // 
            // FrmDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 555);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnLapphieudat);
            Controls.Add(dgvDanhmuc);
            Controls.Add(tbxTiencoc);
            Controls.Add(tbxKenhdat);
            Controls.Add(tbxkhach);
            Controls.Add(tbxSophieudat);
            Controls.Add(lblTiencoc);
            Controls.Add(lblKenhdat);
            Controls.Add(lblNhanphongnguoiluutru);
            Controls.Add(lblDatphong);
            Controls.Add(lblkhach);
            Controls.Add(lblSophieudat);
            Controls.Add(lblPhieudatphong);
            Controls.Add(lblKhachhang);
            Name = "FrmDatPhong";
            Text = "Form1";
            Load += FrmDatPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLapphieudat;
        private DataGridView dgvDanhmuc;
        private TextBox tbxTiencoc;
        private TextBox tbxKenhdat;
        private TextBox tbxkhach;
        private TextBox tbxSophieudat;
        private Label lblTiencoc;
        private Label lblKenhdat;
        private Label lblNhanphongnguoiluutru;
        private Label lblDatphong;
        private Label lblkhach;
        private Label lblSophieudat;
        private Label lblKhachhang;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colPhongChon;
        private DataGridViewTextBoxColumn colSonguoi;
        private DataGridViewTextBoxColumn colDongiatrenngay;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label lblPhieudatphong;
        private DataGridViewTextBoxColumn colSophieu;
        private DataGridViewTextBoxColumn colKhach;
        private DataGridViewTextBoxColumn colNgaynhan;
        private DataGridViewTextBoxColumn colNgaytradukien;
        private DataGridViewTextBoxColumn colCoc;
        private DataGridViewTextBoxColumn colKenh;
        private DataGridViewTextBoxColumn colTrangthai;
    }
}