using System.Threading.Tasks;
using Abp.Application.Services;
using Wingap.Authorization.Accounts.Dto;

namespace Wingap.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
