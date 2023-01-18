using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IInsuranceQueryRepository : IQueryRepository<Insurance>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Insurance>> GetAllAsync();
        Task<IReadOnlyList<Insurance>> GetByPaymentTypeAsync(int paymentTypeId);
        Task<Insurance> GetByIdAsync(int id);
        Task<Insurance> GetByCodeAsync(string code);
        
    }
}
