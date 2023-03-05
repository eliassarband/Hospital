using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface ISettingQueryRepository : IQueryRepository<Setting>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Setting>> GetAllAsync();
        Task<Setting> GetByIdAsync(int id);
        Task<Setting> GetByKeyAsync(string code);
    }
}
