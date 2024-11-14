using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeladeriaMondongo.Models;

public class Icecream
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required double Price { get; set; }

}
