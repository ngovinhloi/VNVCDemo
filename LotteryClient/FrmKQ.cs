using LotteryClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace LotteryClient
{
    public partial class FrmKQ : Form
    {
        private FrmMain _frmmain;
        private Services _services;
        public LotteryUser lotteryUser;
        public FrmKQ(FrmMain frmmain)
        {
            InitializeComponent();
            _services = new Services();
            _frmmain = frmmain;
            lotteryUser = new LotteryUser();
        }

        /// <summary>
        /// FrmKQ_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmKQ_Load(object sender, EventArgs e)
        {
            initData();
            getBookTicketLotteryUser();
        }
        /// <summary>
        /// initData
        /// </summary>
        private void initData()
        {
            lblTenNguoiMua.Text = lotteryUser.Name;
            dgvicTickedLotteryUser.AutoGenerateColumns = false;
        }

        /// <summary>
        /// getBookTicketLotteryUser
        /// </summary>
        private async void getBookTicketLotteryUser()
        {
            BookTicketLottery bookTicketLottery = new BookTicketLottery();
            DateTime date = DateTime.Now.AddHours(1);
            bookTicketLottery.UserId = lotteryUser.Id;
            bookTicketLottery.Year = date.Year;
            bookTicketLottery.Month = date.Month;
            bookTicketLottery.Day = date.Day;
            bookTicketLottery.Hour = date.Hour;
            bookTicketLottery.LotteryResult = "";

            this.Cursor = Cursors.WaitCursor;
            RestResponse response = await _services.GetBookTickedByUser(bookTicketLottery);
            this.Cursor = Cursors.Default;
            if (response != null && response.StatusCode != 0)
            {
                if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(response.Content))
                {
                    var data = JsonConvert.DeserializeObject<List<BookTicketLottery>>(response.Content);
                    if (data != null && data.Count > 0)
                    {
                        dgvicTickedLotteryUser.DataSource = data;
                        var ItemLottery= data.Where(x => x.LotteryResult.ToString() == x.NumberTicket.ToString()).FirstOrDefault();
                        if (ItemLottery != null)
                            Utility.ShowMsgInforOK(string.Format("Xin chúc mừng ban đã trúng số {0} ", ItemLottery.LotteryResult));
                    } 
                }
            }
            else
                Utility.ShowMsgErrorConnectServer();
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
        /// dgvicTickedLotteryUser_CellFormatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvicTickedLotteryUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {                
                if (this.dgvicTickedLotteryUser.Columns[e.ColumnIndex].Name == "col4")
                {
                    if (e.Value != null)
                        e.Value = string.Format("{0}h", e.Value);
                }
                if (dgvicTickedLotteryUser.Rows[e.RowIndex].Cells["col2"].Value.ToString() ==
                    dgvicTickedLotteryUser.Rows[e.RowIndex].Cells["col3"].Value.ToString())
                {
                    dgvicTickedLotteryUser.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
            catch(Exception)
            {
            }
        }
    }
}
