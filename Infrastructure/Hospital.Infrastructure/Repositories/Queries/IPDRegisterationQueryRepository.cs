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
    public class IPDRegisterationQueryRepository : QueryRepository<IPDRegisteration>, IIPDRegisterationQueryRepository
    {
        protected readonly HospitalContext _context;
        public IPDRegisterationQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<IPDRegisteration>> GetAllAsync()
        {
            try
            {
                return _context.IPDRegisterations.Include(b => b.Patient).Include(b => b.RefferBy).Include(b => b.ConsultantIncharge).Include(b => b.SecondConsultant).Include(b => b.ThirdConsultant).Include(b => b.Ward).Include(b => b.RoomType).Include(b => b.Room).Include(b => b.Bed).Include(b => b.CaseType).Include(b => b.Relationship).Include(b => b.IPDRegisterationServices).Include(b => b.IPDRegisterationRooms).Include(b => b.IPDRegisterationPayments).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IPDRegisteration> GetByIdAsync(int id)
        {
            try
            {
                return _context.IPDRegisterations.Where(t => t.Id == id).Include(b => b.Patient).Include(b => b.RefferBy).Include(b => b.ConsultantIncharge).Include(b => b.SecondConsultant).Include(b => b.ThirdConsultant).Include(b => b.Ward).Include(b => b.RoomType).Include(b => b.Room).Include(b => b.Bed).Include(b => b.CaseType).Include(b => b.Relationship).Include(b => b.IPDRegisterationServices).Include(b => b.IPDRegisterationRooms).Include(b => b.IPDRegisterationPayments).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
