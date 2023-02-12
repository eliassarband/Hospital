using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IOPDBillServiceQueryRepository : IQueryRepository<OPDBillService>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<OPDBillService>> GetAllAsync();
        Task<IReadOnlyList<OPDBillService>> GetByOPDBillIdAsync(int OPDBillId);
        Task<OPDBillService> GetByIdAsync(int id);
    }
}
