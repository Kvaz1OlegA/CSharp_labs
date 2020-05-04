using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Physicist:Scientist
    {
        public Physicist(int money, int intelligence, string name, string surname, int age, string country) : base(money, intelligence, name, surname, age, country) { }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendLine("Sphere: Physics");
            return output.ToString();
        }
    }
}
