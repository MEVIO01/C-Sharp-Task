﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class Person
    {
        public int Id { get; set; }

        public double Salary { get; set; }

        public string CompanyName { get; set; }

        public string Name { get; set; }

        public Person(int id, double salary, string companyName, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.CompanyName = companyName;
        }
        public override string ToString()
        {
            return "Id : " + this.Id + Environment.NewLine +
                "Name : " + this.Name + Environment.NewLine + "Company name : " + this.CompanyName +
                Environment.NewLine + "Salary : " + this.Salary.ToString();
        }
    }
}
