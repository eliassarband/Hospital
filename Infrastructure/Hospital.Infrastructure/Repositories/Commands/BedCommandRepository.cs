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
    public class BedCommandRepository : CommandRepository<Bed>, IBedCommandRepository
    {
        public BedCommandRepository(HospitalContext context) : base(context)
        {

        }
    }
}
