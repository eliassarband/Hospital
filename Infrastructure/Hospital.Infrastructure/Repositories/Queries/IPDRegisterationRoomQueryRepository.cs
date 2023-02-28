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
    public class IPDRegisterationRoomQueryRepository : QueryRepository<IPDRegisterationRoom>, IIPDRegisterationRoomQueryRepository
    {
        protected readonly HospitalContext _context;
        public IPDRegisterationRoomQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<IPDRegisterationRoom>> GetAllAsync()
        {
            try
            {
                return _context.IPDRegisterationRooms.Include(s => s.Room).Include(s => s.IPDRegisteration).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<IPDRegisterationRoom>> GetByIPDRegisterationIdAsync(int IPDRegisterationId)
        {
            try
            {
                return _context.IPDRegisterationRooms.Where(s => s.IPDRegisterationId == IPDRegisterationId).Include(s => s.Room).Include(s => s.IPDRegisteration).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IPDRegisterationRoom> GetByIdAsync(int id)
        {
            try
            {
                return _context.IPDRegisterationRooms.Where(t => t.Id == id).Include(s => s.Room).Include(s => s.IPDRegisteration).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        
    }
}
