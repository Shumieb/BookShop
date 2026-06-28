using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{

    public class AuthorModel
    {
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Author name is required.")]
        [StringLength(120, ErrorMessage = "Name cannot exceed 120 characters.")]
        public string AuthorName { get; set; }

        [StringLength(500, ErrorMessage = "Biography cannot exceed 500 characters.")]
        public string Biography { get; set; }

    }
}