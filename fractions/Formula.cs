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
        Dividing,
        Multiplication
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

        public Formula(double fraction1, OpType opType, double fraction2)
        {
            this.fraction1 = new Fractions(fraction1);
            this.fraction2 = new Fractions(fraction2);
            this.opType = opType;
        }

        public Formula(Fractions fraction1, OpType opType, double fraction2)
        {
            this.fraction1 = fraction1;
            this.fraction2 = new Fractions(fraction2);
            this.opType = opType;
        }

        public Formula(double fraction1, OpType opType, Fractions fraction2)
        {
            this.fraction1 = new Fractions(fraction1);
            this.fraction2 = fraction2;
            this.opType = opType;
        }

        public void MathOperation()
        {
            switch (opType)
            {
                case OpType.Sum:
                    if (fraction2.Denominator != 1)
                    {
                        fraction1.Sum(fraction2);
                    }
                    else 
                        fraction1.Sum(fraction2.Numerator);
                    break;
                case OpType.Subtraction:
                    if (fraction2.Denominator != 1)
                    {
                        fraction1.Subtraction(fraction2);
                    }
                    else
                        fraction1.Subtraction(fraction2.Numerator);
                    break;
                case OpType.Multiplication:
                    if (fraction2.Denominator != 1)
                    {
                        fraction1.Multiplication(fraction2);
                    }
                    else
                        fraction1.Multiplication(fraction2.Numerator);
                    break;
                case OpType.Dividing:
                    if (fraction2.Denominator != 1)
                    {
                        fraction1.Dividing(fraction2);
                    }
                    else
                        fraction1.Dividing(fraction2.Numerator);
                    break;
            }
        }
    }
}
