using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        public static void Check(out int num)
        {
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter necessary data");
            }
        }
        public static void SetAllData(List<Transport> transports, int id)
        {
            int wheels, seats;
            string color, num, brand, country, body;
            foreach (Transport transport in transports)
            {
                if (transport.Id == id)
                {
                    Console.WriteLine("Set color");
                    color = Console.ReadLine();
                    Console.WriteLine("Create number");
                    num = Console.ReadLine();
                    Console.WriteLine("Enter wheels");
                    Check(out wheels);
                    Console.WriteLine("Enter seats");
                    Check(out seats);
                    Console.WriteLine("Enter brand");
                    brand = Console.ReadLine();
                    Console.WriteLine("Enter country");
                    country = Console.ReadLine();
                    Console.WriteLine("Enter body");
                    body = Console.ReadLine();
                    transport.Color = color;
                    transport.Number = num;
                    transport.Wheels = wheels;
                    transport.Seats = seats;
                    transport.Brand = brand;
                    transport.Country = country;
                    transport.Body = body;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Transport> transports = new List<Transport>();
            bool k = true;
            while (k)
            {
                Console.WriteLine("(number lenght should be 6 simbols)\n");
                Console.WriteLine("Id\tBrand\t\tCountry\t\tBody\t\t\tWheels\tSeats\tColor\tNumber\tEngine");
                foreach (Transport transport in transports)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}\t{5}\t{6}\t{7}\t{8}", transport.Id, transport.Brand, transport.Country, transport.Body, transport.Wheels, transport.Seats, transport.Color, transport.Number, transport.Engine);
                }
                Console.WriteLine("\n1.Add transport\n2.Delete\n3.Set all data\n4.Set color\n5.Set number\n6.Hear signal\n7.Set brand\n8.Set wheels\n9.Set seats\n10.Set country\n11.Engine\n12.Signal\n13.Exit");
                int choose;
                int number;
                Check(out choose);
                switch (choose)
                {
                    case 1:
                        transports.Add(new Transport());
                        break;
                    case 2:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                transports.Remove(transport);
                                break;
                            }
                        }
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        SetAllData(transports, number);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        string color;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("1.Red\n2.Orange\n3.Yellow\n4.Green\n5.Blue\n6.Violet");
                                color = Console.ReadLine();
                                transport.Color = color;
                            }
                        }
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        string num;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Enter number");
                                num = Console.ReadLine();
                                transport.Number = num;
                            }
                        }
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        Console.Clear();
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine(transport.Signal);
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        string brand;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Enter brand");
                                brand = Console.ReadLine();
                                transport.Brand = brand;
                            }
                        }
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        int wheels;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Enter wheels");
                                Check(out wheels);
                                transport.Wheels = wheels;
                            }
                        }
                        Console.Clear();
                        break;
                    case 9:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        int seats;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Enter seats");
                                Check(out seats);
                                transport.Seats = seats;
                            }
                        }
                        Console.Clear();
                        break;
                    case 10:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        Console.WriteLine("Enter country");
                        string country;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Enter country");
                                country = Console.ReadLine();
                                transport.Country = country;
                            }
                        }
                        Console.Clear();
                        break;
                    case 11:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        string engine;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Switch keys (on/off)");
                                engine = Console.ReadLine();
                                transport.Engine = engine;
                            }
                        }
                        Console.Clear();
                        break;
                    case 12:
                        Console.WriteLine("Ender Id");
                        Check(out number);
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("That the signal of your car");
                                Console.WriteLine(transport.Signal);
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 13:
                        k = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
