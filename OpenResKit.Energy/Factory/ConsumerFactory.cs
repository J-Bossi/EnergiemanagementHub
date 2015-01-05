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

using System;
using System.Data;

namespace OpenResKit.Energy.Factory
{
  public class ConsumerFactory
  {
    internal static Consumer CreateMachine(DataRow myRow)
    {
      var machine = new Consumer();
      //machine.Localid = (int) myRow["GER_ID"];

      //machine.LocalGr = (int) myRow["GER_NR"];
      //machine.LocalGnr = myRow["GER_GNR"] == DBNull.Value
      //  ? ""
      //  : (string) myRow["GER_GNR"];
      //machine.InventoryNr = myRow["GER_INV"] == DBNull.Value
      //  ? ""
      //  : (string) myRow["GER_INV"];
      //machine.LocalSerialNr = myRow["GER_SNR"] == DBNull.Value
      //  ? ""
      //  : (string) myRow["GER_SNR"];
      //machine.Manufacturer = myRow["GER_HST"] == DBNull.Value
      //  ? ""
      //  : (string) myRow["GER_HST"];
      //machine.Identifier = myRow["GER_BEZ"] == DBNull.Value
      //  ? ""
      //  : (string) myRow["GER_BEZ"];
      //machine.Comment = myRow["GER_BEM"] == DBNull.Value
      //  ? ""
      //  : (string) myRow["GER_BEM"];
      //machine.Year = (int) myRow["GER_BAUJ"];
      
      //GERAETE_EIG_KW   PowerOutput 

      //GERAETE_EIG_AMPERE   PowerCurrent 

      return machine;
    }
  }
}