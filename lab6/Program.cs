using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Premium(List<Scientist> scientists)
        {
            List<Scientist> nominamted = new List<Scientist>();
            int num = 0;
            int counter = 0;
            foreach(Scientist scientist in scientists)
            {
                if(scientist.Discovery)
                {
                    nominamted.Add(scientist);
                    scientist.Discovery = false;
                    num++;
                }
            }
            if (num==0)
                return;
            Console.WriteLine("Nominees for this award");
            foreach (Scientist scientist in nominamted)
            {
                Console.WriteLine(scientist.Surname + " " + scientist.Name);
            }
            Random random = new Random();
            int prize = random.Next(0, num - 1);
            int money = random.Next(100, 1000);
            foreach (Scientist scientist1 in nominamted)
            {
                if(counter == prize)
                {
                    foreach (Scientist scientist in scientists)
                    {
                        if(scientist.Name == scientist1.Name)
                        {
                            scientist.Money += money;
                            Console.WriteLine(string.Format("\n{0} {1} become the Nobel Prize winner and awarded {2}", scientist.Name, scientist.Surname, money.ToString()));
                            return;
                        }
                    }
                }
                counter++;
            }
        }
        static void Main(string[] args)
        {
            int choose;
            List<Scientist> scientists = new List<Scientist>()
            {
                new Physicist(500, 45, "Michael", "Faradey", 55, "England"),
                new Medic(300, 30, "Alexander", "Fleming", 39, "England"),
                new Chemist(600, 31, "Dmitry", "Mendeleev", 47, "Russia"),
                new Physicist(50, 29, "Albert", "Einstein", 29, "Germany"),
                new Medic(150, 55, "Harvey", "Cushing", 35, "USA"),
                new Chemist(200, 22, "Alfred", "Nobel", 36, "Sweden"),
                new Physicist(450, 35, "Pierre", "Curie", 35, "Poland"),
                new Medic(100, 33, "Nikolay", "Pirogov", 45, "Russia"),
                new Chemist(350, 27, "Antoine", "Lavoisier", 40, "France")
            };
            while(true)
            {
                foreach (Scientist scientist in scientists)
                {
                    Console.WriteLine(scientist.ToString());
                }
                Console.WriteLine("Enter choose");
                Console.WriteLine("1.Nobel Prize\n2.Make a research\n3.Finish");
                choose = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(choose)
                {
                    case 1:
                        Premium(scientists);
                        break;
                    case 2:
                        Console.WriteLine("Enter the surname");
                        foreach(Scientist scientist in scientists)
                        {
                            Console.WriteLine(scientist.Surname);
                        }
                        Console.WriteLine("\n");
                        string surname = Console.ReadLine();
                        foreach(Scientist scientist in scientists)
                        {
                            if (scientist.Surname == surname)
                            {
                                if (!scientist.Discovery)
                                {
                                    scientist.Research();
                                    if (scientist.Discovery)
                                    {
                                        Console.WriteLine("Research was succesful");
                                    }
                                    else
                                    {
                                        Console.WriteLine("May be next time");
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
