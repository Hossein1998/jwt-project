using System;
using System.Collections.Generic;

namespace GymApi.Models
{
    public partial class Member
    {
        public Member()
        {
            FoodScheduleId = new HashSet<FoodScheduleId>();
            PracticeSchedule = new HashSet<PracticeSchedule>();
        }

        public int MemberId { get; set; }
        public int? CoachId { get; set; }
        public int? GymId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string TimeAttendance { get; set; }
        public byte[] AddImage { get; set; }

        public Coach Coach { get; set; }
        public Gym Gym { get; set; }
        public ICollection<FoodScheduleId> FoodScheduleId { get; set; }
        public ICollection<PracticeSchedule> PracticeSchedule { get; set; }
    }
}
