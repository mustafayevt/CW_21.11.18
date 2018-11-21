using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_21._11._18
{
    class Sections
    {
        public List<Doctor> doctors = new List<Doctor>(3);
    }
    class Doctor : Person
    {
        public Doctor(string name, string surname)
            : base(name, surname) { }
        public Dictionary<string, bool> Worktime = new Dictionary<string, bool>()
        {
            {"09:00-11:00",false },
            {"12:00-14:00",false },
            {"15:00-17:00",false }
        };
        
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
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

    }
}
