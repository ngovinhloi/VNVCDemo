﻿using System.ComponentModel.DataAnnotations;

namespace LotteryClient.Models
{
    public class LotteryResults
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime LotteryDate { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Results { get; set; }
    }
}
