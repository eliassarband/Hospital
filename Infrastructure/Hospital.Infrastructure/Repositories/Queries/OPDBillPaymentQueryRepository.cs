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
    public class OPDBillPaymentQueryRepository : QueryRepository<OPDBillPayment>, IOPDBillPaymentQueryRepository
    {
        protected readonly HospitalContext _context;
        public OPDBillPaymentQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<OPDBillPayment>> GetAllAsync()
        {
            try
            {
                return _context.OPDBillPayments.Include(s => s.OPDBill).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<OPDBillPayment>> GetByOPDBillIdAsync(int OPDBillId)
        {
            try
            {
                return _context.OPDBillPayments.Where(s => s.OPDBillId==OPDBillId).Include(s => s.OPDBill).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<OPDBillPayment> GetByIdAsync(int id)
        {
            try
            {
                return _context.OPDBillPayments.Where(t => t.Id == id).Include(s => s.OPDBill).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        
    }
}
