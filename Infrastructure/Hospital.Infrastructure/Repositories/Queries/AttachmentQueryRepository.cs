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
    public class AttachmentQueryRepository : QueryRepository<Attachment>, IAttachmentQueryRepository
    {
        protected readonly HospitalContext _context;
        public AttachmentQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Attachment>> GetAllAsync()
        {
            try
            {
                return _context.Attachments.ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Attachment> GetByIdAsync(int id)
        {
            try
            {
                return _context.Attachments.Where(t => t.Id == id).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Attachment> GetByNameAsync(string name)
        {
            try
            {
                return _context.Attachments.Where(t => t.Name == name).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

    }
}
