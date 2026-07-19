using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class PaymentCardModel
    {
        [Required]
        public string CardholderName { get; set; }

        [Required]
        [CreditCard]
        public string CardNumber { get; set; }

        [Required]
        public string Expiry { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 3)]
        public string Cvv { get; set; }
    }
}