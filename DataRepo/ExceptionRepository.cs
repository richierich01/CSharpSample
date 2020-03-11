using CEOGroup.Contracts;
using CEOGroup.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CEOGroup.Data
{
    public class ExceptionRepository : RepositoryBase<ExceptionRecord>, IExceptionRepository
    {
        public ExceptionRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<ExceptionRecord>> GetUnprocessedExceptionAsync()
        {
            var exceptionRecords = await FindByCondition(o => string.IsNullOrEmpty(o.ExceptionEmail)).ToListAsync();

            return exceptionRecords;
        }

    }
}
