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

        public void MathOperation(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            if((int)opType == (int)OpType.Sum)
            {
                fraction1.Sum(fraction2);
            }
            else if ((int)opType == (int)OpType.Subtraction)
            {
                fraction1.Subtraction(fraction2);
            }
            else if ((int)opType == (int)OpType.Multiplicaton)
            {
                fraction1.Multiplication (fraction2);
            }
            else if ((int)opType == (int)OpType.Dividing)
            {
                fraction1.Dividing(fraction2);
            }
        }

    }
}
