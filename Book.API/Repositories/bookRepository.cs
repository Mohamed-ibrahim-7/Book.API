using Book.API.Data;
using Book.API.Models;
using Book.API.Repositories.IRepositories;

namespace Book.API.Repositories
{
    public class bookRepository : Repository<book>, IbookRepository
    {
        private readonly ApplicationDbContext _context;

        public bookRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
