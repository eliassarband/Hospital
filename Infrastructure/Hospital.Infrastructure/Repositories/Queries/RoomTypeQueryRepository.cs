using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Infrastructure.Repositories.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Infrastructure.Data;

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
                return _context.RoomTypes.ToList();
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
                return _context.RoomTypes.Where(t => t.Id == id).FirstOrDefault();
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
                return _context.RoomTypes.Where(t => t.Code == code).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<RoomType> GetByNameAsync(string name)
        {
            try
            {
                return _context.RoomTypes.Where(t => t.Name == name).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
