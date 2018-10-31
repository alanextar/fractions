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
            Fractions fr1 = new Fractions(fraction1);
            Fractions fr2 = new Fractions(fraction2);
            this.fraction1 = fr1;
            this.fraction2 = fr2;
            this.opType = opType;
        }

        public Formula(Fractions fraction1, OpType opType, double fraction2)
        {
            this.fraction1 = fraction1;
            this.fraction2.Numerator = fraction2;
            this.fraction2.Denominator = 1;
            this.opType = opType;
        }

        public Formula(double fraction1, OpType opType, Fractions fraction2)
        {
            this.fraction1.Numerator = fraction1;
            this.fraction1.Denominator = 1;
            this.fraction2 = fraction2;
            this.opType = opType;
        }

        public void MathOperation()
        {
            if ((int)opType == (int)OpType.Sum && fractionDouble1 == 0 && fractionDouble2 == 0)
            {
                fraction1.Sum(fraction2);
            }
            else if ((int)opType == (int)OpType.Sum && fraction2.Denominator == 1)
            {
                fraction1.Sum(fractionDouble2);
            }
            else if ((int)opType == (int)OpType.Sum && fraction1.Denominator == 1)
            {
                fraction2.Sum(fractionDouble1);
            }
            else if ((int)opType == (int)OpType.Sum && fraction1.Denominator == 1 && fraction2.Denominator == 1)
            {
                fraction1.Sum(fractionDouble2);
            }
            else if ((int)opType == (int)OpType.Sum && fraction1.Denominator == 1)
            {
                fraction2.Sum(fractionDouble2);
            }
            //else if ((int)opType == (int)OpType.Subtraction)
            //{
            //    fraction1.Subtraction(fraction2);
            //}
            //else if ((int)opType == (int)OpType.Multiplicaton)
            //{
            //    fraction1.Multiplication(fraction2);
            //}
            //else if ((int)opType == (int)OpType.Dividing)
            //{
            //    fraction1.Dividing(fraction2);
            //}
        }

    }
}
