using LotteryServerServcies.Models;

namespace LotteryServerServcies.Repository
{
    public interface ILotteryRepository
    {
        public Task<List<LotteryUser>> GetAllLotteryUsersAsync();
        public Task<List<LotteryResults>> GetAllLotteryResultsAsync();
        public Task<List<BookTicketLottery>> GetBookTickedByUserAsync(BookTicketLottery bookTicketLottery);
        public Task<LotteryUser> GetLotteryUserAsync(string phonenumber);        
        public Task<int> AddLotteryUserAsync(LotteryUser lotteryuser);
        public Task<int> AddBookTicketLotteryAsync(BookTicketLottery bookTicketLottery);
        public Task<bool> CheckExistsLotteryUserByPhoneAsync(string phoneNumber);        


    }
}
