using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Covid19KeralaApi.DistrictCounts.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Covid19KeralaApi.DistrictCounts
{
    public class DistrictCountAppService : IDistrictCountAppService
    {
        private readonly IRepository<DistrictCount, long> _districtcountRepository;
        private readonly IObjectMapper _objectMapper;
        public DistrictCountAppService(IRepository<DistrictCount, long> districtcountRepository, IObjectMapper objectMapper)
        {
            this._districtcountRepository = districtcountRepository;
            this._objectMapper = objectMapper;
        }

		public async Task<List<DistrictCountDto>> GetAll(DistrictCountRequestDto request)
		{
			var result = await this._districtcountRepository.GetAllListAsync();

            /*var x = Expression.Parameter(typeof(DistrictCount), "x");
            var body = Expression.PropertyOrField(x, request);
            var lambda = Expression.Lambda<Func<DistrictCount, string>>(body, x);*/

            /*if (request.DisplayColumns.Count() > 0)
			{
                result = result.SelectMembers(request.DisplayColumns);

			}*/

            return this._objectMapper.Map<List<DistrictCountDto>>(result);
		}
		public async Task<DistrictCountDto> GetDistrictCountByDate(string date)
        {
            var d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            var districtCount = await this._districtcountRepository.GetAll()
                                    .FirstOrDefaultAsync(x => x.Date.Equals(d));
            if (districtCount == null)
            {
                return null;
            }

            var result = new DistrictCountDto()
            {
                Id = districtCount.Id,
                Date = districtCount.Date,
                Total = districtCount.Total,
                Districts = new List<DistrictDto>()
            };

            foreach (var item in districtCount.GetType().GetProperties())
            {
                if (!item.Name.ToLower().Equals("id") && !item.Name.ToLower().Equals("date") && !item.Name.ToLower().Equals("total"))
                {
                    result.Districts.Add(new DistrictDto() { Name = item.Name , Count = (int?) item.GetValue(districtCount, null)});
                }
            }
            return result;
            //return this._objectMapper.Map<DistrictCountDto>(districtCount);
        }
    }
}
