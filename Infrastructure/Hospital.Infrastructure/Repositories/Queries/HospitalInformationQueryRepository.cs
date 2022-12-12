using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Infrastructure.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Infrastructure.Repositories.Queries
{
    public class HospitalInformationQueryRepository : QueryRepository<HospitalInformation>, IHospitalInformationQueryRepository
    {
        protected readonly HospitalContext _context;
        public HospitalInformationQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<HospitalInformation> GetByIdAsync(int id)
        {
            try
            {
                return _context.HospitalInformations.Where(t => t.Id == id).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


    }
}
