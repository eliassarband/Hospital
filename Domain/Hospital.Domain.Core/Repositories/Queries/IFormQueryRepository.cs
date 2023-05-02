using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IFormQueryRepository : IQueryRepository<Form>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Form>> GetAllAsync();
        Task<Form> GetByIdAsync(int id);
		Task<Form> GetByCodeAsync(string code);
		Task<IReadOnlyList<Form>> GetByFormCategoryIdAsync(int formCategoryId);
    }
}
