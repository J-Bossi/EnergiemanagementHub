using System.Collections.Generic;

namespace OpenResKit.Energy
{
    public interface IMeasurable
    {
        string Name { get; set; }
        ICollection<Measure> Measures { get; set; }
    }
}