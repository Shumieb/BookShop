using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookShop.Helper;

namespace BookStore.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UserId { get; set; }
        public UserModel User { get; set; }

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public List<OrderItemModel> Items { get; set; } = new();

        // Calculated total price
        [Range(0, double.MaxValue)]
        public decimal TotalPrice { get; set; }
    }
}
