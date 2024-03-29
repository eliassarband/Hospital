﻿using Hospital.Domain.Core.Entities;
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
    public class RoleQueryRepository : QueryRepository<Role>, IRoleQueryRepository
    {
        protected readonly HospitalContext _context;
        public RoleQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Role>> GetAllAsync()
        {
            try
            {
                return _context.Roles.ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            try
            {
                return _context.Roles.Where(t => t.Id == id).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Role> GetByCodeAsync(string code)
        {
            try
            {
                return _context.Roles.Where(t => t.Code == code).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Role> GetByNameAsync(string name)
        {
            try
            {
                return _context.Roles.Where(t => t.Name == name).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
