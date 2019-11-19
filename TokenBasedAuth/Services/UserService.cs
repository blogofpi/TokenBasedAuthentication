using System.Linq;
using TokenBasedAuth.Data;
using TokenBasedAuth.Models;

namespace TokenBasedAuth.Services
{
    public interface IUserService
    {
        bool IsValidUser(UserModel user);
    }
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool IsValidUser(UserModel user)
        {
            return _context.Users.Any(x => x.Username.ToLower().Equals(user.Username.ToLower()) && x.Password.Equals(user.Password));
        }
    }
}
