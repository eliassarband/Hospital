using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IRoleQueryRepository : IQueryRepository<Role>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Role>> GetAllAsync();
        Task<Role> GetByIdAsync(int id);
        Task<Role> GetByCodeAsync(string code);
        Task<Role> GetByNameAsync(string name);
    }
}
