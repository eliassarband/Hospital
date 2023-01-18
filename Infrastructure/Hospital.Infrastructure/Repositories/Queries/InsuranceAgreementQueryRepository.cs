using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Infrastructure.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Infrastructure.Repositories.Queries
{
    public class InsuranceAgreementQueryRepository : QueryRepository<InsuranceAgreement>, IInsuranceAgreementQueryRepository
    {
        protected readonly HospitalContext _context;
        public InsuranceAgreementQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<InsuranceAgreement>> GetAllAsync()
        {
            try
            {
                return _context.InsuranceAgreements.Include(i => i.Insurance).Include(i => i.Attachment).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<InsuranceAgreement>> GetByInsuranceIdAsync(int insuranceId)
        {
            try
            {
                return _context.InsuranceAgreements.Where(i => i.InsuranceId == insuranceId).Include(i => i.Insurance).Include(i => i.Attachment).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<InsuranceAgreement> GetByIdAsync(int id)
        {
            try
            {
                return _context.InsuranceAgreements.Where(t => t.Id == id).Include(i => i.Insurance).Include(i => i.Attachment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
