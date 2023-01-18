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
    public class RefferByQueryRepository : QueryRepository<RefferBy>, IRefferByQueryRepository
    {
        protected readonly HospitalContext _context;
        public RefferByQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<RefferBy>> GetAllAsync()
        {
            try
            {
                return _context.RefferBies.Include(s => s.StaffType).Include(s => s.NamePrefix).Include(s => s.Speciality).Include(s => s.Qualification).Include(s => s.City).Include(s => s.Area).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<RefferBy>> GetByStaffTypeIdAsync(int StaffTypeId)
        {
            try
            {
                return _context.RefferBies.Where(s => s.StaffTypeId == StaffTypeId).Include(s => s.StaffType).Include(s => s.NamePrefix).Include(s => s.Speciality).Include(s => s.Qualification).Include(s => s.City).Include(s => s.Area).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<RefferBy> GetByIdAsync(int id)
        {
            try
            {
                return _context.RefferBies.Where(t => t.Id == id).Include(s => s.StaffType).Include(s => s.NamePrefix).Include(s => s.Speciality).Include(s => s.Qualification).Include(s => s.City).Include(s => s.Area).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
