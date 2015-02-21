#region License

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at
//  
// http://www.apache.org/licenses/LICENSE-2.0.html
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  
// Copyright (c) 2014, Johannes Boß - HTW Berlin

#endregion

using OpenResKit.RoomBook;

namespace OpenResKit.Energy
{
  public class EnergyMeasure : Measure.Measure
  {
    public virtual string RoomNumber { get; set; } // Raum
    public virtual string Department { get; set; } // Abteilung
    public virtual string ConsumerUnit { get; set; } // Betrachteter Verbraucher
    public Consumer Consumer { get; set; }
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

    public virtual double FailureMoney { get; set; }
    public virtual string Reference { get; set; }
    public Reading ConsumptionActual { get; set; }
    public Reading ConsumptionNormative { get; set; }
  }
}