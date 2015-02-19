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
using System.Data.Entity.Migrations;
using OpenResKit.DomainModel;

namespace OpenResKit.RoomBook.Migrations
{
  [Export(typeof (DbMigrationsConfiguration))]
  internal sealed class RoomBookMigrationsConfiguration : DbMigrationsConfiguration<DomainModelContext>
  {
    [ImportingConstructor]
    public RoomBookMigrationsConfiguration()
    {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
    }

    protected override void Seed(DomainModelContext context) {}
  }
}