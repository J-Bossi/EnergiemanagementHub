using System.Collections.Generic;

namespace OpenResKit.Energy
{
    public class Catalog
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual ICollection<Measure> Measures { get; set; }
    }
}