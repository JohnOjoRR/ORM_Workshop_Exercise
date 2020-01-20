using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public enum Specialist
    {
        Y, N
    }
    public class Doctor : Person
    {
        public Guid DoctorId { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public Specialist Specialist { get; set; }
        public String CountryCode { get; set; }
        //public virtual ICollection<Visits> Visits { get; set; }
    }
}
