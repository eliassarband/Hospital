using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IDepartmentQueryRepository : IQueryRepository<Department>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
        Task<Department> GetByCodeAsync(string code);
        Task<Department> GetByNameAsync(string name);
    }
}
