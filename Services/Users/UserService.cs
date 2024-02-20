
using Microsoft.EntityFrameworkCore;
using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Users
{
    public class UserService(ApplicationDbContext context) : IUserService
    {
        private readonly ApplicationDbContext _context = context;

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}