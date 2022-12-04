using Hospital.Domain.Core.Repositories.Queries.Base;
using Hospital.Infrastructure.Data;

namespace Hospital.Infrastructure.Repositories.Queries.Base
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        protected readonly HospitalContext _context;
        public QueryRepository(HospitalContext context)
        {
            _context = context;
        }
    }
}
