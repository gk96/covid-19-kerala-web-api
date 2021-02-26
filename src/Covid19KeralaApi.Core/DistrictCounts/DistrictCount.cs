using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Covid19KeralaApi.DistrictCounts
{
    public class DistrictCount : Entity<long>
    {
        [Required]
        public DateTime Date { get; set; }
        public int? Kasaragod { get; set; }
        public int? Kannur { get; set; }
        public int? Kozhikode { get; set; }
        public int? Wayanad { get; set; }
        public int? Malappuram { get; set; }
        public int? Palakkad { get; set; }
        public int? Thrissur { get; set; }
        public int? Ernakulam { get; set; }
        public int? Alappuzha { get; set; }
        public int? Kottayam { get; set; }
        public int? Idukki { get; set; }
        public int? Pathanamthitta { get; set; }
        public int? Kollam { get; set; }
        public int? Thiruvananthapuram { get; set; }
        public int Total { get; set; }
    }
}
