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
    public class PatientQueryRepository : QueryRepository<Patient>, IPatientQueryRepository
    {
        protected readonly HospitalContext _context;
        public PatientQueryRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Patient>> GetAllAsync()
        {
            try
            {
                return _context.Patients.Include(s => s.NamePrefix).Include(s => s.Gender).Include(s => s.RefferBy).Include(s => s.City).Include(s => s.Area).Include(s =>s.Insurance).Include(s => s.Attachment).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            try
            {
                return _context.Patients.Where(t => t.Id == id).Include(s => s.NamePrefix).Include(s => s.Gender).Include(s => s.RefferBy).Include(s => s.City).Include(s => s.Area).Include(s => s.Insurance).Include(s => s.Attachment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }


        public async Task<Patient> GetByNationalIdAsync(string nationalId)
        {
            try
            {
                return _context.Patients.Where(t => t.NationalIdCart == nationalId).Include(s => s.NamePrefix).Include(s => s.Gender).Include(s => s.RefferBy).Include(s => s.City).Include(s => s.Area).Include(s => s.Insurance).Include(s => s.Attachment).FirstOrDefault();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }
    }
}
