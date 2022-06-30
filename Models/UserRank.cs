using System.ComponentModel.DataAnnotations;

namespace FoodApplication.Models
{
    public class UserRank
    {
        [Key]
        public int UserRankId { get; set; }
        public Guid? RankId { get; set; }
        public Guid? UserId { get; set; }
        public string? UserName { get; set; }
        public string? RankName { get; set; }
        public string? Value { get; set; }
        public double? Discount { get; set; }
        public decimal? TotalSpent { get; set; }
    }

    public class RankingResponse
    {
        public int UserRankId { get; set; }
        public Guid? RankId { get; set; }
        public Guid? UserId { get; set; }
        public string? RankName { get; set; }
        public string? Value { get; set; }
        public double? Discount { get; set; }
        public decimal? TotalSpent { get; set; }
        public string? UserName { get; set; }

        public RankingResponse(UserRank rank)
        {
            UserRankId = rank.UserRankId;
            RankId = rank.RankId;
            UserId = rank.UserId;
            RankName = rank.RankName;
            Value = rank.Value;
            Discount = rank.Discount;
            TotalSpent = rank.TotalSpent;
            UserName = rank.UserName;
        }
    }
}
