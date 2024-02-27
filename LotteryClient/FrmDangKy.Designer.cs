namespace LotteryClient
{
    partial class FrmDangKy
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
            groupBox1 = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            txtSoDT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtHoten = new TextBox();
            label3 = new Label();
            cmdDangKy = new Button();
            lblCaption = new Label();
            cmdThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 146);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin người chơi";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            dtpNgaySinh.Checked = false;
            dtpNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.ImeMode = ImeMode.NoControl;
            dtpNgaySinh.Location = new Point(130, 66);
            dtpNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.ShowUpDown = true;
            dtpNgaySinh.Size = new Size(107, 25);
            dtpNgaySinh.TabIndex = 2;
            // 
            // txtSoDT
            // 
            txtSoDT.BackColor = SystemColors.ControlLightLight;
            txtSoDT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDT.Location = new Point(130, 100);
            txtSoDT.MaxLength = 10;
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(272, 25);
            txtSoDT.TabIndex = 3;
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
            txtHoten.MaxLength = 100;
            txtHoten.Name = "txtHoten";
            txtHoten.RightToLeft = RightToLeft.No;
            txtHoten.Size = new Size(272, 25);
            txtHoten.TabIndex = 1;
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
            // cmdDangKy
            // 
            cmdDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmdDangKy.Location = new Point(223, 203);
            cmdDangKy.Name = "cmdDangKy";
            cmdDangKy.Size = new Size(92, 27);
            cmdDangKy.TabIndex = 8;
            cmdDangKy.Text = "Đăng &Ký";
            cmdDangKy.UseVisualStyleBackColor = true;
            cmdDangKy.Click += cmdDangKy_Click;
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaption.ForeColor = Color.DodgerBlue;
            lblCaption.Location = new Point(142, 9);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(133, 41);
            lblCaption.TabIndex = 7;
            lblCaption.Text = "Đăng Ký";
            lblCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdThoat
            // 
            cmdThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmdThoat.Location = new Point(321, 203);
            cmdThoat.Name = "cmdThoat";
            cmdThoat.Size = new Size(92, 27);
            cmdThoat.TabIndex = 13;
            cmdThoat.Text = "&Thoát";
            cmdThoat.UseVisualStyleBackColor = true;
            cmdThoat.Click += cmdThoat_Click;
            // 
            // FrmDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 236);
            Controls.Add(cmdThoat);
            Controls.Add(groupBox1);
            Controls.Add(cmdDangKy);
            Controls.Add(lblCaption);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANG KY";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSoDT;
        private Label label5;
        private Label label4;
        private TextBox txtHoten;
        private Label label3;
        private Button cmdDangKy;
        private Label lblCaption;
        private DateTimePicker dtpNgaySinh;
        private Button cmdThoat;
    }
}