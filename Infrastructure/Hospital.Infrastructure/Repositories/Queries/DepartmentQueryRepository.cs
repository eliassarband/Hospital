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
    public class DepartmentQueryRepository : QueryRepository<Department>, IDepartmentQueryRepository
    {
        protected readonly HospitalContext _context;
        public DepartmentQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Department>> GetAllAsync()
        {
            try
            {
                return _context.Departments.Include(d => d.MainDepartment).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Department>> GetByMainDepartmentIdAsync(int departmentId)
        {
            try
            {
                return _context.Departments.Where(d => d.MainDepartmentId == departmentId).Include(d => d.MainDepartment).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            try
            {
                return _context.Departments.Where(t => t.Id == id).Include(t => t.MainDepartment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Department> GetByCodeAsync(string code)
        {
            try
            {
                return _context.Departments.Where(t => t.Code == code).Include(t => t.MainDepartment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Department> GetByNameAsync(string name)
        {
            try
            {
                return _context.Departments.Where(t => t.Name == name).Include(t => t.MainDepartment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
