using LotteryClient.Models;
using Newtonsoft.Json;
using RestSharp;

namespace LotteryClient
{
    public class Services
    {
        private readonly RestClient _client;
        public Services()
        {
            _client = new RestClient(Utility.ApiKey);
        }

        /// <summary>
        /// GetAllLotteryUsers
        /// </summary>
        /// <returns></returns>
        public async Task<RestResponse> GetAllLotteryUsers()
        {
            try
            {
                var request = new RestRequest("GetAllLotteryUsers", Method.Get);
                var response = await _client.ExecuteGetAsync(request);

                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// GetBookTickedByUser
        /// </summary>
        /// <returns></returns>
        public async Task<RestResponse> GetBookTickedByUser(BookTicketLottery bookTicketLottery)
        {
            try
            {                
                var request = new RestRequest("GetBookTickedByUser", Method.Get);
                string jsonData = JsonConvert.SerializeObject(bookTicketLottery);
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                var response = await _client.ExecuteGetAsync(request);

                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// AddBookTicketLottery
        /// </summary>
        /// <param name="bookTicketLottery"></param>
        /// <returns></returns>
        public async Task<RestResponse> AddBookTicketLottery(BookTicketLottery bookTicketLottery)
        {
            try
            {
                var request = new RestRequest("AddBookTicketLottery", Method.Post);
                string jsonData = JsonConvert.SerializeObject(bookTicketLottery);
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                var response = await _client.ExecutePostAsync(request);

                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// RegisLotteryUser
        /// </summary>
        /// <param name="lotteryUser"></param>
        /// <returns></returns>
        public async Task<RestResponse> RegisLotteryUser(LotteryUser lotteryUser)
        {
            try
            {
                var request = new RestRequest("AddLotteryUser", Method.Post);
                string jsonData = JsonConvert.SerializeObject(lotteryUser);
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                var response = await _client.ExecutePostAsync(request);

                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        
        /// <summary>
        /// LoginLotteryUser
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public async Task<RestResponse> LoginLotteryUser(string phoneNumber)
        {
            try
            {
                var request = new RestRequest("GetLotteryUser", Method.Get);                
                request.AddParameter("Phonenumber", phoneNumber);
                var response = await _client.ExecuteGetAsync(request);
                return response;                
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
