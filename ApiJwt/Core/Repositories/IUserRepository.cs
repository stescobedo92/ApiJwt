using System.Threading.Tasks;
using ApiJwt.Core.Models;

namespace ApiJwt.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}