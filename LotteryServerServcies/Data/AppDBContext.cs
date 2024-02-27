using LotteryServerServcies.Models;
using Microsoft.EntityFrameworkCore;

namespace LotteryServerServcies.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<LotteryResults> LotteryResults { get; set; }
        public DbSet<LotteryUser> LotteryUser { get; set; }
        public DbSet<BookTicketLottery> BookTicketLottery { get; set; }
    }
}
