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
// Copyright (c) 2015, Johannes Boß - HTW Berlin

#endregion

using System.Collections.Generic;
using OpenResKit.RoomBook;

namespace OpenResKit.Energy
{
  public class Distributor
  {
    public virtual int Id { get; set; }
    public string Name { get; set; }
    public string Comment { get; set; }
    public virtual ICollection<Reading> Readings { get; set; }
    public bool IsMainDistributor { get; set; }
    public Room Room { get; set; }
  }
}