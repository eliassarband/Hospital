using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IIPDRegisterationPaymentQueryRepository : IQueryRepository<IPDRegisterationPayment>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<IPDRegisterationPayment>> GetAllAsync();
        Task<IReadOnlyList<IPDRegisterationPayment>> GetByIPDRegisterationIdAsync(int IPDRegisterationId);
        Task<IPDRegisterationPayment> GetByIdAsync(int id);
    }
}
