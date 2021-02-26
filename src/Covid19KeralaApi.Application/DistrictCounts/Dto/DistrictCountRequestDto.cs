using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19KeralaApi.DistrictCounts.Dto
{
    public class DistrictCountRequestDto
    {
        public string[] DisplayColumns { get; set; }

        public int PageSize { get; set; }

        public int PageIndex { get; set; }


    }
}
