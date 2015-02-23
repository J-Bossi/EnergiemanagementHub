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

using System.Collections.Generic;
using OpenResKit.RoomBook;

namespace OpenResKit.Energy
{
  public class Consumer
  {
    public virtual int Id { get; set; }
    public virtual string Manufacturer { get; set; } //GER_HST
    public virtual bool IsMachine { get; set; }
    public virtual string Identifier { get; set; } //GER_BEZ
    public int? Year { get; set; } //GER_BAUJ
    public virtual double? PowerOutput { get; set; } //GERAETE_EIG_KW
    public virtual double? PowerCurrent { get; set; } //GERAETE_EIG_AMPERE
    public virtual ICollection<Reading> Readings { get; set; }
    public virtual Room Room { get; set; }
    public virtual Distributor Distributor { get; set; }
    public virtual ConsumerGroup ConsumerGroup { get; set; }
    public virtual string Name { get; set; }
    public virtual ConsumerType ConsumerType { get; set; }
  }
}