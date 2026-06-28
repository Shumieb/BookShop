using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class BookReviewModel : CustomerReviewModel
    {

        [Required(ErrorMessage = "A book ID is required.")]
        public int BookId { get; set; }

        public BookModel Book { get; set; }
    }
}