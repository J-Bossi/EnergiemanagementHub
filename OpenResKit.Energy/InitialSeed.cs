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

using System;
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


            Employee responsibleSubject1 = ResponsibleSubjectModelFactory.CreateEmployee("Hans", "Müller");
            Employee responsibleSubject2 = ResponsibleSubjectModelFactory.CreateEmployee("Gabi", "Becker");
            EmployeeGroup responsibleGroup = ResponsibleSubjectModelFactory.CreateGroup("Praktikanten");

            dbContext.Set<EmployeeGroup>()
                .Add(responsibleGroup);

            dbContext.Set<Employee>()
                .Add(responsibleSubject1);

            dbContext.Set<Employee>()
                .Add(responsibleSubject2);

            Assembly assembly = Assembly.GetExecutingAssembly();

            DateTime creationDate = DateTime.Now;

            var measureCollection1 = new Collection<Measure>();
            var measureCollection2 = new Collection<Measure>();

            for (int i = 0; i < 10; i++)
            {
                Document word = DocumentModelFactory.CreateDocument("doc1.docx",
                    assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyword.docx"));
                Document pdf = DocumentModelFactory.CreateDocument("pdf1.pdf",
                    assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummypdf.pdf"));

                string measureName = "Container leeren";
                string description = "Der Container ist voll";
                string evaluationText = "Das Leeren hat funktioniert";
                DateTime entryDate = DateTime.Now.AddDays(-i*7 - 1);
                DateTime dueDate = DateTime.Now.AddDays(-i*7);
                int status = 2;
                double rating = 0.8;
                int priority = 0;
                MeasureImageSource imageSource =
                    ModelFactory.CreateImage(
                        assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyImage1.jpg"));
                Measure measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate,
                    dueDate, responsibleSubject1, status, priority, creationDate, rating, imageSource,
                    new Collection<Document>
                    {
                        word,
                        pdf
                    });
                measureCollection1.Add(measure);
            }

            for (int i = 5; i < 10; i++)
            {
                Document word = DocumentModelFactory.CreateDocument("doc1.docx",
                    assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyword.docx"));
                Document pdf = DocumentModelFactory.CreateDocument("pdf1.pdf",
                    assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummypdf.pdf"));

                string measureName = "Container leeren";
                string description = "Der Container ist voll";
                DateTime dueDate = DateTime.Now.AddDays(-i*7);
                string evaluationText = string.Empty;
                DateTime? entryDate = null;
                int status = 0;
                double ratig = 0.0;
                int priority = 1;
                MeasureImageSource imageSource =
                    ModelFactory.CreateImage(
                        assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyImage2.jpg"));
                Measure measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate,
                    dueDate, responsibleSubject1, status, priority, creationDate, ratig, imageSource,
                    new Collection<Document>
                    {
                        word,
                        pdf
                    });
                measureCollection1.Add(measure);
            }


            for (int i = 0; i < 5; i++)
            {
                string measureName = "Stromzähler ablesen";
                string description = "Stromzähler befindet sich im Keller";
                string evaluationText = string.Empty;
                DateTime? entryDate = null;
                DateTime dueDate = DateTime.Now.AddDays(-i*3);
                int status = 0;
                double rating = 0.2;
                int priority = 2;
                MeasureImageSource imageSource =
                    ModelFactory.CreateImage(
                        assembly.GetManifestResourceStream("OpenResKit.Energy.Resources.dummyImage3.jpg"));
                Measure measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate,
                    dueDate, responsibleSubject1, status, priority, creationDate, rating, imageSource, null);
                measureCollection2.Add(measure);
            }


            for (int i = 5; i < 10; i++)
            {
                string measureName = "Stromzähler ablesen";
                string description = "Stromzähler befindet sich im Keller";
                string evaluationText = "Das Ablesen war wegen dem ganzen Schmutz kaum möglich";
                DateTime entryDate = DateTime.Now.AddDays(-i*30);
                DateTime dueDate = DateTime.Now.AddDays(-i*30);
                int status = 2;
                double rating = 0.4;
                int priority = 2;
                Measure measure = ModelFactory.CreateMeasure(measureName, description, evaluationText, entryDate,
                    dueDate, responsibleSubject1, status, priority, creationDate, rating, null, null);
                measureCollection2.Add(measure);
            }

            Catalog catalog1 = ModelFactory.CreateCatalog("Katalog 1", "Das ist Katalog 1", measureCollection1);
            Catalog catalog2 = ModelFactory.CreateCatalog("Katalog 2", "Das ist Katalog 2", measureCollection2);


            dbContext.Set<Catalog>()
                .Add(catalog1);
            dbContext.Set<Catalog>()
                .Add(catalog2);

            var subMeasure = new SubMeasure
            {
                IsCompleted = false,
                Name = "Test Untermaßnahme",
                ReleatedMeasure = measureCollection1[0],
                ResponsibleSubject = responsibleSubject1
            };

            dbContext.Set<SubMeasure>().Add(subMeasure);

            ConsumerGroup consumerGroupEDV = ModelFactory.CreateConsumerGroup("01 EDV", "PCs, Server");
            ConsumerGroup consumerGroupAnlagen = ModelFactory.CreateConsumerGroup("02 Anlagen", "SGM, Förderbändern");

            dbContext.Set<ConsumerGroup>().Add(consumerGroupEDV);
            dbContext.Set<ConsumerGroup>().Add(consumerGroupAnlagen);

            dbContext.SaveChanges();
        }
    }
}