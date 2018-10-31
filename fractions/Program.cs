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
            Fractions fraction1 = new Fractions(1,2);
            Fractions fraction2 = new Fractions(2.5);
            double number = 4.5;

            if (fraction1.Denominator != 0)
            {
                Formula formula1 = new Formula(number, OpType.Sum, fraction2);
                formula1.MathOperation();

                Formula formula2 = new Formula(fraction1, OpType.Sum, number);
                formula2.MathOperation();

                Formula formula3 = new Formula(fraction1, OpType.Sum, fraction2);
                formula3.MathOperation();

                Formula formula4 = new Formula(number, OpType.Sum, number);
                formula4.MathOperation();
            }
            else
                Console.WriteLine("Denominator can't be equal 0");
        }
    }
}
