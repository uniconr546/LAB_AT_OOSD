namespace quan_ly_thu_vien
{
    partial class FrmTheLoai
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
            label2 = new Label();
            tbxMaThe = new TextBox();
            lblMaThe = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            colMaDocGia = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colPhai = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, -3);
            label2.Name = "label2";
            label2.Size = new Size(1182, 70);
            label2.TabIndex = 7;
            label2.Text = "QUẢN LÝ THỂ LOẠI";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxMaThe
            // 
            tbxMaThe.Location = new Point(473, 112);
            tbxMaThe.Margin = new Padding(4, 3, 4, 3);
            tbxMaThe.Name = "tbxMaThe";
            tbxMaThe.Size = new Size(360, 27);
            tbxMaThe.TabIndex = 10;
            // 
            // lblMaThe
            // 
            lblMaThe.AutoSize = true;
            lblMaThe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaThe.Location = new Point(246, 111);
            lblMaThe.Margin = new Padding(4, 0, 4, 0);
            lblMaThe.MinimumSize = new Size(165, 24);
            lblMaThe.Name = "lblMaThe";
            lblMaThe.Size = new Size(165, 28);
            lblMaThe.TabIndex = 9;
            lblMaThe.Text = "Mã Thể Loại";
            lblMaThe.TextAlign = ContentAlignment.TopCenter;
            lblMaThe.UseCompatibleTextRendering = true;
            lblMaThe.Click += lblMaThe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(246, 161);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.MinimumSize = new Size(165, 24);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 9;
            label4.Text = "Tên Thể Loại";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseCompatibleTextRendering = true;
            label4.Click += lblMaThe_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 162);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 27);
            textBox1.TabIndex = 10;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(829, 211);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 29);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(450, 211);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(641, 211);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(267, 211);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaDocGia, colHoTen, colNgaySinh, colPhai, colSoDienThoai, colDiaChi, colEmail });
            dataGridView1.Location = new Point(263, 320);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(713, 321);
            dataGridView1.TabIndex = 15;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(527, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.MinimumSize = new Size(165, 24);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 9;
            label5.Text = "Danh Sách Thể Loại";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseCompatibleTextRendering = true;
            label5.Click += lblMaThe_Click;
            // 
            // FrmTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dataGridView1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(tbxMaThe);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(lblMaThe);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "FrmTheLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTheLoai";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tbxMaThe;
        private Label lblMaThe;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaDocGia;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colPhai;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colEmail;
        private Label label5;
    }
}