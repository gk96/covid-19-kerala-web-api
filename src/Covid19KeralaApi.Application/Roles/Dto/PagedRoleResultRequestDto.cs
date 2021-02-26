using Abp.Application.Services.Dto;

namespace Covid19KeralaApi.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

