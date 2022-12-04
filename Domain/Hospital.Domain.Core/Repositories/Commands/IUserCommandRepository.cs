using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Commands.Base;

namespace Hospital.Domain.Core.Repositories.Commands
{
    public interface IUserCommandRepository : ICommandRepository<User>
    {
        Task ChangePasswordAsync(int id, string newPassword);

    }
}
