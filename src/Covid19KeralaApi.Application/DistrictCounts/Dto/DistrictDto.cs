using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Covid19KeralaApi.DistrictCounts.Dto
{
	public class DistrictDto
	{
		public string Name { get; set; }
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int? Count { get; set; }
	}
}
