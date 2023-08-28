using Abp.Application.Services;
using maidCentralTest.MultiTenancy.Dto;

namespace maidCentralTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

