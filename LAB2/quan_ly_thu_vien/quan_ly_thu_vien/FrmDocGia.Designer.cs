namespace quan_ly_thu_vien
{
    partial class FrmDocGia
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
            lblTiltle = new Label();
            lblMaDocGia = new Label();
            tbxMaDocGia = new TextBox();
            lblHoTen = new Label();
            tbxHoTen = new TextBox();
            lblNgaySinh = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblPhai = new Label();
            comboBox1 = new ComboBox();
            lblSDT = new Label();
            tbxSDT = new TextBox();
            lblDiaChi = new Label();
            tbxDiaChi = new TextBox();
            lblemail = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            lbl3x4 = new Label();
            btnChonAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            dataGridView1 = new DataGridView();
            colMaDocGia = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colPhai = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTiltle
            // 
            lblTiltle.Dock = DockStyle.Top;
            lblTiltle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiltle.Location = new Point(0, 0);
            lblTiltle.Name = "lblTiltle";
            lblTiltle.Size = new Size(1182, 70);
            lblTiltle.TabIndex = 1;
            lblTiltle.Text = "QUẢN LÝ ĐỘC GIẢ ";
            lblTiltle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaDocGia
            // 
            lblMaDocGia.AutoSize = true;
            lblMaDocGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaDocGia.Location = new Point(38, 107);
            lblMaDocGia.MinimumSize = new Size(120, 22);
            lblMaDocGia.Name = "lblMaDocGia";
            lblMaDocGia.Size = new Size(120, 28);
            lblMaDocGia.TabIndex = 2;
            lblMaDocGia.Text = "Mã Độc Giả";
            lblMaDocGia.TextAlign = ContentAlignment.TopCenter;
            lblMaDocGia.UseCompatibleTextRendering = true;
            lblMaDocGia.Click += label1_Click;
            // 
            // tbxMaDocGia
            // 
            tbxMaDocGia.Location = new Point(164, 105);
            tbxMaDocGia.Name = "tbxMaDocGia";
            tbxMaDocGia.Size = new Size(181, 27);
            tbxMaDocGia.TabIndex = 3;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(345, 107);
            lblHoTen.MinimumSize = new Size(120, 22);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(120, 28);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên";
            lblHoTen.TextAlign = ContentAlignment.TopCenter;
            lblHoTen.UseCompatibleTextRendering = true;
            lblHoTen.Click += label1_Click;
            // 
            // tbxHoTen
            // 
            tbxHoTen.Location = new Point(471, 105);
            tbxHoTen.Name = "tbxHoTen";
            tbxHoTen.Size = new Size(280, 27);
            tbxHoTen.TabIndex = 3;
            tbxHoTen.TextChanged += textBox2_TextChanged;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgaySinh.Location = new Point(757, 107);
            lblNgaySinh.MinimumSize = new Size(120, 22);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(120, 28);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày Sinh";
            lblNgaySinh.TextAlign = ContentAlignment.TopCenter;
            lblNgaySinh.UseCompatibleTextRendering = true;
            lblNgaySinh.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(883, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblPhai
            // 
            lblPhai.AutoSize = true;
            lblPhai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhai.ForeColor = SystemColors.ActiveCaptionText;
            lblPhai.Location = new Point(45, 180);
            lblPhai.MinimumSize = new Size(50, 22);
            lblPhai.Name = "lblPhai";
            lblPhai.Size = new Size(50, 22);
            lblPhai.TabIndex = 5;
            lblPhai.Text = "Phái";
            lblPhai.Click += label1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(65, 30);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Nam";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(177, 180);
            lblSDT.MinimumSize = new Size(120, 22);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(127, 28);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số Điện Thoại";
            lblSDT.TextAlign = ContentAlignment.TopCenter;
            lblSDT.UseCompatibleTextRendering = true;
            lblSDT.Click += label1_Click;
            // 
            // tbxSDT
            // 
            tbxSDT.Location = new Point(310, 178);
            tbxSDT.Name = "tbxSDT";
            tbxSDT.Size = new Size(181, 27);
            tbxSDT.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(477, 180);
            lblDiaChi.MinimumSize = new Size(120, 22);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(120, 28);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa Chỉ";
            lblDiaChi.TextAlign = ContentAlignment.TopCenter;
            lblDiaChi.UseCompatibleTextRendering = true;
            lblDiaChi.Click += label1_Click;
            // 
            // tbxDiaChi
            // 
            tbxDiaChi.Location = new Point(581, 178);
            tbxDiaChi.Name = "tbxDiaChi";
            tbxDiaChi.Size = new Size(215, 27);
            tbxDiaChi.TabIndex = 3;
            tbxDiaChi.TextChanged += textBox2_TextChanged;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.Location = new Point(792, 180);
            lblemail.MinimumSize = new Size(120, 22);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(120, 28);
            lblemail.TabIndex = 2;
            lblemail.Text = "Email";
            lblemail.TextAlign = ContentAlignment.TopCenter;
            lblemail.UseCompatibleTextRendering = true;
            lblemail.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(904, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 261);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbl3x4
            // 
            lbl3x4.AutoSize = true;
            lbl3x4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3x4.Location = new Point(69, 277);
            lbl3x4.MinimumSize = new Size(120, 22);
            lbl3x4.Name = "lbl3x4";
            lbl3x4.Size = new Size(120, 28);
            lbl3x4.TabIndex = 2;
            lbl3x4.Text = "Ảnh 3X4";
            lbl3x4.TextAlign = ContentAlignment.TopCenter;
            lbl3x4.UseCompatibleTextRendering = true;
            lbl3x4.Click += label1_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChonAnh.Location = new Point(262, 320);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(130, 29);
            btnChonAnh.TabIndex = 8;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(262, 366);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnChonAnh_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(262, 413);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnChonAnh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(262, 459);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnChonAnh_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(262, 501);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 29);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnChonAnh_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(262, 547);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(130, 29);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnChonAnh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaDocGia, colHoTen, colNgaySinh, colPhai, colSoDienThoai, colDiaChi, colEmail });
            dataGridView1.Location = new Point(444, 300);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(713, 321);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMaDocGia
            // 
            colMaDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMaDocGia.DataPropertyName = "MaDocGia";
            colMaDocGia.FillWeight = 12F;
            colMaDocGia.HeaderText = "Mã Độc Giả";
            colMaDocGia.MinimumWidth = 6;
            colMaDocGia.Name = "colMaDocGia";
            colMaDocGia.ReadOnly = true;
            colMaDocGia.Width = 80;
            // 
            // colHoTen
            // 
            colHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            colHoTen.Width = 130;
            // 
            // colNgaySinh
            // 
            colNgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            colNgaySinh.Width = 90;
            // 
            // colPhai
            // 
            colPhai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPhai.DataPropertyName = "Phai";
            colPhai.HeaderText = "Phái";
            colPhai.MinimumWidth = 6;
            colPhai.Name = "colPhai";
            colPhai.ReadOnly = true;
            colPhai.Width = 70;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colSoDienThoai.HeaderText = "Số Điện Thoại";
            colSoDienThoai.MinimumWidth = 6;
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            colSoDienThoai.Width = 110;
            // 
            // colDiaChi
            // 
            colDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            colDiaChi.Width = 125;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(707, 254);
            label1.MinimumSize = new Size(120, 22);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 2;
            label1.Text = "DANH SÁCH ĐỘC GIẢ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            label1.Click += label1_Click;
            // 
            // FrmDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dataGridView1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnChonAnh);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblPhai);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(tbxDiaChi);
            Controls.Add(tbxHoTen);
            Controls.Add(tbxSDT);
            Controls.Add(tbxMaDocGia);
            Controls.Add(lblemail);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblDiaChi);
            Controls.Add(lblSDT);
            Controls.Add(label1);
            Controls.Add(lbl3x4);
            Controls.Add(lblMaDocGia);
            Controls.Add(lblTiltle);
            MinimumSize = new Size(1200, 700);
            Name = "FrmDocGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDocGia";
            Load += this.FrmDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTiltle;
        private Label lblMaDocGia;
        private TextBox tbxMaDocGia;
        private Label lblHoTen;
        private TextBox tbxHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dateTimePicker1;
        private Label lblPhai;
        private ComboBox comboBox1;
        private Label lblSDT;
        private TextBox tbxSDT;
        private Label lblDiaChi;
        private TextBox tbxDiaChi;
        private Label lblemail;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label lbl3x4;
        private Button btnChonAnh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaDocGia;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colPhai;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colEmail;
        private Label label1;
    }
}