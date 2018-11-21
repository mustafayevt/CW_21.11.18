using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_21._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Sections Pediatriya = new Sections();
            Pediatriya.doctors.Add(new Doctor("Saleh", "Abdulla"));
            Pediatriya.doctors.Add(new Doctor("Islam", "Omarov"));
            Pediatriya.doctors.Add(new Doctor("Tural", "Mustafayev"));
            //
            Sections Travmatologiya = new Sections();
            Travmatologiya.doctors.Add(new Doctor("Eli", "Agalarov"));
            Travmatologiya.doctors.Add(new Doctor("Anar", "Zadeh"));
            Travmatologiya.doctors.Add(new Doctor("Fuad", "Shumalov"));
            //
            Sections Stamotologiya = new Sections();
            Stamotologiya.doctors.Add(new Doctor("Elcin", "Memmedov"));
            Stamotologiya.doctors.Add(new Doctor("Kamran", "Zadeh"));
            Stamotologiya.doctors.Add(new Doctor("Aga", "Shumalov"));

            Console.WriteLine("Enter Name, Surname, Email");
            Person person = new Person(Console.ReadLine(), Console.ReadLine());
            person.email = Console.ReadLine();
            while (true)
            {

            Console.WriteLine("Pediatriya     - 1");
            Console.WriteLine("Travmatologiya - 2");
            Console.WriteLine("Stamatologiya  - 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    {
                        int i = 1;
                        foreach (var item in Pediatriya.doctors)
                        {
                            Console.WriteLine($"{i++} : {item.name} - {item.surname} ");
                        }
                        i = 1;
                        var tmp = Console.ReadLine();
                        switch (tmp)
                        {
                            case "1":
                                {
                                    foreach (var item in Pediatriya.doctors[0].WorkTime)
                                    {
                                        Console.WriteLine($"{i++} : {item} - {Pediatriya.doctors[0].checkTime[i-2]}");
                                    }
                                }
                                break;
                            case "2":
                                {
                                    foreach (var item in Pediatriya.doctors[1].WorkTime)
                                    {
                                        Console.WriteLine($"{i++} : {item} - {Pediatriya.doctors[1].checkTime[i - 2]}");
                                    }
                                }
                                break;
                            case "3":
                                {
                                    foreach (var item in Pediatriya.doctors[2].WorkTime)
                                    {
                                        Console.WriteLine($"{i++} : {item} - {Pediatriya.doctors[2].checkTime[i - 2]}");
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
            }
    }
    class Sections
    {
        public List<Doctor> doctors = new List<Doctor>(3);
    }
    class Doctor : Person
    {
        public Doctor(string name, string surname)
            : base(name, surname) { }

        public List<string> WorkTime = new List<string>()
        {
            "09:00-11:00",
            "12:00-14:00",
            "15:00-17:00"
        };
        public bool[] checkTime = new bool[3];
    } 
    class Person
    {
        public Person(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

    }
}
