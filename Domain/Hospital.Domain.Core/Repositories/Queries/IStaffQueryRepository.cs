using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IStaffQueryRepository : IQueryRepository<Staff>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Staff>> GetAllAsync();
        Task<IReadOnlyList<Staff>> GetByStaffTypeIdAsync(int staffTypeId);
        Task<Staff> GetByIdAsync(int id);
        
    }
}
