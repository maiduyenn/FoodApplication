using System.ComponentModel.DataAnnotations;

namespace FoodApplication.Models
{
    public class ReportTarget
    {
        [Key]
        public Guid? TargetId { get; set; }
        public decimal? Target { get; set; }
    }
}
