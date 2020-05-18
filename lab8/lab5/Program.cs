using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        delegate void Show(List<Transport> transports);

        static Show PrintMenu = delegate (List<Transport> transports)
        {
            Console.WriteLine("(number lenght should be 6 simbols)\n");
            Console.WriteLine("Id\tBrand\t\tCountry\t\tBody\t\t\tWheels\tSeats\tColor\tNumber\tEngine");
            foreach (Transport transport in transports)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}\t{5}\t{6}\t{7}\t{8}", transport.Id, transport.Brand, transport.Country, transport.Body, transport.Wheels, transport.Seats, transport.Color, transport.Number, transport.Engine);
            }
            Console.WriteLine("\n1.Add transport\n2.Delete\n3.Set all data\n4.Set color\n5.Set number\n6.Hear signal\n7.Set brand\n8.Set wheels\n9.Set seats\n10.Set country\n11.Engine\n12.Signal\n13.Speed info\n14.Calculate distance\n15.Exit");
        };

        public static void Check(out int num)
        {
            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter necessary data");
            }
        }
        public static void CreateCar(List<Transport> transports)
        {
            Console.Clear();
            Console.WriteLine("Choose transport\n1.Base transport\n2.Auto\n3.Bmw\n4.Jaguar\n5.Volvo\n6.Pegiout");
            int choose;
            Check(out choose);
            switch (choose)
            {
                case 1:
                    transports.Add(new Transport());
                    Console.Clear();
                    break;
                case 2:
                    transports.Add(new Auto());
                    Console.Clear();
                    break;
                case 3:
                    transports.Add(new BMW());
                    Console.Clear();
                    break;
                case 4:
                    transports.Add(new Jaguar());
                    Console.Clear();
                    break;
                case 5:
                    transports.Add(new Volvo());
                    Console.Clear();
                    break;
                case 6:
                    transports.Add(new Pegiout());
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        public static void SetAllData(List<Transport> transports, int id)
        {
            int color, wheels, seats;
            string num, brand, country, body;
            foreach (Transport transport in transports)
            {
                if(transport.Id == id)
                {
                    Console.WriteLine("Choose color\n1.Red\n2.Orange\n3.Yellow\n4.Green\n5.Blue\n6.Violet");
                    Check(out color);
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
                    transport.ChooseColor(color);
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
                PrintMenu(transports);
                int choose;
                int number;
                Check(out choose);
                switch (choose)
                {
                    case 1:
                        CreateCar(transports);
                        break;
                    case 2:
                        Console.WriteLine("Ender Id");
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        SetAllData(transports, number);
                        Console.Clear();
                        break;
                    case 4:
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        int color;
                        foreach (Transport transport in transports)
                        {
                            if(transport.Id == number)
                            {
                                Console.WriteLine("1.Red\n2.Orange\n3.Yellow\n4.Green\n5.Blue\n6.Violet");
                                Check(out color);
                                transport.ChooseColor(color);
                            }
                        }
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Ender Id");
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        string num;
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Enter number");
                                num = Console.ReadLine();
                                transport.Number = num ;
                            }
                        }
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Ender Id");
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        bool engine;
                        Console.WriteLine("Turn the key(choose i/o)");
                        switch(Console.ReadLine())
                        {
                            case "i":
                                engine = true;
                                break;
                            case "o":
                                engine = false;
                                break;
                            default:
                                engine = false;
                                break;
                        }
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                transport.StartCar += DisplayMessage;
                                transport.KeyTurning(engine);
                                transport.StartCar -= DisplayMessage;
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 12:
                        Console.WriteLine("Ender Id");
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
                        Console.WriteLine("Ender Id");
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                                throw new Exception();
                            if (number > transports.Count)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        Console.Clear();
                        foreach (Transport transport in transports)
                        {
                            if (transport.Id == number)
                            {
                                Console.WriteLine("Speed characteristics of car");
                                Console.WriteLine("Your car : Id - " + transport.Id + "\t Brand - " + transport.Brand);
                                transport.SpeedInfo();
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 14:
                        Transport.Distance distance = (speed, time) => speed * time;
                        Console.WriteLine("Enter speed of transport");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter time of transport");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine("Distance"+distance(x, y));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 15:
                        k = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
