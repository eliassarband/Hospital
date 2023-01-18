using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Commands.Base;

namespace Hospital.Domain.Core.Repositories.Commands
{
    public interface IPatientCommandRepository : ICommandRepository<Patient>
    {
        
    }
}
