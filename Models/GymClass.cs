using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym015.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime => StartTime + Duration;
        public string Decrtiption { get; set; }

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; }
    }
}
