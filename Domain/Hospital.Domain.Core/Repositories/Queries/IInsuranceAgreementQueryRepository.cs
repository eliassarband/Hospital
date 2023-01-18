using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IInsuranceAgreementQueryRepository : IQueryRepository<InsuranceAgreement>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<InsuranceAgreement>> GetAllAsync();
        Task<IReadOnlyList<InsuranceAgreement>> GetByInsuranceIdAsync(int insuranceId);
        Task<InsuranceAgreement> GetByIdAsync(int id);
        
    }
}
