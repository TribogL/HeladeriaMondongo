using System.ComponentModel.DataAnnotations;

namespace HeladeriaMondongo.DTOs;
public class UserDTO
{
      [MaxLength(250, ErrorMessage = "Your name cannot have more than 250 characters")]
    public string Name { get; set; }

    [MaxLength(250, ErrorMessage = "Your last name cannot have more than 250 characters")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email is obligatory")]
    [MaxLength(255, ErrorMessage = "The email cannot be longer than {1} characters.")]
    [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is obligatory")]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long, with at least one uppercase letter, one lowercase letter, and one number.")]
    public string Password { get; set; }
    public bool IsAdmin { get; set; } = false;
}
