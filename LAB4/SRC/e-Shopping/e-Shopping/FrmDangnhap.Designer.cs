namespace e_Shopping
{
    partial class FrmDangnhap
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
            panel1 = new Panel();
            lblDangNhap = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblDangKy = new Label();
            btnDangNhap = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(lblTenDangNhap);
            panel1.Controls.Add(lblDangKy);
            panel1.Controls.Add(lblDangNhap);
            panel1.Location = new Point(246, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 422);
            panel1.TabIndex = 0;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Location = new Point(206, 30);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(82, 20);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "Đăng nhập";
            lblDangNhap.Click += label1_Click;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(66, 88);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(107, 20);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            lblTenDangNhap.Click += label1_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(66, 111);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(395, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(66, 192);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật khẩu";
            lblMatKhau.Click += label1_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(66, 215);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(395, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Location = new Point(87, 352);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(139, 20);
            lblDangKy.TabIndex = 0;
            lblDangKy.Text = "Chưa có tài khoản ?";
            lblDangKy.Click += label1_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(66, 276);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(395, 29);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangKy_Click;
            // 
            // button1
            // 
            button1.Location = new Point(232, 348);
            button1.Name = "button1";
            button1.Size = new Size(229, 29);
            button1.TabIndex = 2;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDangKy_Click;
            // 
            // FrmDangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 610);
            Controls.Add(panel1);
            Name = "FrmDangnhap";
            Text = "FrmDangnhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Button btnDangNhap;
        private Label lblDangKy;
        private Button button1;
    }
}