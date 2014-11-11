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

namespace OpenResKit.Organisation
{
  public static class ResponsibleSubjectModelFactory
  {
    public static Employee CreateEmployee(string firstName, string lastName, string number = null)
    {
      return new Employee
             {
               FirstName = firstName,
               LastName = lastName,
               Number = number
             };
    }

    public static EmployeeGroup CreateGroup(string name)
    {
      return new EmployeeGroup
             {
               Name = name
             };
    }
  }
}