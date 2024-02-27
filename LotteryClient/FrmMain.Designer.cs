namespace LotteryClient
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnDangKy = new Button();
            groupBox1 = new GroupBox();
            btnDangNhap = new Button();
            txtNgaySinh = new TextBox();
            txtSoDT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtHoten = new TextBox();
            label3 = new Label();
            txtNhapSo = new TextBox();
            label2 = new Label();
            cmdChapNhan = new Button();
            cmdThoat = new Button();
            dgvLotteryUser = new DataGridView();
            col0 = new DataGridViewTextBoxColumn();
            col1 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotteryUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(218, 24);
            label1.Name = "label1";
            label1.Size = new Size(383, 41);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUAY SỐ";
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.Location = new Point(657, 247);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(92, 27);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng &Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(433, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 140);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người chơi";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(338, 100);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(92, 27);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng &Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.BackColor = SystemColors.ControlLightLight;
            txtNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgaySinh.Location = new Point(130, 68);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.ReadOnly = true;
            txtNgaySinh.RightToLeft = RightToLeft.No;
            txtNgaySinh.Size = new Size(202, 25);
            txtNgaySinh.TabIndex = 7;
            // 
            // txtSoDT
            // 
            txtSoDT.BackColor = SystemColors.ControlLightLight;
            txtSoDT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDT.Location = new Point(130, 100);
            txtSoDT.MaxLength = 10;
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(202, 25);
            txtSoDT.TabIndex = 8;
            txtSoDT.KeyPress += txtSoDT_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 104);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 72);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // txtHoten
            // 
            txtHoten.BackColor = SystemColors.ControlLightLight;
            txtHoten.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(130, 34);
            txtHoten.Name = "txtHoten";
            txtHoten.ReadOnly = true;
            txtHoten.RightToLeft = RightToLeft.No;
            txtHoten.Size = new Size(202, 25);
            txtHoten.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 35);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 0;
            label3.Text = "Họ tên";
            // 
            // txtNhapSo
            // 
            txtNhapSo.Enabled = false;
            txtNhapSo.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            txtNhapSo.ForeColor = Color.Red;
            txtNhapSo.Location = new Point(149, 104);
            txtNhapSo.MaxLength = 1;
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.PlaceholderText = "Nhập số từ 0 tới 9";
            txtNhapSo.Size = new Size(254, 38);
            txtNhapSo.TabIndex = 1;
            txtNhapSo.TextAlign = HorizontalAlignment.Center;
            txtNhapSo.KeyPress += txtNhapSo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 108);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 8;
            label2.Text = "Mua Vé Số";
            // 
            // cmdChapNhan
            // 
            cmdChapNhan.Enabled = false;
            cmdChapNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmdChapNhan.Location = new Point(149, 151);
            cmdChapNhan.Name = "cmdChapNhan";
            cmdChapNhan.Size = new Size(254, 42);
            cmdChapNhan.TabIndex = 2;
            cmdChapNhan.Text = "&Chấp Nhận";
            cmdChapNhan.UseVisualStyleBackColor = true;
            cmdChapNhan.Click += cmdChapNhan_Click;
            // 
            // cmdThoat
            // 
            cmdThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmdThoat.Location = new Point(771, 247);
            cmdThoat.Name = "cmdThoat";
            cmdThoat.Size = new Size(92, 27);
            cmdThoat.TabIndex = 5;
            cmdThoat.Text = "&Thoát";
            cmdThoat.UseVisualStyleBackColor = true;
            cmdThoat.Click += cmdThoat_Click;
            // 
            // dgvLotteryUser
            // 
            dgvLotteryUser.AllowUserToAddRows = false;
            dgvLotteryUser.AllowUserToDeleteRows = false;
            dgvLotteryUser.AllowUserToResizeColumns = false;
            dgvLotteryUser.AllowUserToResizeRows = false;
            dgvLotteryUser.BackgroundColor = SystemColors.ControlLightLight;
            dgvLotteryUser.BorderStyle = BorderStyle.Fixed3D;
            dgvLotteryUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLotteryUser.Columns.AddRange(new DataGridViewColumn[] { col0, col1, col2, col3 });
            dgvLotteryUser.Location = new Point(22, 247);
            dgvLotteryUser.Name = "dgvLotteryUser";
            dgvLotteryUser.ReadOnly = true;
            dgvLotteryUser.RowHeadersVisible = false;
            dgvLotteryUser.RowTemplate.Height = 25;
            dgvLotteryUser.Size = new Size(618, 254);
            dgvLotteryUser.TabIndex = 9;
            dgvLotteryUser.CellDoubleClick += dgvLotteryUser_CellDoubleClick;
            // 
            // col0
            // 
            col0.DataPropertyName = "Id";
            col0.HeaderText = "STT";
            col0.Name = "col0";
            col0.ReadOnly = true;
            col0.Width = 50;
            // 
            // col1
            // 
            col1.DataPropertyName = "Name";
            col1.HeaderText = "Ten";
            col1.Name = "col1";
            col1.ReadOnly = true;
            col1.Width = 255;
            // 
            // col2
            // 
            col2.DataPropertyName = "DateOfBD";
            col2.HeaderText = "Ngày Sinh";
            col2.Name = "col2";
            col2.ReadOnly = true;
            col2.Width = 150;
            // 
            // col3
            // 
            col3.DataPropertyName = "Phone";
            col3.HeaderText = "Phone";
            col3.Name = "col3";
            col3.ReadOnly = true;
            col3.Width = 160;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(22, 229);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 10;
            label6.Text = "DoubleClick cell để xem kết quả";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 522);
            Controls.Add(label6);
            Controls.Add(dgvLotteryUser);
            Controls.Add(cmdThoat);
            Controls.Add(cmdChapNhan);
            Controls.Add(label2);
            Controls.Add(txtNhapSo);
            Controls.Add(groupBox1);
            Controls.Add(btnDangKy);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONG TY XO SO CON GA TRONG";
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotteryUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDangKy;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnDangNhap;
        private Label label3;
        private TextBox txtSoDT;
        private Label label5;
        private Label label4;
        private TextBox txtHoten;
        private TextBox txtNgaySinh;
        private Button cmdChapNhan;
        private Button cmdThoat;
        public TextBox txtNhapSo;
        private DataGridView dgvLotteryUser;
        private DataGridViewTextBoxColumn col0;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private Label label6;
    }
}
