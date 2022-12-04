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
    public class ServiceQueryRepository : QueryRepository<Service>, IServiceQueryRepository
    {
        protected readonly HospitalContext _context;
        public ServiceQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Service>> GetAllAsync()
        {
            try
            {
                return _context.Services.Include(s => s.Department).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Service> GetByIdAsync(int id)
        {
            try
            {
                return _context.Services.Where(t => t.Id == id).Include(s => s.Department).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Service> GetByCodeAsync(string code)
        {
            try
            {
                return _context.Services.Where(t => t.Code == code).Include(s => s.Department).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Service> GetByNameAsync(string name)
        {
            try
            {
                return _context.Services.Where(t => t.Name == name).Include(s => s.Department).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
