using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Commands;
using Hospital.Infrastructure.Repositories.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Infrastructure.Data;

namespace Hospital.Infrastructure.Repositories.Commands
{
    public class UserCommandRepository : CommandRepository<User>, IUserCommandRepository
    {
        HospitalContext context;
        public UserCommandRepository(HospitalContext context) : base(context)
        {
            this.context = context;
        }

        public async Task ChangePasswordAsync(int id, string newEncryptPassword)
        {
            var user = context.Users.Where(u => u.Id == id).FirstOrDefault();

            if (user != null)
            {
                user.Password = newEncryptPassword;

                UpdateAsync(user);
            }
        }
    }
}
