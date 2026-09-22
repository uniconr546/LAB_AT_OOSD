namespace quan_ly_thu_vien
{
    partial class FrmTheThuVien
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
            label1 = new Label();
            lblTiltle = new Label();
            lblMaThe = new Label();
            tbxMaThe = new TextBox();
            lblDocGia = new Label();
            textBox2 = new TextBox();
            btnTim = new Button();
            label2 = new Label();
            tbxHoTen = new TextBox();
            lblHoTen = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            colMaThe = new DataGridViewTextBoxColumn();
            colDocGia = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgayCap = new DataGridViewTextBoxColumn();
            colHanSuDung = new DataGridViewTextBoxColumn();
            colDaDongPhi = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // lblTiltle
            // 
            lblTiltle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiltle.Location = new Point(-237, 360);
            lblTiltle.Margin = new Padding(4, 0, 4, 0);
            lblTiltle.Name = "lblTiltle";
            lblTiltle.Size = new Size(0, 0);
            lblTiltle.TabIndex = 1;
            lblTiltle.Text = "QUẢN LÝ THẺ THƯ VIỆN";
            lblTiltle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaThe
            // 
            lblMaThe.AutoSize = true;
            lblMaThe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaThe.Location = new Point(23, 119);
            lblMaThe.Margin = new Padding(4, 0, 4, 0);
            lblMaThe.MinimumSize = new Size(165, 24);
            lblMaThe.Name = "lblMaThe";
            lblMaThe.Size = new Size(165, 28);
            lblMaThe.TabIndex = 3;
            lblMaThe.Text = "Mã Thẻ";
            lblMaThe.TextAlign = ContentAlignment.TopCenter;
            lblMaThe.UseCompatibleTextRendering = true;
            lblMaThe.Click += lblMaDocGia_Click;
            // 
            // tbxMaThe
            // 
            tbxMaThe.Location = new Point(152, 118);
            tbxMaThe.Margin = new Padding(4, 3, 4, 3);
            tbxMaThe.Name = "tbxMaThe";
            tbxMaThe.Size = new Size(301, 30);
            tbxMaThe.TabIndex = 4;
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocGia.Location = new Point(23, 190);
            lblDocGia.Margin = new Padding(4, 0, 4, 0);
            lblDocGia.MinimumSize = new Size(165, 24);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(165, 28);
            lblDocGia.TabIndex = 3;
            lblDocGia.Text = "Độc Giả";
            lblDocGia.TextAlign = ContentAlignment.TopCenter;
            lblDocGia.UseCompatibleTextRendering = true;
            lblDocGia.Click += lblMaDocGia_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 188);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 30);
            textBox2.TabIndex = 4;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(387, 185);
            btnTim.Margin = new Padding(4, 3, 4, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(66, 32);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 9);
            label2.Name = "label2";
            label2.Size = new Size(1182, 70);
            label2.TabIndex = 6;
            label2.Text = "QUẢN LÝ THẺ THƯ VIỆN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxHoTen
            // 
            tbxHoTen.Location = new Point(155, 251);
            tbxHoTen.Name = "tbxHoTen";
            tbxHoTen.Size = new Size(298, 30);
            tbxHoTen.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(45, 253);
            lblHoTen.MinimumSize = new Size(120, 22);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(120, 28);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ Tên";
            lblHoTen.TextAlign = ContentAlignment.TopCenter;
            lblHoTen.UseCompatibleTextRendering = true;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 315);
            label3.MinimumSize = new Size(120, 22);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 7;
            label3.Text = "Ngày Cấp";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseCompatibleTextRendering = true;
            label3.Click += lblHoTen_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 30);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 376);
            label4.MinimumSize = new Size(120, 22);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 7;
            label4.Text = "Hạn Sử Dụng";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseCompatibleTextRendering = true;
            label4.Click += lblHoTen_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(203, 376);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 30);
            dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 438);
            label5.MinimumSize = new Size(120, 22);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 7;
            label5.Text = "Đã Đóng Phí";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseCompatibleTextRendering = true;
            label5.Click += lblHoTen_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(203, 438);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(56, 30);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Có";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 501);
            label6.MinimumSize = new Size(120, 22);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 7;
            label6.Text = "Trạng Thái";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.UseCompatibleTextRendering = true;
            label6.Click += lblHoTen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(180, 501);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 11;
            button1.Text = "Còn Hiệu Lực";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(68, 569);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 11;
            button2.Text = "Cấp Thẻ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 569);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 11;
            button3.Text = "Gia Hạn";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(347, 569);
            button4.Name = "button4";
            button4.Size = new Size(106, 29);
            button4.TabIndex = 11;
            button4.Text = "Làm Mới";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(752, 107);
            label7.MinimumSize = new Size(120, 22);
            label7.Name = "label7";
            label7.Size = new Size(172, 28);
            label7.TabIndex = 7;
            label7.Text = "DANH SÁCH THẺ";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.UseCompatibleTextRendering = true;
            label7.Click += lblHoTen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaThe, colDocGia, colHoTen, colNgayCap, colHanSuDung, colDaDongPhi, colTrangThai });
            dataGridView1.Location = new Point(460, 149);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(710, 449);
            dataGridView1.TabIndex = 12;
            // 
            // colMaThe
            // 
            colMaThe.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMaThe.DataPropertyName = "MaThe";
            colMaThe.FillWeight = 12F;
            colMaThe.HeaderText = "Mã Thẻ";
            colMaThe.MinimumWidth = 6;
            colMaThe.Name = "colMaThe";
            colMaThe.ReadOnly = true;
            colMaThe.Width = 80;
            // 
            // colDocGia
            // 
            colDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDocGia.DataPropertyName = "DocGia";
            colDocGia.HeaderText = "Độc Giả";
            colDocGia.MinimumWidth = 6;
            colDocGia.Name = "colDocGia";
            colDocGia.ReadOnly = true;
            colDocGia.Width = 130;
            // 
            // colHoTen
            // 
            colHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            colHoTen.Width = 90;
            // 
            // colNgayCap
            // 
            colNgayCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgayCap.DataPropertyName = "NgayCap";
            colNgayCap.HeaderText = "Ngày Cấp";
            colNgayCap.MinimumWidth = 6;
            colNgayCap.Name = "colNgayCap";
            colNgayCap.ReadOnly = true;
            colNgayCap.Width = 70;
            // 
            // colHanSuDung
            // 
            colHanSuDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHanSuDung.DataPropertyName = "HanSuDung";
            colHanSuDung.HeaderText = "Hạn Sử Dụng";
            colHanSuDung.MinimumWidth = 6;
            colHanSuDung.Name = "colHanSuDung";
            colHanSuDung.ReadOnly = true;
            colHanSuDung.Width = 110;
            // 
            // colDaDongPhi
            // 
            colDaDongPhi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDaDongPhi.DataPropertyName = "DaDongPhi";
            colDaDongPhi.HeaderText = "Đã Đóng Phí";
            colDaDongPhi.MinimumWidth = 6;
            colDaDongPhi.Name = "colDaDongPhi";
            colDaDongPhi.ReadOnly = true;
            colDaDongPhi.Width = 125;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 125;
            // 
            // FrmTheThuVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbxHoTen);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lblHoTen);
            Controls.Add(label2);
            Controls.Add(btnTim);
            Controls.Add(textBox2);
            Controls.Add(tbxMaThe);
            Controls.Add(lblDocGia);
            Controls.Add(lblMaThe);
            Controls.Add(lblTiltle);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmTheThuVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTheThuVien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTiltle;
        private Label lblMaThe;
        private TextBox tbxMaThe;
        private Label lblDocGia;
        private TextBox textBox2;
        private Button btnTim;
        private Label label2;
        private TextBox tbxHoTen;
        private Label lblHoTen;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaThe;
        private DataGridViewTextBoxColumn colDocGia;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgayCap;
        private DataGridViewTextBoxColumn colHanSuDung;
        private DataGridViewTextBoxColumn colDaDongPhi;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}