using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Human(string name, string surname, int age, string country)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Country = country;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("{0} {1}, {2} y.o., {3}", Surname, Name, Age.ToString(), Country));
            return output.ToString();
        }
    }
}
