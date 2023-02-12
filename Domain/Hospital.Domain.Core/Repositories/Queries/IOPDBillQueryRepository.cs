﻿using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IOPDBillQueryRepository : IQueryRepository<OPDBill>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<OPDBill>> GetAllAsync();
        Task<OPDBill> GetByIdAsync(int id);
    }
}
