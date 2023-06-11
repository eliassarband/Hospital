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
    public class IPDRegisterationPaymentQueryRepository : QueryRepository<IPDRegisterationPayment>, IIPDRegisterationPaymentQueryRepository
    {
        protected readonly HospitalContext _context;
        public IPDRegisterationPaymentQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<IPDRegisterationPayment>> GetAllAsync()
        {
            try
            {
                return _context.IPDRegisterationPayments.Include(s => s.PaymentType).Include(s => s.IPDRegisteration).Include(s => s.Department).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<IPDRegisterationPayment>> GetByIPDRegisterationIdAsync(int IPDRegisterationId)
        {
            try
            {
                return _context.IPDRegisterationPayments.Where(s => s.IPDRegisterationId == IPDRegisterationId).Include(s => s.PaymentType).Include(s => s.IPDRegisteration).Include(s => s.Department).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IPDRegisterationPayment> GetByIdAsync(int id)
        {
            try
            {
                return _context.IPDRegisterationPayments.Where(t => t.Id == id).Include(s => s.PaymentType).Include(s => s.IPDRegisteration).Include(s => s.Department).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        
    }
}
