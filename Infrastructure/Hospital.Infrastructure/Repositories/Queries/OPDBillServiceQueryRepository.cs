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
    public class OPDBillServiceQueryRepository : QueryRepository<OPDBillService>, IOPDBillServiceQueryRepository
    {
        protected readonly HospitalContext _context;
        public OPDBillServiceQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<OPDBillService>> GetAllAsync()
        {
            try
            {
                return _context.OPDBillServices.Include(s => s.Service).Include(s => s.Staff).Include(s => s.OPDBill).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<OPDBillService>> GetByOPDBillIdAsync(int OPDBillId)
        {
            try
            {
                return _context.OPDBillServices.Where(s => s.OPDBillId==OPDBillId).Include(s => s.Service).Include(s => s.Staff).Include(s => s.OPDBill).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<OPDBillService> GetByIdAsync(int id)
        {
            try
            {
                return _context.OPDBillServices.Where(t => t.Id == id).Include(s => s.Service).Include(s => s.Staff).Include(s => s.OPDBill).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        
    }
}
