using Microsoft.EntityFrameworkCore;
using Lesson14_Intro.Models.Entities.Concretes;

namespace Lesson14_Intro.Datas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    // Table
    public DbSet<Product> Products { get; set; }
}
