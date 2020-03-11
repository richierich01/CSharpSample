using CEOGroup.Contracts;
using CEOGroup.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CEOGroup.Data
{
    public class PersonEmailRepository : RepositoryBase<PersonEmail>, IPersonEmailRepository
    { 
        public PersonEmailRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<PersonEmail>> GetSearchPersonEmailAsync(string searchParam)
        {
            var personEmails = await FindByCondition(o => o.Email.StartsWith(searchParam))
                .Include(o => o.Person)
                .ToListAsync();

            return personEmails;
        }

        public async Task<PersonEmail> GetPersonEmailAsync(string email)
        {
            var personEmail = await FindByCondition(o => o.Email.Equals(email))
                .Include(o => o.Person)
                .FirstOrDefaultAsync();

            return personEmail;
        }

    }
}