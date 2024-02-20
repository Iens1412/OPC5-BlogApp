using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Users
{
    public class UserService(ApplicationDbContext _context) : IUserService
    {
        private readonly ApplicationDbContext context = _context;

        public void AddUser(User user)
        {
            //HASH USER IN HERE?
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User? GetUserByUsername(string username)
        {
            User? fetchedUser = context.Users.FirstOrDefault(u => u.Username == username);

            return fetchedUser;
        }
    }
}