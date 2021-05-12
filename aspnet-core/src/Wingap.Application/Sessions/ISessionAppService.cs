using System.Threading.Tasks;
using Abp.Application.Services;
using Wingap.Sessions.Dto;

namespace Wingap.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
