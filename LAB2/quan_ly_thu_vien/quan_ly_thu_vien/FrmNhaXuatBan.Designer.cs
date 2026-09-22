namespace quan_ly_thu_vien
{
    partial class FrmNhaXuatBan
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
            lblMaThe = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            colMaNXB = new DataGridViewTextBoxColumn();
            colTenNXB = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 0);
            label2.Name = "label2";
            label2.Size = new Size(1182, 70);
            label2.TabIndex = 7;
            label2.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaThe
            // 
            lblMaThe.AutoSize = true;
            lblMaThe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaThe.Location = new Point(235, 105);
            lblMaThe.Margin = new Padding(4, 0, 4, 0);
            lblMaThe.MinimumSize = new Size(165, 24);
            lblMaThe.Name = "lblMaThe";
            lblMaThe.Size = new Size(165, 28);
            lblMaThe.TabIndex = 8;
            lblMaThe.Text = "Mã NXB";
            lblMaThe.TextAlign = ContentAlignment.TopCenter;
            lblMaThe.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(440, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 158);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MinimumSize = new Size(165, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 8;
            label1.Text = "Tên NXB";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(440, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(455, 27);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(235, 209);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.MinimumSize = new Size(165, 24);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 8;
            label3.Text = "Địa Chỉ";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseCompatibleTextRendering = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(440, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(455, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(256, 254);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.MinimumSize = new Size(165, 24);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 8;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseCompatibleTextRendering = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(440, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(284, 27);
            textBox4.TabIndex = 9;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(830, 308);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(451, 308);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(642, 308);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(268, 308);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(518, 362);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.MinimumSize = new Size(165, 24);
            label5.Name = "label5";
            label5.Size = new Size(175, 28);
            label5.TabIndex = 8;
            label5.Text = "DANH SÁCH NXB";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaNXB, colTenNXB, colDiaChi, colSoDienThoai });
            dataGridView1.Location = new Point(304, 393);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(613, 248);
            dataGridView1.TabIndex = 19;
            // 
            // colMaNXB
            // 
            colMaNXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMaNXB.DataPropertyName = "MaNXB";
            colMaNXB.FillWeight = 12F;
            colMaNXB.HeaderText = "Mã NXB";
            colMaNXB.MinimumWidth = 6;
            colMaNXB.Name = "colMaNXB";
            colMaNXB.ReadOnly = true;
            colMaNXB.Width = 90;
            // 
            // colTenNXB
            // 
            colTenNXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTenNXB.DataPropertyName = "TenNXB";
            colTenNXB.HeaderText = "Tên NXB";
            colTenNXB.MinimumWidth = 6;
            colTenNXB.Name = "colTenNXB";
            colTenNXB.ReadOnly = true;
            colTenNXB.Width = 230;
            // 
            // colDiaChi
            // 
            colDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            colDiaChi.Width = 200;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colSoDienThoai.HeaderText = "Số Điện Thoại";
            colSoDienThoai.MinimumWidth = 6;
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            colSoDienThoai.Width = 90;
            // 
            // FrmNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dataGridView1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblMaThe);
            Controls.Add(label2);
            Name = "FrmNhaXuatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNhaXuatBan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblMaThe;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaNXB;
        private DataGridViewTextBoxColumn colTenNXB;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colSoDienThoai;
    }
}