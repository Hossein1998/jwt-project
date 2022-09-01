using System;
using System.Collections.Generic;

namespace GymApi.Models
{
    public partial class FoodScheduleId
    {
        public int FoodScheduleId1 { get; set; }
        public int? MemberId { get; set; }
        public string Egg { get; set; }
        public string Potato { get; set; }
        public string Milk { get; set; }
        public string Chicken { get; set; }
        public string Fish { get; set; }

        public Member Member { get; set; }
    }
}
