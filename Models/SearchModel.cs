using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage = "Please enter an author name or book title.")]
        public string Query { get; set; }
    }
}
