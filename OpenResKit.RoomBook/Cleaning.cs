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
// Copyright (c) 2015, Johannes Boﬂ - HTW Berlin

#endregion

namespace OpenResKit.RoomBook
{
  public class Cleaning
  {
    public virtual string CleaningPerWeek { get; set; }
    public virtual bool External { get; set; }
    public virtual bool Internal { get; set; }
    public virtual bool Special { get; set; }
    public virtual string Weekdays { get; set; }
    public virtual string Rota { get; set; }
    public int Id { get; set; }
  }
}