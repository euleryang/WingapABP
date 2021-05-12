using Abp.Application.Services;
using Wingap.MultiTenancy.Dto;

namespace Wingap.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

