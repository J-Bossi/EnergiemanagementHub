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

using Devart.Data.MySql;

namespace OpenResKit.Energy
{
  public class DbConnector

  {
    private MySqlConnection m_Connection;

    public bool IsConnect()
    {
      if (m_Connection == null)
      {
        string connectionString = string.Format("Server=servdata; database={0}; UID=NovaRead; password=novaread", "nova2");
        m_Connection = new MySqlConnection(connectionString);
        m_Connection.Open();
      }
      return true;
    }

    public MySqlConnection GetConnection()
    {
      return m_Connection;
    }

    public void Close()
    {
      m_Connection.Close();
    }
  }
}