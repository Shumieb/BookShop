using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ReturnItemModel
    {
        [Required]
        public string Reason { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string Comments { get; set; }

        [Required]
        public string UnitPrice { get; set; }
        public string TotalRefund { get; set; }
    }
}