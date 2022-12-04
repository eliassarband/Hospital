using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IUserQueryRepository : IQueryRepository<User>
    {
        Task<IReadOnlyList<User>> GetAllAsync();
        //Task<IReadOnlyList<User>> GetUsersByRoleIdAsync(int roleId);
        //Task<IReadOnlyList<User>> GetUsersByRoleCodeAsync(string roleCode);
        Task<User> GetByIdAsync(int id);
        Task<User> GetByUsernameAsync(string username);
        //Task<IReadOnlyList<User>> GetByTenantIdAsync(int tenantId);
        //Task<IReadOnlyList<User>> GetActivesAsync(bool active);
        //Task<IReadOnlyList<User>> GetByNameAsync(string name);
    }
}
