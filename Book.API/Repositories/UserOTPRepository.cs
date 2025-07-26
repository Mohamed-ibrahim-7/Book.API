using Book.API.Data;
using Book.API.Models;
using Book.API.Repositories.IRepositories;

namespace Book.API.Repositories
{
    public class UserOTPRepository : Repository<UserOTP>, IUserOTPRepository
    {
        private readonly ApplicationDbContext _context;

        public UserOTPRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
                                                                                                                                                             