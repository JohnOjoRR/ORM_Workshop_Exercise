using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public class Doctor
    {
        public Guid DoctorID { get; set; }
        public Guid ClientID { get; set; }
        public Guid Specialist { get; set; }
        public String CountryCode { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
