using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        [DllImport("LabDll.dll")]
        public static extern int BinPow(int a, int n);
        static void Main(string[] args)
        {
            int a, n;
            Console.WriteLine("Enter a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine("Enter n");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input");
            }
            Console.Clear();
            Console.WriteLine(a+"^"+n+"="+BinPow(a, n));
            Console.ReadKey();
        }
    }
}
