using Abp.AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Covid19KeralaApi.DistrictCounts.Dto
{
    public class DistrictCountDto
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public List<DistrictDto> Districts { get; set; }
        public int Total { get; set; }
    }
}
