using Abp.Application.Services;
using Covid19KeralaApi.MultiTenancy.Dto;

namespace Covid19KeralaApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

