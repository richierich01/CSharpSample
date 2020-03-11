using CEOGroup.Core.Entity;
using System.Threading.Tasks;

namespace CEOGroup.Contracts
{
    public interface IRepositoryWrapper
    {
        IUploadRepository Upload { get; }
        
        IEngagementRepository Engagement { get; }

        IPersonRepository Person { get;  }

        IPersonEmailRepository PersonEmail { get; }

        IRepositoryBase<ExceptionRule> ExceptionRule { get; }

        IRepositoryBase<PersonEngagement> PersonEngagement { get; }

        IExceptionRepository Exception { get; }

        Task SaveAsync();
    }
}
