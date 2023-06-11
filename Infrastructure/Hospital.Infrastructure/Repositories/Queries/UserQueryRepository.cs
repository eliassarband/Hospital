using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Infrastructure.Data;
using Hospital.Infrastructure.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Infrastructure.Repositories.Queries
{
    public class UserQueryRepository : QueryRepository<User>, IUserQueryRepository
    {
        protected readonly HospitalContext _context;
        public UserQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<User>> GetAllAsync()
        {
            try
            {
                return _context.Users.Include(U => U.UserRoles).ThenInclude(u => u.Role).Include(u => u.Attachment).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<User> GetByIdAsync(int id)
        {
            try
            {
                return _context.Users.Where(t => t.Id == id).Include(U => U.UserRoles).ThenInclude(u => u.Role).Include(u => u.Attachment).Include(u => u.UserRoles).Include(u => u.GroupUsers).Include(u => u.FormActionAccesses).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            try
            {
                return _context.Users.Where(t => t.Username == username).Include(U => U.UserRoles).ThenInclude(u => u.Role).Include(u => u.Attachment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }
        
    }
}
