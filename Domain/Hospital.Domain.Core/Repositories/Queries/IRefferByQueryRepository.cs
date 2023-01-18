using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IRefferByQueryRepository : IQueryRepository<RefferBy>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<RefferBy>> GetAllAsync();
        Task<IReadOnlyList<RefferBy>> GetByStaffTypeIdAsync(int StaffTypeId);
        Task<RefferBy> GetByIdAsync(int id);
        
    }
}
