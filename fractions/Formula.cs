using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    enum OpType
    {
        Sum,
        Subtraction,
        Dividing,
        Multiplicaton
    };

    class Formula
    {
        public readonly OpType opType;
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions();

        public Formula(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            this.fraction1 = fraction1;
            this.fraction2 = fraction2;
            this.opType = opType;
        }
        
        public double MathOperation()
        {
            return fraction1.Sum(fraction2.Numerator, fraction2.Denominator);
        }
    }
}
