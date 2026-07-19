using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class FilterModel
    {
        [Required]
        public int FilterId { get; set; }

        [Required]
        public string FilterType { get; set; }

        [Required]
        public int FilterTypeId { get; set; }

        public bool isSelected { get; set; }
    }
}