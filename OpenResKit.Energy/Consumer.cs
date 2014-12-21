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

namespace OpenResKit.Energy
{
  public class Consumer
  {
    public virtual int Id { get; set; }
    public virtual int Localid { get; set; } //"GER_ID"
    public virtual int LocalGr { get; set; } //"GER_NR"
    public virtual string LocalGnr { get; set; } //"GER_GNR
    public virtual string InventoryNr { get; set; } //"GER_INV
    public virtual string LocalSerialNr { get; set; } //"GER_SNR
    public virtual string Manufacturer { get; set; } //GER_HST
    public virtual string Identifier { get; set; } //GER_BEZ
    public virtual string Comment { get; set; } //GER_BEM
    public int? Year { get; set; } //GER_BAUJ
    public virtual long? PowerOutput { get; set; } //GERAETE_EIG_KW
    public virtual long? PowerCurrent { get; set; } //GERAETE_EIG_AMPERE
    public virtual ICollection<Reading> Readings { get; set; }
    public virtual Room Room { get; set; }
    public virtual Distributor Distributor { get; set; }
    public virtual ConsumerGroup ConsumerGroup { get; set; }
    public string Name { get; set; }
    public ConsumerType ConsumerType { get; set; }
  }
}