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
            return fractionNumerator/fractionDenominator;
        }
    }
}
