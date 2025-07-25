using AutomotiveWebApi.Models;

namespace AutomotiveWebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task RegisterUserAsync(User user);
        Task<User?> GetUserByEmailAsync(string email);
    }
}
