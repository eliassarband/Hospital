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
    public class StaffQueryRepository : QueryRepository<Staff>, IStaffQueryRepository
    {
        protected readonly HospitalContext _context;
        public StaffQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Staff>> GetAllAsync()
        {
            try
            {
                return _context.Staffs.Include(s => s.StaffType).Include(s => s.NamePrefix).Include(s => s.Speciality).Include(s => s.Qualification).Include(s => s.City).Include(s => s.Area).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Staff>> GetByStaffTypeIdAsync(int staffTypeId)
        {
            try
            {
                return _context.Staffs.Where(s => s.StaffTypeId ==  staffTypeId).Include(s => s.StaffType).Include(s => s.NamePrefix).Include(s => s.Speciality).Include(s => s.Qualification).Include(s => s.City).Include(s => s.Area).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Staff> GetByIdAsync(int id)
        {
            try
            {
                return _context.Staffs.Where(t => t.Id == id).Include(s => s.StaffType).Include(s => s.NamePrefix).Include(s => s.Speciality).Include(s => s.Qualification).Include(s => s.City).Include(s => s.Area).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
