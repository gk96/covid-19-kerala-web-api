using Abp.Application.Services;
using Covid19KeralaApi.DistrictCounts.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19KeralaApi.DistrictCounts
{
    public interface IDistrictCountAppService : IApplicationService
    {
		Task<List<DistrictCountDto>> GetAll(DistrictCountRequestDto request);
		Task<DistrictCountDto> GetDistrictCountByDate(string date);
        //Task<DistrictCountDto> GetDistrictCountForDistrict(string date);
    }
}
