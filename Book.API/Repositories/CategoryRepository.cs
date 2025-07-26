using Book.API.Data;
using Book.API.Models;
using Book.API.Repositories.IRepositories;

namespace Book.API.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
