using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IOPDBillPaymentQueryRepository : IQueryRepository<OPDBillPayment>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<OPDBillPayment>> GetAllAsync();
        Task<IReadOnlyList<OPDBillPayment>> GetByOPDBillIdAsync(int OPDBillId);
        Task<OPDBillPayment> GetByIdAsync(int id);
    }
}
