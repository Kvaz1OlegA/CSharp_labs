using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7
{
    class Fraction:IComparable, IEquatable<Fraction>
    {
        int numerator;
        int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a!=b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        public static int SmallestCommonMultiple(int a, int b)
        {
            return Math.Abs(a) * Math.Abs(b) / GreatestCommonDivisor(a, b);
        }

        public static void Simplify(ref int a, ref int b)
        {
            int temp = GreatestCommonDivisor(a, b);
            a /= temp;
            b /= temp;
            if(a<0&&b<0)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
            }
            else if(a>0 && b<0)
            {
                a *= -1;
                b *= -1;
            }
        }

        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            int temp_denominator = SmallestCommonMultiple(num1.denominator, num2.denominator);
            int numerator_1 = num1.numerator * (SmallestCommonMultiple(num1.denominator, num2.denominator) / num1.denominator);
            int numerator_2 = num2.numerator * (SmallestCommonMultiple(num1.denominator, num2.denominator) / num2.denominator);
            int temp_numerator = numerator_1 + numerator_2;
            if(temp_numerator!=0)
                Simplify(ref temp_numerator, ref temp_denominator);
            return new Fraction(temp_numerator, temp_denominator);
        }

        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            int temp_denominator = SmallestCommonMultiple(num1.denominator, num2.denominator);
            int numerator_1 = num1.numerator * (SmallestCommonMultiple(num1.denominator, num2.denominator) / num1.denominator);
            int numerator_2 = num2.numerator * (SmallestCommonMultiple(num1.denominator, num2.denominator) / num2.denominator);
            int temp_numerator = numerator_1 - numerator_2;
            if (temp_numerator != 0)
                Simplify(ref temp_numerator, ref temp_denominator);
            return new Fraction(temp_numerator, temp_denominator);
        }

        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            int temp_numerator = num1.numerator * num2.numerator;
            int temp_denominator = num1.denominator * num2.denominator;
            if (temp_numerator != 0)
                Simplify(ref temp_numerator, ref temp_denominator);
            return new Fraction(temp_numerator, temp_denominator);
        }

        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            int temp_numerator = num1.numerator * num2.denominator;
            int temp_denominator = num1.denominator * num2.numerator;
            if (temp_numerator != 0)
                Simplify(ref temp_numerator, ref temp_denominator);
            return new Fraction(temp_numerator, temp_denominator);
        }

        public static bool operator >(Fraction num1, Fraction num2)
        {
            return ((double)num1.numerator / num1.denominator) > ((double)num2.numerator / num2.denominator);
        }

        public static bool operator <(Fraction num1, Fraction num2)
        {
            return ((double)num1.numerator / num1.denominator) < ((double)num2.numerator / num2.denominator);
        }

        public static bool operator >=(Fraction num1, Fraction num2)
        {
            return ((double)num1.numerator / num1.denominator) >= ((double)num2.numerator / num2.denominator);
        }

        public static bool operator <=(Fraction num1, Fraction num2)
        {
            return ((double)num1.numerator / num1.denominator) <= ((double)num2.numerator / num2.denominator);
        }

        public static bool operator ==(Fraction num1, Fraction num2)
        {
            return num1.Equals(num2);
        }
        public static bool operator !=(Fraction num1, Fraction num2)
        {
            return !(num1.Equals(num2));
        }

        public bool Equals(Fraction fraction)
        {
            if (fraction is null)
                return false;
            if ((double)this.numerator / this.denominator == (double)fraction.numerator / fraction.denominator)
                return true;
            else
                return false;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Fraction temp = obj as Fraction;
            if (temp != null)
            {
                double first_compare = (double)this.numerator / this.denominator;
                double second_compare = (double)temp.numerator / temp.denominator;
                return first_compare.CompareTo(second_compare);
            }
            else
                throw new ArgumentException("Object is not a Fraction");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            if (denominator == 1)
            {
                output.Append(numerator);
            }
            else if (numerator == 0)
            {
                output.Append(0);
            }
            else
            {
                Simplify(ref numerator, ref denominator);
                output.Append(numerator + "/" + denominator);
            }
            return output.ToString();
        }

        public static implicit operator double (Fraction fraction)
        {
            return (double)fraction.numerator / (double)fraction.denominator;
        }

        public static implicit operator int (Fraction fraction)
        {
            double result =(double)fraction.numerator / (double)fraction.denominator;
            return (int)Math.Truncate(result);
        }

        public static implicit operator float(Fraction fraction)
        {
            return (float)(fraction.numerator / (float)fraction.denominator);
        }

        public static bool TryParse(string str, out Fraction fraction)
        {
            Regex pattern = new Regex(@"^-?[0-9]{1,9}/|,[0-9]{1,9}$");
            fraction = null;

            if (pattern.IsMatch(str))
            {
                string[] numParts = str.Split('/');

                if (numParts.Length == 2)
                {
                    fraction = new Fraction(Convert.ToInt32(numParts[0]), Convert.ToInt32(numParts[1]));
                }
                else
                {
                    numParts = str.Split(',');

                    if (numParts.Length == 2)
                    {
                        int numerator = Convert.ToInt32(numParts[0]);
                        int numOfTens = 0;

                        foreach (char c in numParts[1])
                        {
                            if (numParts[0][0] == '-')
                                numerator = numerator * 10 - (c - '0');
                            else
                                numerator = numerator * 10 + c - '0';
                            numOfTens++;
                        }
                        fraction = new Fraction(numerator, (int)Math.Pow(10, numOfTens));
                    }
                    else
                    {
                        fraction = new Fraction(Convert.ToInt32(numParts[0]), 1);
                    }
                }
                return true;
            }
            return false;
        }
    }
}
