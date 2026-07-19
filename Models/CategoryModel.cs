using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
        public string CategoryName { get; set; }

        [StringLength(300, ErrorMessage = "Description cannot exceed 300 characters.")]
        public string Description { get; set; }

        public List<TagModel> CategoryTags { get; set; } = new();

    }
}