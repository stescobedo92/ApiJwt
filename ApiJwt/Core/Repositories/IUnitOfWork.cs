using System.Threading.Tasks;

namespace ApiJwt.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}