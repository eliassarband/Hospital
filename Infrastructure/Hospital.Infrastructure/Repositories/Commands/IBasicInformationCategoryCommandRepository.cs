﻿using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Commands;
using Hospital.Domain.Core.Repositories.Commands.Base;
using Hospital.Infrastructure.Data;
using Hospital.Infrastructure.Repositories.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Infrastructure.Repositories.Commands
{
    public class BasicInformationCategoryCommandRepository : CommandRepository<BasicInformationCategory>, IBasicInformationCategoryCommandRepository
    {
        public BasicInformationCategoryCommandRepository(HospitalContext context) : base(context)
        {

        }
    }
}
