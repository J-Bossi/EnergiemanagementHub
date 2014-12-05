using OpenResKit.Organisation;

namespace OpenResKit.Energy
{
    public class SubMeasure
    {
        public virtual int Id { get; set; } // eindeutige ID der Maßnahme
        public virtual string Name { get; set; } // Name = Name der Untermaßnahme
        public virtual bool IsCompleted { get; set; } // Untermaßnahme abgeschlossen ja/nein
        public virtual ResponsibleSubject ResponsibleSubject { get; set; }
        // Verantwortlicher Mitarbeiter für entsprechende Untermaßnahme
        public virtual EnergyMeasure ReleatedMeasure { get; set; } // Maßnahmenzugehörigkeit
    }
}