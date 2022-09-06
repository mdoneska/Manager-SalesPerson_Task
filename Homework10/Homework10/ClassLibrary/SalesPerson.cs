using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework10.Models
{
    public class SalesPerson : Employee
    {
        ///???????

        public SalesPerson(string firstName, string lastName,  Gender gender) : base(firstName, lastName,  gender)
        {
            Salary = 500;
        }
        public int Salary { get; private set; }
        public static void PrintByFirstName(List<SalesPerson> salesPersons)
        {
            Console.WriteLine("Sales Persons ordered by First Name:");
            salesPersons.ToList().OrderBy(s => s.FirstName).ToList().ForEach(sp =>
            {
                Console.WriteLine($"First Name: {sp.FirstName}, Last Name: {sp.LastName}, Salary: {sp.Salary}");
            });
        }
        public static void PrintFemales(List<SalesPerson> salesPersons)
        {
            Console.WriteLine("Sales Persons - only female");
            salesPersons.Where(s => s.Gender.Equals(Gender.Female)).ToList().
            ForEach(s => Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}, Salary: {s.Salary}"));
        }

    }
}
