namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
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
            lblKhuvuc = new Label();
            lblNhanvien = new Label();
            lblLoaitiennghi = new Label();
            lblDichvu = new Label();
            label4 = new Label();
            lblMa = new Label();
            textBox1 = new TextBox();
            lblTen = new Label();
            tbxAnsang = new TextBox();
            lblDonviVaitro = new Label();
            tbxSuat = new TextBox();
            button1 = new Button();
            dgvDanhmuc = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colLoaiVairo = new DataGridViewTextBoxColumn();
            colDonvi = new DataGridViewTextBoxColumn();
            colDongiaMuc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).BeginInit();
            SuspendLayout();
            // 
            // lblKhuvuc
            // 
            lblKhuvuc.AutoSize = true;
            lblKhuvuc.Location = new Point(12, 25);
            lblKhuvuc.Name = "lblKhuvuc";
            lblKhuvuc.Size = new Size(79, 20);
            lblKhuvuc.TabIndex = 1;
            lblKhuvuc.Text = "[ Khu vực ]";
            // 
            // lblNhanvien
            // 
            lblNhanvien.AutoSize = true;
            lblNhanvien.Location = new Point(86, 25);
            lblNhanvien.Name = "lblNhanvien";
            lblNhanvien.Size = new Size(93, 20);
            lblNhanvien.TabIndex = 1;
            lblNhanvien.Text = "[ Nhân viên ]";
            // 
            // lblLoaitiennghi
            // 
            lblLoaitiennghi.AutoSize = true;
            lblLoaitiennghi.Location = new Point(174, 25);
            lblLoaitiennghi.Name = "lblLoaitiennghi";
            lblLoaitiennghi.Size = new Size(117, 20);
            lblLoaitiennghi.TabIndex = 1;
            lblLoaitiennghi.Text = "[ Loại tiện nghi ]";
            // 
            // lblDichvu
            // 
            lblDichvu.AutoSize = true;
            lblDichvu.Location = new Point(285, 25);
            lblDichvu.Name = "lblDichvu";
            lblDichvu.Size = new Size(76, 20);
            lblDichvu.TabIndex = 1;
            lblDichvu.Text = "[ Dịch vụ ]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 25);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 1;
            label4.Text = "[ Quy định đền bù  ]";
            label4.Click += label4_Click;
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(12, 61);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(37, 20);
            lblMa.TabIndex = 1;
            lblMa.Text = "Mã: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "DV01";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(241, 61);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(35, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên:";
            // 
            // tbxAnsang
            // 
            tbxAnsang.Location = new Point(315, 58);
            tbxAnsang.Name = "tbxAnsang";
            tbxAnsang.Size = new Size(125, 27);
            tbxAnsang.TabIndex = 0;
            tbxAnsang.Text = "Ăn sáng";
            // 
            // lblDonviVaitro
            // 
            lblDonviVaitro.AutoSize = true;
            lblDonviVaitro.Location = new Point(456, 61);
            lblDonviVaitro.Name = "lblDonviVaitro";
            lblDonviVaitro.Size = new Size(112, 20);
            lblDonviVaitro.TabIndex = 1;
            lblDonviVaitro.Text = "Đơn vị / Vai trò:";
            // 
            // tbxSuat
            // 
            tbxSuat.Location = new Point(571, 58);
            tbxSuat.Name = "tbxSuat";
            tbxSuat.Size = new Size(125, 27);
            tbxSuat.TabIndex = 0;
            tbxSuat.Text = "Suất";
            // 
            // button1
            // 
            button1.Location = new Point(702, 58);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            dgvDanhmuc.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen, colLoaiVairo, colDonvi, colDongiaMuc });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhmuc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhmuc.Location = new Point(12, 113);
            dgvDanhmuc.Name = "dgvDanhmuc";
            dgvDanhmuc.RowHeadersVisible = false;
            dgvDanhmuc.RowHeadersWidth = 51;
            dgvDanhmuc.Size = new Size(773, 267);
            dgvDanhmuc.TabIndex = 3;
            dgvDanhmuc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMa
            // 
            colMa.HeaderText = "Mã";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            // 
            // colTen
            // 
            colTen.HeaderText = "Tên";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            // 
            // colLoaiVairo
            // 
            colLoaiVairo.HeaderText = "Loại / Vai trò";
            colLoaiVairo.MinimumWidth = 6;
            colLoaiVairo.Name = "colLoaiVairo";
            // 
            // colDonvi
            // 
            colDonvi.HeaderText = "Đơn vị";
            colDonvi.MinimumWidth = 6;
            colDonvi.Name = "colDonvi";
            // 
            // colDongiaMuc
            // 
            colDongiaMuc.HeaderText = "Đơn vị / Mức";
            colDongiaMuc.MinimumWidth = 6;
            colDongiaMuc.Name = "colDongiaMuc";
            // 
            // FrmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDanhmuc);
            Controls.Add(button1);
            Controls.Add(tbxSuat);
            Controls.Add(tbxAnsang);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(lblDichvu);
            Controls.Add(lblDonviVaitro);
            Controls.Add(lblLoaitiennghi);
            Controls.Add(lblTen);
            Controls.Add(lblNhanvien);
            Controls.Add(lblMa);
            Controls.Add(lblKhuvuc);
            Name = "FrmDanhMuc";
            Text = "Danh mục khách sạn";
            ((System.ComponentModel.ISupportInitialize)dgvDanhmuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKhuvuc;
        private Label lblNhanvien;
        private Label lblLoaitiennghi;
        private Label lblDichvu;
        private Label label4;
        private Label lblMa;
        private TextBox textBox1;
        private Label lblTen;
        private TextBox tbxAnsang;
        private Label lblDonviVaitro;
        private TextBox tbxSuat;
        private Button button1;
        private DataGridView dgvDanhmuc;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colLoaiVairo;
        private DataGridViewTextBoxColumn colDonvi;
        private DataGridViewTextBoxColumn colDongiaMuc;
    }
}