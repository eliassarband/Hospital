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
    public class GroupQueryRepository : QueryRepository<Group>, IGroupQueryRepository
    {
        protected readonly HospitalContext _context;
        public GroupQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Group>> GetAllAsync()
        {
            try
            {
                return _context.Groups.Include(g => g.GroupUsers).ThenInclude(g => g.User).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Group> GetByIdAsync(int id)
        {
            try
            {
                return _context.Groups.Where(t => t.Id == id).Include(g => g.GroupUsers).ThenInclude(g => g.User).Include(g => g.FormActionAccesses).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        

    }
}
