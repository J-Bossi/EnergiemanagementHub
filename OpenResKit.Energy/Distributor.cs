using System.Collections.Generic;

namespace OpenResKit.Measure
{
    public class Distributor
    {
        public virtual int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Reading> Readings { get; set; }

        public bool IsMainDistributor { get; set; }

        public Room Room { get; set; }
    }
}