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

using System.IO;

namespace OpenResKit.Organisation
{
  public static class MapModelFactory
  {
    public static Map CreateMap(string name, Stream imageStream)
    {
      byte[] byteArray;
      using (var br = new BinaryReader(imageStream))
      {
        byteArray = br.ReadBytes((int) imageStream.Length);
      }

      return new Map
             {
               MapSource = new MapSource
                           {
                             BinarySource = byteArray
                           },
               Name = name
             };
    }

    public static MapPosition CreateMapPosition(Map map, double x, double y)
    {
      return new MapPosition
             {
               Map = map,
               XPosition = x,
               YPosition = y
             };
    }
  }
}