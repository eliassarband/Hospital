using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IUserQueryRepository : IQueryRepository<User>
    {
        Task<IReadOnlyList<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> GetByUsernameAsync(string username);
        
    }
}
