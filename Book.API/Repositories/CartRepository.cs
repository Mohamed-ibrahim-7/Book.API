using Book.API.Data;
using Book.API.Models;
using Book.API.Repositories.IRepositories;

namespace Book.API.Repositories
{
    public class CartRepository : Repository<CartItem>, ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
