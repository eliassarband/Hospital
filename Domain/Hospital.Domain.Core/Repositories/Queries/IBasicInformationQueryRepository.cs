using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IBasicInformationQueryRepository : IQueryRepository<BasicInformation>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<BasicInformation>> GetAllAsync();
        Task<IReadOnlyList<BasicInformation>> GetByCategoryIdAsync(int CategoryId);
        Task<IReadOnlyList<BasicInformation>> GetByCategoryCodeAsync(string CategoryCode);
        Task<IReadOnlyList<BasicInformation>> GetByActiveAsync(bool active);
        Task<IReadOnlyList<BasicInformation>> GetByRelatedBasicInformationIdAsync(int basicInformationId);
        Task<BasicInformation> GetByIdAsync(int id);
        Task<BasicInformation> GetByCodeAsync(int code);
        Task<BasicInformation> GetByStrCodeAsync(string strCode);
    }
}
