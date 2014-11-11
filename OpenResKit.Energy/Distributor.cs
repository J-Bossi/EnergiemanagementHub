using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Energy
{
    public class Distributor
    {
        public virtual int Id { get; set; }

        public virtual ICollection<Reading> Readings { get; set; }
     
        public bool IsMainDistributor { get; set; }

        public Room Room { get; set; }

    }
}
