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
    public class BasicInformationQueryRepository : QueryRepository<BasicInformation>, IBasicInformationQueryRepository
    {
        protected readonly HospitalContext _context;
        public BasicInformationQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<BasicInformation>> GetAllAsync()
        {
            try
            {
                return _context.BasicInformations.Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<BasicInformation>> GetByCategoryIdAsync(int CategoryId)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.CategoryId == CategoryId).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<BasicInformation>> GetByCategoryCodeAsync(string CategoryCode)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.Category.Code == CategoryCode).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<BasicInformation>> GetByActiveAsync(bool active)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.Active == active).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<BasicInformation>> GetByRelatedBasicInformationIdAsync(int basicInformationId)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.RelatedBasicInformationId == basicInformationId).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<BasicInformation> GetByIdAsync(int id)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.Id == id).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<BasicInformation> GetByCodeAsync(int code)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.Code == code).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<BasicInformation> GetByStrCodeAsync(string strCode)
        {
            try
            {
                return _context.BasicInformations.Where(b => b.StrCode == strCode).Include(t => t.Category).Include(b => b.RelatedBasicInformation).Include(b => b.BasicInformations).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
