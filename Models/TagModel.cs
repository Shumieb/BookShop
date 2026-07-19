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

        [Required(ErrorMessage = "Please specify if the tag is for books.")]
        public bool forBooks { get; set; }

        [Required(ErrorMessage = "Please specify if the tag is for authors.")]
        public bool forAuthors { get; set; }

        [Required(ErrorMessage = "Please specify if the tag is for categories.")]
        public bool forCategories { get; set; }
    }
}