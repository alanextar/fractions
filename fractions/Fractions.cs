using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    class Fractions
    {
        public Fractions(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fractions() { }
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        public double Sum(double numerator, double denominator)
        {
            double sum = (this.Numerator * denominator + this.Denominator * numerator) / (this.Denominator * denominator);
            Console.WriteLine(sum);
            return sum;
        }
    }
}
