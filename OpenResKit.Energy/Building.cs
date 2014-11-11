using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Energy
{
    public class Building 
    {
        public virtual int Id { get; set; }

        public virtual string BuildingName { get; set; }
        public string Name { get; set; }
    }
}
