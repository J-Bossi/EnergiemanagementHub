using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Energy
{
    public class Room 
    {
        public virtual int Id { get; set; }

        public virtual Building Building { get; set; }

        public virtual string RoomNumber { get; set;}

        public virtual int Floor { get; set; } //Etage (0,1,2,...)

        public virtual string Level { get; set; } // EG, OG

        public virtual long Space { get; set; } // square Meters

        public virtual string RoomInformation { get; set; }

        public virtual string RoomUsage { get; set; }
    
    }
}
