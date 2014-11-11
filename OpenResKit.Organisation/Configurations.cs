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

using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenResKit.DomainModel;

namespace OpenResKit.Organisation
{
  [Export(typeof (IDomainEntityConfiguration))]
  public class AppointmentConfiguration : EntityTypeConfiguration<Appointment>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }


  [Export(typeof (IDomainEntityConfiguration))]
  public class ResponsibleSubjectConfiguration : EntityTypeConfiguration<ResponsibleSubject>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class EmployeeConfiguration : EntityTypeConfiguration<Employee>, IDomainEntityConfiguration
  {
    public EmployeeConfiguration()
    {
      HasMany(s => s.Groups)
        .WithMany();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class EmployeeGroupConfiguration : EntityTypeConfiguration<EmployeeGroup>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class SeriesConfiguration : EntityTypeConfiguration<Series>, IDomainEntityConfiguration
  {
    public SeriesConfiguration()
    {
      Ignore(s => s.CycleEnum);
      HasMany(s => s.WeekDays)
        .WithOptional()
        .WillCascadeOnDelete(true);
      HasRequired(s => s.SeriesColor)
        .WithRequiredPrincipal()
        .WillCascadeOnDelete(true);
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ScheduledTaskConfiguration : EntityTypeConfiguration<ScheduledTask>, IDomainEntityConfiguration
  {
    public ScheduledTaskConfiguration()
    {
      HasRequired(st => st.DueDate)
        .WithOptional()
        .WillCascadeOnDelete(true);
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class MapConfiguration : EntityTypeConfiguration<Map>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class MapPositionConfiguration : EntityTypeConfiguration<MapPosition>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }


  [Export(typeof (IDomainEntityConfiguration))]
  public class DocumentConfiguration : EntityTypeConfiguration<Document>, IDomainEntityConfiguration
  {
    public DocumentConfiguration()
    {
      HasOptional(d => d.DocumentSource)
        .WithOptionalDependent()
        .WillCascadeOnDelete();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class DocumentSourceConfiguration : EntityTypeConfiguration<DocumentSource>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
}