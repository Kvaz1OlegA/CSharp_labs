using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Scientist:Human, IScientist
    {
        public bool Discovery { get; set; }
        public int Money { get; set; }
        public int Intelligence { get; set; }
        public Scientist(int money, int intelligence,string name, string surname, int age, string country):base(name, surname, age, country)
        {
            Money = money;
            Intelligence = intelligence;
        }
        public void Research()
        {
            Random random = new Random();
            if (Intelligence - 15 < 85)
            { 
                Intelligence += random.Next(1, 15); 
            }
            if (random.Next(1, 100 - Intelligence) < 15)
            {
                Discovery = true;
            }
            else
            {
                Discovery = false;
            }
        }
        public override string ToString()
         {
             StringBuilder output = new StringBuilder(base.ToString());
             output.AppendLine(string.Format("Money: {0}", Money));
             output.AppendLine(string.Format("Intelligence: {0}", Intelligence));
            output.AppendLine(string.Format("Discovery: {0}", Discovery));
            return output.ToString();
         }
        public int CompareTo(object o)
        {
            Scientist another = o as Scientist;
            if (Money < another.Money)
                return -1;
            if (Money > another.Money)
                return 1;
            return 0;
        }
    }
}
