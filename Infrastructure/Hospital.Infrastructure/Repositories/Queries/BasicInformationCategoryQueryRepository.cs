using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Infrastructure.Data;
using Hospital.Infrastructure.Repositories.Queries.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Infrastructure.Repositories.Queries
{
    public class BasicInformationCategoryQueryRepository : QueryRepository<BasicInformationCategory>, IBasicInformationCategoryQueryRepository
    {
        protected readonly HospitalContext _context;
        public BasicInformationCategoryQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<BasicInformationCategory>> GetAllAsync()
        {
            try
            {
                return _context.BasicInformationCategories.Include(b => b.BasicInformations).Include(b => b.RelatedCategory).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<BasicInformationCategory>> GetViewablesAsync(bool viewable)
        {
            try
            {
                return _context.BasicInformationCategories.Where(b => b.Viewable == viewable).Include(t => t.BasicInformations).Include(b => b.RelatedCategory).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<BasicInformationCategory>> GetByRelatedCategoryIdAsync(int categoryId)
        {
            try
            {
                return _context.BasicInformationCategories.Where(b => b.RelatedCategoryId == categoryId).Include(t => t.BasicInformations).Include(b => b.RelatedCategory).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<BasicInformationCategory> GetByIdAsync(int id)
        {
            try
            {
                return _context.BasicInformationCategories.Where(b => b.Id == id).Include(b => b.BasicInformations).Include(b => b.BasicInformationCategories).Include(b => b.RelatedCategory).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<BasicInformationCategory> GetByCodeAsync(string code)
        {
            try
            {
                return _context.BasicInformationCategories.Where(b => b.Code == code).Include(b => b.BasicInformations).Include(b => b.RelatedCategory).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
