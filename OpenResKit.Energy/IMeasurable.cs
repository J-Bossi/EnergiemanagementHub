using System.Collections.Generic;

namespace OpenResKit.Energy
{
    public interface IMeasurable
    {
        string Name { get; set; }
        ICollection<EnergyMeasure> Measures { get; set; }
    }
}