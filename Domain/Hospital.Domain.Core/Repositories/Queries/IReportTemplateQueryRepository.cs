﻿using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Repositories.Queries
{
    public interface IReportTemplateQueryRepository : IQueryRepository<ReportTemplate>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<ReportTemplate>> GetAllAsync();
        Task<ReportTemplate> GetByIdAsync(int id);
        Task<IReadOnlyList<ReportTemplate>> GetByCodeAsync(string code);
    }
}
