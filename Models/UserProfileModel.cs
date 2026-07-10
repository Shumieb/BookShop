using System.ComponentModel.DataAnnotations;

public class UpdateProfileModel
{
    [Required]
    [StringLength(50)]
    public string Username { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
