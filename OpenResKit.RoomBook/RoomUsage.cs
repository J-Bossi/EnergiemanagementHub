using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.RoomBook
{
  public class RoomUsage
  {
    public int Id { get; set; }
    public virtual string Group { get; set; } // Gruppe
    public virtual string Key { get; set; } // Schlüssel
    public virtual string Example { get; set; } // Beispiele
    public virtual string UsageGroup { get; set; } // Nutzergruppe
  }
}
