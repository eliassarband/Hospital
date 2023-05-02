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
    public class FormQueryRepository : QueryRepository<Form>, IFormQueryRepository
    {
        protected readonly HospitalContext _context;
        public FormQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Form>> GetAllAsync()
        {
            try
            {
                return _context.Forms.Include(s => s.FormCategory).Include(s =>s.FormActions).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Form> GetByIdAsync(int id)
        {
            try
            {
                return _context.Forms.Where(t => t.Id == id).Include(s => s.FormCategory).Include(s => s.FormActions).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

		public async Task<Form> GetByCodeAsync(string code)
		{
			try
			{
				return _context.Forms.Where(t => t.Code == code).Include(s => s.FormCategory).Include(s => s.FormActions).FirstOrDefault();
			}
			catch (Exception exp)
			{
				throw new Exception(exp.Message, exp);
			}
		}

		public async Task<IReadOnlyList<Form>> GetByFormCategoryIdAsync(int formCategoryId)
        {
            try
            {
                return _context.Forms.Where(u => u.FormCategoryId == formCategoryId).Include(s => s.FormCategory).Include(s => s.FormActions).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
