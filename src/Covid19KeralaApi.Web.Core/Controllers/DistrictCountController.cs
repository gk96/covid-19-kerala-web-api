using Abp.Authorization;
using Abp.Web.Models;
using Covid19KeralaApi.DistrictCounts;
using Covid19KeralaApi.DistrictCounts.Dto;
using Covid19KeralaApi.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Covid19KeralaApi.Controllers
{
    //[AbpAuthorize]
    //[DontWrapResult]
    [Route("api/[controller]/[action]")]
    public class DistrictCountController : Covid19KeralaApiControllerBase
    {
        private readonly IDistrictCountAppService _districtcountAppService;
        private readonly IHubContext<ChatHub> _hub;
            
        public DistrictCountController(IDistrictCountAppService districtcountAppService, IHubContext<ChatHub> hub)
        {
            this._hub = hub;
            this._districtcountAppService = districtcountAppService;
        }
       
        [HttpPost]
        [ProducesResponseType(typeof(DistrictCountDto), 200)]
        [ProducesResponseType(typeof(ErrorInfo), 500)]
        //[DontWrapResult]
        public async Task<IActionResult> GetAll([FromBody] DistrictCountRequestDto request)
        {
            Logger.Info("Enter DistrictCountController - GetAll");
            var retVal = await this._districtcountAppService.GetAll(request);
            if (retVal == null) { return NotFound(); }
            return this.Ok(retVal);
        }

        [HttpGet]
        [ProducesResponseType(typeof(DistrictCountDto), 200)]
        [ProducesResponseType(typeof(ErrorInfo), 500)]
        //[DontWrapResult]
        public async Task<IActionResult> GetByDate(string date)
        {
            Logger.Info("Enter DistrictCountController - GetByDate");
            var retVal = await this._districtcountAppService.GetDistrictCountByDate(date);
            if (retVal == null) { return this.NotFound(); }
            return this.Ok(retVal);
        }
    }
}
    

