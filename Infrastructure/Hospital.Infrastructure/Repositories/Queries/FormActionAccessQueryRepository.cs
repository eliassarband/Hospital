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
    public class FormActionAccessQueryRepository : QueryRepository<FormActionAccess>, IFormActionAccessQueryRepository
    {
        protected readonly HospitalContext _context;
        public FormActionAccessQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<FormActionAccess>> GetAllAsync()
        {
            try
            {
                return _context.FormActionAccesses.Include(s => s.User).Include(s =>s.Group).Include(s => s.FormAction).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<FormActionAccess> GetByIdAsync(int id)
        {
            try
            {
                return _context.FormActionAccesses.Where(t => t.Id == id).Include(s => s.User).Include(s => s.Group).Include(s => s.FormAction).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<FormActionAccess>> GetByUserIdAsync(int userId)
        {
            try
            {
                return _context.FormActionAccesses.Where(u => u.UserId == userId).Include(s => s.User).Include(s => s.Group).Include(s => s.FormAction).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<FormActionAccess>> GetByGroupIdAsync(int groupId)
        {
            try
            {
                return _context.FormActionAccesses.Where(u => u.GroupId == groupId).Include(s => s.User).Include(s => s.Group).Include(s => s.FormAction).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

		public async Task<FormActionAccess> GetByFormCodeFormActionCodeUserIdAsync(string formCode, string formActionCode, int userId)
		{
			try
			{
				return _context.FormActionAccesses.Include(s => s.User).Include(s => s.Group).Include(s => s.FormAction).ThenInclude(s => s.Form).FirstOrDefault(s => s.FormAction.Form.Code == formCode && s.FormAction.Code == formActionCode && s.UserId == userId);
			}
			catch (Exception exp)
			{
				throw new Exception(exp.Message, exp);
			}
		}

		public async Task<FormActionAccess> GetByFormCodeFormActionCodeGroupIdAsync(string formCode, string formActionCode, int groupId)
		{
			try
			{
				return _context.FormActionAccesses.Include(s => s.User).Include(s => s.Group).Include(s => s.FormAction).ThenInclude(s => s.Form).FirstOrDefault(s => s.FormAction.Form.Code == formCode && s.FormAction.Code == formActionCode && s.GroupId == groupId);
			}
			catch (Exception exp)
			{
				throw new Exception(exp.Message, exp);
			}
		}

	}
}
