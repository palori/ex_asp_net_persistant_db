using System;

namespace Employees_MySQL.Models
{
    public class Employee
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Job {get; set;}
        public double Salary {get; set;}
    }
}