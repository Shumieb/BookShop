using System.ComponentModel.DataAnnotations;

public class BookFeedback
{
    [Required]
    [Range(1, 5, ErrorMessage = "Book rating must be between 1 and 5.")]
    public int BookRating { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Book review must be under 500 characters.")]
    public string BookReview { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "Delivery rating must be between 1 and 5.")]
    public int DeliveryRating { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Delivery review must be under 500 characters.")]
    public string DeliveryReview { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "Service rating must be between 1 and 5.")]
    public int ServiceRating { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Service review must be under 500 characters.")]
    public string ServiceReview { get; set; }
}
