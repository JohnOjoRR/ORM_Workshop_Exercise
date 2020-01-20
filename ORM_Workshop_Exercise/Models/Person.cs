using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public enum Gender
    {
        M, F
    }
    public enum Active
    {
        Y, N
    }
    public class Person
    {
        public Guid PersonId { get; set; }
        public String PersonName { get; set; }
        public String PersonSurname { get; set; }
        public Gender? Gender { get; set; }
        public String PersonIDnumber { get; set; }
        public String PersonEmail { get; set; }
        public String PersonContactNumber { get; set; }
        public Active? Active { get; set; }
    }
}
