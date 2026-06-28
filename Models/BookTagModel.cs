using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class BookTagModel
    {
        public int BookTagId { get; set; }

        [Required(ErrorMessage = "Tag name is required.")]
        [StringLength(50, ErrorMessage = "Tag name cannot exceed 50 characters.")]
        public string BookTagName { get; set; }

        // Optional: description for admin UI
        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters.")]
        public string Description { get; set; }
    }
}