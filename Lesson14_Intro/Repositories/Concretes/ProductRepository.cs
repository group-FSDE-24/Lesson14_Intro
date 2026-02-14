using Lesson14_Intro.Datas;
using Lesson14_Intro.Models.Entities.Concretes;
using Lesson14_Intro.Repositories.Abstracts;

namespace Lesson14_Intro.Repositories.Concretes;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext appDbContext) : base(appDbContext) { }

}
