using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.RoomBook
{
  public class Flooring
  {
    public int Id { get; set; }
    public virtual string FloorCovering { get; set; } //Bodenbelag
    public virtual string Manufacturer { get; set; } //Hersteller
    public virtual string Material { get; set; } //Material
    public virtual string Color { get; set; } //Farbe
    public virtual string Info { get; set; } // Info
    public virtual string CleaningMethod { get; set; } // Reinigungsmethode Unterhalt
    public virtual string ApprovedDetergents { get; set; } // Zugelassene Reinigungsmittel
  }
}
