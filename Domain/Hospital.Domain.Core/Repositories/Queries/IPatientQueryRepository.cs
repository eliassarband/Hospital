using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IPatientQueryRepository : IQueryRepository<Patient>
    {
        Task<IReadOnlyList<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync(int id);
        Task<Patient> GetByNationalIdAsync(string nationalId);
        
    }
}
