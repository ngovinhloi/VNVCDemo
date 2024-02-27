using LotteryClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace LotteryClient
{
    public partial class FrmMain : Form
    {
        private Services _services;
        private LotteryUser CurrenLotteryUser;
        public FrmMain()
        {
            InitializeComponent();
            _services = new Services();
            CurrenLotteryUser = new LotteryUser();
        }

        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            getListLotteryUser();
        }

        /// <summary>
        /// cmdChapNhan_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cmdChapNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhapSo.Text.Trim()))
            {
                Utility.ShowMsgWarningOK("Vui lòng Chọn số trúng");
                return;
            }

            try
            {
                BookTicketLottery bookTicketLottery = new BookTicketLottery();
                DateTime date = DateTime.Now;
                DateTime dateTearm = date.AddHours(1);
                bookTicketLottery.LotteryDate = date; // date book
                bookTicketLottery.UserId = CurrenLotteryUser.Id;
                bookTicketLottery.Year = dateTearm.Year;
                bookTicketLottery.Month = dateTearm.Month;
                bookTicketLottery.Day = dateTearm.Day;
                bookTicketLottery.Hour = dateTearm.Hour;
                bookTicketLottery.NumberTicket = Convert.ToInt32(txtNhapSo.Text);
                bookTicketLottery.LotteryResult = "";
                this.Cursor = Cursors.WaitCursor;
                RestResponse response = await _services.AddBookTicketLottery(bookTicketLottery);

                this.Cursor = Cursors.Default;
                if (response != null && response.StatusCode != 0)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Utility.ShowMsgInforOK(string.Format("Bạn mua vé {0} cho kỳ sổ xố lúc {1}h vào ngày {2}.\nChúc ban mai mắn !",
                                                bookTicketLottery.NumberTicket,
                                                bookTicketLottery.Hour,
                                                bookTicketLottery.LotteryDate.Date.ToString("dd/MM/yyyy")));
                    }
                    else if (response.StatusCode == HttpStatusCode.UpgradeRequired)
                        Utility.ShowMsgWarningOK("Vé này bạn đã book");
                    else
                        Utility.ShowMsgWarningOK("Đăng ký không thành công");
                }
                else
                    Utility.ShowMsgErrorConnectServer();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// getListLotteryUser
        /// </summary>
        public async void getListLotteryUser()
        {
            this.Cursor = Cursors.WaitCursor;
            RestResponse response = await _services.GetAllLotteryUsers();

            this.Cursor = Cursors.Default;
            if (response != null && response.StatusCode != 0)
            {
                if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(response.Content))
                {
                    var data = JsonConvert.DeserializeObject<List<LotteryUser>>(response.Content);
                    if (data != null && data.Count > 0)
                        dgvLotteryUser.DataSource = data;
                }
            }
            else
                Utility.ShowMsgErrorConnectServer();
        }

        /// <summary>
        /// btnDangNhap_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoDT.Text))
            {
                Utility.ShowMsgWarningOK("Vui lòng nhâp SDT để đăng nhập");
                txtSoDT.Focus();
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                txtHoten.Text = string.Empty;
                txtNgaySinh.Text = string.Empty;
                RestResponse response = await _services.LoginLotteryUser(txtSoDT.Text);

                this.Cursor = Cursors.Default;
                if (response != null &&
                    response.StatusCode != 0 &&
                    !string.IsNullOrEmpty(response.Content))
                {
                    var lotteryUser = JsonConvert.DeserializeObject<LotteryUser>(response.Content);
                    if (lotteryUser != null && lotteryUser.Id > 0)
                    {
                        txtHoten.Text = lotteryUser.Name;
                        txtNgaySinh.Text = lotteryUser.DateOfBD.ToShortDateString();
                        txtNhapSo.Enabled = true;
                        cmdChapNhan.Enabled = true;
                        CurrenLotteryUser = lotteryUser;
                        Utility.ShowMsgInforOK(string.Format("Xin chào bạn {0}. Vui lòng chọn vé", txtHoten.Text));
                        txtNhapSo.Focus();
                    }
                    else
                        Utility.ShowMsgWarningOK("Số điện thoại này chưa được đăng ký");
                }
                else
                    Utility.ShowMsgErrorConnectServer();
            }
            catch (Exception)
            {
                Utility.ShowMsgErrorOK("Lỗi đăng nhập");
            }
        }

        /// <summary>
        /// btnDangKy_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frmdangky = new FrmDangKy(this);
            frmdangky.ShowDialog();
        }

        /// <summary>
        /// cmdThoat_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát không ?", "THONG BAO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// textBox1_KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!string.IsNullOrEmpty(txtNhapSo.Text) && e.KeyChar == '\r')
            {
                btnDangNhap.Focus();
            }
        }

        /// <summary>
        /// txtSoDT_KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!string.IsNullOrEmpty(txtNhapSo.Text) && e.KeyChar == '\r')
            {
                cmdChapNhan.Focus();
            }
        }

        /// <summary>
        /// txtNhapSo_KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!string.IsNullOrEmpty(txtNhapSo.Text) && e.KeyChar == '\r')
            {
                cmdChapNhan.Focus();
            }
        }

        /// <summary>
        /// dgvLotteryUser_CellDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLotteryUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLotteryUser.RowCount > 0)
                {
                    var selectedRow = dgvLotteryUser.Rows[e.RowIndex];
                    var lotteryUser = (LotteryUser)selectedRow.DataBoundItem;
                    FrmKQ frmdangky = new FrmKQ(this);
                    frmdangky.lotteryUser = lotteryUser;
                    frmdangky.ShowDialog();
                }
            }
            catch(Exception)
            {
            }
        }
    }
}
