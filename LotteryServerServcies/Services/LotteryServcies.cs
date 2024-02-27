using LotteryServerServcies.Data;
using LotteryServerServcies.Models;
using Serilog;

namespace LotteryServerServcies.Services
{
    public class LotteryServcies : BackgroundService
    {
        private readonly ILogger<LotteryServcies> _logger;
        private readonly AppDBContext _dbContext;

        /// <summary>
        /// LotteryServcies
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public LotteryServcies(ILogger<LotteryServcies> logger, IServiceProvider serviceProvider)
        {
            var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDBContext>();
            _dbContext = dbContext;
            _logger = FormatLog();
        }

        /// <summary>
        /// ExecuteAsync
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("WELL COME TO AUTOMATIC LOTTERY SERVICES");
            _logger.LogInformation("OUR COMPANY WILL BE AUTOMATIC LOTERY EVERY HOUR");
            _logger.LogInformation("Server is stating...");
            while (!stoppingToken.IsCancellationRequested)
            {
                DateTime date = DateTime.Now;
                 int waittingTime = GetNextTime(date);
                if (waittingTime == 0)  // Minute is 0
                {                    
                    int result = GenerateLotteryNumbers(date);
                    if (result > 0)
                    {
                        _logger.LogInformation(string.Format("Lottery result: {0} is {1}", date.ToString("dd/MM/yyyy hh:mm:ss"), result));
                    }
                    else
                    {
                        if (result == -1)
                            _logger.LogInformation(string.Format("This lottery result was opened on {0} at {1} hour", date.ToString("dd/MM/yyyy"), date.ToString("hh")));
                        else
                        {
                            // have error repeat to try again
                        }
                    }
                    waittingTime = GetNextTime(DateTime.Now);
                    waittingTime = waittingTime == 0 ? 60 : waittingTime;
                }

                // Next time
                _logger.LogInformation(string.Format("The next program will start at {0}h", DateTime.Now.AddMinutes(waittingTime).Hour));
                _logger.LogInformation("================================================");
                await Task.Delay(TimeSpan.FromMinutes(waittingTime), stoppingToken);
            }
        }

        /// <summary>
        /// generateLotteryNumbers
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private int GenerateLotteryNumbers(DateTime date)
        {
            Random rand = new Random();
            int result = rand.Next(10);
            try
            {
                // Check Results Exists
                var LotteryExistsResults = _dbContext.LotteryResults.Where(x =>
                                            x.Year == date.Year &&
                                            x.Month == date.Month &&
                                            x.Day == date.Day &&
                                            x.Hour == date.Hour).FirstOrDefault();
                if (LotteryExistsResults != null)
                    return -1;

                LotteryResults lotteryResults = new LotteryResults();
                lotteryResults.Year = date.Year;
                lotteryResults.Month = date.Month;
                lotteryResults.Day = date.Day;
                lotteryResults.Hour = date.Hour;
                lotteryResults.LotteryDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, date.Kind);
                lotteryResults.Results = result;
                _dbContext.LotteryResults.Add(lotteryResults);
                _dbContext.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return -2;
            }
        }

        /// <summary>
        /// GetNextTime
        /// </summary>
        /// <returns></returns>
        private int GetNextTime(DateTime date)
        {
            return date.Minute == 0 ? date.Minute : 60 - date.Minute;
        }
        /// <summary>
        /// FormatLog
        /// </summary>
        /// <returns></returns>
        private ILogger<LotteryServcies> FormatLog()
        {
            Serilog.ILogger serilogLogger = new LoggerConfiguration().WriteTo.Console(
            outputTemplate: "{Timestamp:HH:mm:ss} {Level:u4}: {Message:lj}{NewLine}{Exception}")
            .CreateLogger();
            Serilog.Log.Logger = serilogLogger;
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog(serilogLogger);
            });
            return loggerFactory.CreateLogger<LotteryServcies>();
        }
    }
}
