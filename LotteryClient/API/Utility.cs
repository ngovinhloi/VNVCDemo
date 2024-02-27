namespace LotteryClient
{
    public static class Utility
    {
        public static string ApiKey { get; set; }
        public static void ShowMsgWarningOK(string mess)
        {
            MessageBox.Show(mess, "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowMsgInforOK(string mess)
        {
            MessageBox.Show(mess, "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowMsgErrorOK(string mess)
        {
            MessageBox.Show(mess, "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowMsgErrorConnectServer()
        {
            MessageBox.Show("Không thể kết nối đến Server.", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
