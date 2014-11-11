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
// Copyright (c) 2013, HTW Berlin

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenResKit.Organisation
{
  public static class SeriesModelFactory
  {
    private static readonly Random m_Random = new Random();

    public static Series CreateSeries(string name, DateTime begin, DateTime end, DateTime repeatUntilDate, bool repeat, bool endsWithDate, bool isAllDay, int cycle, int recurrenceInterval,
      int numberOfRecurrences, IEnumerable<System.DayOfWeek> weekDays)
    {
      var colorBytes = new byte[3];
      m_Random.NextBytes(colorBytes);

      return new Series
             {
               Name = name,
               Begin = begin,
               End = end,
               RepeatUntilDate = repeatUntilDate,
               Repeat = repeat,
               EndsWithDate = endsWithDate,
               IsAllDay = isAllDay,
               Cycle = cycle,
               RecurrenceInterval = recurrenceInterval,
               NumberOfRecurrences = numberOfRecurrences,
               WeekDays = weekDays.Select(dow => new DayOfWeek
                                                 {
                                                   WeekDay = (int) DateTime.Now.DayOfWeek
                                                 })
                                  .ToList(),
               SeriesColor = new SeriesColor
                             {
                               R = colorBytes[0],
                               G = colorBytes[1],
                               B = colorBytes[2]
                             }
             };
    }
  }
}