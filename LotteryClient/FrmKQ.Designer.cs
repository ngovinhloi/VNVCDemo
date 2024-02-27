namespace LotteryClient
{
    partial class FrmKQ
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
            lblCaption = new Label();
            dgvicTickedLotteryUser = new DataGridView();
            col0 = new DataGridViewTextBoxColumn();
            col1 = new DataGridViewTextBoxColumn();
            col4 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            cmdThoat = new Button();
            label3 = new Label();
            lblTenNguoiMua = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvicTickedLotteryUser).BeginInit();
            SuspendLayout();
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaption.ForeColor = Color.DodgerBlue;
            lblCaption.Location = new Point(202, 13);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(217, 41);
            lblCaption.TabIndex = 8;
            lblCaption.Text = "Kết Quả Xổ Số";
            lblCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvicTickedLotteryUser
            // 
            dgvicTickedLotteryUser.AllowUserToAddRows = false;
            dgvicTickedLotteryUser.AllowUserToDeleteRows = false;
            dgvicTickedLotteryUser.AllowUserToResizeColumns = false;
            dgvicTickedLotteryUser.AllowUserToResizeRows = false;
            dgvicTickedLotteryUser.BackgroundColor = SystemColors.ControlLightLight;
            dgvicTickedLotteryUser.BorderStyle = BorderStyle.Fixed3D;
            dgvicTickedLotteryUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvicTickedLotteryUser.Columns.AddRange(new DataGridViewColumn[] { col0, col1, col4, col2, col3 });
            dgvicTickedLotteryUser.Location = new Point(28, 93);
            dgvicTickedLotteryUser.Name = "dgvicTickedLotteryUser";
            dgvicTickedLotteryUser.ReadOnly = true;
            dgvicTickedLotteryUser.RowHeadersVisible = false;
            dgvicTickedLotteryUser.RowTemplate.Height = 25;
            dgvicTickedLotteryUser.Size = new Size(618, 254);
            dgvicTickedLotteryUser.TabIndex = 10;
            dgvicTickedLotteryUser.CellFormatting += dgvicTickedLotteryUser_CellFormatting;
            // 
            // col0
            // 
            col0.DataPropertyName = "Id";
            col0.HeaderText = "STT";
            col0.Name = "col0";
            col0.ReadOnly = true;
            col0.Visible = false;
            col0.Width = 50;
            // 
            // col1
            // 
            col1.DataPropertyName = "LotteryDate";
            col1.HeaderText = "Ngày Mua";
            col1.Name = "col1";
            col1.ReadOnly = true;
            col1.Width = 220;
            // 
            // col4
            // 
            col4.DataPropertyName = "Hour";
            dataGridViewCellStyle1.NullValue = null;
            col4.DefaultCellStyle = dataGridViewCellStyle1;
            col4.HeaderText = "Kỳ Xổ Lúc";
            col4.Name = "col4";
            col4.ReadOnly = true;
            col4.Width = 95;
            // 
            // col2
            // 
            col2.DataPropertyName = "NumberTicket";
            col2.HeaderText = "Vé Đã Mua";
            col2.Name = "col2";
            col2.ReadOnly = true;
            col2.Width = 150;
            // 
            // col3
            // 
            col3.DataPropertyName = "LotteryResult";
            col3.HeaderText = "Kết Quả Xổ Số";
            col3.Name = "col3";
            col3.ReadOnly = true;
            col3.Width = 150;
            // 
            // cmdThoat
            // 
            cmdThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmdThoat.Location = new Point(554, 366);
            cmdThoat.Name = "cmdThoat";
            cmdThoat.Size = new Size(92, 27);
            cmdThoat.TabIndex = 11;
            cmdThoat.Text = "&Thoát";
            cmdThoat.UseVisualStyleBackColor = true;
            cmdThoat.Click += cmdThoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 62);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 12;
            label3.Text = "Người Mua";
            // 
            // lblTenNguoiMua
            // 
            lblTenNguoiMua.AutoSize = true;
            lblTenNguoiMua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNguoiMua.Location = new Point(103, 60);
            lblTenNguoiMua.Name = "lblTenNguoiMua";
            lblTenNguoiMua.Size = new Size(0, 21);
            lblTenNguoiMua.TabIndex = 13;
            // 
            // FrmKQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 410);
            Controls.Add(lblTenNguoiMua);
            Controls.Add(label3);
            Controls.Add(cmdThoat);
            Controls.Add(dgvicTickedLotteryUser);
            Controls.Add(lblCaption);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKQ";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "KET QUA";
            Load += FrmKQ_Load;
            ((System.ComponentModel.ISupportInitialize)dgvicTickedLotteryUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaption;
        private DataGridView dgvicTickedLotteryUser;
        private Button cmdThoat;
        private Label label3;
        private Label lblTenNguoiMua;
        private DataGridViewTextBoxColumn col0;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
    }
}