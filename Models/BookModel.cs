using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class BookModel
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "A book title is required.")]
        [StringLength(200, ErrorMessage = "The title cannot exceed 200 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please select an author.")]
        public AuthorModel Author { get; set; }

        [Required(ErrorMessage = "Please enter the author's name.")]
        [StringLength(120, ErrorMessage = "Author name cannot exceed 120 characters.")]
        public string AuthorName { get; set; }

        [Range(1, 5000, ErrorMessage = "Page count must be between 1 and 5000.")]
        public int PageCount { get; set; }

        [Required(ErrorMessage = "Please select a publication date.")]
        public DateTime PublishedOn { get; set; }

        [StringLength(13, ErrorMessage = "ISBN must be 13 characters.")]
        public string ISBN { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters.")]
        public string Summary { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Range(0.01, 9999.99, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock level cannot be negative.")]
        public int StockLevel { get; set; }

        [Required(ErrorMessage = "Please choose a category.")]
        public CategoryModel Category { get; set; }

        [Required(ErrorMessage = "Please enter a category name")]
        public string CategoryName { get; set; }

        public List<BookTagModel> Tags { get; set; } = new();
    }
}