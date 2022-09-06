using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10.Models
{
    public class Manager : Employee
    {
       

        public Manager(int id, string firstName, string lastName,  string department, Gender gender, int salary):base(firstName, lastName,  gender)
        {
            Id = id;
            Salary = salary;
            Department = department;
        }
        public int Id { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
       

        public  string ManagerDetails()
        {

            return $"{FirstName} {LastName} ({Gender}) is a manager on {Department} department with Salary {Salary}";
        }
       
   
    }
}
