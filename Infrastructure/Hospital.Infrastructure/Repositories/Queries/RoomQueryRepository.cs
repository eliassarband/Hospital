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
    public class RoomQueryRepository : QueryRepository<Room>, IRoomQueryRepository
    {
        protected readonly HospitalContext _context;
        public RoomQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Room>> GetAllAsync()
        {
            try
            {
                return _context.Rooms.Include(s => s.RoomType).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Room>> GetByRoomTypeId(int roomTypeId)
        {
            try
            {
                return _context.Rooms.Where(r => r.RoomTypeId == roomTypeId).Include(s => s.RoomType).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Room> GetByIdAsync(int id)
        {
            try
            {
                return _context.Rooms.Where(t => t.Id == id).Include(s => s.RoomType).Include(s => s.Beds).Include(s => s.IPDRegisterations).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Room> GetByCodeAsync(string code)
        {
            try
            {
                return _context.Rooms.Where(t => t.Code == code).Include(s => s.RoomType).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Room> GetByNameAsync(string name)
        {
            try
            {
                return _context.Rooms.Where(t => t.Name == name).Include(s => s.RoomType).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
