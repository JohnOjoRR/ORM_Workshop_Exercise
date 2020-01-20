using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Workshop_Exercise.Models
{
    public class Client
    {
        public Guid ClientID { get; set; }
        public Guid PersonID { get; set; }
        public Guid IllnessID { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
