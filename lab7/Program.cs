using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an expression");
            string definition = Console.ReadLine();
            string[] nums = definition.Split(' ');
            Fraction a, b;
            int a_int, b_int;
            double a_double, b_double;
            if (nums.Length==2 && Fraction.TryParse(nums[0], out a) && Fraction.TryParse(nums[1], out b))
            {
                Console.WriteLine("\nDifferent operations, comparison and integer and real representation");
                Console.WriteLine(" +\t" + (a + b).ToString());
                Console.WriteLine(" -\t" + (a - b).ToString());
                Console.WriteLine(" *\t" + (a * b).ToString());
                Console.WriteLine(" /\t" + (a / b).ToString());
                Console.WriteLine("a>b\t" + (a > b));
                Console.WriteLine("a<b\t" + (a < b));
                Console.WriteLine("a>=b\t" + (a >= b));
                Console.WriteLine("a<=b\t" + (a <= b));
                Console.WriteLine("a==b\t" + (a == b));
                Console.WriteLine("a!=b\t" + (a != b));
                a_int = a; b_int = b;
                a_double = a; b_double = b;
                Console.WriteLine("a(int) = " + a_int + " b(int) = " + b_int);
                Console.WriteLine("a(double) = " + a_double + " b(double) = " + b_double);
                Console.WriteLine("a = " + a.ToString());
                Console.WriteLine("b = " + b.ToString());
            }
            else
            {
                Console.WriteLine("Wroooooooooong");
            }
            Console.ReadKey();
        }
    }
}
