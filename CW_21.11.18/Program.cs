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
            int count = 1;
            bool registiration = false;
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
            List<Person> person = new List<Person>()
            {
                new Person(Console.ReadLine(),Console.ReadLine())
            };
            person[person.Count - 1].email = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                if (registiration)
                {
                    Console.WriteLine("Enter Name, Surname, Email");
                    person.Add(new Person(Console.ReadLine(), Console.ReadLine()));
                    person[person.Count - 1].email = Console.ReadLine();
                }
                Console.WriteLine("Pediatriya     - 1");
                Console.WriteLine("Travmatologiya - 2");
                Console.WriteLine("Stamatologiya  - 3");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            //Doctors
                            foreach (var item in Pediatriya.doctors)
                            {
                                Console.WriteLine($"{count++}: {item.name} {item.surname}");
                            }
                            count = 1;
                            choice = Console.ReadLine();
                            //Times
                            if (choice == "1")
                            {
                                again:;
                                ShowDoc_Pediatriya(0);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Pediatriya(0,0)) goto again;
                                if (choice == "2") if (!CheckTime_Pediatriya(1,0)) goto again;
                                if (choice == "3") if (!CheckTime_Pediatriya(2,0)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                            if (choice == "2")
                            {
                                again:;
                                ShowDoc_Pediatriya(1);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Pediatriya(0,1)) goto again;
                                if (choice == "2") if (!CheckTime_Pediatriya(1,1)) goto again;
                                if (choice == "3") if (!CheckTime_Pediatriya(2,1)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                            if (choice == "3")
                            {
                                again:;
                                ShowDoc_Pediatriya(2);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Pediatriya(0,2)) goto again;
                                if (choice == "2") if (!CheckTime_Pediatriya(1,2)) goto again;
                                if (choice == "3") if (!CheckTime_Pediatriya(2,2)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                        }
                        break;
                    case "2":
                        {
                            //Doctors
                            foreach (var item in Travmatologiya.doctors)
                            {
                                Console.WriteLine($"{count++}: {item.name} {item.surname}");
                            }
                            count = 1;
                            choice = Console.ReadLine();
                            //Times
                            if (choice == "1")
                            {
                                again:;
                                ShowDoc_Travmatologiya(0);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Travmatologiya(0, 0)) goto again;
                                if (choice == "2") if (!CheckTime_Travmatologiya(1, 0)) goto again;
                                if (choice == "3") if (!CheckTime_Travmatologiya(2, 0)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                            if (choice == "2")
                            {
                                again:;
                                ShowDoc_Travmatologiya(1);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Travmatologiya(0, 1)) goto again;
                                if (choice == "2") if (!CheckTime_Travmatologiya(1, 1)) goto again;
                                if (choice == "3") if (!CheckTime_Travmatologiya(2, 1)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                            if (choice == "3")
                            {
                                again:;
                                ShowDoc_Travmatologiya(2);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Travmatologiya(0, 2)) goto again;
                                if (choice == "2") if (!CheckTime_Travmatologiya(1, 2)) goto again;
                                if (choice == "3") if (!CheckTime_Travmatologiya(2, 2)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                        }
                        break;
                    case "3":
                        {
                            //Doctors
                            foreach (var item in Stamotologiya.doctors)
                            {
                                Console.WriteLine($"{count++}: {item.name} {item.surname}");
                            }
                            count = 1;
                            choice = Console.ReadLine();
                            //Times
                            if (choice == "1")
                            {
                                again:;
                                ShowDoc_Stamotologiya(0);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Stamotologiya(0, 0)) goto again;
                                if (choice == "2") if (!CheckTime_Stamotologiya(1, 0)) goto again;
                                if (choice == "3") if (!CheckTime_Stamotologiya(2, 0)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                            if (choice == "2")
                            {
                                again:;
                                ShowDoc_Stamotologiya(1);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Stamotologiya(0, 1)) goto again;
                                if (choice == "2") if (!CheckTime_Stamotologiya(1, 1)) goto again;
                                if (choice == "3") if (!CheckTime_Stamotologiya(2, 1)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                            if (choice == "3")
                            {
                                again:;
                                ShowDoc_Stamotologiya(2);
                                choice = Console.ReadLine();
                                //Reserv
                                if (choice == "1") if (!CheckTime_Stamotologiya(0, 2)) goto again;
                                if (choice == "2") if (!CheckTime_Stamotologiya(1, 2)) goto again;
                                if (choice == "3") if (!CheckTime_Stamotologiya(2, 2)) goto again;
                                Console.ReadKey();
                                registiration = true;
                                continue;
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
            void ShowDoc_Pediatriya(int i)
            {
                foreach (var item in Pediatriya.doctors[i].Worktime)
                {
                    Console.Write($"{count++}: {item.Key} - ");
                    if (!item.Value) Console.WriteLine("Avialible");
                    else Console.WriteLine("Not Avialible");
                }
                count = 1;
            }
            bool CheckTime_Pediatriya(int i,int h)
            {
                if (!Pediatriya.doctors[h].Worktime.ElementAt(i).Value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Reservation was succesfull!");
                    Console.ResetColor();
                    Pediatriya.doctors[h].Worktime[Pediatriya.doctors[h].Worktime.ElementAt(i).Key] = true;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This time already reserved, please, choose another time");
                    Console.ResetColor();
                    return false;
                }
            }
            //
            void ShowDoc_Travmatologiya(int i)
            {
                foreach (var item in Travmatologiya.doctors[i].Worktime)
                {
                    Console.Write($"{count++}: {item.Key} - ");
                    if (!item.Value) Console.WriteLine("Avialible");
                    else Console.WriteLine("Not Avialible");
                }
                count = 1;
            }
            bool CheckTime_Travmatologiya(int i,int h)
            {
                if (!Travmatologiya.doctors[h].Worktime.ElementAt(i).Value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Reservation was succesfull!");
                    Console.ResetColor();
                    Travmatologiya.doctors[h].Worktime[Travmatologiya.doctors[h].Worktime.ElementAt(i).Key] = true;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This time already reserved, please, choose another time");
                    Console.ResetColor();
                    return false;
                }
            }
            //
            void ShowDoc_Stamotologiya(int i)
            {
                foreach (var item in Stamotologiya.doctors[i].Worktime)
                {
                    Console.Write($"{count++}: {item.Key} - ");
                    if (!item.Value) Console.WriteLine("Avialible");
                    else Console.WriteLine("Not Avialible");
                }
                count = 1;
            }
            bool CheckTime_Stamotologiya(int i,int h)
            {
                if (!Stamotologiya.doctors[h].Worktime.ElementAt(i).Value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Reservation was succesfull!");
                    Console.ResetColor();
                    Stamotologiya.doctors[h].Worktime[Stamotologiya.doctors[h].Worktime.ElementAt(i).Key] = true;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This time already reserved, please, choose another time");
                    Console.ResetColor();
                    return false;
                }
            }
        }
    }
}
