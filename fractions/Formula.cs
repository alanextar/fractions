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
        Multiplicaton,
        Dividing
    };

    class Formula
    {
        double fractionDouble1;
        double fractionDouble2;
        public readonly OpType opType;
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions();

        public Formula(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            this.fraction1 = fraction1;
            this.fraction2 = fraction2;
            this.opType = opType;
        }

        public Formula(double fraction1, OpType opType, double fraction2)
        {
            fractionDouble1 = fraction1;
            fractionDouble2 = fraction2;
            this.opType = opType;
        }

        public double MathOperation(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            if((int)opType == (int)OpType.Sum)
            {
                return fraction1.Sum(fraction2.Numerator, fraction2.Denominator);
            }
            if ((int)opType == (int)OpType.Subtraction)
            {
                return fraction1.Subtraction(fraction2.Numerator, fraction2.Denominator);
            }
            return 1;

        }

        //public double MathOperation(double fractionDouble1, OpType opType, double fractionDouble2)
        //{
        //    return fraction1.Sum(fractionDouble2);
        //}
    }
}
