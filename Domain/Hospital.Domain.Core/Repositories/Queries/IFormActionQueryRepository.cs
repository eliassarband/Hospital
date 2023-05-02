using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IFormActionQueryRepository : IQueryRepository<FormAction>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<FormAction>> GetAllAsync();
        Task<FormAction> GetByIdAsync(int id);
        Task<FormAction> GetByFormIdCodeAsync(int formId, string Code);
		Task<IReadOnlyList<FormAction>> GetByFormIdAsync(int formId);

	}
}
