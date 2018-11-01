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
            Fractions fraction2 = new Fractions(2.5);

            //for formula3 and formula4
            double doubleFraction1 = 4.5;
            double doubleFraction2 = 0.5;

            if (fraction1.Denominator != 0)
            {
                Formula formula1 = new Formula(fraction1, OpType.Sum, fraction2);
                formula1.MathOperation();

                Formula formula2 = new Formula(doubleFraction1, OpType.Subtraction, fraction2);
                formula2.MathOperation();

                Formula formula3 = new Formula(fraction1, OpType.Multiplication, doubleFraction2);
                formula3.MathOperation();

                Formula formula4 = new Formula(doubleFraction1, OpType.Dividing, doubleFraction2);
                formula4.MathOperation();
            }
            else
                Console.WriteLine("Denominator can't be equal 0");
        }
    }
}
