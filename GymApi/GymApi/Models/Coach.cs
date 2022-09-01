using System;
using System.Collections.Generic;

namespace GymApi.Models
{
    public partial class Coach
    {
        public Coach()
        {
            Member = new HashSet<Member>();
        }

        public int CoachId { get; set; }
        public int? GymId { get; set; }
        public string Age { get; set; }
        public string Exprience { get; set; }
        public string NumberOfMemberManege { get; set; }

        public Gym Gym { get; set; }
        public ICollection<Member> Member { get; set; }
    }
}
