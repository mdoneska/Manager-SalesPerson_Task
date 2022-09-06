using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public Gender Gender { get; set; }
    }
}
