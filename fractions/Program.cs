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
            Fractions fraction1 = new Fractions(2,3);
            Fractions fraction2 = new Fractions(4,3);

            //for formula3 and formula4
            Fractions fraction3 = new Fractions(9);
            Fractions fraction4 = new Fractions(3);

            if (fraction1.Denominator != 0)
            {
                Formula formula1 = new Formula(fraction1, OpType.Sum, fraction2);
                formula1.MathOperation(fraction1, OpType.Sum, fraction2);

                Formula formula2 = new Formula(fraction1, OpType.Subtraction, fraction2);
                formula2.MathOperation(fraction1, OpType.Subtraction, fraction2);

                Formula formula3 = new Formula(fraction3, OpType.Dividing, fraction4);
                formula3.MathOperation(fraction1, OpType.Dividing, fraction2);

                Formula formula4 = new Formula(fraction1, OpType.Multiplicaton, fraction2);
                formula4.MathOperation(fraction1, OpType.Multiplicaton, fraction2);
            }
            else
                Console.WriteLine("Denominator can't be equal 0");
        }
    }
}
