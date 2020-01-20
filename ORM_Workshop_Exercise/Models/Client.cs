using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public class Client : Person
    {
        public Guid ClientId { get; set; }
        //public Guid PersonId { get; set; }
        //public Person Person { get; set; }
        public virtual Guid? PersonId { get; set; }
        public virtual Person Person { get; set; }
        public Guid IllnessId { get; set; }
        public Illness Illness { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
