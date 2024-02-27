using LotteryServerServcies.Models;
using LotteryServerServcies.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LotteryServerServcies.Controllers
{
    [ApiController]
    [Route("api/Lottery")]
    public class LotteryController : ControllerBase
    {
        private readonly ILotteryRepository _lotteryRep;
        public LotteryController(ILotteryRepository lotteryRep)
        {
            _lotteryRep = lotteryRep;
        }

        /// <summary>
        /// GetLotteryUser
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        [HttpGet("GetLotteryUser")]
        public async Task<IActionResult> GetLotteryUser(string phoneNumber)
        {
            var lotteryUser = await _lotteryRep.GetLotteryUserAsync(phoneNumber);
            return Ok(lotteryUser);
        }

        /// <summary>
        /// GetAllLotteryUsers
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllLotteryUsers")]
        public async Task<IActionResult> GetAllLotteryUsers()
        {
            var lstLotteryUser = await _lotteryRep.GetAllLotteryUsersAsync();
            return Ok(lstLotteryUser);
        }

        /// <summary>
        /// GetBookTickedUser
        /// </summary>
        /// <param name="bookTicketLottery"></param>
        /// <returns></returns>
        [HttpGet("GetBookTickedByUser")]
        public async Task<IActionResult> GetBookTickedByUser([FromBody] BookTicketLottery bookTicketLottery)
        {
            var lstbookTicketLottery = await _lotteryRep.GetBookTickedByUserAsync(bookTicketLottery);
            return Ok(lstbookTicketLottery);
        }

        /// <summary>
        ///AddLotteryUser
        /// </summary>
        /// <param name="lotteryUser"></param>
        /// <returns></returns>
        [HttpPost("AddLotteryUser")]
        public async Task<IActionResult> AddLotteryUser([FromBody] LotteryUser lotteryUser)
        {
            int result = await _lotteryRep.AddLotteryUserAsync(lotteryUser);            
            if (result == 0)
                return StatusCode(StatusCodes.Status200OK);            
            else if(result == -2)
                return StatusCode(StatusCodes.Status426UpgradeRequired);
            else
                return StatusCode(StatusCodes.Status400BadRequest);
        }

        /// <summary>
        /// AddBookTicketLotteryAsync
        /// </summary>
        /// <param name="bookTicketLottery"></param>
        /// <returns></returns>
        [HttpPost("AddBookTicketLottery")]
        public async Task<IActionResult> AddBookTicketLottery([FromBody] BookTicketLottery bookTicketLottery)
        {
            int result = await _lotteryRep.AddBookTicketLotteryAsync(bookTicketLottery);
            if (result == 0)
                return StatusCode(StatusCodes.Status200OK);
            else if (result == -2)
                return StatusCode(StatusCodes.Status426UpgradeRequired);
            else
                return StatusCode(StatusCodes.Status400BadRequest);
        }        
    }
}
