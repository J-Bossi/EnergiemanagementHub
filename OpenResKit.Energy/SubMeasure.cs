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
    public virtual EnergyMeasure ReleatedMeasure { get; set; }
  }
}