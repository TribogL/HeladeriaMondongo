using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeladeriaMondongo.DTOs
{
    public class IcecreamDTO
    {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "The Icecream Name is too long")]
    public required string Name { get; set; }

    [Required]
    [MaxLength(255, ErrorMessage = "The description is too long")]
    public required string Description { get; set; }

    [Required]
    [Range(2500.00, 25000.00, ErrorMessage ="Invalid price amount")]
    public required double Price { get; set; }
    }
}