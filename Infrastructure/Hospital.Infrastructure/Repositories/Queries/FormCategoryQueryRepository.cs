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
    public class FormCategoryQueryRepository : QueryRepository<FormCategory>, IFormCategoryQueryRepository
    {
        protected readonly HospitalContext _context;
        public FormCategoryQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<FormCategory>> GetAllAsync()
        {
            try
            {
                return _context.FormCategories.Include(c => c.Forms).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<FormCategory> GetByIdAsync(int id)
        {
            try
            {
                return _context.FormCategories.Where(t => t.Id == id).Include(c => c.Forms).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<FormCategory> GetByCodeAsync(string code)
        {
            try
            {
                return _context.FormCategories.Where(t => t.Code == code).Include(c => c.Forms).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
