using System.Collections.Generic;

namespace OpenResKit.Measure
{
    public interface IMeasurable
    {
        string Name { get; set; }
        ICollection<Measure> Measures { get; set; }
    }
}