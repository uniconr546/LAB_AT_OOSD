namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnLapphieu = new Button();
            dgvDanhmuc = new DataGridView();
            txbSoluong = new TextBox();
            tbxDichvu = new TextBox();
            txbNgaysudung = new TextBox();
            tbxPhong = new TextBox();
            tbxPhieuluutru = new TextBox();
            lblDichvu = new Label();
            lblTiennghi = new Label();
            lblNgaysudung = new Label();
            lblPhong = new Label();
            lblPhieuluutru = new Label();
            colSophieu = new DataGridViewTextBoxColumn();
            colPhong = new DataGridViewTextBoxColumn();
            colNgay = new DataGridViewTextBoxColumn();
            colDichvu = new DataGridViewTextBoxColumn();
            colSoluong = new DataGridViewTextBoxColumn();
            colDongia = new DataGridViewTextBoxColumn();
            colThanhtien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).BeginInit();
            SuspendLayout();
            // 
            // btnLapphieu
            // 
            btnLapphieu.BackColor = SystemColors.ControlLight;
            btnLapphieu.Location = new Point(624, 69);
            btnLapphieu.Name = "btnLapphieu";
            btnLapphieu.Size = new Size(125, 29);
            btnLapphieu.TabIndex = 35;
            btnLapphieu.Text = "Ghi Nhận";
            btnLapphieu.UseVisualStyleBackColor = false;
            btnLapphieu.Click += btnLapphieu_Click;
            // 
            // dgvDanhmuc
            // 
            dgvDanhmuc.AllowUserToAddRows = false;
            dgvDanhmuc.AllowUserToDeleteRows = false;
            dgvDanhmuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhmuc.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDanhmuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhmuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhmuc.Columns.AddRange(new DataGridViewColumn[] { colSophieu, colPhong, colNgay, colDichvu, colSoluong, colDongia, colThanhtien });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDanhmuc.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhmuc.Location = new Point(36, 121);
            dgvDanhmuc.Name = "dgvDanhmuc";
            dgvDanhmuc.RowHeadersVisible = false;
            dgvDanhmuc.RowHeadersWidth = 51;
            dgvDanhmuc.Size = new Size(812, 346);
            dgvDanhmuc.TabIndex = 34;
            // 
            // txbSoluong
            // 
            txbSoluong.Location = new Point(390, 66);
            txbSoluong.Name = "txbSoluong";
            txbSoluong.Size = new Size(109, 27);
            txbSoluong.TabIndex = 23;
            txbSoluong.Text = "2";
            // 
            // tbxDichvu
            // 
            tbxDichvu.Location = new Point(624, 26);
            tbxDichvu.Name = "tbxDichvu";
            tbxDichvu.Size = new Size(178, 27);
            tbxDichvu.TabIndex = 21;
            tbxDichvu.Text = "Ăn sáng";
            // 
            // txbNgaysudung
            // 
            txbNgaysudung.Location = new Point(141, 70);
            txbNgaysudung.Name = "txbNgaysudung";
            txbNgaysudung.Size = new Size(127, 27);
            txbNgaysudung.TabIndex = 24;
            txbNgaysudung.Text = "12/09/2026";
            // 
            // tbxPhong
            // 
            tbxPhong.Location = new Point(390, 23);
            tbxPhong.Name = "tbxPhong";
            tbxPhong.Size = new Size(109, 27);
            tbxPhong.TabIndex = 22;
            tbxPhong.Text = "A101";
            // 
            // tbxPhieuluutru
            // 
            tbxPhieuluutru.Location = new Point(141, 26);
            tbxPhieuluutru.Name = "tbxPhieuluutru";
            tbxPhieuluutru.Size = new Size(127, 27);
            tbxPhieuluutru.TabIndex = 25;
            tbxPhieuluutru.Text = "DP001";
            // 
            // lblDichvu
            // 
            lblDichvu.AutoSize = true;
            lblDichvu.Location = new Point(534, 29);
            lblDichvu.Name = "lblDichvu";
            lblDichvu.Size = new Size(61, 20);
            lblDichvu.TabIndex = 29;
            lblDichvu.Text = "Dịch vụ:";
            // 
            // lblTiennghi
            // 
            lblTiennghi.AutoSize = true;
            lblTiennghi.Location = new Point(311, 69);
            lblTiennghi.Name = "lblTiennghi";
            lblTiennghi.Size = new Size(72, 20);
            lblTiennghi.TabIndex = 31;
            lblTiennghi.Text = "Số lượng:";
            // 
            // lblNgaysudung
            // 
            lblNgaysudung.AutoSize = true;
            lblNgaysudung.Location = new Point(36, 73);
            lblNgaysudung.Name = "lblNgaysudung";
            lblNgaysudung.Size = new Size(104, 20);
            lblNgaysudung.TabIndex = 30;
            lblNgaysudung.Text = "Ngày sử dụng:";
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(311, 26);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(54, 20);
            lblPhong.TabIndex = 33;
            lblPhong.Text = "Phòng:";
            // 
            // lblPhieuluutru
            // 
            lblPhieuluutru.AutoSize = true;
            lblPhieuluutru.Location = new Point(33, 30);
            lblPhieuluutru.Name = "lblPhieuluutru";
            lblPhieuluutru.Size = new Size(95, 20);
            lblPhieuluutru.TabIndex = 32;
            lblPhieuluutru.Text = "Phiếu lưu trú:";
            // 
            // colSophieu
            // 
            colSophieu.HeaderText = "Số phiếu";
            colSophieu.MinimumWidth = 6;
            colSophieu.Name = "colSophieu";
            // 
            // colPhong
            // 
            colPhong.HeaderText = "Phòng";
            colPhong.MinimumWidth = 6;
            colPhong.Name = "colPhong";
            // 
            // colNgay
            // 
            colNgay.HeaderText = "Ngày";
            colNgay.MinimumWidth = 6;
            colNgay.Name = "colNgay";
            // 
            // colDichvu
            // 
            colDichvu.HeaderText = "Dịch vụ";
            colDichvu.MinimumWidth = 6;
            colDichvu.Name = "colDichvu";
            // 
            // colSoluong
            // 
            colSoluong.HeaderText = "Số lượng";
            colSoluong.MinimumWidth = 6;
            colSoluong.Name = "colSoluong";
            // 
            // colDongia
            // 
            colDongia.HeaderText = "Đơn giá";
            colDongia.MinimumWidth = 6;
            colDongia.Name = "colDongia";
            // 
            // colThanhtien
            // 
            colThanhtien.HeaderText = "Thành tiền";
            colThanhtien.MinimumWidth = 6;
            colThanhtien.Name = "colThanhtien";
            // 
            // FrmDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 493);
            Controls.Add(btnLapphieu);
            Controls.Add(dgvDanhmuc);
            Controls.Add(txbSoluong);
            Controls.Add(tbxDichvu);
            Controls.Add(txbNgaysudung);
            Controls.Add(tbxPhong);
            Controls.Add(tbxPhieuluutru);
            Controls.Add(lblDichvu);
            Controls.Add(lblTiennghi);
            Controls.Add(lblNgaysudung);
            Controls.Add(lblPhong);
            Controls.Add(lblPhieuluutru);
            Name = "FrmDichVu";
            Text = "Sử dụng dịch vụ";
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLapphieu;
        private DataGridView dgvDanhmuc;
        private TextBox textBox1;
        private TextBox txbSoluong;
        private TextBox tbxDichvu;
        private TextBox txbNgaysudung;
        private TextBox tbxPhong;
        private TextBox tbxPhieuluutru;
        private Label label1;
        private Label lblDichvu;
        private Label lblTiennghi;
        private Label lblNgaysudung;
        private Label lblPhong;
        private Label lblPhieuluutru;
        private DataGridViewTextBoxColumn colSophieu;
        private DataGridViewTextBoxColumn colPhong;
        private DataGridViewTextBoxColumn colNgay;
        private DataGridViewTextBoxColumn colDichvu;
        private DataGridViewTextBoxColumn colSoluong;
        private DataGridViewTextBoxColumn colDongia;
        private DataGridViewTextBoxColumn colThanhtien;
    }
}