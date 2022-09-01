using System;
using System.Collections.Generic;

namespace GymApi.Models
{
    public partial class Gym
    {
        public Gym()
        {
            Coach = new HashSet<Coach>();
            Member = new HashSet<Member>();
        }

        public int GymId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public ICollection<Coach> Coach { get; set; }
        public ICollection<Member> Member { get; set; }
    }
}
