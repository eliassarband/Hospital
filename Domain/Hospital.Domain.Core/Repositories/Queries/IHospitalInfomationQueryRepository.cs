﻿using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IHospitalInformationQueryRepository : IQueryRepository<HospitalInformation>
    {
        //Custom operation which is not generic
        Task<HospitalInformation> GetByIdAsync(int id);
    }
}
