using Microsoft.EntityFrameworkCore;
using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace OPC5_BlogApp.Services
{
    public interface IUserService
    {
        void AddUser(User user);
    }
}
