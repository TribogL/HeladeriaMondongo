using System.ComponentModel.DataAnnotations;

namespace HeladeriaMondongo.DTOs;
public class UserDTO
{
    [MaxLength(250, ErrorMessage = "Your name can not have more than 250 characters")]
    public string Name { get; set; }

    [MaxLength(250, ErrorMessage = "Your Last name can not have more than 250 characters")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "The Type is obligatory")]
    [MaxLength(255, ErrorMessage = "The email can't be longer than {1} characters.")]
    [EmailAddress(ErrorMessage = "You must write a correct email format.")]
    [Display(Name = "example@gmail.com")]
    public string Email { get; set; }

    [Required(ErrorMessage = "The Type is obligatory")]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.")]
    [Display(Name = "Must be at least 8 characters, one uppercase letter, one lowercase, and one number.")]
    public string Password { get; set; }
}
