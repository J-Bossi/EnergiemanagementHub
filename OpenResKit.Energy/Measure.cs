using System;
using System.Collections.Generic;
using OpenResKit.Organisation;

namespace OpenResKit.Energy
{
    public class EnergyMeasure : Measure.Measure
    {
      

        public virtual string RoomNumber { get; set; } // Raum
        public virtual string Department { get; set; } // Abteilung
        public virtual string Building { get; set; } // Gebäude
        public virtual string ConsumerUnit { get; set; } // Betrachteter Verbraucher
        public virtual string Parameter { get; set; } // Kenngröße -> Einheit EnPI
        public virtual string Meter { get; set; } // Verwendetes Messgerät
        public virtual double Investment { get; set; } // Nötige Investitionskosten

        public virtual double SavedMoneyShould { get; set; }
        // kalkulierter Geldbetrag der nach gelungener Maßnahme eingespart wird (theoretischer Soll-Wert -> Potenzial)
        public virtual double SavedMoneyIs { get; set; }
        // Geldbetrag der nach gelungener Maßnahme eingespart ist (tatsächliche Einsparung nach beendeter Maßnahme)
        public virtual double SavedMoneyAtm { get; set; } // Aktueller Ist-Verbrauchswert in Euro
        public virtual double SavedWattAtm { get; set; } // Aktueller Ist-Verbrauchswert in kWh
        public virtual double SavedWattShould { get; set; }
        // kalkulierter Energieverbrauch der nach gelungener Maßnahme eingespart wird (theoretischer Soll-Wert -> Potenzial)
        public virtual double SavedWattIs { get; set; }
        // Energieeinsparung der nach gelungener Maßnahme eingespart ist (tatsächliche Einsparung nach beendeter Maßnahme)
        public virtual double SavedCo2 { get; set; } // CO2 Einsparung durch gelungene Maßnahme

        public virtual double PaybackTime { get; set; }
        // Zeit (GeplanteKosten / GeldEinsparung) bis Maßnahme sich rentiert hat (Amortisationszeit in Tagen)
        public virtual double FailureMoney { get; set; }
        public virtual double ElectricityCosts { get; set; } // Elektrizitätskosten
        public virtual string Reference { get; set; } // Verweis auf ...

        public virtual IMeasurable ReferedObject { get; set; }

       
    }
}