using System.ComponentModel.DataAnnotations;

namespace FoodApplication.Models
{
    public class Ranking
    {
        [Key]
        public Guid? RankId { get; set; }
        public string? RankName { get; set; }
        public int Value { get; set; }
        public int Discount { get; set; }
        public string? UserId { get; set; }
        public decimal TotalSpent { get; set; }
    }
}
