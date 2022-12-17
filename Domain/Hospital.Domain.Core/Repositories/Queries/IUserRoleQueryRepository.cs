using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IUserRoleQueryRepository : IQueryRepository<UserRole>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<UserRole>> GetAllAsync();
        Task<UserRole> GetByIdAsync(int id);
        Task<IReadOnlyList<UserRole>> GetByUserIdAsync(int userId);
        Task<IReadOnlyList<UserRole>> GetByRoleIdAsync(int roleId);
    }
}
