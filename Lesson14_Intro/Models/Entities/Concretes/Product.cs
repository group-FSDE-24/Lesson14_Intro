using Lesson14_Intro.Models.Entities.Abstracts;

namespace Lesson14_Intro.Models.Entities.Concretes;

public class Product : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public double? Price { get; set; }
    public int? Stock { get; set; }
}
