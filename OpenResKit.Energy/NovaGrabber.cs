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
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using Devart.Data.MySql;
using OpenResKit.Energy.Factory;

namespace OpenResKit.Energy
{
  public class NovaGrabber
  {
    private readonly DbConnector connector = new DbConnector();

    public Collection<Consumer> getData()
    {
      var collection = new Collection<Consumer>();
      if (connector.IsConnect())
      {
        string query = "SELECT * FROM geraete WHERE GERAETE_TYP_GER_TYP_ID = 8;";
        var command = new MySqlCommand(query, connector.GetConnection());
        var adapter = new MySqlDataAdapter();
        adapter.SelectCommand = command;

        var machineDataSet = new DataSet();
        adapter.Fill(machineDataSet, "geraete");
        foreach (DataTable myTable in machineDataSet.Tables)
        {
          foreach (DataRow myRow in myTable.Rows)
          {
            collection.Add(ConsumerFactory.CreateMachine(myRow));
          }
        }

        string propertiesQuery = "SELECT * FROM geraete_eig;";
        var propertiescommand = new MySqlCommand(propertiesQuery, connector.GetConnection());
        var propertiesadapter = new MySqlDataAdapter();
        propertiesadapter.SelectCommand = propertiescommand;

        var propertiesDataSet = new DataSet();
        propertiesadapter.Fill(propertiesDataSet, "geraete_eig");

        foreach (DataTable myTable in propertiesDataSet.Tables)
        {
          foreach (DataRow myRow in myTable.Rows)
          {
            Consumer machine = new Consumer();
    //        Consumer machine = collection.SingleOrDefault(c => c.Localid == (int) myRow["GERAETE_GER_ID"]);
            if (machine != null)
            {
              machine.PowerCurrent = myRow["GERAETE_EIG_AMPERE"] == DBNull.Value
                ? 0
                : Convert.ToInt64(myRow["GERAETE_EIG_AMPERE"]);
              machine.PowerOutput = myRow["GERAETE_EIG_KW"] == DBNull.Value
                ? 0
                : Convert.ToInt64(myRow["GERAETE_EIG_KW"]);
            }
          }
        }
      }
      return collection;
    }
  }
}