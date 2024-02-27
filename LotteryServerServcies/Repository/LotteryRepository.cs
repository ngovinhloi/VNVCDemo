using LotteryServerServcies.Models;
using LotteryServerServcies.Data;
using Microsoft.EntityFrameworkCore;
using LotteryServerServcies.Services;

namespace LotteryServerServcies.Repository
{
    public class LotteryRepository : ILotteryRepository
    {
        private readonly AppDBContext _context;
        private readonly ILogger<LotteryServcies> _logger;

        /// <summary>
        /// LotteryRepository
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        public LotteryRepository(AppDBContext context, ILogger<LotteryServcies> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// GetAllLotteryUsersAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<LotteryUser>> GetAllLotteryUsersAsync()
        {
            try
            {
                var lstLotteryUser = await _context.LotteryUser.Select(x => new LotteryUser()
                {
                    Id = x.Id,
                    Name = x.Name,
                    DateOfBD = x.DateOfBD,
                    Phone = x.Phone
                }).ToListAsync();
                return lstLotteryUser;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<LotteryUser>();
            }
        }

        /// <summary>
        /// GetAllLotteryResultsAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<LotteryResults>> GetAllLotteryResultsAsync()
        {
            try
            {
                var lstlotteryResults = await _context.LotteryResults.Select(x => new LotteryResults()
                {
                    Id = x.Id,
                    LotteryDate = x.LotteryDate,
                    Results = x.Results
                }).ToListAsync();

                return lstlotteryResults;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<LotteryResults>();
            }
        }

        /// <summary>
        /// GetBookTickedUserAsync
        /// </summary>
        /// <param name="bookTicketLottery"></param>
        /// <returns></returns>
        public async Task<List<BookTicketLottery>> GetBookTickedByUserAsync(BookTicketLottery bookTicketLottery)
        {
            try
            {
                var lstLotteryResults = await _context.BookTicketLottery
                                                           .Where(x => x.UserId == bookTicketLottery.UserId &&
                                                                       x.Year == bookTicketLottery.Year &&
                                                                       x.Month == bookTicketLottery.Month &&
                                                                       x.Day == bookTicketLottery.Day &&
                                                                       x.Hour == bookTicketLottery.Hour)
                                                           .Select(x => new BookTicketLottery()
                                                           {
                                                               Id = x.Id,
                                                               LotteryDate = x.LotteryDate,
                                                               Year = x.Year,
                                                               Day = x.Day,
                                                               Hour = x.Hour,
                                                               NumberTicket = x.NumberTicket,
                                                               LotteryResult = "Waitting result",
                                                           })
                                                           .ToListAsync();

                // get the last tearm lottery
                var lotteryResult = _context.LotteryResults.OrderByDescending(x => x.LotteryDate).FirstOrDefault();
                if (lotteryResult != null)
                {
                    var lstlottery = await _context.BookTicketLottery
                                                           .Where(x => x.UserId == bookTicketLottery.UserId &&
                                                                       x.Year == lotteryResult.Year &&
                                                                       x.Month == lotteryResult.Month &&
                                                                       x.Day == lotteryResult.Day &&
                                                                       x.Hour == lotteryResult.Hour)
                                                           .Select(x => new BookTicketLottery()
                                                           {
                                                               Id = x.Id,
                                                               LotteryDate = x.LotteryDate,
                                                               Year = x.Year,
                                                               Day = x.Day,
                                                               Hour = x.Hour,
                                                               NumberTicket = x.NumberTicket,
                                                               LotteryResult = lotteryResult.Results.ToString(),
                                                           })
                                                           .ToListAsync();
                    if (lstlottery!=null && lstlottery.Count>0)
                        lstLotteryResults.AddRange(lstlottery);
                }
                if (lstLotteryResults != null && lstLotteryResults.Count() > 0)
                {
                    return lstLotteryResults;
                }
                else
                {
                    // user don't buy for befor tearm
                    return new List<BookTicketLottery>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<BookTicketLottery>();
            }
        }
        
        /// <summary>
        /// GetLotteryUserAsync
        /// </summary>
        /// <param name="Phonenumber"></param>
        /// <returns></returns>
        public async Task<LotteryUser> GetLotteryUserAsync(string Phonenumber)
        {
            try
            {
                var _lotteryUser = await _context.LotteryUser.Where(x => x.Phone == Phonenumber)
                                                             .FirstOrDefaultAsync();
                return _lotteryUser == null ? new LotteryUser() : _lotteryUser;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new LotteryUser();
            }
        }

        /// <summary>
        /// AddLotteryUserAsync
        /// </summary>
        /// <param name="lotteryuser"></param>
        /// <returns></returns>
        public async Task<int> AddLotteryUserAsync(LotteryUser lotteryuser)
        {
            try
            {
                bool ischeckPhone = await CheckExistsLotteryUserByPhoneAsync(lotteryuser.Phone);
                if (ischeckPhone == true)
                    return -2; // Phone is exists

                await _context.LotteryUser.AddAsync(lotteryuser);
                await _context.SaveChangesAsync();
                return 0;// OK
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// AddBookTicketLotteryAsync
        /// </summary>
        /// <param name="bookTicketLottery"></param>
        /// <returns></returns>
        public async Task<int> AddBookTicketLotteryAsync(BookTicketLottery bookTicketLottery)
        {
            try
            {
                var bookedTicketLottery = _context.BookTicketLottery
                                                   .Where(x => x.UserId == bookTicketLottery.UserId &&
                                                               x.Year == bookTicketLottery.Year &&
                                                               x.Month == bookTicketLottery.Month &&
                                                               x.Day == bookTicketLottery.Day &&
                                                               x.Hour == bookTicketLottery.Hour &&
                                                               x.NumberTicket == bookTicketLottery.NumberTicket).FirstOrDefault();
                if (bookedTicketLottery != null)
                    return -2;

                await _context.BookTicketLottery.AddAsync(bookTicketLottery);
                await _context.SaveChangesAsync();
                return 0;// OK
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// CheckExistsLotteryUserByPhoneAsync
        /// </summary>
        /// <param name="Phonenumber"></param>
        /// <returns></returns>
        public async Task<bool> CheckExistsLotteryUserByPhoneAsync(string Phonenumber)
        {
            try
            {
                var _lotteryUser = await _context.LotteryUser.Where(x => x.Phone == Phonenumber)
                                                             .FirstOrDefaultAsync();
                return _lotteryUser == null ? false : true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
