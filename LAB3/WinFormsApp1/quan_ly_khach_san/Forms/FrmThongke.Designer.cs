namespace QuanLyKhachSan.Forms
{
    partial class FrmThongke
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
            btnLapphieu = new Button();
            dgvDanhmuc = new DataGridView();
            lblDenngay = new Label();
            lblTungay = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            colMaDV = new DataGridViewTextBoxColumn();
            colTendichvu = new DataGridViewTextBoxColumn();
            colTongsoluong = new DataGridViewTextBoxColumn();
            colTongtien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).BeginInit();
            SuspendLayout();
            // 
            // btnLapphieu
            // 
            btnLapphieu.BackColor = SystemColors.ControlLight;
            btnLapphieu.Location = new Point(720, 25);
            btnLapphieu.Name = "btnLapphieu";
            btnLapphieu.Size = new Size(125, 29);
            btnLapphieu.TabIndex = 47;
            btnLapphieu.Text = "Thống kê";
            btnLapphieu.UseVisualStyleBackColor = false;
            btnLapphieu.Click += btnLapphieu_Click;
            // 
            // dgvDanhmuc
            // 
            dgvDanhmuc.AllowUserToAddRows = false;
            dgvDanhmuc.AllowUserToDeleteRows = false;
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
            dgvDanhmuc.Columns.AddRange(new DataGridViewColumn[] { colMaDV, colTendichvu, colTongsoluong, colTongtien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhmuc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhmuc.Location = new Point(33, 230);
            dgvDanhmuc.Name = "dgvDanhmuc";
            dgvDanhmuc.RowHeadersVisible = false;
            dgvDanhmuc.RowHeadersWidth = 51;
            dgvDanhmuc.Size = new Size(812, 288);
            dgvDanhmuc.TabIndex = 46;
            // 
            // lblDenngay
            // 
            lblDenngay.AutoSize = true;
            lblDenngay.Location = new Point(380, 32);
            lblDenngay.Name = "lblDenngay";
            lblDenngay.Size = new Size(75, 20);
            lblDenngay.TabIndex = 43;
            lblDenngay.Text = "Đến ngày:";
            // 
            // lblTungay
            // 
            lblTungay.AutoSize = true;
            lblTungay.Location = new Point(33, 32);
            lblTungay.Name = "lblTungay";
            lblTungay.Size = new Size(65, 20);
            lblTungay.TabIndex = 42;
            lblTungay.Text = "Từ ngày:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(461, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(44, 76);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 42;
            label1.Text = "Phiếu đặt: 28";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(44, 122);
            label2.Name = "label2";
            label2.Size = new Size(100, 18);
            label2.TabIndex = 42;
            label2.Text = "Hóa đơn: 21";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(44, 164);
            label3.Name = "label3";
            label3.Size = new Size(198, 18);
            label3.TabIndex = 42;
            label3.Text = "Tổng đền bù: 2.100.000 đ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(450, 76);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 42;
            label4.Text = "Đang ở: 7";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(450, 122);
            label5.Name = "label5";
            label5.Size = new Size(206, 18);
            label5.TabIndex = 42;
            label5.Text = "Doanh thu HĐ: 52.600.000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 207);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 42;
            label6.Text = "Dịch vụ sử dụng:";
            // 
            // colMaDV
            // 
            colMaDV.HeaderText = "Mã DV";
            colMaDV.MinimumWidth = 6;
            colMaDV.Name = "colMaDV";
            // 
            // colTendichvu
            // 
            colTendichvu.HeaderText = "Tên dịch vụ";
            colTendichvu.MinimumWidth = 6;
            colTendichvu.Name = "colTendichvu";
            // 
            // colTongsoluong
            // 
            colTongsoluong.HeaderText = "Tổng số lượng";
            colTongsoluong.MinimumWidth = 6;
            colTongsoluong.Name = "colTongsoluong";
            // 
            // colTongtien
            // 
            colTongtien.HeaderText = "Tổng tiền";
            colTongtien.MinimumWidth = 6;
            colTongtien.Name = "colTongtien";
            // 
            // FrmThongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 545);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnLapphieu);
            Controls.Add(dgvDanhmuc);
            Controls.Add(lblDenngay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lblTungay);
            Name = "FrmThongke";
            Text = "Form1";
            Load += FrmThongke_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLapphieu;
        private DataGridView dgvDanhmuc;
        private Label lblDenngay;
        private Label lblTungay;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn colMaDV;
        private DataGridViewTextBoxColumn colTendichvu;
        private DataGridViewTextBoxColumn colTongsoluong;
        private DataGridViewTextBoxColumn colTongtien;
        private Label label6;
    }
}