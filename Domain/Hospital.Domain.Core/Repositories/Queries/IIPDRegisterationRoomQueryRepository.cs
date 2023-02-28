using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IIPDRegisterationRoomQueryRepository : IQueryRepository<IPDRegisterationRoom>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<IPDRegisterationRoom>> GetAllAsync();
        Task<IReadOnlyList<IPDRegisterationRoom>> GetByIPDRegisterationIdAsync(int IPDRegisterationId);
        Task<IPDRegisterationRoom> GetByIdAsync(int id);
    }
}
