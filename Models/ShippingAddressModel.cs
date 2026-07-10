using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ShippingAddressModel
    {
        public int ShippingAddressId { get; set; }

        [Required]
        public string ShippingAddressNickname { get; set; } = string.Empty;

        [Required]
        public string Street { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string Postcode { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;
    }
}