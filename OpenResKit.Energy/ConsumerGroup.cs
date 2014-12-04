using System.Collections.Generic;

namespace OpenResKit.Measure
{
    public class ConsumerGroup : IMeasurable
    {
        public virtual int Id { get; set; }

        public virtual string GroupName { get; set; }
        public virtual string GroupDescription { get; set; }

        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }
    }
}