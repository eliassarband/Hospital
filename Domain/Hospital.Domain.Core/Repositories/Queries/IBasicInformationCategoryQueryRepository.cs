using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IBasicInformationCategoryQueryRepository : IQueryRepository<BasicInformationCategory>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<BasicInformationCategory>> GetAllAsync();
        Task<IReadOnlyList<BasicInformationCategory>> GetViewablesAsync(bool viewable);
        Task<IReadOnlyList<BasicInformationCategory>> GetByRelatedCategoryIdAsync(int categoryId);
        Task<BasicInformationCategory> GetByIdAsync(int id);
        Task<BasicInformationCategory> GetByCodeAsync(string code);
    }
    
}

