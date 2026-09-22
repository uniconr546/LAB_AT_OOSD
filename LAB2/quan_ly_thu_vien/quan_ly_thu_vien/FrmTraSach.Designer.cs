namespace quan_ly_thu_vien
{
    partial class FrmTraSach
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
            btnTim = new Button();
            textBox2 = new TextBox();
            lblDocGia = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colChon = new DataGridViewTextBoxColumn();
            colMaSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colNgayMuon = new DataGridViewTextBoxColumn();
            colNgayTra = new DataGridViewTextBoxColumn();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTim
            // 
            btnTim.Location = new Point(819, 91);
            btnTim.Margin = new Padding(4, 3, 4, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(66, 32);
            btnTim.TabIndex = 13;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 91);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 27);
            textBox2.TabIndex = 12;
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocGia.Location = new Point(267, 93);
            lblDocGia.Margin = new Padding(4, 0, 4, 0);
            lblDocGia.MinimumSize = new Size(165, 24);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(165, 28);
            lblDocGia.TabIndex = 11;
            lblDocGia.Text = "Mã Độc Giả";
            lblDocGia.TextAlign = ContentAlignment.TopCenter;
            lblDocGia.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-2, -1);
            label2.Name = "label2";
            label2.Size = new Size(1182, 70);
            label2.TabIndex = 14;
            label2.Text = "TRẢ SÁCH";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 140);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 27);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MinimumSize = new Size(165, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 15;
            label1.Text = "Họ Tên";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colChon, colMaSach, colTenSach, colNgayMuon, colNgayTra });
            dataGridView1.Location = new Point(303, 196);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(582, 260);
            dataGridView1.TabIndex = 17;
            // 
            // colChon
            // 
            colChon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colChon.DataPropertyName = "Chon";
            colChon.FillWeight = 12F;
            colChon.HeaderText = "Chọn";
            colChon.MinimumWidth = 6;
            colChon.Name = "colChon";
            colChon.ReadOnly = true;
            colChon.Width = 80;
            // 
            // colMaSach
            // 
            colMaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMaSach.DataPropertyName = "MaSach";
            colMaSach.HeaderText = "Mã Sách";
            colMaSach.MinimumWidth = 6;
            colMaSach.Name = "colMaSach";
            colMaSach.ReadOnly = true;
            colMaSach.Width = 130;
            // 
            // colTenSach
            // 
            colTenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.HeaderText = "Tên Sách ";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            colTenSach.Width = 130;
            // 
            // colNgayMuon
            // 
            colNgayMuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgayMuon.DataPropertyName = "NgayMuon";
            colNgayMuon.HeaderText = "Ngày Mượn";
            colNgayMuon.MinimumWidth = 6;
            colNgayMuon.Name = "colNgayMuon";
            colNgayMuon.ReadOnly = true;
            colNgayMuon.Width = 130;
            // 
            // colNgayTra
            // 
            colNgayTra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgayTra.DataPropertyName = "NgayTra";
            colNgayTra.HeaderText = "Ngày Trả";
            colNgayTra.MinimumWidth = 6;
            colNgayTra.Name = "colNgayTra";
            colNgayTra.ReadOnly = true;
            colNgayTra.Width = 110;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(444, 480);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(441, 27);
            dateTimePicker2.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(306, 479);
            label4.MinimumSize = new Size(120, 22);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 18;
            label4.Text = "Ngày Trả";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(320, 536);
            label6.MinimumSize = new Size(120, 22);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 20;
            label6.Text = "Trạng Thái Thẻ";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.UseCompatibleTextRendering = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(484, 533);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(401, 30);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Bình Thường";
            // 
            // button1
            // 
            button1.Location = new Point(389, 596);
            button1.Name = "button1";
            button1.Size = new Size(242, 29);
            button1.TabIndex = 22;
            button1.Text = "Xác Nhận Trả";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(648, 596);
            button2.Name = "button2";
            button2.Size = new Size(163, 29);
            button2.TabIndex = 22;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmTraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnTim);
            Controls.Add(textBox2);
            Controls.Add(lblDocGia);
            Name = "FrmTraSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTraSach";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTim;
        private TextBox textBox2;
        private Label lblDocGia;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colChon;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colNgayTra;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}