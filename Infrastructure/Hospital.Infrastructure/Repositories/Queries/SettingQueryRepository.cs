using Hospital.Domain.Core.Entities;
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
    public class SettingQueryRepository : QueryRepository<Setting>, ISettingQueryRepository
    {
        protected readonly HospitalContext _context;
        public SettingQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Setting>> GetAllAsync()
        {
            try
            {
                return _context.Settings.ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            try
            {
                return _context.Settings.Where(t => t.Id == id).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Setting> GetByKeyAsync(string key)
        {
            try
            {
                return _context.Settings.Where(t => t.Key == key).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
