﻿#region License

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
  public class ConsumerGroup : IMeasurable
  {
    public virtual int Id { get; set; }
    public virtual string GroupName { get; set; }
    public virtual string GroupDescription { get; set; }
    public string Name { get; set; }
    public ICollection<EnergyMeasure> Measures { get; set; }
  }
}