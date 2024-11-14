using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HeladeriaMondongo.Models;

[Table("icecreams")]
public class Icecream
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }

    [Column("description")]
    [Required]
    [MaxLength(255)]
    public required string Description { get; set; }

    [Column("price")]
    [Required]
    [Range(2500.00, 25000.00)]
    public required double Price { get; set; }

    public Icecream(){}

    public Icecream(int id, string name, string description)
    {
        Id = id;
        Name = name.ToLower().Trim();
        Description = description.ToLower().Trim();
    }

}
