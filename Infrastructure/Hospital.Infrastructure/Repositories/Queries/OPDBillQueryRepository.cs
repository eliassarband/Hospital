﻿using Hospital.Domain.Core.Entities;
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
    public class OPDBillQueryRepository : QueryRepository<OPDBill>, IOPDBillQueryRepository
    {
        protected readonly HospitalContext _context;
        public OPDBillQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<OPDBill>> GetAllAsync()
        {
            try
            {
                return _context.OPDBills.Include(b => b.PatientId).Include(b => b.OPDBillServices).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<OPDBill> GetByIdAsync(int id)
        {
            try
            {
                return _context.OPDBills.Where(t => t.Id == id).Include(b => b.PatientId).Include(b => b.OPDBillServices).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
