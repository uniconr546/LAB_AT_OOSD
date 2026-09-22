namespace quan_ly_thu_vien
{
    partial class FrmPhieuPhat
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
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lblDocGia = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            colSach = new DataGridViewTextBoxColumn();
            colLyDo = new DataGridViewTextBoxColumn();
            colPhiPhat = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, -1);
            label2.Name = "label2";
            label2.Size = new Size(1182, 70);
            label2.TabIndex = 15;
            label2.Text = "PHIẾU PHẠT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(383, 585);
            button2.Name = "button2";
            button2.Size = new Size(163, 29);
            button2.TabIndex = 33;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(628, 585);
            button1.Name = "button1";
            button1.Size = new Size(242, 29);
            button1.TabIndex = 34;
            button1.Text = "Làm Mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(559, 232);
            label6.MinimumSize = new Size(120, 22);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 31;
            label6.Text = "Chi Tiết Phạt";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.UseCompatibleTextRendering = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(449, 102);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(458, 27);
            dateTimePicker2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 102);
            label4.MinimumSize = new Size(120, 22);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 29;
            label4.Text = "Ngày Phạt";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSach, colLyDo, colPhiPhat });
            dataGridView1.Location = new Point(291, 263);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(638, 260);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(449, 138);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 27);
            textBox1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MinimumSize = new Size(165, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 26;
            label1.Text = "Độc Giả";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(449, 61);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(458, 27);
            textBox2.TabIndex = 24;
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocGia.Location = new Point(289, 61);
            lblDocGia.Margin = new Padding(4, 0, 4, 0);
            lblDocGia.MinimumSize = new Size(165, 24);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(165, 28);
            lblDocGia.TabIndex = 23;
            lblDocGia.Text = "Mã Phiếu Phạt";
            lblDocGia.TextAlign = ContentAlignment.TopCenter;
            lblDocGia.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(269, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.MinimumSize = new Size(165, 24);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 26;
            label3.Text = "Nhân Viên";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseCompatibleTextRendering = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(449, 180);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(458, 27);
            textBox3.TabIndex = 27;
            // 
            // colSach
            // 
            colSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSach.DataPropertyName = "Sach";
            colSach.FillWeight = 12F;
            colSach.HeaderText = "Sách";
            colSach.MinimumWidth = 6;
            colSach.Name = "colSach";
            colSach.ReadOnly = true;
            // 
            // colLyDo
            // 
            colLyDo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLyDo.DataPropertyName = "LyDo";
            colLyDo.HeaderText = "Lý Do";
            colLyDo.MinimumWidth = 6;
            colLyDo.Name = "colLyDo";
            colLyDo.ReadOnly = true;
            // 
            // colPhiPhat
            // 
            colPhiPhat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPhiPhat.DataPropertyName = "PhiPhat";
            colPhiPhat.HeaderText = "Phí Phạt";
            colPhiPhat.MinimumWidth = 6;
            colPhiPhat.Name = "colPhiPhat";
            colPhiPhat.ReadOnly = true;
            colPhiPhat.Width = 130;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 539);
            label5.MinimumSize = new Size(120, 22);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 31;
            label5.Text = "Tổng Tiền Phạt";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseCompatibleTextRendering = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(449, 537);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(480, 27);
            textBox4.TabIndex = 27;
            // 
            // FrmPhieuPhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(lblDocGia);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmPhieuPhat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPhieuPhat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label lblDocGia;
        private Label label3;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn colSach;
        private DataGridViewTextBoxColumn colLyDo;
        private DataGridViewTextBoxColumn colPhiPhat;
        private Label label5;
        private TextBox textBox4;
    }
}