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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Reflection;
using OpenResKit.DomainModel;
using OpenResKit.Energy.Factory;
using OpenResKit.Organisation;

namespace OpenResKit.Energy
{
  [Export(typeof (IInitialSeed))]
  internal class InitialSeed : IInitialSeed
  {
    public void Seed(DbContext dbContext)
    {
      //var grabber = new NovaGrabber();

      //foreach (Machine machine in grabber.getData())
      //{
      //    dbContext.Set<Machine>().AddOrUpdate(machine);
      //}

      var responsibleSubject1 = ResponsibleSubjectModelFactory.CreateEmployee("Hans", "Müller");
      var responsibleSubject2 = ResponsibleSubjectModelFactory.CreateEmployee("Gabi", "Becker");
      var responsibleGroup = ResponsibleSubjectModelFactory.CreateGroup("Praktikanten");

      dbContext.Set<EmployeeGroup>()
               .Add(responsibleGroup);

      dbContext.Set<Employee>()
               .Add(responsibleSubject1);

      dbContext.Set<Employee>()
               .Add(responsibleSubject2);

      var assembly = Assembly.GetExecutingAssembly();

      var creationDate = DateTime.Now;

      var measureCollection1 = new List<EnergyMeasure>();
      var measureCollection2 = new List<EnergyMeasure>();

      for (var i = 0; i < 10; i++)
      {
        var word = DocumentModelFactory.CreateDocument("doc1.docx",
          assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyword.docx"));
        var pdf = DocumentModelFactory.CreateDocument("pdf1.pdf",
          assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummypdf.pdf"));

        var measureName = "Container leeren";
        var description = "Der Container ist voll";
        var evaluationText = "Das Leeren hat funktioniert";
        var entryDate = DateTime.Now.AddDays(-i * 7 - 1);
        var dueDate = DateTime.Now.AddDays(-i * 7);
        var status = 2;
        var rating = 0.8;
        var priority = 0;
        var imageSource =
          ModelFactory.CreateImage(assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyImage1.jpg"));
        var measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate, dueDate,
          responsibleSubject1, status, priority, creationDate, rating, imageSource, new Collection<Document>
          {
            word,
            pdf
          });
        measureCollection1.Add(measure);
      }

      for (var i = 5; i < 10; i++)
      {
        var word = DocumentModelFactory.CreateDocument("doc1.docx",
          assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyword.docx"));
        var pdf = DocumentModelFactory.CreateDocument("pdf1.pdf",
          assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummypdf.pdf"));

        var measureName = "Container leeren";
        var description = "Der Container ist voll";
        var dueDate = DateTime.Now.AddDays(-i * 7);
        var evaluationText = string.Empty;
        DateTime? entryDate = null;
        var status = 0;
        var ratig = 0.0;
        var priority = 1;
        var imageSource =
          ModelFactory.CreateImage(assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyImage2.jpg"));
        var measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate, dueDate,
          responsibleSubject1, status, priority, creationDate, ratig, imageSource, new Collection<Document>
          {
            word,
            pdf
          });
        measureCollection1.Add(measure);
      }

      for (var i = 0; i < 5; i++)
      {
        var measureName = "Stromzähler ablesen";
        var description = "Stromzähler befindet sich im Keller";
        var evaluationText = string.Empty;
        DateTime? entryDate = null;
        var dueDate = DateTime.Now.AddDays(-i * 3);
        var status = 0;
        var rating = 0.2;
        var priority = 2;
        var imageSource =
          Measure.ModelFactory.CreateImage(assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyImage3.jpg"));
        var measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate, dueDate,
          responsibleSubject1, status, priority, creationDate, rating, imageSource, null);
        measureCollection2.Add(measure);
      }

      for (var i = 5; i < 10; i++)
      {
        var measureName = "Stromzähler ablesen";
        var description = "Stromzähler befindet sich im Keller";
        var evaluationText = "Das Ablesen war wegen dem ganzen Schmutz kaum möglich";
        var entryDate = DateTime.Now.AddDays(-i * 30);
        var dueDate = DateTime.Now.AddDays(-i * 30);
        var status = 2;
        var rating = 0.4;
        var priority = 2;
        var measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate, dueDate,
          responsibleSubject1, status, priority, creationDate, rating, null, null);
        measureCollection2.Add(measure);
      }

      var subMeasure = new SubMeasure
      {
        IsCompleted = false,
        Name = "Test Untermaßnahme",
        ReleatedMeasure = measureCollection1[0],
        ResponsibleSubject = responsibleSubject1
      };

      dbContext.Set<SubMeasure>()
               .Add(subMeasure);

      var sgm = new ConsumerType
      {
        TypeName = "SGM"
      };
      var auto = new ConsumerType
      {
        TypeName = "Automaten"
      };
      var pc = new ConsumerType
      {
        TypeName = "PCs"
      };
      var server = new ConsumerType
      {
        TypeName = "Server"
      };
      dbContext.Set<ConsumerType>()
               .Add(sgm);
      dbContext.Set<ConsumerType>()
               .Add(auto);
      dbContext.Set<ConsumerType>()
               .Add(pc);
      dbContext.Set<ConsumerType>()
               .Add(server);

      var consumerGroupEdv = ModelFactory.CreateConsumerGroup("01 EDV");
      consumerGroupEdv.ConsumerTypes.Add(pc);
      consumerGroupEdv.ConsumerTypes.Add(server);
      var consumerGroupAnlagen = ModelFactory.CreateConsumerGroup("02 Anlagen");
      consumerGroupAnlagen.ConsumerTypes.Add(auto);
      consumerGroupAnlagen.ConsumerTypes.Add(sgm);

      dbContext.Set<ConsumerGroup>()
               .Add(consumerGroupEdv);
      dbContext.Set<ConsumerGroup>()
               .Add(consumerGroupAnlagen);
      dbContext.SaveChanges();

      var distributorvi = ModelFactory.CreateDistributor("Verteiler Villa");
      var distributorA = ModelFactory.CreateDistributor("Verteiler Gebäude A");
      var distributorSchiene = ModelFactory.CreateDistributor("Stromschine 1");

      dbContext.Set<Distributor>()
               .Add(distributorvi);
      dbContext.Set<Distributor>()
               .Add(distributorA);
      dbContext.Set<Distributor>()
               .Add(distributorSchiene);

      var auto1 = ModelFactory.CreateConsumer("Automat 1", distributorA, consumerGroupAnlagen, auto);
      var auto2 = ModelFactory.CreateConsumer("Automat 2", distributorA, consumerGroupAnlagen, auto);
      var sgm1 = ModelFactory.CreateConsumer("Spritzgußmaschine 1", distributorA, consumerGroupAnlagen, sgm);
      var sgm2 = ModelFactory.CreateConsumer("Spritzgußmaschine 2", distributorSchiene, consumerGroupAnlagen, sgm);
      var sgm3 = ModelFactory.CreateConsumer("Spritzgußmaschine 3", distributorSchiene, consumerGroupAnlagen, sgm);
      var sgm4 = ModelFactory.CreateConsumer("Spritzgußmaschine 4", distributorSchiene, consumerGroupAnlagen, sgm);

      dbContext.Set<Consumer>()
               .Add(auto1);
      dbContext.Set<Consumer>()
               .Add(auto2);
      dbContext.Set<Consumer>()
               .Add(sgm1);
      dbContext.Set<Consumer>()
               .Add(sgm2);
      dbContext.Set<Consumer>()
               .Add(sgm3);
      dbContext.Set<Consumer>()
               .Add(sgm4);

      dbContext.SaveChanges();
    }
  }
}