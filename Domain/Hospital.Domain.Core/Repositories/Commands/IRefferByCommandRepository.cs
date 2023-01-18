using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Commands
{
    public interface IRefferByCommandRepository : ICommandRepository<RefferBy>
    {
    }
}
