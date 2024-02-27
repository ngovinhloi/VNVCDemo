
using System.ComponentModel.DataAnnotations;

namespace LotteryServerServcies.Models
{
    public class LotteryUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public DateTime DateOfBD { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
