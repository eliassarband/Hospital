using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Infrastructure.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Infrastructure.Data;

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
                return _context.Departments.ToList();
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
                return _context.Departments.Where(t => t.Id == id).FirstOrDefault();
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
                return _context.Departments.Where(t => t.Code == code).FirstOrDefault();
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
                return _context.Departments.Where(t => t.Name == name).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
