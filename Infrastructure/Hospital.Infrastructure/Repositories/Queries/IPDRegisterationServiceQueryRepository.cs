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
    public class IPDRegisterationServiceQueryRepository : QueryRepository<IPDRegisterationService>, IIPDRegisterationServiceQueryRepository
    {
        protected readonly HospitalContext _context;
        public IPDRegisterationServiceQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<IPDRegisterationService>> GetAllAsync()
        {
            try
            {
                return _context.IPDRegisterationServices.Include(s => s.Service).Include(s => s.Staff).Include(s => s.IPDRegisteration).Include(s => s.Service).Include(s => s.Staff).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<IPDRegisterationService>> GetByIPDRegisterationIdAsync(int IPDRegisterationId)
        {
            try
            {
                return _context.IPDRegisterationServices.Where(s => s.IPDRegisterationId == IPDRegisterationId).Include(s => s.Service).Include(s => s.Staff).Include(s => s.IPDRegisteration).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IPDRegisterationService> GetByIdAsync(int id)
        {
            try
            {
                return _context.IPDRegisterationServices.Where(t => t.Id == id).Include(s => s.Service).Include(s => s.Staff).Include(s => s.IPDRegisteration).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        
    }
}
