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

        public Fractions() { }

        public double Sum(double numerator, double denominator)
        {
            double fractionNumerator = this.Numerator * denominator + this.Denominator * numerator;
            double fractionDenominator = this.Denominator * denominator;
            if(fractionDenominator == fractionNumerator)
            {
                return 1;
            }

            for (int i = 2; i < 10; i++)
            {
                while((fractionNumerator % i) == 0 && (fractionDenominator % i) == 0)
                {
                    fractionNumerator = fractionNumerator / i;
                    fractionDenominator = fractionDenominator / i;
                }
            }

            Console.WriteLine("{0}/{1}", fractionNumerator, fractionDenominator);
            return fractionNumerator/fractionDenominator;
        }
    }
}
