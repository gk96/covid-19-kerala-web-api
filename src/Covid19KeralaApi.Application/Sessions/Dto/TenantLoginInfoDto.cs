using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Covid19KeralaApi.MultiTenancy;

namespace Covid19KeralaApi.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
