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

namespace OpenResKit.RoomBook
{
  public class Room
  {
    public virtual int Id { get; set; }
    public virtual string Building { get; set; }
    public virtual string RoomNumber { get; set; }
    public virtual int Floor { get; set; } //Etage (0,1,2,...)
    public virtual string Level { get; set; } //Ebene
    public virtual float? Space { get; set; } // square Meters
    public virtual float? Height { get; set; }
    public virtual RoomUsage RoomInformation { get; set; }
    public virtual Flooring Flooring { get; set; }
    public virtual Cleaning CleaningInterval { get; set; }
  }
}