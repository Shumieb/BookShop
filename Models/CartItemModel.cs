using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class CartItem
    {
        public BookModel Book { get; set; }
        public int Quantity { get; set; }
    }
}
