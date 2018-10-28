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
            Fractions fraction1 = new Fractions (2,3);
            Fractions fraction2 = new Fractions (1,3);
            //fraction1.sum(fraction2.numerator, fraction2.denominator);
            Formula formula = new Formula(fraction1, "Sum", fraction2);
        }
    }
}
