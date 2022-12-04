using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IServiceQueryRepository : IQueryRepository<Service>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Service>> GetAllAsync();
        Task<Service> GetByIdAsync(int id);
        Task<Service> GetByCodeAsync(string code);
        Task<Service> GetByNameAsync(string name);
    }
}
