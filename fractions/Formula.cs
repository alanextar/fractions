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
        public readonly OpType opType;

        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions();

        public Formula(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            this.fraction1 = fraction1;
            this.fraction2 = fraction2;
            this.opType = opType;
        }

        public Formula(double fraction1, OpType opType, double number)
        {
            this.fraction1 = new Fractions(fraction1);
            this.fraction2 = new Fractions(number);
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
            this.fraction1.Sum(fraction2);
        }

    }
}
