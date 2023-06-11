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
    public class RoomTypeQueryRepository : QueryRepository<RoomType>, IRoomTypeQueryRepository
    {
        protected readonly HospitalContext _context;
        public RoomTypeQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<RoomType>> GetAllAsync()
        {
            try
            {
                return _context.RoomTypes.Include(r => r.Ward).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<RoomType>> GetByWardIdAsync(int wardId)
        {
            try
            {
                return _context.RoomTypes.Where(t => t.WardId == wardId).Include(r => r.Ward).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<RoomType> GetByIdAsync(int id)
        {
            try
            {
                return _context.RoomTypes.Where(t => t.Id == id).Include(r => r.Ward).Include(r => r.Rooms).Include(r => r.IPDRegisterations).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<RoomType> GetByCodeAsync(string code)
        {
            try
            {
                return _context.RoomTypes.Where(t => t.Code == code).Include(r => r.Ward).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        

    }
}
