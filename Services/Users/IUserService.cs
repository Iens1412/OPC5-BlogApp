using Microsoft.EntityFrameworkCore;
using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Users
{
    public interface IUserService
    {
        void AddUser(User user);
        User? GetUserByUsername(string username);
    }
}
