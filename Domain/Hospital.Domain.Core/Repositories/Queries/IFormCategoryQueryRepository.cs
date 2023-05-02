using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IFormCategoryQueryRepository : IQueryRepository<FormCategory>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<FormCategory>> GetAllAsync();
        Task<FormCategory> GetByIdAsync(int id);
        Task<FormCategory> GetByCodeAsync(string code);
    }
}
