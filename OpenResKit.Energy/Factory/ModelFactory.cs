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
using System.Collections.Generic;
using System.IO;
using OpenResKit.Organisation;

namespace OpenResKit.Energy.Factory
{
    internal static class ModelFactory
    {
        public static Measure CreateMeasure(string name, string description, string evaluation, DateTime? entryDate,
            DateTime dueDate, ResponsibleSubject responsibleSubject, int status, int priority,
            DateTime creationDate, double rating, MeasureImageSource imageSource = null,
            ICollection<Document> attachedDocuments = null)
        {
            return new Measure
            {
                Name = name,
                Description = description,
                Evaluation = evaluation,
                EntryDate = entryDate,
                DueDate = dueDate,
                ResponsibleSubject = responsibleSubject,
                Status = status,
                Priority = priority,
                CreationDate = creationDate,
                MeasureImageSource = imageSource,
                AttachedDocuments = attachedDocuments,
                EvaluationRating = rating
            };
        }

        public static Catalog CreateCatalog(string name, string description, ICollection<Measure> measures)
        {
            return new Catalog
            {
                Name = name,
                Description = description,
                Measures = measures
            };
        }

        public static MeasureImageSource CreateImage(Stream stream)
        {
            byte[] byteArray;
            using (var br = new BinaryReader(stream))
            {
                byteArray = br.ReadBytes((int) stream.Length);
            }

            return new MeasureImageSource
            {
                BinarySource = byteArray
            };
        }

        public static ConsumerGroup CreateConsumerGroup(string p1, string p2)
        {
            return new ConsumerGroup
            {
                GroupName = p1,
                GroupDescription = p2
            };
        }

        public static Consumer CreateConsumer(string p1, Distributor d1)
        {
            return new Consumer
            {
                Name = p1,
                Distributor = d1
            };
        }

        public static Distributor CreateDistributor(string p1)
        {
            return new Distributor
            {
                Name = p1
            };
        }
    }
}