using Microsoft.AspNetCore.Identity;

namespace Miniblog.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
