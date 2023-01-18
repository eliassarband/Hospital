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
    public class InsuranceQueryRepository : QueryRepository<Insurance>, IInsuranceQueryRepository
    {
        protected readonly HospitalContext _context;
        public InsuranceQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Insurance>> GetAllAsync()
        {
            try
            {
                return _context.Insurances.Include(i => i.InsurancePaymentType).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Insurance>> GetByPaymentTypeAsync(int paymentTypeId)
        {
            try
            {
                return _context.Insurances.Where(i => i.InsurancePaymentTypeId == paymentTypeId).Include(i => i.InsurancePaymentType).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Insurance> GetByIdAsync(int id)
        {
            try
            {
                return _context.Insurances.Where(t => t.Id == id).Include(i => i.InsurancePaymentType).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Insurance> GetByCodeAsync(string code)
        {
            try
            {
                return _context.Insurances.Where(t => t.Code == code).Include(i => i.InsurancePaymentType).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
