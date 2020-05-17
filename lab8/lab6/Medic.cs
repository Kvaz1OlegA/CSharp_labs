using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Medic:Scientist
    {
        public Medic(int money, int intelligence, string name, string surname, int age, string country) : base(money, intelligence, name, surname, age, country) { }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendLine("Sphere: Medecine");
            return output.ToString();
        }
    }
}
