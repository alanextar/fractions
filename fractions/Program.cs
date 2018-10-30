using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static fractions.Formula;

namespace fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            //for formula1 and formula2
            Fractions fraction1 = new Fractions(1,2);
            double deFraction2 = 2.5;

            if (fraction1.Denominator != 0)
            {
                Formula formula1 = new Formula(fraction1, OpType.Sum, deFraction2);
                formula1.MathOperation();
            }
            else
                Console.WriteLine("Denominator can't be equal 0");
        }
    }
}
