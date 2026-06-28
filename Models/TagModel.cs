using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class TagModel
    {
        public int TagId { get; set; }

        [Required(ErrorMessage = "Tag name is required.")]
        [StringLength(50, ErrorMessage = "Tag name cannot exceed 50 characters.")]
        public string TagName { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters.")]
        public string Description { get; set; }
    }
}