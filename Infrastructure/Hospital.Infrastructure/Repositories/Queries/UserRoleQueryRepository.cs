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
    public class UserRoleQueryRepository : QueryRepository<UserRole>, IUserRoleQueryRepository
    {
        protected readonly HospitalContext _context;
        public UserRoleQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<UserRole>> GetAllAsync()
        {
            try
            {
                return _context.UserRoles.Include(s => s.User).Include(s =>s.Role).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<UserRole> GetByIdAsync(int id)
        {
            try
            {
                return _context.UserRoles.Where(t => t.Id == id).Include(s => s.User).Include(s => s.Role).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<UserRole>> GetByUserIdAsync(int userId)
        {
            try
            {
                return _context.UserRoles.Where(u => u.UserId == userId).Include(s => s.User).Include(s => s.Role).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<UserRole>> GetByRoleIdAsync(int roleId)
        {
            try
            {
                return _context.UserRoles.Where(u => u.RoleId == roleId).Include(s => s.User).Include(s => s.Role).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
