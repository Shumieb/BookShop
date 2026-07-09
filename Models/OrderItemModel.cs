using System;
using System.ComponentModel.DataAnnotations;
using BookShop.Models;

namespace BookStore.Models
{
    public class OrderItemModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Book relationship
        [Required]
        public Guid BookId { get; set; }
        public BookModel Book { get; set; }

        // Order relationship
        [Required]
        public Guid OrderId { get; set; }
        public OrderModel Order { get; set; }

        // Pricing
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal UnitPrice { get; set; }

        public bool Delivered { get; set; } = false;
        public DateTime DeliveryDate { get; set; }

        public bool Returned { get; set; } = false;

        public int ReturnedQuantity { get; set; } = 0;

        public decimal ReturnTotal => ReturnedQuantity * UnitPrice;

        [Required]
        public string ReturnReason { get; set; }

        public string ReturnComments { get; set; }

        public decimal Subtotal => (UnitPrice * Quantity) - ReturnTotal;
    }
}
