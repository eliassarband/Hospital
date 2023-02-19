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
    public class ReportTemplateQueryRepository : QueryRepository<ReportTemplate>, IReportTemplateQueryRepository
    {
        protected readonly HospitalContext _context;
        public ReportTemplateQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<ReportTemplate>> GetAllAsync()
        {
            try
            {
                return _context.ReportTemplates.ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<ReportTemplate> GetByIdAsync(int id)
        {
            try
            {
                return _context.ReportTemplates.Where(t => t.Id == id).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<ReportTemplate> GetByCodeAsync(string code)
        {
            try
            {
                return _context.ReportTemplates.Where(t => t.Code == code).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
