using Microsoft.AspNetCore.Identity;
using MinimalAuthAPI.Models;
using MinimalAuthAPI.Reposutories;
using ProductWeb.Repositories;

namespace ProductWeb.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin) 
        {
            User user = UserRepository.Users
                .FirstOrDefault
        }
    }
}
