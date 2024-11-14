
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeladeriaMondongo.Models;
[Table("users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(250)]
    public string Name { get; set; }

    [Column("last_name")]
    [MaxLength(250)]
    public string LastName { get; set; }

    [Column("email")]
    [MaxLength(250)]
    public string Email { get; set; }

    [Column("password")]
    [MaxLength(220)]
    public string Password { get; set; }

    [Column("is_admin")]
    public bool IsAdmin { get; set; } = false;


    public User(string name, string email, string lastName, string password, bool isAdmin)
    {
        Name = name.ToLower().Trim(); ;
        LastName = lastName.ToLower().Trim(); ;
        Email = email.ToLower().Trim(); ;
        Password = password;
        IsAdmin = isAdmin;
    }

    public User()
    {

    }
}
