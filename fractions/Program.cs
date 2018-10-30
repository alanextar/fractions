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
            //Fractions fraction1 = new Fractions (21,65);
            //Fractions fraction2 = new Fractions (3,4);
            //Formula formula = new Formula(fraction1, OpType.Subtraction , fraction2);
            //Console.WriteLine(formula.MathOperation(fraction1, OpType.Subtraction, fraction2));
            Fractions fraction1 = new Fractions(1.5);
            Fractions fraction2 = new Fractions(4,2);
            Formula formula = new Formula(fraction1, OpType.Sum, fraction2);
            Console.WriteLine(formula.MathOperation(fraction1, OpType.Sum, fraction2));
        }
    }
}
