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

using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenResKit.DomainModel;


namespace OpenResKit.Energy
{
  [Export(typeof (IDomainEntityConfiguration))]
  public class MeasureConfigurations : EntityTypeConfiguration<EnergyMeasure>, IDomainEntityConfiguration
  {
    public MeasureConfigurations()
    {
      HasMany(m => m.AttachedDocuments)
        .WithOptional()
        .WillCascadeOnDelete();
      HasOptional(m => m.MeasureImageSource)
        .WithOptionalPrincipal()
        .WillCascadeOnDelete(true);
      HasOptional(m => m.Consumer)
        .WithMany();
      HasOptional(m => m.ConsumptionActual)
        .WithMany();
      HasOptional(m => m.ConsumptionNormative)
        .WithMany();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }


  [Export(typeof (IDomainEntityConfiguration))]
  public class ConsumerConfiguration : EntityTypeConfiguration<Consumer>, IDomainEntityConfiguration
  {
    public ConsumerConfiguration()
    {
      HasOptional(c => c.Room)
        .WithMany();
      HasMany(c => c.Readings)
        .WithOptional()
        .WillCascadeOnDelete(true);
      HasOptional(c => c.Distributor)
        .WithMany();
      HasOptional(c => c.ConsumerGroup)
        .WithMany();
      HasOptional(c => c.ConsumerType)
        .WithMany();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configuration)
    {
      configuration.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ConsumerGroupConfiguration : EntityTypeConfiguration<ConsumerGroup>, IDomainEntityConfiguration
  {
    public ConsumerGroupConfiguration()
    {
      HasMany(cg => cg.ConsumerTypes)
        .WithRequired()
        .WillCascadeOnDelete(true);
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configuration)
    {
      configuration.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class DistributorConfiguration : EntityTypeConfiguration<Distributor>, IDomainEntityConfiguration
  {
    public DistributorConfiguration()
    {
      HasMany(d => d.Readings)
        .WithOptional()
        .WillCascadeOnDelete(true);
      HasOptional(c => c.Room)
  .WithMany();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configuration)
    {
      configuration.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ReadingConfiguration : EntityTypeConfiguration<Reading>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configuration)
    {
      configuration.Add(this);
    }
  }


  [Export(typeof (IDomainEntityConfiguration))]
  public class SubMeasureConfigurations : EntityTypeConfiguration<SubMeasure>, IDomainEntityConfiguration
  {
    public SubMeasureConfigurations()
    {
      HasOptional(s => s.ReleatedMeasure);
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ConsumerTypeConfiguration : EntityTypeConfiguration<ConsumerType>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
}