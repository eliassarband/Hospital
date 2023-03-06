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
    public class BedQueryRepository : QueryRepository<Bed>, IBedQueryRepository
    {
        protected readonly HospitalContext _context;
        public BedQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Bed>> GetAllAsync()
        {
            try
            {
                return _context.Beds.Include(s => s.Room).ThenInclude(r => r.RoomType).ThenInclude(r => r.Ward).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Bed>> GetByRoomIdAsync(int roomId)
        {
            try
            {
                return _context.Beds.Where(t => t.RoomId == roomId).Include(s => s.Room).ThenInclude(r => r.RoomType).ThenInclude(r => r.Ward).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Bed> GetByIdAsync(int id)
        {
            try
            {
                return _context.Beds.Where(t => t.Id == id).Include(s => s.Room).ThenInclude(r => r.RoomType).ThenInclude(r => r.Ward).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Bed> GetByCodeAsync(string code)
        {
            try
            {
                return _context.Beds.Where(t => t.Code == code).Include(s => s.Room).ThenInclude(r => r.RoomType).ThenInclude(r => r.Ward).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        

    }
}
