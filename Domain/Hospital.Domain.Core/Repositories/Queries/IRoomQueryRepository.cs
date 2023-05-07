using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IRoomQueryRepository : IQueryRepository<Room>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Room>> GetAllAsync();
        Task<IReadOnlyList<Room>> GetByRoomTypeId(int roomTypeId);
        Task<Room> GetByIdAsync(int id);
        Task<Room> GetByCodeAsync(string code);
        Task<Room> GetByNameAsync(string name);
    }
}
