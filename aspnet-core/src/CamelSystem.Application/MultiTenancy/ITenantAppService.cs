using Abp.Application.Services;
using CamelSystem.MultiTenancy.Dto;

namespace CamelSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

