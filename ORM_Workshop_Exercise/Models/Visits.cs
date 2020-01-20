using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public class Visits
    {
        public Guid VisitID { get; set; }
        public Guid DoctorID { get; set; }
        public Guid ClientID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Client Client { get; set; }
    }
}
