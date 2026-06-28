using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class CustomerReviewModel
    {
        public int CustomerReviewId { get; set; }

        [Required(ErrorMessage = "A rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(120, ErrorMessage = "Name cannot exceed 120 characters.")]
        public string ReviewerName { get; set; }

        [StringLength(500, ErrorMessage = "Review text cannot exceed 500 characters.")]
        public string ReviewText { get; set; }

        [Required(ErrorMessage = "A review date is required.")]
        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;

    }
}