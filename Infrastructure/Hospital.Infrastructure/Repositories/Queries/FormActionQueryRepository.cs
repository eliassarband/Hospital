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
    public class FormActionQueryRepository : QueryRepository<FormAction>, IFormActionQueryRepository
    {
        protected readonly HospitalContext _context;
        public FormActionQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<FormAction>> GetAllAsync()
        {
            try
            {
                return _context.FormActions.Include(s => s.Form).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<FormAction> GetByIdAsync(int id)
        {
            try
            {
                return _context.FormActions.Where(t => t.Id == id).Include(s => s.Form).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<FormAction> GetByFormIdCodeAsync(int formId, string code)
        {
            try
            {
                return _context.FormActions.Where(u => u.FormId == formId && u.Code == code).Include(s => s.Form).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

		public async Task<IReadOnlyList<FormAction>> GetByFormIdAsync(int formId)
		{
			try
			{
				return _context.FormActions.Where(u => u.FormId == formId).Include(s => s.Form).ToList();
			}
			catch (Exception exp)
			{
				throw new Exception(exp.Message, exp);
			}
		}

	}
}
