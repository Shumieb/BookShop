using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookShop.Helper;
using BookShop.Models;

namespace BookStore.Models
{
    public class UserModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, StringLength(100, ErrorMessage = "The name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required, StringLength(50, ErrorMessage = "The Username cannot exceed 50 characters.")]
        public string Username { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(200)]
        public string ShippingAddress { get; set; }

        [Required, StringLength(200)]
        public string BillingAddress { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public UserRole Role { get; set; } = UserRole.Customer;

        // Relationships
        public List<BookModel> Watchlist { get; set; } = new();
        public List<AuthorModel> FollowedAuthors { get; set; } = new();
        public List<OrderModel> Orders { get; set; } = new();
        public List<CustomerReviewModel> Reviews { get; set; } = new();
    }
}
