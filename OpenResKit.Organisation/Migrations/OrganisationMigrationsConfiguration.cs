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
using System.Data.Entity.Migrations;
using OpenResKit.DomainModel;

namespace OpenResKit.Organisation.Migrations
{
  [Export]
  internal sealed class OrganisationMigrationsConfiguration : DbMigrationsConfiguration<DomainModelContext>
  {
    [ImportingConstructor]
    public OrganisationMigrationsConfiguration()
    {
      AutomaticMigrationsEnabled = false;
      MigrationsDirectory = @"Migrations";
    }

    protected override void Seed(DomainModelContext context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data. E.g.
      //
      //    context.People.AddOrUpdate(
      //      p => p.FullName,
      //      new Person { FullName = "Andrew Peters" },
      //      new Person { FullName = "Brice Lambson" },
      //      new Person { FullName = "Rowan Miller" }
      //    );
      //
    }
  }
}