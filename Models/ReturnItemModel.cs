using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ReturnItemModel
    {
        [Required]
        public string Reason { get; set; }

        public string Comments { get; set; }
    }
}