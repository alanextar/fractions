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
            Fractions fraction3 = new Fractions(9);
            Fractions fraction4 = new Fractions(3);

            if (fraction1.Denominator != 0)
            {
                Formula formula1 = new Formula(fraction1, OpType.Sum, fraction2);
                formula1.MathOperation();

                Formula formula2 = new Formula(fraction1, OpType.Subtraction, fraction2);
                formula2.MathOperation();

                Formula formula3 = new Formula(fraction3, OpType.Dividing, fraction4);
                formula3.MathOperation();

                Formula formula4 = new Formula(fraction1, OpType.Multiplicaton, fraction2);
                formula4.MathOperation();
            }
            else
                Console.WriteLine("Denominator can't be equal 0");
        }
    }
}
