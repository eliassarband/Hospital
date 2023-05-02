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
    public class GroupUserQueryRepository : QueryRepository<GroupUser>, IGroupUserQueryRepository
    {
        protected readonly HospitalContext _context;
        public GroupUserQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<GroupUser>> GetAllAsync()
        {
            try
            {
                return _context.GroupUsers.Include(s => s.User).Include(s =>s.Group).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<GroupUser> GetByIdAsync(int id)
        {
            try
            {
                return _context.GroupUsers.Where(t => t.Id == id).Include(s => s.User).Include(s => s.Group).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<GroupUser>> GetByUserIdAsync(int userId)
        {
            try
            {
                return _context.GroupUsers.Where(u => u.UserId == userId).Include(s => s.User).Include(s => s.Group).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<GroupUser>> GetByGroupIdAsync(int groupId)
        {
            try
            {
                return _context.GroupUsers.Where(u => u.GroupId == groupId).Include(s => s.User).Include(s => s.Group).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

		public async Task<GroupUser> GetByGroupIdUserIdAsync(int groupId, int userId)
		{
			try
			{
				return _context.GroupUsers.Where(u => u.GroupId == groupId && u.UserId == userId).Include(s => s.User).Include(s => s.Group).FirstOrDefault();
			}
			catch (Exception exp)
			{
				throw new Exception(exp.Message, exp);
			}
		}

	}
}
