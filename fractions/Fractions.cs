using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    class Fractions
    {
        double decimalFraction;
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        public Fractions(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fractions(double decimalFraction)
        {
            this.decimalFraction = decimalFraction;
            this.Numerator = decimalFraction;
            this.Denominator = 1;
        }


        public Fractions() { }

        public void Sum(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Denominator + this.Denominator * fractionToCalculate.Numerator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Denominator;
            Console.WriteLine("({0}/{1}) + ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Sum(double decimalFraction)
        {
            double fractionNumerator = this.Numerator * 10 + this.Denominator * (decimalFraction * 10);
             double fractionDenominator = this.Denominator * 10;
            Console.WriteLine("({0}/{1}) + {2} = {3}", this.Numerator,
                this.Denominator, decimalFraction, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Subtraction(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Denominator - this.Denominator * fractionToCalculate.Numerator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Denominator;
            Console.WriteLine("({0}/{1}) - ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Subtraction(double decimalFraction)
        {
            double fractionNumerator = this.Numerator * 10 - this.Denominator * (decimalFraction * 10);
            double fractionDenominator = this.Denominator * 10;
            Console.WriteLine("({0}/{1}) - {2} = {3}", this.Numerator,
                this.Denominator, decimalFraction, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Multiplication(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Numerator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Denominator;
            Console.WriteLine("({0}/{1}) x ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Multiplication(double decimalFraction)
        {
            double fractionNumerator = this.Numerator * (decimalFraction * 10);
            double fractionDenominator = this.Denominator * 10;
            Console.WriteLine("({0}/{1}) x {2} = {3}", this.Numerator,
                this.Denominator, decimalFraction, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Dividing(Fractions fractionToCalculate)
        {
            double fractionNumerator = this.Numerator * fractionToCalculate.Denominator;
            double fractionDenominator = this.Denominator * fractionToCalculate.Numerator;
            Console.WriteLine("({0}/{1}) : ({2}/{3}) = {4}", this.Numerator,
                this.Denominator, fractionToCalculate.Numerator, fractionToCalculate.Denominator, ReduceFraction(fractionNumerator, fractionDenominator));
        }

        public void Dividing(double decimalFraction)
        {
            double fractionNumerator = this.Numerator * 10;
            double fractionDenominator = this.Denominator * (decimalFraction * 10);
            Console.WriteLine("({0}/{1}) : {2} = {3}", this.Numerator,
                this.Denominator, decimalFraction, ReduceFraction(fractionNumerator, fractionDenominator));
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
