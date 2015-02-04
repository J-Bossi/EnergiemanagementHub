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
// Copyright (c) 2015, Johannes Boß - HTW Berlin

#endregion

using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenResKit.DomainModel;

namespace OpenResKit.RoomBook
{
  [Export(typeof (IDomainEntityConfiguration))]
  public class RoomConfiguration : EntityTypeConfiguration<Room>, IDomainEntityConfiguration
  {
    public RoomConfiguration()
    {
      HasOptional(r => r.CleaningInterval)
        .WithMany();
      HasOptional(r => r.Flooring)
        .WithMany();
      HasOptional(r => r.RoomInformation)
        .WithMany();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class RoomUsageConfiguration : EntityTypeConfiguration<RoomUsage>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
  [Export(typeof(IDomainEntityConfiguration))]
  public class FlooringConfiguration : EntityTypeConfiguration<Flooring>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
  [Export(typeof(IDomainEntityConfiguration))]
  public class CleaningConfiguration : EntityTypeConfiguration<Cleaning>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
}