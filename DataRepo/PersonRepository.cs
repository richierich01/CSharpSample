
using CEOGroup.Contracts;
using CEOGroup.Core.Entity;

namespace CEOGroup.Data
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}