using System.ComponentModel.DataAnnotations;

namespace LotteryClient.Models
{
    public class LotteryUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBD { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
