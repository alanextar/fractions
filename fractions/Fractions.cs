using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    class Fractions
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        public Fractions(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fractions(double numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public Fractions() { }

        public double Sum(double numerator, double denominator)
        {
            double fractionNumerator = this.Numerator * denominator + this.Denominator * numerator;
            double fractionDenominator = this.Denominator * denominator;
            return ReduceFraction(fractionNumerator, fractionDenominator);
        }

        public double Subtraction(double numerator, double denominator)
        {
            double fractionNumerator = this.Numerator * denominator - this.Denominator * numerator;
            double fractionDenominator = this.Denominator * denominator;
            return ReduceFraction(fractionNumerator, fractionDenominator);
        }

        public double ReduceFraction(double numerator, double denominator)
        {
            if (numerator == denominator)
            {
                return 1;
            }
            else if (numerator == 0)
            {
                return 0;
            }
            else if ((numerator % denominator) == 0)
            {
                return numerator / denominator;
            }

            for (int i = 2; i < 10; i++)
            {
                while ((numerator % i) == 0 && (denominator % i) == 0)
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                }
            }
            Console.WriteLine("{0}/{1}", numerator, denominator);
            return numerator / denominator;
        }

        //public double Sum(double fraction)
        //{
        //    double result = fraction + Numerator / Denominator;
        //    Console.WriteLine("{0}", result);
        //    return result;
        //}

    }
}
