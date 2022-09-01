using System;
using System.Collections.Generic;

namespace GymApi.Models
{
    public partial class PracticeSchedule
    {
        public int PracticeScheduleId { get; set; }
        public int? MemberId { get; set; }
        public string JoloBazoDambal { get; set; }
        public string PoshtBazo { get; set; }
        public string JoloBzoHalter { get; set; }
        public string JoloPa { get; set; }
        public string PoshtePa { get; set; }
        public string SaghPa { get; set; }
        public string PresSineHalter { get; set; }

        public Member Member { get; set; }
    }
}
