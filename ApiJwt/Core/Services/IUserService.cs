using System.Threading.Tasks;
using ApiJwt.Core.Models;
using ApiJwt.Core.Services.Communication;

namespace ApiJwt.Core.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}