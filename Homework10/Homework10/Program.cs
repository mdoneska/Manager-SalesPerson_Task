using Homework10.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework10
{
    public class Program
    {
        public static List<Manager> ListOfManagers = new List<Manager>();
        public static List<SalesPerson> ListOfSalesPerson = new List<SalesPerson>();

        static void Main(string[] args)
        {
            while (true)
            {
                ToMainMenu();
            }

    }

        public static Manager CreateManager()
        {
            Console.Clear();
            Console.WriteLine("Create new Manager");

            Console.WriteLine("Insert ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Insert Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Insert department: ");
            string department = Console.ReadLine();

            Console.WriteLine("Select Gender (M or F): ");
            string genderInput = Console.ReadLine();
            Gender gender;
            if (genderInput == "M")
            {
                gender = Gender.Male;
            }
            else if (genderInput == "F")
            {
                gender = Gender.Female;
            }
            else
            {
                throw new ApplicationException("Invalid gender input.");
            }

            Console.WriteLine("Insert salary: ");
            int salary = int.Parse(Console.ReadLine());

            Manager newManager = new Manager(id, firstName, lastName, department, gender, salary);
            ListOfManagers.Add(newManager);
            return newManager;
        }
        public static void ChooseManager()
        {
            Console.Clear();
            if (ListOfManagers.Count == 0)
            {
                Console.WriteLine("Empty managers list. First you need to create at least one manager.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please select manager by choosing id from the following list");
                ListOfManagers.ForEach(manager => Console.WriteLine($" {manager.Id}) {manager.FirstName} {manager.LastName}"));
                Console.WriteLine("Select 0 to go back");
                string optionChosen = Console.ReadLine();
                if (optionChosen == "0")
                {
                    ToMainMenu();
                }
                else
                {
                    int optionChosenInt = 0;
                    if(!int.TryParse(optionChosen, out optionChosenInt))
                    {
                        ChooseManager();
                    }
                    // Find the manager with the id that was chosen
                    Manager foundManager = ListOfManagers.FirstOrDefault(manager => manager.Id == int.Parse(optionChosen));
                  if (foundManager != null)
                    {
                        ManagersMenu(foundManager);
                    }
                  else
                    {
                        ChooseManager();
                    }
                }
            }

        }

        static void ManagersMenu(Manager manager)
        {
            Console.Clear();
            Console.WriteLine($"Manager's menu - Selected manager is ({manager.FirstName} {manager.LastName})");
            Console.WriteLine("Choose options:");
            Console.WriteLine("1) Add new Sales Person");
            Console.WriteLine("2) Print Manager's Details");
            Console.WriteLine("3) Print Sales Persons - ordered br First Name");
            Console.WriteLine("4) Print Sales Persons - only female");
            Console.WriteLine("Select 0 to go back");
            string optionChosen = Console.ReadLine();
            switch (optionChosen)
            {
                case "0":
                    ChooseManager();
                    break;
                case "1":
                    CreateSalesPerson();
                    break;
                case "2":
                    Console.WriteLine(manager.ManagerDetails());
                    break;
                case "3":
                    SalesPerson.PrintByFirstName(ListOfSalesPerson);
                    break;
                case "4":
                    SalesPerson.PrintFemales(ListOfSalesPerson);
                    break;
            }
            Console.ReadLine();
            ManagersMenu(manager);
        }


        public static SalesPerson CreateSalesPerson()
        {
            Console.WriteLine("Add new Sales Person");


            Console.WriteLine("Insert First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Insert Last Name:");
            string lastName = Console.ReadLine();


            Console.WriteLine("Select Gender (M or F): ");
            string genderInput = Console.ReadLine();
            Gender gender;
            if (genderInput == "M")
            {
                gender = Gender.Male;
            }
            else if (genderInput == "F")
            {
                gender = Gender.Female;
            }
            else
            {
                throw new ApplicationException("Invalid gender input.");
            }
            SalesPerson newSalesPerson = new SalesPerson( firstName, lastName,gender);
            ListOfSalesPerson.Add(newSalesPerson);
            return newSalesPerson;
        }

        public static void ToMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create new Manager");
            Console.WriteLine("2) Choose Manager");
            Console.WriteLine("0) Exit");
            string mainManuChoice = Console.ReadLine();

            switch (mainManuChoice)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    CreateManager();
                    break;
                case "2":
                    ChooseManager();
                    break;
                default:
                    break;
            }
        }

      


    }
}
