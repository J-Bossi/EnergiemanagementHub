using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Energy
{
    public interface IMeasurable
    {
        string Name { get; set; }
        ICollection<Measure> Measures { get; set; } 
    }
}
