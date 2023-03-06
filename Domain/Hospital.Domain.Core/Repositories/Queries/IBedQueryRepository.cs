using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IBedQueryRepository : IQueryRepository<Bed>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Bed>> GetAllAsync();
        Task<IReadOnlyList<Bed>> GetByRoomIdAsync(int roomId);
        Task<Bed> GetByIdAsync(int id);
        Task<Bed> GetByCodeAsync(string code);
        
    }
}
