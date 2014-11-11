using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Energy
{
    public class Reading
    {
        public virtual int Id { get; set; }

        public virtual long CounterReading { get; set; }
    
        public virtual DateTime ReadingDate { get; set; }
    }
}
