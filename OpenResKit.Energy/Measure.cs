using System;
using System.Collections.Generic;
using OpenResKit.Organisation;

namespace OpenResKit.Measure
{
    public class Measure
    {
        public virtual int Id { get; set; } // eindeutige ID der Maßnahme
        public virtual string Name { get; set; } // Name = Name der Aktion
        public virtual string Description { get; set; } // Beschreibung
        public virtual string Evaluation { get; set; } // Bewertung
        public virtual DateTime? EntryDate { get; set; } // erfüllt am ??
        public virtual DateTime DueDate { get; set; } // geplant am ??
        public virtual DateTime CreationDate { get; set; } // erstellt am ??
        public virtual ResponsibleSubject ResponsibleSubject { get; set; } // verantwortlicher Mitarbeiter
        public virtual int Status { get; set; } // Status (laufend, abgeschlossen ...)
        public virtual int Priority { get; set; } // Priorität (wenig, mittel, hoch)
        public virtual MeasureImageSource MeasureImageSource { get; set; } // Bild einer Maßnahme anhängen
        public virtual ICollection<Document> AttachedDocuments { get; set; } // Dokument einer Maßnahme anhängen
        public virtual double EvaluationRating { get; set; } // Abschlussbewertung

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

        internal Status StatusEnum
        {
            get { return (Status) Status; }
            set
            {
                if ((Status != (int) value))
                {
                    Status = (int) value;
                }
            }
        }

        internal Priority PriorityEnum
        {
            get { return (Priority) Priority; }
            set
            {
                if ((Priority != (int) value))
                {
                    Priority = (int) value;
                }
            }
        }
    }
}