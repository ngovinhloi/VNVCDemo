using LotteryClient.Models;
using RestSharp;
using System.Net;

namespace LotteryClient
{
    public partial class FrmDangKy : Form
    {
        private FrmMain _frmmain;
        private Services _services;
        public FrmDangKy(FrmMain frmmain)
        {
            InitializeComponent();
            _frmmain = frmmain;
            _services = new Services();
        }

        /// <summary>
        /// cmdDangKy_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cmdDangKy_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(txtHoten.Text.Trim()))
            {
                Utility.ShowMsgWarningOK("Vui lòng nhập họ tên");
                return;
            }
            if (string.IsNullOrEmpty(txtSoDT.Text.Trim()))
            {
                Utility.ShowMsgWarningOK("Vui lòng nhập Số điện thoại");
                return;
            }
            if (txtSoDT.Text.Length !=10 )
            {
                Utility.ShowMsgWarningOK("Vui lòng nhập 10 ký số");
                return;
            }

            try
            {
                LotteryUser lotteryUser = new LotteryUser();
                lotteryUser.Name = txtHoten.Text;
                lotteryUser.DateOfBD = dtpNgaySinh.Value.Date;
                lotteryUser.Phone = txtSoDT.Text.Trim();
                this.Cursor = Cursors.WaitCursor;
                RestResponse response = await _services.RegisLotteryUser(lotteryUser);

                this.Cursor = Cursors.Default;
                if (response != null && response.StatusCode != 0)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        cmdDangKy.Enabled = false;
                        _frmmain.getListLotteryUser();
                        Utility.ShowMsgInforOK("Đăng ký thành công");
                    }
                    else if (response.StatusCode == HttpStatusCode.UpgradeRequired)
                        Utility.ShowMsgWarningOK("Số điện thoại này đã tồn tại");
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
        /// cmdThoat_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!string.IsNullOrEmpty(txtSoDT.Text) && e.KeyChar == '\r')
            {
                cmdDangKy.Focus();
            }
        }
    }
}
