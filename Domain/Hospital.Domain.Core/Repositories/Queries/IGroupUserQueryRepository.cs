using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IGroupUserQueryRepository : IQueryRepository<GroupUser>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<GroupUser>> GetAllAsync();
        Task<GroupUser> GetByIdAsync(int id);
        Task<IReadOnlyList<GroupUser>> GetByUserIdAsync(int userId);
        Task<IReadOnlyList<GroupUser>> GetByGroupIdAsync(int groupId);
        Task<GroupUser> GetByGroupIdUserIdAsync(int groupId, int userId);

	}
}
