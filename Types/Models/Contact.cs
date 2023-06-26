using System.ComponentModel.DataAnnotations;

namespace Types.Models;

public class CreateContact
{
    [Required]
    public required string Name { get; set; }
    [Required]
    [Phone]
    public required string Phone { get; set; }
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
}

public class Contact
{
    public required string Name { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
}
