using CEOGroup.Contracts;
using CEOGroup.Core.Entity;
using System.Threading.Tasks;

namespace CEOGroup.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext repositoryContext;
        private UploadRepository upload;
        private EngagementRepository engagement;
        private PersonRepository person;
        private PersonEmailRepository personEmail;
        private ExceptionRulesRepository exceptionRule;
        private PersonEngagementRepository personEngagement;
        private ExceptionRepository exception;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public IUploadRepository Upload
        {
            get
            {
                if (upload == null)
                {
                    upload = new UploadRepository(repositoryContext);
                }
                return upload;
            }
        }

        public IEngagementRepository Engagement
        {
            get
            {
                if (engagement == null)
                {
                    engagement = new EngagementRepository(repositoryContext);
                }
                return engagement;
            }
        }

        public IPersonRepository Person
        {
            get
            {
                if (person == null)
                {
                    person = new PersonRepository(repositoryContext);
                }
                return person;
            }
        }

        public IPersonEmailRepository PersonEmail
        {
            get
            {
                if (personEmail == null)
                {
                    personEmail = new PersonEmailRepository(repositoryContext);
                }
                return personEmail;
            }
        }

       public IRepositoryBase<PersonEngagement> PersonEngagement
        {
            get
            {
                if (personEngagement == null)
                {
                    personEngagement = new PersonEngagementRepository(repositoryContext);
                }
                return personEngagement;
            }
        }

        public IExceptionRepository Exception
        {
            get
            {
                if (exception == null)
                {
                    exception = new ExceptionRepository(repositoryContext);
                }
                return exception;
            }
        }

        public IRepositoryBase<ExceptionRule> ExceptionRule
        {
            get
            {
                if (exceptionRule == null)
                {
                    exceptionRule = new ExceptionRulesRepository(repositoryContext);
                }
                return exceptionRule;
            }
        }

        public async Task SaveAsync()
        {
           await repositoryContext.SaveChangesAsync();
        }
    }
}
