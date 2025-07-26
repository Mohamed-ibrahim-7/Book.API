using Book.API.Data;
using Book.API.Models;
using Book.API.Repositories.IRepositories;

namespace Book.API.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
