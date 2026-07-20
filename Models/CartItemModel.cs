using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public BookModel Book { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => UnitPrice * Quantity;
    }
}
