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

        public void Sum(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Denominator + this.Denominator * fractionToCalculate.Numerator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Denominator;
            Console.WriteLine("({0}/{1}) + ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Subtraction(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Denominator - this.Denominator * fractionToCalculate.Numerator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Denominator;
            Console.WriteLine("({0}/{1}) - ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Multiplication(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Numerator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Denominator;
            Console.WriteLine("({0}/{1}) x ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Dividing(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Denominator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Numerator;
            Console.WriteLine("({0}/{1}) : ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public string ReduceFraction( double numerator, double denominator)
        {
            if (numerator == denominator)
            {
                return 1.ToString();
            }
            else if (numerator == 0)
            {
                return 0.ToString();
            }
            else if ((numerator % denominator) == 0)
            {
                return (numerator / denominator).ToString();
            }

            for (int i = 2; i < 10; i++)
            {
                while ((numerator % i) == 0 && (denominator % i) == 0)
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                }
            }
            return numerator.ToString()+"/"+denominator.ToString();
        }

    }
}
