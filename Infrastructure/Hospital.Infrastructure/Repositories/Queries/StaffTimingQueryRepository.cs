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
    public class StaffTimingQueryRepository : QueryRepository<StaffTiming>, IStaffTimingQueryRepository
    {
        protected readonly HospitalContext _context;
        public StaffTimingQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<StaffTiming>> GetAllAsync()
        {
            try
            {
                return _context.StaffTimings.Include(s => s.Staff).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<StaffTiming>> GetByStaffIdAsync(int staffId)
        {
            try
            {
                return _context.StaffTimings.Where(s => s.StaffId ==  staffId).Include(s => s.Staff).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<StaffTiming> GetByIdAsync(int id)
        {
            try
            {
                return _context.StaffTimings.Where(t => t.Id == id).Include(s => s.Staff).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
