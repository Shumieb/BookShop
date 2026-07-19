using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class BookModel
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "A book title is required.")]
        [StringLength(200, ErrorMessage = "The title cannot exceed 200 characters.")]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Please select an author.")]
        public AuthorModel Author { get; set; }

        public int PageCount { get; set; }

        public DateTime PublishedOn { get; set; }

        [StringLength(13, ErrorMessage = "ISBN must be 13 characters.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Please enter a summary.")]
        [StringLength(200, ErrorMessage = "Summary cannot exceed 200 characters.")]
        public string Summary { get; set; }

        [StringLength(500, ErrorMessage = "AuthorBook note cannot exceed 500 characters.")]
        public string AuthorBookNote { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        [Range(0.01, 9999.99, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a stock level.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock level cannot be negative.")]
        public int StockLevel { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public CategoryModel Category { get; set; }

        public List<TagModel> BookTags { get; set; } = new();

        public List<string> BookImageUrls { get; set; } = new();
    }
}