using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public class Visits
    {
        public Guid VisitsId { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
