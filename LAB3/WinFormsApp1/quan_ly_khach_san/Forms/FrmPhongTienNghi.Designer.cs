namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
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
            dgvDanhmuc = new DataGridView();
            tbxSonguoitoida = new TextBox();
            tbxKhuvuc = new TextBox();
            tbxSophong = new TextBox();
            lblSonguoitoida = new Label();
            lblLapdatLuanchuyen = new Label();
            lblTiennghi = new Label();
            lblSophong = new Label();
            lblPhong = new Label();
            khuvuc = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            lblPhieulapdat = new Label();
            Tiennghi = new Label();
            Phong = new Label();
            lblTinhtrang = new Label();
            txbPhieulapdat = new TextBox();
            txbTiennghi = new TextBox();
            textBox4 = new TextBox();
            txbTinhtrang = new TextBox();
            colPhong = new DataGridViewTextBoxColumn();
            colKhu = new DataGridViewTextBoxColumn();
            colSuachua = new DataGridViewTextBoxColumn();
            colDongia = new DataGridViewTextBoxColumn();
            colTrangthai = new DataGridViewTextBoxColumn();
            btnLapphieu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).BeginInit();
            SuspendLayout();
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
            dgvDanhmuc.Columns.AddRange(new DataGridViewColumn[] { colPhong, colKhu, colSuachua, colDongia, colTrangthai });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDanhmuc.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhmuc.Location = new Point(12, 97);
            dgvDanhmuc.Name = "dgvDanhmuc";
            dgvDanhmuc.RowHeadersVisible = false;
            dgvDanhmuc.RowHeadersWidth = 51;
            dgvDanhmuc.Size = new Size(812, 257);
            dgvDanhmuc.TabIndex = 16;
            // 
            // tbxSonguoitoida
            // 
            tbxSonguoitoida.Location = new Point(538, 49);
            tbxSonguoitoida.Name = "tbxSonguoitoida";
            tbxSonguoitoida.Size = new Size(60, 27);
            tbxSonguoitoida.TabIndex = 4;
            tbxSonguoitoida.Text = "2";
            // 
            // tbxKhuvuc
            // 
            tbxKhuvuc.Location = new Point(284, 49);
            tbxKhuvuc.Name = "tbxKhuvuc";
            tbxKhuvuc.Size = new Size(109, 27);
            tbxKhuvuc.TabIndex = 5;
            tbxKhuvuc.Text = "Khu A";
            // 
            // tbxSophong
            // 
            tbxSophong.Location = new Point(86, 49);
            tbxSophong.Name = "tbxSophong";
            tbxSophong.Size = new Size(105, 27);
            tbxSophong.TabIndex = 6;
            tbxSophong.Text = "A101";
            // 
            // lblSonguoitoida
            // 
            lblSonguoitoida.AutoSize = true;
            lblSonguoitoida.Location = new Point(417, 52);
            lblSonguoitoida.Name = "lblSonguoitoida";
            lblSonguoitoida.Size = new Size(115, 20);
            lblSonguoitoida.TabIndex = 9;
            lblSonguoitoida.Text = "Số người tối đa:";
            lblSonguoitoida.Click += lblSonguoitoida_Click;
            // 
            // lblLapdatLuanchuyen
            // 
            lblLapdatLuanchuyen.AutoSize = true;
            lblLapdatLuanchuyen.Location = new Point(174, 14);
            lblLapdatLuanchuyen.Name = "lblLapdatLuanchuyen";
            lblLapdatLuanchuyen.Size = new Size(164, 20);
            lblLapdatLuanchuyen.TabIndex = 10;
            lblLapdatLuanchuyen.Text = "[ Lắp đặt/Luân chuyển ]";
            // 
            // lblTiennghi
            // 
            lblTiennghi.AutoSize = true;
            lblTiennghi.Location = new Point(86, 14);
            lblTiennghi.Name = "lblTiennghi";
            lblTiennghi.Size = new Size(88, 20);
            lblTiennghi.TabIndex = 12;
            lblTiennghi.Text = "[ Tiện nghi ]";
            // 
            // lblSophong
            // 
            lblSophong.AutoSize = true;
            lblSophong.Location = new Point(12, 52);
            lblSophong.Name = "lblSophong";
            lblSophong.Size = new Size(80, 20);
            lblSophong.TabIndex = 13;
            lblSophong.Text = "Số phòng: ";
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(12, 14);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(69, 20);
            lblPhong.TabIndex = 14;
            lblPhong.Text = "[ Phòng ]";
            // 
            // khuvuc
            // 
            khuvuc.AutoSize = true;
            khuvuc.Location = new Point(214, 52);
            khuvuc.Name = "khuvuc";
            khuvuc.Size = new Size(64, 20);
            khuvuc.TabIndex = 13;
            khuvuc.Text = "Khu vực:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(628, 52);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 9;
            label1.Text = "Đơn giá/ngày:";
            label1.Click += lblSonguoitoida_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(737, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "600000";
            // 
            // lblPhieulapdat
            // 
            lblPhieulapdat.AutoSize = true;
            lblPhieulapdat.Location = new Point(12, 373);
            lblPhieulapdat.Name = "lblPhieulapdat";
            lblPhieulapdat.Size = new Size(99, 20);
            lblPhieulapdat.TabIndex = 13;
            lblPhieulapdat.Text = "Phiếu lắp đặt:";
            lblPhieulapdat.Click += label2_Click;
            // 
            // Tiennghi
            // 
            Tiennghi.AutoSize = true;
            Tiennghi.Location = new Point(237, 373);
            Tiennghi.Name = "Tiennghi";
            Tiennghi.Size = new Size(73, 20);
            Tiennghi.TabIndex = 13;
            Tiennghi.Text = "Tiện nghi:";
            // 
            // Phong
            // 
            Phong.AutoSize = true;
            Phong.Location = new Point(451, 373);
            Phong.Name = "Phong";
            Phong.Size = new Size(54, 20);
            Phong.TabIndex = 9;
            Phong.Text = "Phòng:";
            Phong.Click += lblSonguoitoida_Click;
            // 
            // lblTinhtrang
            // 
            lblTinhtrang.AutoSize = true;
            lblTinhtrang.Location = new Point(640, 373);
            lblTinhtrang.Name = "lblTinhtrang";
            lblTinhtrang.Size = new Size(79, 20);
            lblTinhtrang.TabIndex = 9;
            lblTinhtrang.Text = "Tình trạng:";
            lblTinhtrang.Click += lblSonguoitoida_Click;
            // 
            // txbPhieulapdat
            // 
            txbPhieulapdat.Location = new Point(117, 370);
            txbPhieulapdat.Name = "txbPhieulapdat";
            txbPhieulapdat.Size = new Size(105, 27);
            txbPhieulapdat.TabIndex = 6;
            txbPhieulapdat.Text = "LD001";
            // 
            // txbTiennghi
            // 
            txbTiennghi.Location = new Point(316, 370);
            txbTiennghi.Name = "txbTiennghi";
            txbTiennghi.Size = new Size(109, 27);
            txbTiennghi.TabIndex = 5;
            txbTiennghi.Text = "TV01";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(520, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 27);
            textBox4.TabIndex = 4;
            textBox4.Text = "A101";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // txbTinhtrang
            // 
            txbTinhtrang.Location = new Point(737, 370);
            txbTinhtrang.Name = "txbTinhtrang";
            txbTinhtrang.Size = new Size(87, 27);
            txbTinhtrang.TabIndex = 4;
            txbTinhtrang.Text = "Tốt";
            // 
            // colPhong
            // 
            colPhong.HeaderText = "Phòng";
            colPhong.MinimumWidth = 6;
            colPhong.Name = "colPhong";
            // 
            // colKhu
            // 
            colKhu.HeaderText = "Khu";
            colKhu.MinimumWidth = 6;
            colKhu.Name = "colKhu";
            // 
            // colSuachua
            // 
            colSuachua.HeaderText = "Sửa chửa";
            colSuachua.MinimumWidth = 6;
            colSuachua.Name = "colSuachua";
            // 
            // colDongia
            // 
            colDongia.HeaderText = "Đơn giá";
            colDongia.MinimumWidth = 6;
            colDongia.Name = "colDongia";
            // 
            // colTrangthai
            // 
            colTrangthai.HeaderText = "Trạng thái";
            colTrangthai.MinimumWidth = 6;
            colTrangthai.Name = "colTrangthai";
            // 
            // btnLapphieu
            // 
            btnLapphieu.BackColor = SystemColors.ControlLight;
            btnLapphieu.Location = new Point(737, 403);
            btnLapphieu.Name = "btnLapphieu";
            btnLapphieu.Size = new Size(87, 29);
            btnLapphieu.TabIndex = 17;
            btnLapphieu.Text = "Lập phiếu";
            btnLapphieu.UseVisualStyleBackColor = false;
            // 
            // FrmPhongTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(btnLapphieu);
            Controls.Add(dgvDanhmuc);
            Controls.Add(txbTinhtrang);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(txbTiennghi);
            Controls.Add(tbxSonguoitoida);
            Controls.Add(txbPhieulapdat);
            Controls.Add(tbxKhuvuc);
            Controls.Add(tbxSophong);
            Controls.Add(lblTinhtrang);
            Controls.Add(Phong);
            Controls.Add(label1);
            Controls.Add(lblSonguoitoida);
            Controls.Add(lblLapdatLuanchuyen);
            Controls.Add(Tiennghi);
            Controls.Add(lblTiennghi);
            Controls.Add(lblPhieulapdat);
            Controls.Add(khuvuc);
            Controls.Add(lblSophong);
            Controls.Add(lblPhong);
            Name = "FrmPhongTienNghi";
            Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhmuc;
        private Button btnLapphieu;
        private TextBox tbxSonguoitoida;
        private TextBox tbxKhuvuc;
        private TextBox tbxSophong;
        private Label label4;
        private Label lblDichvu;
        private Label lblSonguoitoida;
        private Label lblLapdatLuanchuyen;
        private Label lblTen;
        private Label lblTiennghi;
        private Label lblSophong;
        private Label lblPhong;
        private Label khuvuc;
        private Label label1;
        private TextBox textBox1;
        private Label lblPhieulapdat;
        private Label Tiennghi;
        private Label Phong;
        private Label lblTinhtrang;
        private TextBox txbPhieulapdat;
        private TextBox txbTiennghi;
        private TextBox textBox4;
        private TextBox txbTinhtrang;
        private DataGridViewTextBoxColumn colPhong;
        private DataGridViewTextBoxColumn colKhu;
        private DataGridViewTextBoxColumn colSuachua;
        private DataGridViewTextBoxColumn colDongia;
        private DataGridViewTextBoxColumn colTrangthai;
    }
}