using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IFormActionAccessQueryRepository : IQueryRepository<FormActionAccess>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<FormActionAccess>> GetAllAsync();
        Task<FormActionAccess> GetByIdAsync(int id);
        Task<IReadOnlyList<FormActionAccess>> GetByUserIdAsync(int userId);
        Task<IReadOnlyList<FormActionAccess>> GetByGroupIdAsync(int groupId);
		Task<FormActionAccess> GetByFormCodeFormActionCodeUserIdAsync(string formCode, string formActionCode, int userId);
		Task<FormActionAccess> GetByFormCodeFormActionCodeGroupIdAsync(string formCode, string formActionCode, int groupId);
	}
}
