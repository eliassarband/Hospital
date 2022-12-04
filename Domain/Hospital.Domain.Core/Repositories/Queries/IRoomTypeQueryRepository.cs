using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IRoomTypeQueryRepository : IQueryRepository<RoomType>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<RoomType>> GetAllAsync();
        Task<RoomType> GetByIdAsync(int id);
        Task<RoomType> GetByCodeAsync(string code);
        Task<RoomType> GetByNameAsync(string name);
    }
}
