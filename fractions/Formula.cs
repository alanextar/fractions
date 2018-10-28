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

        public Formula(Fractions fraction1, string operationType, Fractions fraction2)
        {
            this.fraction1 = fraction1;
            this.fraction2 = fraction2;
            opType = (OpType)Enum.Parse(typeof(OpType), operationType);
        }
        
        public double MathOperation(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            return fraction1.Sum(fraction2.Numerator, fraction2.Denominator);
        }
    }
}
